using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM PAGOS_TRABAJADORES";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO PAGOS_TRABAJADORES (ID_PAGO_TRABAJADOR, TRABAJADOR, TIPO_PAGO, CUENTA)VALUES(@ID_PAGO_TRABAJADOR, @TRABAJADOR, @TIPO_PAGO, @CUENTA)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_PAGO_TRABAJADOR", txtID_PAGO_TRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@TIPO_PAGO", txtTIPO_PAGO.Text);
            cmd1.Parameters.AddWithValue("@CUENTA", txtCUENTA.Text);
           

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_PAGO_TRABAJADOR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTRABAJADOR.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTIPO_PAGO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCUENTA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                

            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE PAGOS_TRABAJADORES SET ID_PAGO_TRABAJADOR=@ID_PAGO_TRABAJADOR, TRABAJADOR=@TRABAJADOR, TIPO_PAGO=@TIPO_PAGO, CUENTA=@CUENTA WHERE ID_PAGO_TRABAJADOR=@ID_PAGO_TRABAJADOR";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_PAGO_TRABAJADOR", txtID_PAGO_TRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@TIPO_PAGO", txtTIPO_PAGO.Text);
            cmd2.Parameters.AddWithValue("@CUENTA", txtCUENTA.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM PAGOS_TRABAJADORES WHERE ID_PAGO_TRABAJADOR=@ID_PAOG_TRABAJADOR";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_PAGO_TRABAJADOR", txtID_PAGO_TRABAJADOR.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_PAGO_TRABAJADOR.Clear();
            txtTRABAJADOR.Clear();
            txtTIPO_PAGO.Clear();
            txtCUENTA.Clear();
        }
    }
}