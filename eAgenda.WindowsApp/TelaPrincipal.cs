using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnTarefa_MouseHover(object sender, EventArgs e)
        {
            btnTarefa.BackColor = Color.MediumPurple;
        }      

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnTarefa_MouseLeave(object sender, EventArgs e)
        {
            btnTarefa.BackColor = Color.Transparent;
        }


        private void btnCompromisso_MouseHover_1(object sender, EventArgs e)
        {
            btnCompromisso.BackColor = Color.MediumPurple;
        }

        private void btnContato_MouseHover_1(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.MediumPurple;
        }

        private void btnCompromisso_MouseLeave_1(object sender, EventArgs e)
        {
            btnCompromisso.BackColor = Color.Transparent;
        }

        private void btnContato_MouseLeave_1(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.Transparent;
        }

        private void btnCompromisso_Click_1(object sender, EventArgs e)
        {
            FrmCompromisso frmCompromisso = new FrmCompromisso();
            frmCompromisso.Show();
            this.Hide();
        }

        private void btnContato_Click_1(object sender, EventArgs e)
        {
            FrmContato frmContato = new FrmContato();
            frmContato.Show();
            this.Hide();
        }

        private void btnTarefa_Click_1(object sender, EventArgs e)
        {
            FrmTarefa frmTarefa = new FrmTarefa();
            frmTarefa.Show();
            this.Hide();
        }
    }
}
