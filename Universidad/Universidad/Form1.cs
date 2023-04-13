using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Universidad
{
    public partial class Form1 : Form
    {
        string estado;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-43OTBI3\\SQLEXPRESS;Initial Catalog=estudiante;Persist Security Info=True;User ID=sa;Password=123456");

        public Form1()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (activo.Checked == true)
                {
                    estado = "A";
                }
                else
                {
                    estado = "I";
                }
                string modificacion = "update estudiante set matricula=" + matricula.Text + ", nombre='" + nombre.Text + "', apellido='" + apellido.Text + "', fecha_nacimiento='" + fechanacimiento.Text + "', carrera='" + carrera.Text + "', estado='" + estado + "' where matricula=" + matricula.Text + " ";
                SqlCommand comando = new SqlCommand(modificacion, connection);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Registro Modificado");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            finally
            {
                connection.Close();
                llenar();
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (!((matricula.Text == string.Empty) || (nombre.Text == string.Empty) || (apellido.Text == string.Empty) || (fechanacimiento.Text == string.Empty) || (carrera.Text == string.Empty)))
            {
                try
                {
                    connection.Open();
                    if (activo.Checked == true)
                    {
                        estado = "A";
                    }
                    else
                    {
                        estado = "I";
                    }

                    string consulta = "insert into estudiante values (" + matricula.Text + ", '" + nombre.Text + "','" + apellido.Text + "','" + fechanacimiento.Text + "','" + carrera.Text + "','" + estado + "')";
                    SqlCommand comando = new SqlCommand(consulta, connection);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("estudiante ingresado con exito");
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.ToString());
                }
                finally
                {
                    connection.Close();
                    llenar();
                }
            }
            else
            {
                MessageBox.Show("existen campos sin completar");
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string eliminando = "delete from estudiante where matricula = " + matricula.Text + "";
                SqlCommand comando = new SqlCommand(eliminando, connection);
                comando.ExecuteNonQuery();
                MessageBox.Show("estudiante eliminado con exito");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            finally
            {
                connection.Close();
                llenar();
            }
        }


        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiando();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string consultar = "select * from estudiante";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            matricula.Text = dataGridView1.SelectedCells[1].Value.ToString();
            nombre.Text = dataGridView1.SelectedCells[2].Value.ToString();
            apellido.Text = dataGridView1.SelectedCells[3].Value.ToString();
            fechanacimiento.Text = dataGridView1.SelectedCells[4].Value.ToString();
            carrera.Text = dataGridView1.SelectedCells[5].Value.ToString();
            string esta = dataGridView1.SelectedCells[6].Value.ToString();

            if (esta == "A")
            {
                activo.Checked = true;
            }
            else
            {
                inactivo.Checked = true;
            }

        }


        public void llenar()
        {
            string consultar = "select * from estudiante";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, connection);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollo en proceso");
            llenar();
        }

        public void limpiando()
        {
            codigo.Clear();
            matricula.Clear();
            nombre.Clear();
            apellido.Clear();
            carrera.Clear();
            matricula.Focus();
            fechanacimiento.Value = DateTime.Today;
        }
    }
}
