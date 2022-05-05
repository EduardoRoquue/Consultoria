﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar_grid();
        }
        public DataTable Llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM PRODUCTOS";

            SqlCommand sqlCommand = new SqlCommand(consulta, Conexion.Conectar());
            SqlCommand cmd = sqlCommand;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO PRODUCTOS (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO_PRODUCTO)VALUES(@ID_PRODUCTO, @NOMBRE_PRODUCTO, @TIPO_PRODUCTO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID_PRODUCTO", txtID_PRODUCTO.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE_PRODUCTO", txtNOMBRE_PRODUCTO.Text);
            cmd1.Parameters.AddWithValue("@TIPO_PRODUCTO", txtTIPO_PRODUCTO.Text);



            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtID_PRODUCTO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNOMBRE_PRODUCTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTIPO_PRODUCTO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE PRODUCTOS SET ID_PRODUCTO=@ID_PRODUCTO, NOMBRE_PRODUCTO=@NOMBRE_PRODUCTO, TIPO_PRODUCTO=@TIPO_PRODUCTO WHERE ID_PRODUCTO=@ID_PRODUCTO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@ID_PRODUCTO", txtID_PRODUCTO.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE_PRODUCTO", txtNOMBRE_PRODUCTO.Text);
            cmd2.Parameters.AddWithValue("@TIPO_PRODUCTO", txtTIPO_PRODUCTO.Text);


            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM PRODUCTOS WHERE ID_PRODUCTO=@ID_PRODUCTO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID_PRODUCTO", txtID_PRODUCTO.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");
            dataGridView1.DataSource = Llenar_grid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID_PRODUCTO.Clear();
            txtNOMBRE_PRODUCTO.Clear();
            txtTIPO_PRODUCTO.Clear();
        }
    }
}
