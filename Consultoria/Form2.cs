using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            string insertar = "INSERT INTO INFORMACION_TRABAJADORES (ID_DIRECCION_TRABAJADOR, TRABAJADOR, CALLE, MANZANA, LOTE, LOCALIDAD, MUNICIPIO, ESTADO, CP)VALUES(@ID_DIRECCION_TRABAJADOR, @TRABAJADOR, @CALLE, @MANZANA, @LOTE, @LOCALIDAD, @MUNICIPIO, @ESTADO, @CP)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_DIRECCION_TRABAJADOR", txtID_DIRECCION_TRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd1.Parameters.AddWithValue("@CALLE", txtCALLE.Text);
            cmd1.Parameters.AddWithValue("@MANZANA", txtMANZANA.Text);
            cmd1.Parameters.AddWithValue("@LOTE", txtLOTE.Text);
            cmd1.Parameters.AddWithValue("@LOCALIDAD", txtLOCALIDAD.Text);
            cmd1.Parameters.AddWithValue("@MUNICIPIO", txtMUNICIPIO.Text);
            cmd1.Parameters.AddWithValue("@ESTADO", txtESTADO.Text);
            cmd1.Parameters.AddWithValue("@CP", txtCP.Text);


            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_DIRECCION_TRABAJADOR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTRABAJADOR.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCALLE.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtMANZANA.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLOTE.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLOCALIDAD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMUNICIPIO.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtESTADO.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtCP.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE INFORMACION_TRABAJADORES SET ID_DIRECCION_TRABAJADOR=@ID_DIRECCION_TRABAJADOR, TRABAJADOR=@TRABAJADOR, CALLE=@CALLE, MANZANA=@MANZANA, LOTE=@LOTE, LOCALIDAD=@LOCALIDAD, MUNICIPIO=@MUNICIPIO, ESTADO=@ESTADO, CP=@CP WHERE ID_DIRECCION_TRABAJADOR=@ID_DIRECCION_TRABAJADOR";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_DIRECCION_TRABAJADOR", txtID_DIRECCION_TRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@TRABAJADOR", txtTRABAJADOR.Text);
            cmd2.Parameters.AddWithValue("@CALLE", txtCALLE.Text);
            cmd2.Parameters.AddWithValue("@MANZANA", txtMANZANA.Text);
            cmd2.Parameters.AddWithValue("@LOTE", txtLOTE.Text);
            cmd2.Parameters.AddWithValue("@LOCALIDAD", txtLOCALIDAD.Text);
            cmd2.Parameters.AddWithValue("@MUNICIPIO", txtMUNICIPIO.Text);
            cmd2.Parameters.AddWithValue("@ESTADO", txtESTADO.Text);
            cmd2.Parameters.AddWithValue("@CP", txtCP.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM INFORMACION_TRABAJADORES WHERE ID_DIRECCION_TRABAJDOR=@ID_DIRECCION_TRABAJADOR";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_DIRECCION_TRABAJADOR", txtID_DIRECCION_TRABAJADOR.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_DIRECCION_TRABAJADOR.Clear();
            txtTRABAJADOR.Clear();
            txtCALLE.Clear();
            txtMANZANA.Clear();
            txtLOTE.Clear();
            txtLOCALIDAD.Clear();
            txtMUNICIPIO.Clear();
            txtESTADO.Clear();
            txtCP.Clear();
        }
    }
}
