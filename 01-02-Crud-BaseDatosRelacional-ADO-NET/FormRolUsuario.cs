using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02_Crud_BaseDatosRelacional_ADO_NET
{
    public partial class FormRolUsuario : Form
    {
        public FormRolUsuario()
        {
            InitializeComponent();
        }
        Panel p = new Panel();
        private void FormRolUsuario_Load(object sender, EventArgs e)
        {

        }
        private void btnMauseEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            pNombre.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(148, 3);
            p.Location = new
                Point(txt.Location.X, txt.Location.Y + 13);
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pNombre.Controls.Remove(p);
        }
        private void GUardarRol()
        {
            try
            {
                using (dbtstEntities db = new dbtstEntities())
                {
                    rol rol = new rol();
                    rol.nombre = txtNombre.Text.ToUpper().Trim();//mayusculas y quitar espacios en blanco en caso de tenerlos
                    db.rol.Add(rol);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void GuardarPermiso(permiso pPermiso)
        {
            try
            {
                using (dbtstEntities db = new dbtstEntities())
                {
                    db.permiso.Add(pPermiso);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        private int UltimoRegistro()
        {
            using (dbtstEntities db = new dbtstEntities())
            {
                var ultimo = (from c in db.rol //uso de linq
                              orderby c.id descending
                              select c.id).FirstOrDefault();
                return ultimo;
            }
        }
        private void CheckRol()
        {
            permiso permisoEntidad = new permiso();
            int id = UltimoRegistro();
            foreach (Control chk in pTipoUsuario.Controls)
            {
                permisoEntidad.rolUsuarioid = id;
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        permisoEntidad.opcionid = Convert.ToInt32(chk.Tag);
                        permisoEntidad.permitido = true;
                        GuardarPermiso(permisoEntidad);
                    }
                    else
                    {
                        permisoEntidad.opcionid = Convert.ToInt32(chk.Tag);
                        permisoEntidad.permitido = false;
                        GuardarPermiso(permisoEntidad);
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            foreach (Control chk in pTipoUsuario.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        ((CheckBox)chk).Checked = false;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GUardarRol();
            CheckRol();
            Limpiar();
            MessageBox.Show("Rol de usuario guardado");
        }
    }
}
