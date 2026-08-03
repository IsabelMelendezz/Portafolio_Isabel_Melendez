using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CBodegas
    {
        CConexion objetoConexion = new CConexion();

        public void MostrarBodegas(DataGridView tablaBodegas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query =
                    "SELECT " +
                    "b.id_bodega AS Id_Bodega, " +
                    "b.id_sucursal AS Id_Sucursal, " +
                    "b.nombre AS Nombre, " +
                    "b.id_direccion AS Id_Direccion, " +
                    "a.id_area AS Id_Area, " +
                    "a.departamento AS Departamento, " +
                    "a.municipio AS Municipio, " +
                    "a.zona AS Zona, " +
                    "d.direccion_detalle AS Direccion, " +
                    "b.capacidad AS Capacidad, " +
                    "b.telefono AS Telefono " +
                    "FROM bodega b " +
                    "LEFT JOIN direccion d ON b.id_direccion = d.id_direccion " +
                    "LEFT JOIN areas_cubiertas a ON d.id_area = a.id_area";

                tablaBodegas.DataSource = null;
                tablaBodegas.Columns.Clear();

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaBodegas.AutoGenerateColumns = true;

                tablaBodegas.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron las bodegas.\n" + ex.ToString());
            }
        }

        public void Buscar(
    TextBox txtBuscar,
    DataGridView tablaBodegas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT " +
                    "b.id_bodega AS Id_Bodega, " +
                    "b.id_sucursal AS Id_Sucursal, " +
                    "b.nombre AS Nombre, " +
                    "b.id_direccion AS Id_Direccion, " +
                    "a.id_area AS Id_Area, " +
                    "a.departamento AS Departamento, " +
                    "a.municipio AS Municipio, " +
                    "a.zona AS Zona, " +
                    "d.direccion_detalle AS Direccion, " +
                    "b.capacidad AS Capacidad, " +
                    "b.telefono AS Telefono " +
                    "FROM bodega b " +
                    "LEFT JOIN direccion d ON b.id_direccion = d.id_direccion " +
                    "LEFT JOIN areas_cubiertas a ON d.id_area = a.id_area " +
                    "WHERE b.nombre LIKE @buscar " +
                    "OR d.direccion_detalle LIKE @buscar " +
                    "OR a.zona LIKE @buscar " +
                    "OR a.municipio LIKE @buscar " +
                    "OR a.departamento LIKE @buscar";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar", "%" + txtBuscar.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaBodegas.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar.\n" + ex.Message);
            }
        }


        public void LlenarComboSucursal(ComboBox comboSucursal)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT id_sucursal, nombre FROM sucursal";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(
                        consulta,
                        objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboSucursal.DataSource = dt;

                comboSucursal.DisplayMember = "nombre";

                comboSucursal.ValueMember = "id_sucursal";

                comboSucursal.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales.\n" + ex.Message);
            }
        }

        public void LlenarComboDepartamento(ComboBox comboDepartamento)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT DISTINCT departamento FROM areas_cubiertas " +
                    "WHERE departamento IS NOT NULL ORDER BY departamento";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboDepartamento.DataSource = dt;

                comboDepartamento.DisplayMember = "departamento";

                comboDepartamento.ValueMember = "departamento";

                comboDepartamento.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos.\n" + ex.Message);
            }
        }

        public void LlenarComboMunicipio(ComboBox comboMunicipio, string departamento)
        {
            try
            {
                comboMunicipio.DataSource = null;
                comboMunicipio.Items.Clear();

                if (string.IsNullOrWhiteSpace(departamento))
                    return;

                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT DISTINCT municipio FROM areas_cubiertas " +
                    "WHERE departamento = @departamento AND municipio IS NOT NULL " +
                    "ORDER BY municipio";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@departamento", departamento);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboMunicipio.DataSource = dt;

                comboMunicipio.DisplayMember = "municipio";

                comboMunicipio.ValueMember = "municipio";

                comboMunicipio.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los municipios.\n" + ex.Message);
            }
        }


        public void LlenarComboZona(ComboBox comboZona, string municipio, string departamento)
        {
            try
            {
                comboZona.DataSource = null;
                comboZona.Items.Clear();

                if (string.IsNullOrWhiteSpace(municipio) || string.IsNullOrWhiteSpace(departamento))
                    return;

                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT id_area, zona FROM areas_cubiertas " +
                    "WHERE municipio = @municipio AND departamento = @departamento " +
                    "ORDER BY zona";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@municipio", municipio);
                comando.Parameters.AddWithValue("@departamento", departamento);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboZona.DataSource = dt;

                comboZona.DisplayMember = "zona";

                comboZona.ValueMember = "id_area";

                comboZona.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las zonas.\n" + ex.Message);
            }
        }


        public void SeleccionarBodega(
    DataGridView tablaBodegas,
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            try
            {
                if (tablaBodegas.CurrentRow == null)
                    return;

                txtIdBodega.Text = tablaBodegas.CurrentRow.Cells["Id_Bodega"].Value.ToString();

                txtNombre.Text = tablaBodegas.CurrentRow.Cells["Nombre"].Value.ToString();

                nudCapacidad.Value = Convert.ToDecimal(
                    tablaBodegas.CurrentRow.Cells["Capacidad"].Value);

                txtTelefono.Text = tablaBodegas.CurrentRow.Cells["Telefono"].Value.ToString();

                cbSucursal.SelectedValue = tablaBodegas.CurrentRow.Cells["Id_Sucursal"].Value;

                object oDepartamento = tablaBodegas.CurrentRow.Cells["Departamento"].Value;
                object oMunicipio = tablaBodegas.CurrentRow.Cells["Municipio"].Value;
                object oIdArea = tablaBodegas.CurrentRow.Cells["Id_Area"].Value;
                object oDireccion = tablaBodegas.CurrentRow.Cells["Direccion"].Value;

                if (oDepartamento == null || oDepartamento == DBNull.Value)
                {
                    // La bodega no tiene dirección normalizada asignada todavía
                    cbDepartamento.SelectedIndex = -1;
                    txtDireccion.Clear();
                    return;
                }

                string departamento = oDepartamento.ToString();
                string municipio = oMunicipio.ToString();
                int idArea = Convert.ToInt32(oIdArea);

                // El orden importa: cada asignación dispara el evento en cascada
                // correspondiente, que vuelve a llenar el combo siguiente.
                cbDepartamento.SelectedItem = departamento;
                cbMunicipio.SelectedItem = municipio;
                cbZona.SelectedValue = idArea;

                txtDireccion.Text = oDireccion == DBNull.Value ? "" : oDireccion.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la bodega.\n" + ex.Message);
            }
        }

        public void Nuevo(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            txtIdBodega.Clear();

            cbSucursal.SelectedIndex = -1;

            txtNombre.Clear();

            cbDepartamento.SelectedIndex = -1;

            cbMunicipio.DataSource = null;
            cbMunicipio.Items.Clear();

            cbZona.DataSource = null;
            cbZona.Items.Clear();

            txtDireccion.Clear();

            nudCapacidad.Value = 0;

            txtTelefono.Clear();

            txtNombre.Focus();
        }

        private bool ValidarCampos(
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            if (cbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                cbSucursal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la bodega.");
                txtNombre.Focus();
                return false;
            }

            if (cbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el departamento.");
                cbDepartamento.Focus();
                return false;
            }

            if (cbMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el municipio.");
                cbMunicipio.Focus();
                return false;
            }

            if (cbZona.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la zona/área.");
                cbZona.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese el detalle de la dirección.");
                txtDireccion.Focus();
                return false;
            }

            if (nudCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor que cero.");
                nudCapacidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            return true;
        }


        private int InsertarDireccion(
    MySqlConnection conexionAbierta,
    int idArea,
    string detalle)
        {
            string consulta =
                "INSERT INTO direccion (id_area, direccion_detalle) " +
                "VALUES (@id_area, @direccion_detalle); " +
                "SELECT LAST_INSERT_ID();";

            MySqlCommand comando = new MySqlCommand(consulta, conexionAbierta);

            comando.Parameters.AddWithValue("@id_area", idArea);
            comando.Parameters.AddWithValue("@direccion_detalle", detalle);

            object resultado = comando.ExecuteScalar();

            return Convert.ToInt32(resultado);
        }

        private void ActualizarDireccion(
    MySqlConnection conexionAbierta,
    int idDireccion,
    int idArea,
    string detalle)
        {
            string consulta =
                "UPDATE direccion SET " +
                "id_area = @id_area, " +
                "direccion_detalle = @direccion_detalle " +
                "WHERE id_direccion = @id_direccion";

            MySqlCommand comando = new MySqlCommand(consulta, conexionAbierta);

            comando.Parameters.AddWithValue("@id_area", idArea);
            comando.Parameters.AddWithValue("@direccion_detalle", detalle);
            comando.Parameters.AddWithValue("@id_direccion", idDireccion);

            comando.ExecuteNonQuery();
        }

        private int? ObtenerIdDireccionDeBodega(MySqlConnection conexionAbierta, int idBodega)
        {
            string consulta = "SELECT id_direccion FROM bodega WHERE id_bodega = @id_bodega";

            MySqlCommand comando = new MySqlCommand(consulta, conexionAbierta);
            comando.Parameters.AddWithValue("@id_bodega", idBodega);

            object resultado = comando.ExecuteScalar();

            if (resultado == null || resultado == DBNull.Value)
                return null;

            return Convert.ToInt32(resultado);
        }

        private void InsertarBodega(
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            CConexion objetoConexion = new CConexion();

            MySqlConnection conexion = objetoConexion.establecerConexion();

            int idArea = Convert.ToInt32(cbZona.SelectedValue);

            int idDireccion = InsertarDireccion(conexion, idArea, txtDireccion.Text);

            string consulta =
                "INSERT INTO bodega " +
                "(id_sucursal, nombre, id_direccion, capacidad, telefono) " +
                "VALUES (@id_sucursal,@nombre,@id_direccion,@capacidad,@telefono)";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@id_sucursal", cbSucursal.SelectedValue);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@id_direccion", idDireccion);
            comando.Parameters.AddWithValue("@capacidad", nudCapacidad.Value);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        private void ActualizarBodega(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            CConexion objetoConexion = new CConexion();

            MySqlConnection conexion = objetoConexion.establecerConexion();

            int idBodega = Convert.ToInt32(txtIdBodega.Text);
            int idArea = Convert.ToInt32(cbZona.SelectedValue);

            int? idDireccionExistente = ObtenerIdDireccionDeBodega(conexion, idBodega);

            int idDireccion;

            if (idDireccionExistente.HasValue)
            {
                idDireccion = idDireccionExistente.Value;
                ActualizarDireccion(conexion, idDireccion, idArea, txtDireccion.Text);
            }
            else
            {
                idDireccion = InsertarDireccion(conexion, idArea, txtDireccion.Text);
            }

            string consulta =
                "UPDATE bodega SET " +
                "id_sucursal = @id_sucursal, " +
                "nombre = @nombre, " +
                "id_direccion = @id_direccion, " +
                "capacidad = @capacidad, " +
                "telefono = @telefono " +
                "WHERE id_bodega = @id_bodega";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@id_bodega", idBodega);
            comando.Parameters.AddWithValue("@id_sucursal", cbSucursal.SelectedValue);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@id_direccion", idDireccion);
            comando.Parameters.AddWithValue("@capacidad", nudCapacidad.Value);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        private void EliminarBodega(TextBox txtIdBodega)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "DELETE FROM bodega WHERE id_bodega = @id_bodega";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_bodega", txtIdBodega.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        public void Guardar(
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas,
    TextBox txtIdBodega)
        {
            if (!ValidarCampos(
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono))
                return;

            InsertarBodega(
                cbSucursal,
                txtNombre,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);

            MessageBox.Show("Bodega registrada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }

        public void Editar(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas)
        {
            if (!ValidarCampos(
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono))
                return;

            if (string.IsNullOrWhiteSpace(txtIdBodega.Text))
            {
                MessageBox.Show("Seleccione una bodega para editar.");
                return;
            }

            ActualizarBodega(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);

            MessageBox.Show("Bodega actualizada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }

        public void Eliminar(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas)
        {
            if (string.IsNullOrWhiteSpace(txtIdBodega.Text))
            {
                MessageBox.Show("Seleccione una bodega para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar esta bodega?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            EliminarBodega(txtIdBodega);

            MessageBox.Show("Bodega eliminada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }

        public void Actualizar(
    DataGridView tablaBodegas,
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    ComboBox cbDepartamento,
    ComboBox cbMunicipio,
    ComboBox cbZona,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                cbDepartamento,
                cbMunicipio,
                cbZona,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }
    }
}