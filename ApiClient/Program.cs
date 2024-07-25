using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using ApiClient.Services;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace ApiClient
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configurar la lectura del archivo de configuración
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = configurationBuilder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            // Resolver el formulario principal e iniciar la aplicación
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);

            var uriString = Configuration["ApiSettings:BaseUrl"];
            services.AddHttpClient<IClientApiService, ClientApiService>(client =>
            {
                client.BaseAddress = new Uri(uriString);
            });


            services.AddTransient<MainForm>();
            //services.AddTransient<OtroForm>();

            // services.AddTransient<IServicio, IServicio>();
        }
    }
}