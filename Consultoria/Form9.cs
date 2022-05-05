using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM ALMACEN";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO ALMACEN (ID_ALMACEN, PRODUCTO, PRECIO, CANTIDAD, PROYECTO)VALUES(@ID_ALMACEN, @PRODUCTO, @PRECIO, @CANTIDAD, @PROYECTO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_ALMACEN", txtID_ALMACEN.Text);
            cmd1.Parameters.AddWithValue("@PRODUCTO", txtPRODUCTO.Text);
            cmd1.Parameters.AddWithValue("@PRECIO", txtPRECIO.Text);
            cmd1.Parameters.AddWithValue("@CANTIDAD", txtCANTIDAD.Text);
            cmd1.Parameters.AddWithValue("@PROYECTO", txtPROYECTO.Text);




            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_ALMACEN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPRODUCTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPRECIO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCANTIDAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPROYECTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();



            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE ALMACEN SET ID_ALMACEN=@ID_ALMACEN, PRODUCTO=@PRODUCTO, CANTIDAD=@CANTIDAD, PRECIO=@PRECIO, PROYECTO=@PROYECTO WHERE ID_ALMACEN=@ID_ALMACEN";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_ALMACEN", txtID_ALMACEN.Text);
            cmd2.Parameters.AddWithValue("@PRODUCTO", txtPRODUCTO.Text);
            cmd2.Parameters.AddWithValue("@CANTIDAD", txtCANTIDAD.Text);
            cmd2.Parameters.AddWithValue("@PRECIO", txtPRECIO.Text);
            cmd2.Parameters.AddWithValue("@PROYECTO", txtPROYECTO.Text);



            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM ALMACEN WHERE ID_ALMACEN=@ID_ALMACEN";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_ALMACEN", txtID_ALMACEN.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_ALMACEN.Clear();
            txtPRODUCTO.Clear();
            txtCANTIDAD.Clear();
            txtPRECIO.Clear();
            txtPROYECTO.Clear();

        }
    }
}
