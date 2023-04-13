namespace Universidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.activo = new System.Windows.Forms.RadioButton();
            this.inactivo = new System.Windows.Forms.RadioButton();
            this.modificar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fechanacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula";
            // 
            // matricula
            // 
            this.matricula.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(135, 103);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(169, 27);
            this.matricula.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(126, 149);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(250, 27);
            this.nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(136, 195);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(238, 27);
            this.apellido.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // carrera
            // 
            this.carrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrera.Location = new System.Drawing.Point(134, 296);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(238, 27);
            this.carrera.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carrera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado";
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activo.Location = new System.Drawing.Point(132, 342);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(71, 23);
            this.activo.TabIndex = 14;
            this.activo.TabStop = true;
            this.activo.Text = "Activo";
            this.activo.UseVisualStyleBackColor = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivo.Location = new System.Drawing.Point(217, 342);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(83, 23);
            this.inactivo.TabIndex = 15;
            this.inactivo.TabStop = true;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(276, 386);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(97, 38);
            this.modificar.TabIndex = 17;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(522, 386);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(97, 38);
            this.limpiar.TabIndex = 19;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(398, 386);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(97, 38);
            this.eliminar.TabIndex = 20;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(643, 386);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(97, 38);
            this.salir.TabIndex = 21;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ingresar
            // 
            this.ingresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.Location = new System.Drawing.Point(151, 386);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(97, 38);
            this.ingresar.TabIndex = 22;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 303);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(135, 60);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Size = new System.Drawing.Size(169, 27);
            this.codigo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Codigo";
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechanacimiento.Location = new System.Drawing.Point(226, 246);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(146, 27);
            this.fechanacimiento.TabIndex = 26;
            this.fechanacimiento.Value = new System.DateTime(2023, 3, 3, 18, 8, 29, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton activo;
        private System.Windows.Forms.RadioButton inactivo;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechanacimiento;
        private System.Windows.Forms.TextBox nombre;
    }
}

