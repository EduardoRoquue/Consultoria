namespace Consultoria
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUEVO = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.MODIFICAR = new System.Windows.Forms.Button();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.txtHORA_SALIDA = new System.Windows.Forms.TextBox();
            this.txtHORA_ENTRADA = new System.Windows.Forms.TextBox();
            this.txtTURNO = new System.Windows.Forms.TextBox();
            this.txtTRABAJADOR = new System.Windows.Forms.TextBox();
            this.txtID_HORARIO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NUEVO);
            this.groupBox1.Controls.Add(this.ELIMINAR);
            this.groupBox1.Controls.Add(this.MODIFICAR);
            this.groupBox1.Controls.Add(this.AGREGAR);
            this.groupBox1.Controls.Add(this.txtHORA_SALIDA);
            this.groupBox1.Controls.Add(this.txtHORA_ENTRADA);
            this.groupBox1.Controls.Add(this.txtTURNO);
            this.groupBox1.Controls.Add(this.txtTRABAJADOR);
            this.groupBox1.Controls.Add(this.txtID_HORARIO);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HORARIOS";
            // 
            // NUEVO
            // 
            this.NUEVO.Location = new System.Drawing.Point(524, 143);
            this.NUEVO.Name = "NUEVO";
            this.NUEVO.Size = new System.Drawing.Size(101, 35);
            this.NUEVO.TabIndex = 8;
            this.NUEVO.Text = "NUEVO";
            this.NUEVO.UseVisualStyleBackColor = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(414, 143);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(101, 35);
            this.ELIMINAR.TabIndex = 7;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.Location = new System.Drawing.Point(113, 149);
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.Size = new System.Drawing.Size(101, 35);
            this.MODIFICAR.TabIndex = 6;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(6, 149);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(101, 35);
            this.AGREGAR.TabIndex = 5;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = true;
            // 
            // txtHORA_SALIDA
            // 
            this.txtHORA_SALIDA.Location = new System.Drawing.Point(414, 98);
            this.txtHORA_SALIDA.Name = "txtHORA_SALIDA";
            this.txtHORA_SALIDA.Size = new System.Drawing.Size(188, 22);
            this.txtHORA_SALIDA.TabIndex = 4;
            // 
            // txtHORA_ENTRADA
            // 
            this.txtHORA_ENTRADA.Location = new System.Drawing.Point(414, 42);
            this.txtHORA_ENTRADA.Name = "txtHORA_ENTRADA";
            this.txtHORA_ENTRADA.Size = new System.Drawing.Size(188, 22);
            this.txtHORA_ENTRADA.TabIndex = 3;
            // 
            // txtTURNO
            // 
            this.txtTURNO.Location = new System.Drawing.Point(220, 149);
            this.txtTURNO.Name = "txtTURNO";
            this.txtTURNO.Size = new System.Drawing.Size(188, 22);
            this.txtTURNO.TabIndex = 2;
            // 
            // txtTRABAJADOR
            // 
            this.txtTRABAJADOR.Location = new System.Drawing.Point(21, 98);
            this.txtTRABAJADOR.Name = "txtTRABAJADOR";
            this.txtTRABAJADOR.Size = new System.Drawing.Size(188, 22);
            this.txtTRABAJADOR.TabIndex = 1;
            // 
            // txtID_HORARIO
            // 
            this.txtID_HORARIO.Location = new System.Drawing.Point(21, 42);
            this.txtID_HORARIO.Name = "txtID_HORARIO";
            this.txtID_HORARIO.Size = new System.Drawing.Size(188, 22);
            this.txtID_HORARIO.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID_HORARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "TRABAJADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "TURNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "HORA_ENTRADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "HORA_SALIDA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "HORARIOS";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHORA_SALIDA;
        private System.Windows.Forms.TextBox txtHORA_ENTRADA;
        private System.Windows.Forms.TextBox txtTURNO;
        private System.Windows.Forms.TextBox txtTRABAJADOR;
        private System.Windows.Forms.TextBox txtID_HORARIO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NUEVO;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button MODIFICAR;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}