namespace ApiClient
{
    partial class NuevoShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblGeneros = new Label();
            txtGeneros = new TextBox();
            lblStatus = new Label();
            lblAverage = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cbStatus = new ComboBox();
            nudAverage = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAverage).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(84, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(289, 23);
            txtName.TabIndex = 1;
            // 
            // lblGeneros
            // 
            lblGeneros.AutoSize = true;
            lblGeneros.Location = new Point(51, 83);
            lblGeneros.Name = "lblGeneros";
            lblGeneros.Size = new Size(50, 15);
            lblGeneros.TabIndex = 0;
            lblGeneros.Text = "Generos";
            // 
            // txtGeneros
            // 
            txtGeneros.Location = new Point(107, 80);
            txtGeneros.Name = "txtGeneros";
            txtGeneros.Size = new Size(289, 23);
            txtGeneros.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(62, 112);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(241, 112);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(74, 15);
            lblAverage.TabIndex = 0;
            lblAverage.Text = "Clasificación";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(321, 170);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(240, 170);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(107, 109);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(128, 23);
            cbStatus.TabIndex = 5;
            // 
            // nudAverage
            // 
            nudAverage.DecimalPlaces = 1;
            nudAverage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudAverage.Location = new Point(321, 110);
            nudAverage.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAverage.Name = "nudAverage";
            nudAverage.Size = new Size(75, 23);
            nudAverage.TabIndex = 6;
            nudAverage.TextAlign = HorizontalAlignment.Right;
            // 
            // NuevoShowForm
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(456, 220);
            Controls.Add(nudAverage);
            Controls.Add(cbStatus);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblAverage);
            Controls.Add(lblStatus);
            Controls.Add(txtGeneros);
            Controls.Add(lblGeneros);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NuevoShowForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEdit";
            FormClosing += NuevoShowForm_FormClosing;
            Load += NuevoShowForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Label lblGeneros;
        private TextBox txtGeneros;
        private Label lblStatus;
        private Label lblAverage;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cbStatus;
        private NumericUpDown nudAverage;
    }
}