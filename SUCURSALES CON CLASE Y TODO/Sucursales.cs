using SistemaReparto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.MostrarSucursales(dataGridView1);

            // Enlazamos los combos en cascada por código para no
            // depender de que el Designer ya tenga los eventos.
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            comboBoxMunicipio.SelectedIndexChanged += comboBoxMunicipio_SelectedIndexChanged;

            objetoSucursal.CargarDepartamentos(comboBoxDepartamento);
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            if (comboBoxDepartamento.SelectedIndex == -1)
            {
                comboBoxMunicipio.DataSource = null;
                comboBoxMunicipio.Items.Clear();
                comboBoxZona.DataSource = null;
                comboBoxZona.Items.Clear();
                return;
            }

            string departamento = comboBoxDepartamento.SelectedValue.ToString();

            objetoSucursal.CargarMunicipios(comboBoxMunicipio, departamento);
        }

        private void comboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            if (comboBoxMunicipio.SelectedIndex == -1 || comboBoxDepartamento.SelectedIndex == -1)
            {
                comboBoxZona.DataSource = null;
                comboBoxZona.Items.Clear();
                return;
            }

            string departamento = comboBoxDepartamento.SelectedValue.ToString();
            string municipio = comboBoxMunicipio.SelectedValue.ToString();

            objetoSucursal.CargarZonas(comboBoxZona, departamento, municipio);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Nuevo(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Guardar(
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1,
                textBoxIdSucursal);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Editar(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Eliminar(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Buscar(
                txtBuscar,
                dataGridView1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Actualizar(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }
    }
}
