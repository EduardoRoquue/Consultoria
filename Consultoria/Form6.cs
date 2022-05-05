using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM NOMBRE_PROYECTOS";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO NOMBRE_PROYECTOS (ID_NOMBRE_PROYECTO, NOMBRE_PROYECTO, TIPO_PROYECTO)VALUES(@ID_NOMBRE_PROYECTO, @NOMBRE_PROYECTO, @TIPO_PROYECTO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_NOMBRE_PROYECTO", txtID_NOMBRE_PROYECTO.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE_PROYECTO", txtNOMBRE_PROYECTO.Text);
            cmd1.Parameters.AddWithValue("@TIPO_PROYECTO", txtTIPO_PROYECTO.Text);



            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_NOMBRE_PROYECTO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNOMBRE_PROYECTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTIPO_PROYECTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();



            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE NOMBRE_PROYECTOS SET ID_NOMBRE_PROYECTO=@ID_NOMBRE_PROYECTO, NOMBRE_PROYECTO=@NOMBRE_PROYECTO, TIPO_PROYECTO=@TIPO_PROYECTO WHERE ID_NOMBRE_PROYECTO=@ID_NOMBRE_PROYECTO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_NOMBRE_PROYECTO", txtID_NOMBRE_PROYECTO.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE_PROYECTO", txtNOMBRE_PROYECTO.Text);
            cmd2.Parameters.AddWithValue("@TIPO_PROYECTO", txtTIPO_PROYECTO.Text);


            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM NOMBRE_PROYECTOS WHERE ID_NOMBRE_PROYECTO=@ID_NOMBRE_PROYECTO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_NOMBRE_PROYECTO", txtID_NOMBRE_PROYECTO.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_NOMBRE_PROYECTO.Clear();
            txtNOMBRE_PROYECTO.Clear();
            txtTIPO_PROYECTO.Clear();
        }
    }
}