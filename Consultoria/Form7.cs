using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TIPO_PRODUCTO";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO TIPO_PRODUCTO (ID_TP, NOMBRE_TP)VALUES(@ID_TP, @NOMBRE_TP)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_TP", txtID_TP.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE_TP", txtNOMBRE_TP.Text);
            


            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_TP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNOMBRE_TP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               


            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE TIPO_PRODUCTO SET ID_TP=@ID_TP, NOMBRE_TP=@NOMBRE_TP WHERE ID_TP=@ID_TP";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_TP", txtID_TP.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE_TP", txtNOMBRE_TP.Text);


            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM TIPO_PRODUCTO WHERE ID_TP=@ID_TP";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_TP", txtID_TP.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_TP.Clear();
            txtNOMBRE_TP.Clear();
        }
    }
}