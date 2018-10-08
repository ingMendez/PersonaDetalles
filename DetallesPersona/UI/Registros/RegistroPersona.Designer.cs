namespace DetallesPersona.UI.Registros
{
    partial class RegistroPersona
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fechaNacimientoLabel;
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DetalleDataGriView = new System.Windows.Forms.DataGridView();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Direccion_textBox = new System.Windows.Forms.TextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.Telefono_textBox = new System.Windows.Forms.TextBox();
            this.Cedula_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CargarButton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Tipo_comboBox = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGriView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(26, 171);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 59;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(155, 199);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(45, 23);
            this.AgregarButton.TabIndex = 58;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Tipo";
            // 
            // DetalleDataGriView
            // 
            this.DetalleDataGriView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGriView.Location = new System.Drawing.Point(25, 226);
            this.DetalleDataGriView.Name = "DetalleDataGriView";
            this.DetalleDataGriView.Size = new System.Drawing.Size(344, 106);
            this.DetalleDataGriView.TabIndex = 55;
            this.DetalleDataGriView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGriView_CellContentClick);
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(120, 60);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(198, 20);
            this.Nombre_textBox.TabIndex = 47;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(245, 369);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 36);
            this.EliminarButton.TabIndex = 54;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(136, 369);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(76, 36);
            this.GuardarButton.TabIndex = 53;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(19, 367);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(83, 36);
            this.NuevoButton.TabIndex = 52;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Direccion_textBox
            // 
            this.Direccion_textBox.Location = new System.Drawing.Point(119, 123);
            this.Direccion_textBox.Name = "Direccion_textBox";
            this.Direccion_textBox.Size = new System.Drawing.Size(199, 20);
            this.Direccion_textBox.TabIndex = 50;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(119, 23);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.IDnumericUpDown.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(224, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 42);
            this.BuscarButton.TabIndex = 38;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // Telefono_textBox
            // 
            this.Telefono_textBox.Location = new System.Drawing.Point(206, 200);
            this.Telefono_textBox.Multiline = true;
            this.Telefono_textBox.Name = "Telefono_textBox";
            this.Telefono_textBox.Size = new System.Drawing.Size(112, 20);
            this.Telefono_textBox.TabIndex = 48;
            this.Telefono_textBox.Text = "s";
            this.Telefono_textBox.TextChanged += new System.EventHandler(this.Telefono_textBox_TextChanged);
            // 
            // Cedula_textBox
            // 
            this.Cedula_textBox.Location = new System.Drawing.Point(120, 97);
            this.Cedula_textBox.Name = "Cedula_textBox";
            this.Cedula_textBox.Size = new System.Drawing.Size(198, 20);
            this.Cedula_textBox.TabIndex = 49;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personasBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(120, 173);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 60;
            // 
            // CargarButton
            // 
            this.CargarButton.Location = new System.Drawing.Point(324, 197);
            this.CargarButton.Name = "CargarButton";
            this.CargarButton.Size = new System.Drawing.Size(45, 23);
            this.CargarButton.TabIndex = 62;
            this.CargarButton.Text = "+";
            this.CargarButton.UseVisualStyleBackColor = true;
            this.CargarButton.Click += new System.EventHandler(this.CargarButton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Location = new System.Drawing.Point(30, 338);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(72, 23);
            this.Removerbutton.TabIndex = 63;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click_1);
            // 
            // Tipo_comboBox
            // 
            this.Tipo_comboBox.FormattingEnabled = true;
            this.Tipo_comboBox.Location = new System.Drawing.Point(44, 200);
            this.Tipo_comboBox.Name = "Tipo_comboBox";
            this.Tipo_comboBox.Size = new System.Drawing.Size(111, 21);
            this.Tipo_comboBox.TabIndex = 64;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataSource = typeof(DetallesPersona.Entidades.Personas);
            // 
            // RegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 432);
            this.Controls.Add(this.Tipo_comboBox);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.CargarButton);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalleDataGriView);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Direccion_textBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.Telefono_textBox);
            this.Controls.Add(this.Cedula_textBox);
            this.Name = "RegistroPersona";
            this.Text = "RegistroPersona";
            this.Load += new System.EventHandler(this.RegistroPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGriView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DetalleDataGriView;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox Direccion_textBox;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox Telefono_textBox;
        private System.Windows.Forms.TextBox Cedula_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private System.Windows.Forms.Button CargarButton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.ComboBox Tipo_comboBox;
    }
}