using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cassia.io
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome welcomeScreen = new frmWelcome();
            mudatela(welcomeScreen);
        }

        public void mudatela(Form frm)
        {
            // Limpa os controles dentro do painel de container
            pnlContainer.Controls.Clear();

            // Configura o formulário filho como não principal
            frm.TopLevel = false;

            // Limpa os controles dentro do painel de container (caso existam)
            pnlContainer.Controls.Clear();

            // Adiciona o formulário filho ao painel de container
            pnlContainer.Controls.Add(frm);

            // Exibe o formulário filho
            frm.Show();

            // Coloca o formulário filho na frente de outros controles no painel
            frm.BringToFront();
        }

        private void cboxMain_MaximizeRestoreClicked(object sender, Bunifu.UI.WinForms.BunifuFormControlBox.MaximizeRestoreClickedEventArgs e)
        {
            
        }
    }
}
