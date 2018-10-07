namespace DetallesPersona.UI.Registros
{
    partial class RegistroTelefono
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
            System.Windows.Forms.Label telefonoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.DetalleDataGriView = new System.Windows.Forms.DataGridView();
            this.AgragarButton = new System.Windows.Forms.Button();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGriView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(69, 58);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.IDnumericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "tipo ";
            // 
            // Tipo_Textbox
            // 
            this.Tipo_Textbox.Location = new System.Drawing.Point(67, 89);
            this.Tipo_Textbox.Name = "Tipo_Textbox";
            this.Tipo_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Tipo_Textbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registro Telefonicos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(70, 129);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 129);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // DetalleDataGriView
            // 
            this.DetalleDataGriView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGriView.Location = new System.Drawing.Point(-6, 190);
            this.DetalleDataGriView.Name = "DetalleDataGriView";
            this.DetalleDataGriView.Size = new System.Drawing.Size(295, 106);
            this.DetalleDataGriView.TabIndex = 56;
            // 
            // AgragarButton
            // 
            this.AgragarButton.Location = new System.Drawing.Point(112, 155);
            this.AgragarButton.Name = "AgragarButton";
            this.AgragarButton.Size = new System.Drawing.Size(75, 29);
            this.AgragarButton.TabIndex = 57;
            this.AgragarButton.Text = "Agregar";
            this.AgragarButton.UseVisualStyleBackColor = true;
            this.AgragarButton.Click += new System.EventHandler(this.AgragarButton_Click_1);
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataSource = typeof(DetallesPersona.Entidades.Personas);
            // 
            // RegistroTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 288);
            this.Controls.Add(this.AgragarButton);
            this.Controls.Add(this.DetalleDataGriView);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tipo_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "RegistroTelefono";
            this.Text = "RegistroTelefono";
            this.Load += new System.EventHandler(this.RegistroTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGriView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tipo_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DataGridView DetalleDataGriView;
        private System.Windows.Forms.Button AgragarButton;
    }
}