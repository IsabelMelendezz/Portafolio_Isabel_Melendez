//Cristian David Sipac Ispache
//9959-23-1567
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CRutas
    {
        public void mostrarRutas(DataGridView Dgv_Tabla_Rutas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT * FROM ruta";

                Dgv_Tabla_Rutas.DataSource = null;
                Dgv_Tabla_Rutas.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dgv_Tabla_Rutas.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }


        // COMBOS (llaves foráneas)

        public void llenarComboBodega(ComboBox Cbo_Id_Bodega)
        {
            try
            {
                Cbo_Id_Bodega.DataSource = null;
                Cbo_Id_Bodega.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_bodega, nombre FROM bodega";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Id_Bodega.DataSource = dt;
                Cbo_Id_Bodega.DisplayMember = "nombre";
                Cbo_Id_Bodega.ValueMember = "id_bodega";
                Cbo_Id_Bodega.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Bodega, error: " + ex.ToString());
            }
        }


        public void llenarComboArea(ComboBox Cbo_Id_Area)
        {
            try
            {
                Cbo_Id_Area.DataSource = null;
                Cbo_Id_Area.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_area, CONCAT('Zona ', zona, ' - ', municipio, ', ', departamento) AS area_completa FROM areas_cubiertas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Id_Area.DataSource = dt;
                Cbo_Id_Area.DisplayMember = "area_completa";
                Cbo_Id_Area.ValueMember = "id_area";
                Cbo_Id_Area.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Área, error: " + ex.ToString());
            }
        }


        public void llenarComboTipoRuta(ComboBox Cbo_Tipo_Ruta)
        {
            try
            {
                Cbo_Tipo_Ruta.DataSource = null;
                Cbo_Tipo_Ruta.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_tipo_ruta, nombre FROM tipo_ruta";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Tipo_Ruta.DataSource = dt;
                Cbo_Tipo_Ruta.DisplayMember = "nombre";
                Cbo_Tipo_Ruta.ValueMember = "id_tipo_ruta";
                Cbo_Tipo_Ruta.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Tipo de Ruta, error: " + ex.ToString());
            }
        }


        public void llenarComboEstadoRuta(ComboBox Cbo_Estado_Ruta)
        {
            try
            {
                Cbo_Estado_Ruta.DataSource = null;
                Cbo_Estado_Ruta.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_estado_ruta, nombre FROM estado_ruta";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Estado_Ruta.DataSource = dt;
                Cbo_Estado_Ruta.DisplayMember = "nombre";
                Cbo_Estado_Ruta.ValueMember = "id_estado_ruta";
                Cbo_Estado_Ruta.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Estado de Ruta, error: " + ex.ToString());
            }
        }


        // GUARDAR (INSERT)

        public int GuardarRuta(ComboBox Cbo_Id_Bodega, ComboBox Cbo_Id_Area, ComboBox Cbo_Tipo_Ruta, ComboBox Cbo_Estado_Ruta,
            DateTimePicker Fecha_Ruta, DateTimePicker Hora_Inicio, DateTimePicker Hora_Fin,
            TextBox text_Distancia, TextBox text_observaciones)
        {
            try
            {
                if (Cbo_Id_Bodega.SelectedValue == null || Cbo_Id_Area.SelectedValue == null ||
                    Cbo_Tipo_Ruta.SelectedValue == null || Cbo_Estado_Ruta.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar Bodega, Área, Tipo de Ruta y Estado.");
                    return -1;
                }

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO ruta " +
                    "(id_bodega, id_area, id_tipo_ruta, id_estado_ruta, fecha_ruta, hora_inicio, hora_fin, distancia_km, observaciones) " +
                    "VALUES (@bodega, @area, @tipor, @estador, @fecha, @horainicio, @horafin, @distancia, @observ)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@bodega", Cbo_Id_Bodega.SelectedValue);
                myComand.Parameters.AddWithValue("@area", Cbo_Id_Area.SelectedValue);
                myComand.Parameters.AddWithValue("@tipor", Cbo_Tipo_Ruta.SelectedValue);
                myComand.Parameters.AddWithValue("@estador", Cbo_Estado_Ruta.SelectedValue);
                myComand.Parameters.AddWithValue("@fecha", Fecha_Ruta.Value.Date);
                myComand.Parameters.AddWithValue("@horainicio", Hora_Inicio.Value.TimeOfDay);
                myComand.Parameters.AddWithValue("@horafin", Hora_Fin.Value.TimeOfDay);
                myComand.Parameters.AddWithValue("@distancia", text_Distancia.Text);
                myComand.Parameters.AddWithValue("@observ", text_observaciones.Text);

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó la ruta correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó la ruta, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (cargar fila de la tabla a los controles)

        public int SeleccionarRuta(DataGridView Dgv_Tabla_Rutas,
            ComboBox Cbo_Id_Bodega, ComboBox Cbo_Id_Area, ComboBox Cbo_Tipo_Ruta, ComboBox Cbo_Estado_Ruta,
            DateTimePicker Fecha_Ruta, DateTimePicker Hora_Inicio, DateTimePicker Hora_Fin,
            TextBox text_Distancia, TextBox text_observaciones)
        {
            try
            {
                DataGridViewRow fila = Dgv_Tabla_Rutas.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["id_ruta"].Value == null)
                    return -1;

                int idRuta = Convert.ToInt32(fila.Cells["id_ruta"].Value);

                Cbo_Id_Bodega.SelectedValue = Convert.ToInt32(fila.Cells["id_bodega"].Value);
                Cbo_Id_Area.SelectedValue = Convert.ToInt32(fila.Cells["id_area"].Value);
                Cbo_Tipo_Ruta.SelectedValue = Convert.ToInt32(fila.Cells["id_tipo_ruta"].Value);
                Cbo_Estado_Ruta.SelectedValue = Convert.ToInt32(fila.Cells["id_estado_ruta"].Value);

                string fechaTexto = ObtenerTexto(fila, "fecha_ruta");
                if (!string.IsNullOrEmpty(fechaTexto))
                    Fecha_Ruta.Value = Convert.ToDateTime(fechaTexto);

                string horaInicioTexto = ObtenerTexto(fila, "hora_inicio");
                if (!string.IsNullOrEmpty(horaInicioTexto))
                    Hora_Inicio.Value = Convert.ToDateTime(horaInicioTexto);

                string horaFinTexto = ObtenerTexto(fila, "hora_fin");
                if (!string.IsNullOrEmpty(horaFinTexto))
                    Hora_Fin.Value = Convert.ToDateTime(horaFinTexto);

                text_Distancia.Text = ObtenerTexto(fila, "distancia_km");
                text_observaciones.Text = ObtenerTexto(fila, "observaciones");

                return idRuta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar la ruta: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }


        // MODIFICAR (UPDATE)

        public void ModificarRuta(int idRuta, ComboBox Cbo_Id_Bodega, ComboBox Cbo_Id_Area, ComboBox Cbo_Tipo_Ruta, ComboBox Cbo_Estado_Ruta,
            DateTimePicker Fecha_Ruta, DateTimePicker Hora_Inicio, DateTimePicker Hora_Fin,
            TextBox text_Distancia, TextBox text_observaciones)
        {
            try
            {
                if (idRuta <= 0)
                {
                    MessageBox.Show("Debe seleccionar una ruta de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE ruta SET " +
                    "id_bodega = @bodega, " +
                    "id_area = @area, " +
                    "id_tipo_ruta = @tipor, " +
                    "id_estado_ruta = @estador, " +
                    "fecha_ruta = @fecha, " +
                    "hora_inicio = @horainicio, " +
                    "hora_fin = @horafin, " +
                    "distancia_km = @distancia, " +
                    "observaciones = @observ " +
                    "WHERE id_ruta = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@bodega", Cbo_Id_Bodega.SelectedValue);
                myComand.Parameters.AddWithValue("@area", Cbo_Id_Area.SelectedValue);
                myComand.Parameters.AddWithValue("@tipor", Cbo_Tipo_Ruta.SelectedValue);
                myComand.Parameters.AddWithValue("@estador", Cbo_Estado_Ruta.SelectedValue);
                myComand.Parameters.AddWithValue("@fecha", Fecha_Ruta.Value.Date);
                myComand.Parameters.AddWithValue("@horainicio", Hora_Inicio.Value.TimeOfDay);
                myComand.Parameters.AddWithValue("@horafin", Hora_Fin.Value.TimeOfDay);
                myComand.Parameters.AddWithValue("@distancia", text_Distancia.Text);
                myComand.Parameters.AddWithValue("@observ", text_observaciones.Text);
                myComand.Parameters.AddWithValue("@id", idRuta);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó la ruta, error: " + ex.ToString());
            }
        }


        // ELIMINAR (DELETE)

        public void EliminarRuta(int idRuta)
        {
            try
            {
                if (idRuta <= 0)
                {
                    MessageBox.Show("Debe seleccionar una ruta de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM ruta WHERE id_ruta = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idRuta);

                int filasAfectadas = myComand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    MessageBox.Show("Se eliminó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro, error: " + ex.ToString());
            }
        }
    }
}