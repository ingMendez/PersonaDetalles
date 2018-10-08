using DetallesPersona.BLL;
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
    public partial class RegistroPersona : Form
    {
        public List<TelefonosDetalles>Detalle { get; set; }

        public RegistroPersona()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonosDetalles>();
        }
        private void Limpiar()
        {
            errorProvider.Clear();
            IDnumericUpDown.Value = 0;
            Nombre_textBox.Text = string.Empty;
            Cedula_textBox.Text = string.Empty;
            Telefono_textBox.Text = string.Empty;
            Direccion_textBox.Text = string.Empty;
            fechaNacimientoDateTimePicker.Value = DateTime.Now;
            this.Detalle = new List<TelefonosDetalles>();
            CargarGrid();


        }

        internal void CargarButton_Click()
        {
            throw new NotImplementedException();
        }

        private void LlenaCampo(Personas persona)
        {
            IDnumericUpDown.Value = persona.PersonaId;
            Nombre_textBox.Text = persona.Nombre;
            Telefono_textBox.Text = persona.Telefono;
            Cedula_textBox.Text = persona.Cedula;
            Direccion_textBox.Text = persona.Direccion;
            fechaNacimientoDateTimePicker.Value = persona.FechaNacimiento;

        } 

            private Personas LlenaClase()
        {
            Personas persona = new Personas();
            persona.PersonaId = Convert.ToInt32(IDnumericUpDown.Value);
            persona.Nombre = Nombre_textBox.Text;
            persona.Cedula = Cedula_textBox.Text;
            persona.Telefono = Telefono_textBox.Text;
            persona.Direccion = Direccion_textBox.Text;
            persona.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
            persona.Telefonos = this.Detalle;
            return persona;
        }
        private bool Validar()
        {

            bool paso = true;
            if (String.IsNullOrWhiteSpace(Nombre_textBox.Text))
            {
                errorProvider.SetError(Nombre_textBox, "no puede dejar este campo vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(Telefono_textBox.Text))
            {
                errorProvider.SetError(Telefono_textBox, "no puede dejar este campo vacio");
                paso = false;
            }
            if (String.IsNullOrWhiteSpace(Cedula_textBox.Text))
            {
                errorProvider.SetError(Cedula_textBox, "no puede estar vacio este campo");
                paso = false;
            }
            if( String.IsNullOrWhiteSpace(Direccion_textBox.Text))
            {
                errorProvider.SetError(Direccion_textBox, "no puede estar vacio");
                paso = false;
             }
            if (this.Detalle.Count == 0)
            {
                errorProvider.SetError(DetalleDataGriView, "debe agregar algun telefono");
                Telefono_textBox.Focus();
                paso = false;
            }
            return paso;
        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Personas persona;
            bool paso = false;

            if (!Validar())
                return;
                persona = LlenaClase();

            //determina si es guardar o modificar 
            if (IDnumericUpDown.Value == 0)
            {
                paso = PersonaBLL.Guardar(persona);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("no esiste en la vase de datos", "fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                paso = PersonaBLL.Modificar(persona);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Personas persona = PersonaBLL.Buscar((int)IDnumericUpDown.Value);
            return (persona != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Personas persona = new Personas();
            int.TryParse(IDnumericUpDown.Text, out id);
            persona = PersonaBLL.Buscar(id);

            if(persona != null)
            {
                MessageBox.Show("Persona Encontrada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(persona);

            }
            else
            {
                MessageBox.Show("Persona no econtrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(IDnumericUpDown, "no se pudo eliminar una persona que no existen");
                return;
            }
            if (PersonaBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado");
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            RegistroTelefono rt = new RegistroTelefono();
              rt.ShowDialog();
            if (DetalleDataGriView.DataSource != null)
            {
                this.Detalle = (List<TelefonosDetalles>)DetalleDataGriView.DataSource;
                // todo; validar campos del detalle
                // agregar un nuevo detalle con los datos intoducidos.

                this.Detalle.Add(
                    new TelefonosDetalles(
                        id:0,
                       idPersona:(int)IDnumericUpDown.Value,
                        telefono:Telefono_textBox.Text,
                        tipoTelefono:Tipo_comboBox.Text
                     )
                   );
                CargarGrid();
                Telefono_textBox.Focus();
                Telefono_textBox.Clear();
               // Tipo_textBox.Clear();

            }

        }
        public void CargarGrid()
        {
            DetalleDataGriView.DataSource = null;
            DetalleDataGriView.DataSource = this.Detalle;
        }
        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGriView.Rows.Count > 0 && DetalleDataGriView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGriView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void Telefono_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TlefonoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPersona_Load(object sender, EventArgs e)
        {

        }

        private  void CargarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGriView.DataSource != null)
            {
                this.Detalle = (List<TelefonosDetalles>)DetalleDataGriView.DataSource;
            }
            // todo : validar campo del detalle

            // agregar un nuevo Detalle con los datos incluidos
            this.Detalle.Add(
                new TelefonosDetalles(
                    id : 0,
                   idPersona : (int)IDnumericUpDown.Value,
                    telefono: Telefono_textBox.Text,
                    tipoTelefono : Tipo_comboBox.Text
                ));
            CargarGrid();
            Telefono_textBox.Focus();
          //  Telefono_textBox.Clear();
           // Tipo_comboBox.Clear();
            

        }

        private void Removerbutton_Click_1(object sender, EventArgs e)
        {
            if(DetalleDataGriView.Rows.Count > 0 && DetalleDataGriView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGriView.CurrentRow.Index);
                CargarGrid();
            }

        }

        public void DetalleDataGriView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
