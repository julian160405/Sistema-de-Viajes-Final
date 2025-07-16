using sistemaDeViajesV3.Clases;
using sistemaDeViajesV3.Interfaces;
using SistemaV5.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaV5
{
    public partial class FRMReservasClientes : Form
    {
        private readonly string _reservasFilePath = "reservas.txt"; // Ruta del archivo de reservas
        private IReservasRepositorio _reservaRepositorio;

        private List<CLSReserva> _todasLasReservas;

        public FRMReservasClientes()
        {
            InitializeComponent();

            _reservaRepositorio = new ArchivoReservasRepositorio(); // Inicializa tu repositorio de reservas
            CargarTodasLasReservas();
        }

        private void CargarTodasLasReservas()
        {
            try
            {
                _todasLasReservas = _reservaRepositorio.GetAllReservas();
                dgvReservas.DataSource = _todasLasReservas;

                if (_todasLasReservas.Count == 0)
                {
                    MessageBox.Show("No hay reservas registradas en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar todas las reservas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReservas.DataSource = null; // Limpiar el DataGridView en caso de error
            }
        }

        private void btnBuscarReservas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdClienteBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID de Cliente para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteBuscar;
            if (!int.TryParse(txtIdClienteBuscar.Text, out idClienteBuscar))
            {
                MessageBox.Show("El ID de Cliente debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filtrar las reservas por el ID del cliente
            List<CLSReserva> reservasFiltradas = _todasLasReservas
                                                    .Where(r => r.IdCliente == idClienteBuscar)
                                                    .ToList();

            dgvReservas.DataSource = reservasFiltradas;

            if (reservasFiltradas.Count == 0)
            {
                MessageBox.Show($"No se encontraron reservas para el cliente con ID {idClienteBuscar}.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarReservas_Click(object sender, EventArgs e)
        {
            txtIdClienteBuscar.Clear(); // Limpia el campo de búsqueda
            CargarTodasLasReservas(); // Vuelve a cargar todas las reservas
        }
    }
}
