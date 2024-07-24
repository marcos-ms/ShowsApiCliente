namespace ApiClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnObtenerTodos = new Button();
            btnObtenerPorId = new Button();
            btnObtenerFiltrados = new Button();
            btnSaveShows = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCount = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            averageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            showViewerBindingSource = new BindingSource(components);
            gbFiltro = new GroupBox();
            chkAverageMax = new CheckBox();
            chkAverageMin = new CheckBox();
            btnBorrar = new Button();
            txtGenero = new TextBox();
            cbStatus = new ComboBox();
            nudAverageMin = new NumericUpDown();
            nudAverageMax = new NumericUpDown();
            lblStatus = new Label();
            lblName = new Label();
            lblGenero = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnClearDb = new Button();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnBorrar2 = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showViewerBindingSource).BeginInit();
            gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAverageMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAverageMax).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnObtenerTodos
            // 
            btnObtenerTodos.Location = new Point(9, 38);
            btnObtenerTodos.Name = "btnObtenerTodos";
            btnObtenerTodos.Size = new Size(181, 23);
            btnObtenerTodos.TabIndex = 0;
            btnObtenerTodos.Text = "Obtener Todos";
            btnObtenerTodos.UseVisualStyleBackColor = true;
            btnObtenerTodos.Click += btnObtenerTodos_Click;
            // 
            // btnObtenerPorId
            // 
            btnObtenerPorId.Location = new Point(196, 38);
            btnObtenerPorId.Name = "btnObtenerPorId";
            btnObtenerPorId.Size = new Size(181, 23);
            btnObtenerPorId.TabIndex = 0;
            btnObtenerPorId.Text = "Obtener Por Id";
            btnObtenerPorId.UseVisualStyleBackColor = true;
            btnObtenerPorId.Click += btnObtenerPorId_Click;
            // 
            // btnObtenerFiltrados
            // 
            btnObtenerFiltrados.Location = new Point(21, 72);
            btnObtenerFiltrados.Name = "btnObtenerFiltrados";
            btnObtenerFiltrados.Size = new Size(181, 23);
            btnObtenerFiltrados.TabIndex = 0;
            btnObtenerFiltrados.Text = "Obtener Filtrados";
            btnObtenerFiltrados.UseVisualStyleBackColor = true;
            btnObtenerFiltrados.Click += btnObtenerFiltrados_Click;
            // 
            // btnSaveShows
            // 
            btnSaveShows.Image = Properties.Resources.escudo2;
            btnSaveShows.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveShows.Location = new Point(383, 10);
            btnSaveShows.Name = "btnSaveShows";
            btnSaveShows.Size = new Size(136, 23);
            btnSaveShows.TabIndex = 0;
            btnSaveShows.Text = "Guardar Todos";
            btnSaveShows.UseVisualStyleBackColor = true;
            btnSaveShows.Click += btnSaveShows_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(107, 23);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(383, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(269, 23);
            txtId.TabIndex = 9;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 326);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(32, 15);
            lblCount.TabIndex = 8;
            lblCount.Text = "Listo";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, generosDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, averageDataGridViewTextBoxColumn });
            dataGridView1.DataSource = showViewerBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(745, 311);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // generosDataGridViewTextBoxColumn
            // 
            generosDataGridViewTextBoxColumn.DataPropertyName = "Generos";
            generosDataGridViewTextBoxColumn.HeaderText = "Generos";
            generosDataGridViewTextBoxColumn.Name = "generosDataGridViewTextBoxColumn";
            generosDataGridViewTextBoxColumn.ReadOnly = true;
            generosDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageDataGridViewTextBoxColumn
            // 
            averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            averageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            averageDataGridViewTextBoxColumn.HeaderText = "Average";
            averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            averageDataGridViewTextBoxColumn.ReadOnly = true;
            averageDataGridViewTextBoxColumn.Width = 50;
            // 
            // showViewerBindingSource
            // 
            showViewerBindingSource.DataSource = typeof(Models.ShowViewer);
            // 
            // gbFiltro
            // 
            gbFiltro.Controls.Add(chkAverageMax);
            gbFiltro.Controls.Add(chkAverageMin);
            gbFiltro.Controls.Add(txtName);
            gbFiltro.Controls.Add(btnBorrar);
            gbFiltro.Controls.Add(txtGenero);
            gbFiltro.Controls.Add(cbStatus);
            gbFiltro.Controls.Add(btnObtenerFiltrados);
            gbFiltro.Controls.Add(nudAverageMin);
            gbFiltro.Controls.Add(nudAverageMax);
            gbFiltro.Controls.Add(lblStatus);
            gbFiltro.Controls.Add(lblName);
            gbFiltro.Controls.Add(lblGenero);
            gbFiltro.Location = new Point(9, 67);
            gbFiltro.Name = "gbFiltro";
            gbFiltro.Size = new Size(741, 106);
            gbFiltro.TabIndex = 6;
            gbFiltro.TabStop = false;
            gbFiltro.Text = "Filtro";
            // 
            // chkAverageMax
            // 
            chkAverageMax.AutoSize = true;
            chkAverageMax.Location = new Point(516, 24);
            chkAverageMax.Name = "chkAverageMax";
            chkAverageMax.Size = new Size(98, 19);
            chkAverageMax.TabIndex = 7;
            chkAverageMax.Text = "Average Max:";
            chkAverageMax.UseVisualStyleBackColor = true;
            chkAverageMax.CheckedChanged += chkAverageMax_CheckedChanged;
            // 
            // chkAverageMin
            // 
            chkAverageMin.AutoSize = true;
            chkAverageMin.Location = new Point(395, 24);
            chkAverageMin.Name = "chkAverageMin";
            chkAverageMin.Size = new Size(96, 19);
            chkAverageMin.TabIndex = 6;
            chkAverageMin.Text = "Average Min:";
            chkAverageMin.UseVisualStyleBackColor = true;
            chkAverageMin.CheckedChanged += chkAverageMin_CheckedChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(637, 42);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(134, 43);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(107, 23);
            txtGenero.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(247, 43);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(142, 23);
            cbStatus.TabIndex = 4;
            // 
            // nudAverageMin
            // 
            nudAverageMin.DecimalPlaces = 1;
            nudAverageMin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAverageMin.Location = new Point(395, 44);
            nudAverageMin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAverageMin.Name = "nudAverageMin";
            nudAverageMin.Size = new Size(115, 23);
            nudAverageMin.TabIndex = 2;
            nudAverageMin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudAverageMax
            // 
            nudAverageMax.DecimalPlaces = 1;
            nudAverageMax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAverageMax.Location = new Point(516, 43);
            nudAverageMax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAverageMax.Name = "nudAverageMax";
            nudAverageMax.Size = new Size(115, 23);
            nudAverageMax.TabIndex = 2;
            nudAverageMax.TextAlign = HorizontalAlignment.Right;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(247, 25);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(134, 25);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Genero:";
            lblGenero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnClearDb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSaveShows);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 532);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 74);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(357, 15);
            label3.TabIndex = 1;
            label3.Text = "Importa los datos del api TvMaze y de guardan en la base de datos.";
            // 
            // btnClearDb
            // 
            btnClearDb.Image = Properties.Resources.escudo2;
            btnClearDb.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearDb.Location = new Point(383, 37);
            btnClearDb.Name = "btnClearDb";
            btnClearDb.Size = new Size(136, 23);
            btnClearDb.TabIndex = 0;
            btnClearDb.Text = "Limpiar BD";
            btnClearDb.UseVisualStyleBackColor = true;
            btnClearDb.Click += btnClearDb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(357, 15);
            label2.TabIndex = 1;
            label2.Text = "Importa los datos del api TvMaze y de guardan en la base de datos.";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnObtenerTodos);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(btnObtenerPorId);
            panel3.Controls.Add(gbFiltro);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 186);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 10;
            label1.Text = "Funciones de lectura de la API";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBorrar2);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(lblCount);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(844, 344);
            panel4.TabIndex = 11;
            // 
            // btnBorrar2
            // 
            btnBorrar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBorrar2.Enabled = false;
            btnBorrar2.Image = Properties.Resources.escudo2;
            btnBorrar2.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar2.Location = new Point(767, 70);
            btnBorrar2.Name = "btnBorrar2";
            btnBorrar2.Size = new Size(65, 23);
            btnBorrar2.TabIndex = 9;
            btnBorrar2.Text = "Borrar";
            btnBorrar2.TextAlign = ContentAlignment.MiddleRight;
            btnBorrar2.UseVisualStyleBackColor = true;
            btnBorrar2.Click += btnBorrar2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.escudo2;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(767, 41);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(65, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.Image = Properties.Resources.escudo2;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(767, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(65, 23);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 530);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 2);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 606);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(860, 645);
            Name = "MainForm";
            Text = "Cliente del API";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showViewerBindingSource).EndInit();
            gbFiltro.ResumeLayout(false);
            gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAverageMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAverageMax).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnObtenerTodos;
        private Button btnObtenerPorId;
        private Button btnObtenerFiltrados;
        private Button btnSaveShows;
        private Button btnGuardarPorId;
        private TextBox txtName;
        private NumericUpDown upDown1;
        private NumericUpDown upDown2;
        private Label lblName;
        private Label lblGenero;
        private TextBox txtGenero;
        private ComboBox cbStatus;
        private Label lblStatus;
        private Button btnBorrar;
        private NumericUpDown nudAverageMax;
        private NumericUpDown nudAverageMin;
        private GroupBox gbFiltro;
        private DataGridView dataGridView1;
        private BindingSource showViewerBindingSource;
        private Label lblCount;
        private CheckBox chkAverageMin;
        private CheckBox chkAverageMax;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private Panel panel2;
        private TextBox txtId;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnBorrar2;
        private Button btnEditar;
        private Button btnNuevo;
        private Label label3;
        private Button button1;
        private Button btnClearDb;
    }
}
