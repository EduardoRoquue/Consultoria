using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Consultoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();


        }

        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM TRABAJADORES";
            
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO TRABAJADORES (ID_TRABAJADOR, NOMBRE, AP, AM)VALUES(@ID_TRABAJADOR, @NOMBRE, @AP, @AM)";
            SqlCommand cmd1 = new SqlCommand(insertar,Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_TRABAJADOR", txtID_TRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txtNOMBRE.Text);
            cmd1.Parameters.AddWithValue("@AP", txtAP.Text);
            cmd1.Parameters.AddWithValue("@AM", txtAM.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource=Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                txtID_TRABAJADOR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNOMBRE.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtAP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() ;
                txtAM.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE TRABAJADORES SET ID_TRABAJADOR=@ID_TRABAJADOR, NOMBRE=@NOMBRE, AP=@AP, AM=@AM WHERE ID_TRABAJADOR=@ID_TRABAJADOR";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_TRABAJADOR", txtID_TRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txtNOMBRE.Text);
            cmd2.Parameters.AddWithValue("@AP", txtAP.Text);
            cmd2.Parameters.AddWithValue("@AM", txtAM.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM TRABAJADORES WHERE ID_TRABAJDOR=@ID_TRABAJADOR";
            SqlCommand cmd3 = new SqlCommand(eliminar,Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_TRABAJADOR", txtID_TRABAJADOR.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource=Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID_TRABAJADOR.Clear();
            txtNOMBRE.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtID_TRABAJADOR.Focus();
        }
    }
}
