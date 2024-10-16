namespace Dapper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Buscar_text = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Cargar = new System.Windows.Forms.Button();
            this.BuscarID = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(12, 49);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(274, 150);
            this.Datos.TabIndex = 0;
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(121, 247);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(142, 20);
            this.Names.TabIndex = 1;
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(121, 284);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(142, 20);
            this.Salario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(131, 325);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 6;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Buscar_text
            // 
            this.Buscar_text.Location = new System.Drawing.Point(12, 23);
            this.Buscar_text.Name = "Buscar_text";
            this.Buscar_text.Size = new System.Drawing.Size(194, 20);
            this.Buscar_text.TabIndex = 7;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(214, 21);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(231, 205);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(55, 23);
            this.Cargar.TabIndex = 9;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // BuscarID
            // 
            this.BuscarID.Location = new System.Drawing.Point(337, 127);
            this.BuscarID.Name = "BuscarID";
            this.BuscarID.Size = new System.Drawing.Size(75, 23);
            this.BuscarID.TabIndex = 11;
            this.BuscarID.Text = "Buscar";
            this.BuscarID.UseVisualStyleBackColor = true;
            this.BuscarID.Click += new System.EventHandler(this.BuscarID_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(320, 101);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(106, 20);
            this.ID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(433, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Buscar_text);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Datos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox Buscar_text;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button BuscarID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
    }
}

