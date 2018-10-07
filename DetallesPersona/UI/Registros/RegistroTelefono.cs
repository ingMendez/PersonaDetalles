using DetallesPersona.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetallesPersona.UI.Registros
{
    public partial class RegistroTelefono : Form
    {
        


        public RegistroTelefono()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     

        private void RegistroTelefono_Load(object sender, EventArgs e)
        {

        }

        private void AgragarButton_Click_1(object sender, EventArgs e)
        {
            RegistroPersona rp = new RegistroPersona();
            if (DetalleDataGriView.DataSource != null)
            {
                rp.Detalle = (List<TelefonosDetalles>)DetalleDataGriView.DataSource;
            }
            // todo : validar campo del detalle

            // agregar un nuevo Detalle con los datos incluidos
            rp.Detalle.Add(
                new TelefonosDetalles(
                    id: 0,
                   idPersona: 0,
                    telefono: telefonoTextBox.Text,
                    tipoTelefono: Tipo_Textbox.Text
                ));
            rp.CargarGrid();
            telefonoTextBox.Focus();
            Close();
            //  Telefono_textBox.Clear();
            // Tipo_comboBox.Clear();


        }
    }
}
