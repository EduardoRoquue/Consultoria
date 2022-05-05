namespace Consultoria
{
    partial class Form4
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
            this.txtID_PAGO_TRABAJADOR = new System.Windows.Forms.TextBox();
            this.txtTRABAJADOR = new System.Windows.Forms.TextBox();
            this.txtTIPO_PAGO = new System.Windows.Forms.TextBox();
            this.txtCUENTA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCUENTA);
            this.groupBox1.Controls.Add(this.txtTIPO_PAGO);
            this.groupBox1.Controls.Add(this.txtTRABAJADOR);
            this.groupBox1.Controls.Add(this.txtID_PAGO_TRABAJADOR);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAGO_TRABAJADOR";
            // 
            // txtID_PAGO_TRABAJADOR
            // 
            this.txtID_PAGO_TRABAJADOR.Location = new System.Drawing.Point(20, 55);
            this.txtID_PAGO_TRABAJADOR.Name = "txtID_PAGO_TRABAJADOR";
            this.txtID_PAGO_TRABAJADOR.Size = new System.Drawing.Size(202, 22);
            this.txtID_PAGO_TRABAJADOR.TabIndex = 0;
            // 
            // txtTRABAJADOR
            // 
            this.txtTRABAJADOR.Location = new System.Drawing.Point(20, 125);
            this.txtTRABAJADOR.Name = "txtTRABAJADOR";
            this.txtTRABAJADOR.Size = new System.Drawing.Size(202, 22);
            this.txtTRABAJADOR.TabIndex = 1;
            // 
            // txtTIPO_PAGO
            // 
            this.txtTIPO_PAGO.Location = new System.Drawing.Point(269, 55);
            this.txtTIPO_PAGO.Name = "txtTIPO_PAGO";
            this.txtTIPO_PAGO.Size = new System.Drawing.Size(202, 22);
            this.txtTIPO_PAGO.TabIndex = 2;
            // 
            // txtCUENTA
            // 
            this.txtCUENTA.Location = new System.Drawing.Point(269, 125);
            this.txtCUENTA.Name = "txtCUENTA";
            this.txtCUENTA.Size = new System.Drawing.Size(202, 22);
            this.txtCUENTA.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 22);
            this.button4.TabIndex = 7;
            this.button4.Text = "NUEVO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID_PAGO_TRABAJADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "TRABAJADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "TIPO_PAGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CUENTA";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "PAGOS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCUENTA;
        private System.Windows.Forms.TextBox txtTIPO_PAGO;
        private System.Windows.Forms.TextBox txtTRABAJADOR;
        private System.Windows.Forms.TextBox txtID_PAGO_TRABAJADOR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}