namespace Rockola
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnaleatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblreproduccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(102, 399);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(188, 114);
            this.btnreproducir.TabIndex = 1;
            this.btnreproducir.Text = "Reproducir";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnaleatorio
            // 
            this.btnaleatorio.Location = new System.Drawing.Point(495, 399);
            this.btnaleatorio.Name = "btnaleatorio";
            this.btnaleatorio.Size = new System.Drawing.Size(207, 114);
            this.btnaleatorio.TabIndex = 2;
            this.btnaleatorio.Text = "Reproducir Aleatorio";
            this.btnaleatorio.UseVisualStyleBackColor = true;
            this.btnaleatorio.Click += new System.EventHandler(this.btnaleatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introducir cancion";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(102, 75);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(188, 26);
            this.Txtnombre.TabIndex = 4;
            this.Txtnombre.TextChanged += new System.EventHandler(this.Txtnombre_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(600, 205);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(355, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblreproduccion
            // 
            this.lblreproduccion.AutoSize = true;
            this.lblreproduccion.Location = new System.Drawing.Point(102, 564);
            this.lblreproduccion.Name = "lblreproduccion";
            this.lblreproduccion.Size = new System.Drawing.Size(0, 20);
            this.lblreproduccion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reproduciendo cancion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblreproduccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaleatorio);
            this.Controls.Add(this.btnreproducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnaleatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblreproduccion;
        private System.Windows.Forms.Label label2;
    }
}

