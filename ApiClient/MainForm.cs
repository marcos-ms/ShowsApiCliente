using ApiClient.Models;
using ApiClient.Services;
using System.Windows.Forms;

namespace ApiClient
{
    public partial class MainForm : Form
    {
        private readonly IClientApiService _clientApiService;

        private readonly List<string> statusList = ["", "ended", "Running", "To Be Determined"];

        public MainForm(IClientApiService clientApiService)
        {
            _clientApiService = clientApiService;
            InitializeComponent();

            lblCount.Text = "Listo";
            nudAverageMin.Value = 0;
            nudAverageMin.Enabled = chkAverageMin.Checked;
            nudAverageMax.Value = 10;
            nudAverageMax.Enabled = chkAverageMax.Checked;

            label2.Text = "Se importa los datos del api TvMaze y de guardan en la base de datos. ";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = statusList;
            UpdateButtonState();
        }

        private async void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                BorrarViewers();
                List<Show> shows = await _clientApiService.GetAsync();
                var showViewers = shows.Select(FromShowToShowViewers).ToList();
                CargarViewers(showViewers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching shows: {ex.Message}");
            }
        }

        private void BorrarViewers()
        {
            showViewerBindingSource.DataSource = new List<ShowViewer>();
            lblCount.Text = "Listo";
        }

        private async void btnObtenerPorId_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show($@"Id es necesario");
                    return;
                }

                BorrarViewers();
                var show = await _clientApiService.GetByIdAsync(txtId.Text);
                if (show is null)
                {
                    MessageBox.Show("Show not found");
                    return;
                }

                var showViewers = new List<ShowViewer>() { FromShowToShowViewers(show) };
                CargarViewers(showViewers);
                MessageBox.Show($"Show name: {show.Name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching shows: {ex.Message}");
            }
        }

        private async void btnSaveShows_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _clientApiService.ImportTvMazeAsync();
                await CargarDatos();
                MessageBox.Show($"Resultado: {(result.Success ? "OK" : "NOK")}\nMensaje: {result.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching shows: {ex.Message}");
            }
        }

        private async void btnClearDb_Click(object sender, EventArgs e)
        {
            try
            {
                await _clientApiService.ClearDataBaseAsync();
                await CargarDatos();
                MessageBox.Show($"Se han borrado los datos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching shows: {ex.Message}");
            }
        }

        private async void btnObtenerFiltrados_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new Filter
                {
                    Name = txtName.Text,
                    Genres = txtGenero.Text,
                    Status = cbStatus.SelectedIndex != 0 ? cbStatus.SelectedIndex : null,
                    MinAverage = chkAverageMin.Checked ? (double)nudAverageMin.Value : null,
                    MaxAverage = chkAverageMax.Checked ? (double)nudAverageMax.Value : null
                };

                if (!filtro.IsValid(out var errorMessage))
                {
                    MessageBox.Show(errorMessage);
                    return;
                }

                BorrarViewers();
                var shows = await _clientApiService.GetSearchAsync(filtro);
                var showViewers = shows.Select(FromShowToShowViewers).ToList();
                CargarViewers(showViewers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching shows: {ex.Message}");
            }
        }

        private void CargarViewers(List<ShowViewer> showViewers)
        {
            showViewerBindingSource.DataSource = showViewers;
            lblCount.Text = $"Listados: {showViewers.Count}";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            upDown1.Value = 0;
            upDown2.Value = 0;
            txtName.Text = "";
            txtGenero.Text = "";
            cbStatus.SelectedIndex = 0;
            chkAverageMin.Checked = false;
            chkAverageMax.Checked = false;
            nudAverageMin.Value = 0;
            nudAverageMin.Enabled = chkAverageMin.Checked;
            nudAverageMax.Value = 10;
            nudAverageMax.Enabled = chkAverageMax.Checked;

        }

        private ShowViewer FromShowToShowViewers(Show show)
        {
            return new ShowViewer
            {
                Id = show.Id,
                Name = show.Name,
                Generos = string.Join(",", show.Genres),
                Status = show.Status,
                Average = show.Rating?.Average ?? 0.0
            };
        }

        private void chkAverageMin_CheckedChanged(object sender, EventArgs e)
        {
            nudAverageMin.Enabled = chkAverageMin.Checked;
        }

        private void chkAverageMax_CheckedChanged(object sender, EventArgs e)
        {
            nudAverageMax.Enabled = chkAverageMax.Checked;
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            using var form = new NuevoShowForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var show = form.Show;
                if (show is null)
                {
                    return;
                }

                await _clientApiService.SaveShowAsync(show);

                await CargarDatos();

                MessageBox.Show("Show guardado correctamente.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Habilitar el botón solo si hay filas y una fila está seleccionada
            btnEditar.Enabled = dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0;
            btnBorrar2.Enabled = dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (showViewerBindingSource.Current is not ShowViewer show)
                    return;

                using var form = new NuevoShowForm(show);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var showEditado = form.Show;
                    if (showEditado is null)
                    {
                        return;
                    }

                    await _clientApiService.UpdateShowAsync(showEditado);
                    await CargarDatos();

                    MessageBox.Show("Show guardado correctamente.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "/n" + exception.InnerException);
            }
        }

        private async void btnBorrar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (showViewerBindingSource.Current is not ShowViewer show)
                    return;

                if (MessageBox.Show(@"¿Está seguro de que desea borrarlo?", "Borrar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                await _clientApiService.DeleteShowAsync(show.Id);
                await CargarDatos();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "/n" + exception.InnerException);
            }
        }
    }
}
