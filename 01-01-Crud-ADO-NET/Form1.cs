using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_Crud_ADO_NET
{
    public partial class Form1 : Form
    {
        CDatos dato = new CDatos();//al crear podemos hacer uso de los metodos de la clase datos 
        persona persona = new persona();//modelo de ta tabla
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            var Lst = dato.Read();
            dataGridView.DataSource = Lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarDatos()
        {
            persona.id = Id;
            persona.nombre = txtNombre.Text;
            persona.apellido = txtApellido.Text;
            persona.correo = txtCorreo.Text;
        }
        private void Limpiar()
        {
            Id = 0;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            CargarGrid();
            txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            dato.Create(persona);
            CargarGrid();
            Limpiar();
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dataGridView.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dataGridView.CurrentRow.Cells["apellido"].Value.ToString();
            txtCorreo.Text = dataGridView.CurrentRow.Cells["correo"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                CargarDatos();
                dato.Update(persona);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Selecciona un registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                CargarDatos();
                dato.Delete(Id);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Selecciona un registro");
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (txtBuscarId.Text != string.Empty)
            {
                var Lst = dato.buscarId(Convert.ToInt32(txtBuscarId.Text));
                dataGridView.DataSource = Lst;
            }
            else
            {
                CargarGrid();
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text != string.Empty)
            {
                var Lst = dato.buscarNombre(txtBuscarNombre.Text);
                dataGridView.DataSource = Lst;
            }
            else
            {
                CargarGrid();
            }
        }
    }
}
