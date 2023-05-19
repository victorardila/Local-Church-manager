﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//se importa la libreria para arrastrar formulario
using BLL;
using Entity;
using System.Runtime.InteropServices;
using System.Threading;

namespace UI
{
    public partial class FormMenu : Form
    {
        UsuarioService empleadoService;
        IdUsuarioTxtService idUsuarioTxtService = new IdUsuarioTxtService();
        int cantidadFormularios = 4;
        string rutaFacturasVenta;
        string rutaCierreDeCaja;
        public string idUsuario;

        string rol;
        private readonly EventArgs e;
        private readonly object sender;
        public FormMenu()
        {
            empleadoService = new UsuarioService(ConfigConnection.ConnectionString);
            InitializeComponent();
            customizeDesign();
            EliminarIdSesionDeUsuario();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void ValidarUsuario()
        {
            BusquedaUsuarioRespuesta respuesta = new BusquedaUsuarioRespuesta();
            respuesta = empleadoService.BuscarPorIdentificacion(idUsuario);
            if (respuesta.Usuario != null)
            {
                rol = respuesta.Usuario.Rol;
                if (rol == "Programador")
                {
                    btnGestionSecretaria.Enabled = true;
                    btnGestionSecretaria.Visible = true;
                    btnGestionTesoreria.Enabled = true;
                    btnGestionTesoreria.Visible = true;
                    btnAjustes.Enabled = true;
                }
                else
                {
                    if (rol == "Secretario(a)")
                    {
                        btnGestionSecretaria.Visible = true;
                        btnGestionSecretaria.Enabled = true;
                        btnGestionTesoreria.Enabled = false;
                        btnGestionTesoreria.Visible = false;
                        btnAjustes.Enabled = false;
                    }
                    else
                    {
                        if (rol == "Tesorero(a)")
                        {
                            btnGestionTesoreria.Visible = true;
                            btnGestionTesoreria.Enabled = true;
                            btnGestionSecretaria.Enabled = false;
                            btnGestionSecretaria.Visible = false;
                            btnAjustes.Enabled = false;
                        }
                    }
                }
            }
            GuardarIdUsuarioSesion(idUsuario);
        }

        public void GuardarIdUsuarioSesion(string idUsuario)
        {
            IdUsuarioTxt idUsuarioTxt = new IdUsuarioTxt(idUsuario);
            string mensaje = idUsuarioTxtService.Guardar(idUsuarioTxt);
            if (idUsuarioTxt.Identificacion == "1003377848")
            {
                labelTiempoLicencia.Visible = true;
                btnVerLicencia.Visible = true;
                textTiempoLicencia.Visible = true;
                labelTheme.Visible = true;
                btnModeLight.Visible = true;
                iconThemeSun.Visible = true;
            }
        }
        private void btnGestionSecretaria_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Secretaria";
            showSubMenu(subMenuSecretaria);
            panelSelectionSecretaria.Location = btnGestionSecretaria.Location;
            panelSelectionSecretaria.Visible = true;
            panelSelectionFactura.Visible = false;
            panelSelectionTesoreria.Visible = false;
            panelSelectionAjustes.Visible = false;
        }

        private void btnGestionTesoreria_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Tesoreria";
            showSubMenu(subMenuTesoreria);
            panelSelectionTesoreria.Location = btnGestionTesoreria.Location;
            panelSelectionTesoreria.Visible = true;
            panelSelectionFactura.Visible = false;
            panelSelectionSecretaria.Visible = false;
            panelSelectionAjustes.Visible = false;
        }
        private void EliminarIdSesionDeUsuario()
        {
            string mensaje = idUsuarioTxtService.EliminarHistorial();
        }

        private void btnWindowCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWindowMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnWindowMaximize.Visible = false;
            btnWindowRestore.Visible = true;
        }

        private void btnWindowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnWindowRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnWindowRestore.Visible = false;
            btnWindowMaximize.Visible = true;
        }
        private void customizeDesign()
        {
            subMenuSecretaria.Visible = false;
            subMenuTesoreria.Visible = false;
            btnCloseSidebar_Click(sender, e);
            AbrirSumadorDelSistema();
            //AbrirFormulario<FormGestionarCaja>();
        }
        private void hideSubMenu()
        {
            if (subMenuSecretaria.Visible == true)
                subMenuSecretaria.Visible = false;
            if (subMenuTesoreria.Visible == true)
                subMenuTesoreria.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (panelSidebar.Width == 186)
            {
                if (subMenu.Visible == false)
                {
                    hideSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
        }
        private void btnCloseSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Width = 46;
            btnOpenSidebar.Visible = true;
            btnCloseSidebar.Visible = false;
            labelLogoName.Visible = false;
            btnGestionSecretaria.Text = "";
            btnGestionTesoreria.Text = "";
            btnGestionFactura.Text = "";
            btnAjustes.Text = "";
            panelSidebarClose.Visible = true;
        }

        private void btnOpenSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Width = 186;
            btnOpenSidebar.Visible = false;
            btnCloseSidebar.Visible = true;
            labelLogoName.Visible = true;
            btnGestionSecretaria.Text = "Gestion de secretaría";
            btnGestionTesoreria.Text = "Gestion de tesoreria";
            btnGestionFactura.Text = "Gestion de Factura";
            btnAjustes.Text = "Ajustes";
            panelSidebarClose.Visible = false;
        }
        private void AbrirSumadorDelSistema()
        {
            labelHeaderRuta.Text = "Inicio";
            AbrirFormulario<InicioResumen>();
        }
        //funcion Abrir Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorInterno.Controls.Add(formulario);
                panelContenedorInterno.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        //Funcion cerrar Formularios
        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }
        private void CerrarFormularioSwicth(int FormularioCerrar)
        {
            switch (FormularioCerrar)
            {
                case 1:
                    CerrarFormulario<FormDirectorio>();
                    break;
                case 2:
                    CerrarFormulario<FormMiembros>();
                    break;
                case 3:
                    CerrarFormulario<FormReuniones>();
                    break;
                case 4:
                    CerrarFormulario<FormDirectivas>();
                    break;
            }
        }
        //Cerrar los formularios abiertos
        private void CerrarFormulariosCiclo()
        {
            for (int i = 1; i <= cantidadFormularios; i++)
            {
                CerrarFormularioSwicth(i);
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}