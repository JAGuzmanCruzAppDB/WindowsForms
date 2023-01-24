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
    public partial class Form1 : Form
    {
        int IdRol, IdUsuario;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string pUser, int pidRol, int pidUsuario)
        {
            InitializeComponent();
            lblInicioSesion.Text = pUser;
            IdRol = pidRol;
            IdUsuario = pidUsuario;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConsultarRol(pAdmin);
            ConsultarRol(pServicios);
            ConsultarRol(pMantenimiento);
            ConsultarRol(pClientes);
        }
        private List<permiso>SelectOpcion(int pId)
        {
            using(dbtstEntities db=new dbtstEntities())
            {
                return db.permiso.Where(i => i.rolUsuarioid == pId).ToList();
            }
        }
        private void ConsultarRol(Control pControl)
        {
            var Lstop = SelectOpcion(IdRol);
            foreach(Control c in pControl.Controls)
            {
                if(c is Button)
                {
                    foreach(permiso opc in Lstop)
                    {
                        if (opc.opcionid == Convert.ToInt32(c.Tag))
                        {
                            if (opc.permitido == false)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }
            }
        }
        Panel p = new Panel();
        private void btnMauseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(140, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); 
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!pAdmin.Visible)
            {
                pAdmin.Visible = true;
            }
            else
            {
                pAdmin.Visible = false;
            }
        }
        private void btnServicio_Click(object sender, EventArgs e)
        {
            if (!pServicios.Visible)
            {
                pServicios.Visible = true;
            }
            else
            {
                pServicios.Visible = false;
            }
        }
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (!pMantenimiento.Visible)
            {
                pMantenimiento.Visible = true;
            }
            else
            {
                pMantenimiento.Visible = false;
            }
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!pClientes.Visible)
            {
                pClientes.Visible = true;
            }
            else
            {
                pClientes.Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuario UsuarioForm = new FormUsuario();
            UsuarioForm.Show();
        }
        private void btnRol_Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRolUsuario roles = new FormRolUsuario();
            roles.Show();
        }
    }
}
