using DetallesPersona.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetallesPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistroTelefono r = new RegistroTelefono();

            r.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistroPersona r =new  RegistroPersona();
            r.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
