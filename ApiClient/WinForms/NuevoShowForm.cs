using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiClient.Models;

namespace ApiClient;

public partial class NuevoShowForm : Form
{
    private Show _show;
    private ShowViewer? _showViewer;
    private readonly List<string> statusList = ["", "Ended", "Running", "To Be Determined"];

    public Show Show
    {
        get => _show;
        private set => _show = value;
    }

    public NuevoShowForm(ShowViewer? show = null)
    {
        InitializeComponent();

        _showViewer = show;

    }

    private void NuevoShowForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            _show = new Show
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Genres =
                [
                    ..txtGeneros.Text.Split(", ",
                        StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                ],
                Status = cbStatus?.SelectedItem.ToString(),
                Rating = new Rating
                {
                    Average = (double?)nudAverage.Value
                }
            };
        }
    }

    private void NuevoShowForm_Load(object sender, EventArgs e)
    {
        cbStatus.DataSource = statusList;


        if (_showViewer != null)
        {
            txtId.Text = _showViewer.Id;
            txtName.Text = _showViewer.Name;
            txtGeneros.Text = string.Join(", ", _showViewer.Generos);
            cbStatus.SelectedIndex = statusList.IndexOf(_showViewer.Status);
            nudAverage.Value = _showViewer?.Average != null ? (decimal)_showViewer.Average : 0;

        }
    }
}