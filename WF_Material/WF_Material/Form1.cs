using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Material
{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager manager;
        public Form1()
        {
            InitializeComponent();
            //criar o gerenciador dos temas
            //adidcionar no gerrenciador o Form
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);

            //Determinar o tema do form
            manager.Theme = MaterialSkinManager.Themes.DARK;

            //definiçao de cores

            //Exemplos de temas
            //manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500,
            //    Accent.LightBlue200, TextShade.WHITE);

            manager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Pink200, TextShade.WHITE);


        }

        private void txtUsuario_TextAlignChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("TextChang");

            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                chkLembrarme.Enabled = true;
                btnLogin.Enabled = true;
            }
            else {
                chkLembrarme.Enabled = false;
                btnLogin.Enabled = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e) 
        { 
            //MessageBox.Show("TextChang");
             if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                chkLembrarme.Enabled = true;
                btnLogin.Enabled = true;
            }
            else
            {
                chkLembrarme.Enabled = false;
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo " + txtUsuario.Text,"Login confirmado",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            
            if(manager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
