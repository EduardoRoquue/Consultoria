using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TIPO_SERVICIOS";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO TIPO_SERVICIOS (ID_TIPO_SERVICIOS, TIPO_SERVICIO)VALUES(@ID_TIPO_SERVICIOS, @TIPO_SERVICIO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_TIPO_SERVICIOS", txtID_TIPO_SERVICIOS.Text);
            cmd1.Parameters.AddWithValue("@TIPO_SERVICIO", txtTIPO_SERVICIO.Text);
            



            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_TIPO_SERVICIOS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTIPO_SERVICIO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
              



            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE TIPO_SERVICIOS SET ID_TIPO_SERVICIOS=@ID_TIPO_SERVICIOS, TIPO_SERVICIO=@TIPO_SERVICIOV WHERE ID_TIPO_SERVICIO=@ID_TIPO_SERVICIO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_TIPO_SERVICIOS", txtID_TIPO_SERVICIOS.Text);
            cmd2.Parameters.AddWithValue("@TIPO_SERVICIO", txtTIPO_SERVICIO.Text);
            


            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM TIPO_SERVICIOS WHERE ID_TIPO_SERVICIOS=@ID_TIPO_SERVICIOS";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_TIPO_SERVICIOS", txtID_TIPO_SERVICIOS.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_TIPO_SERVICIOS.Clear();
            txtTIPO_SERVICIO.Clear();
            
        }
    }
}
