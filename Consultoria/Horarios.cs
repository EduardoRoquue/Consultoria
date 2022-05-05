using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM INFORMACION_TRABAJADORES";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO HORARIOS (ID_HORARIO, TRABAJADOR, TURNO, HORA_ENTRADA, HORA_SALIDA)VALUES(@ID_HORARIO, @TRABAJADOR, @TURNO, @HORA_ENTRADA, @HORA_SALIDA)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_HORARIO", txtID_HORARIO.Text);
            cmd1.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@TURNO", txtTURNO.Text);
            cmd1.Parameters.AddWithValue("@HORA_ENTRADA", txtHORA_ENTRADA.Text);
            cmd1.Parameters.AddWithValue("@HORA_SALIDA", txtHORA_SALIDA.Text);


            cmd1.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron agregados con exito");
                dataGridView1.DataSource = Llenar_grid();

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {

                    txtID_HORARIO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtTRABAJADOR.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtTURNO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtHORA_ENTRADA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtHORA_SALIDA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                   
                }
                catch
                {
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Conexion.Conectar();
                string actualizar = "UPDATE HORARIOS SET ID_HORARIO=@ID_HORARIO, TRABAJADOR=@TRABAJADOR, TURNO=@TURNO, HORA_ENTRADA=@HORA_ENTRADA, HORA_SALIDA=@HORA_SALIDA  WHERE ID_HORARIO=@ID_HORARIO";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_HORARIO", txtID_HORARIO.Text);
            cmd2.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@TURNO", txtTURNO.Text);
            cmd2.Parameters.AddWithValue("@HORA_ENTRADA", txtHORA_ENTRADA.Text);
            cmd2.Parameters.AddWithValue("@HORA_SALIDA", txtHORA_SALIDA.Text);

            cmd2.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron actualizados con exito");
                dataGridView1.DataSource = Llenar_grid();

            }

            private void button3_Click(object sender, EventArgs e)
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM HORARIO WHERE ID_HORARIO=@ID_HORARIO";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@ID_HORARIO", txtID_HORARIO.Text);

                cmd3.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron eliminados con exito");
                dataGridView1.DataSource = Llenar_grid();

            }

            private void button4_Click(object sender, EventArgs e)
            {
                txtID_HORARIO.Clear();
                txtTRABAJADOR.Clear();
                txtTURNO.Clear();
                txtHORA_ENTRADA.Clear();
                txtHORA_SALIDA.Clear();
            }
        }
    }




