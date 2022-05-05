namespace Consultoria
{
    partial class Form7
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
            this.TIPO_PRODUCTO = new System.Windows.Forms.GroupBox();
            this.txtID_TP = new System.Windows.Forms.TextBox();
            this.txtNOMBRE_TP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TIPO_PRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TIPO_PRODUCTO
            // 
            this.TIPO_PRODUCTO.Controls.Add(this.button4);
            this.TIPO_PRODUCTO.Controls.Add(this.button3);
            this.TIPO_PRODUCTO.Controls.Add(this.button2);
            this.TIPO_PRODUCTO.Controls.Add(this.button1);
            this.TIPO_PRODUCTO.Controls.Add(this.label2);
            this.TIPO_PRODUCTO.Controls.Add(this.label1);
            this.TIPO_PRODUCTO.Controls.Add(this.txtNOMBRE_TP);
            this.TIPO_PRODUCTO.Controls.Add(this.txtID_TP);
            this.TIPO_PRODUCTO.Location = new System.Drawing.Point(33, 42);
            this.TIPO_PRODUCTO.Name = "TIPO_PRODUCTO";
            this.TIPO_PRODUCTO.Size = new System.Drawing.Size(586, 182);
            this.TIPO_PRODUCTO.TabIndex = 0;
            this.TIPO_PRODUCTO.TabStop = false;
            this.TIPO_PRODUCTO.Text = "TIPO_PRODUCTO";
            // 
            // txtID_TP
            // 
            this.txtID_TP.Location = new System.Drawing.Point(17, 64);
            this.txtID_TP.Name = "txtID_TP";
            this.txtID_TP.Size = new System.Drawing.Size(287, 22);
            this.txtID_TP.TabIndex = 0;
            // 
            // txtNOMBRE_TP
            // 
            this.txtNOMBRE_TP.Location = new System.Drawing.Point(17, 139);
            this.txtNOMBRE_TP.Name = "txtNOMBRE_TP";
            this.txtNOMBRE_TP.Size = new System.Drawing.Size(287, 22);
            this.txtNOMBRE_TP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID_TP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE_TP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 131);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "NUEVO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TIPO_PRODUCTO);
            this.Name = "Form7";
            this.Text = "TIPO PRODUCTO";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.TIPO_PRODUCTO.ResumeLayout(false);
            this.TIPO_PRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TIPO_PRODUCTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE_TP;
        private System.Windows.Forms.TextBox txtID_TP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}