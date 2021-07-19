using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
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
    public partial class FrmContato : Form
    {
        ControladorContato controladorContato;
        public FrmContato()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            AtualizarDadosDataGrid();

        }
        private void AtualizarDadosDataGrid()
        {
            try
            {

                this.tBCONTATOTableAdapter.Fill(this.dBeAgendaDataSet.TBCONTATO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmpresa.Enabled = true;
            txtCargo.Enabled = true;

        }

        private void HabilitarBtnSalvar()
        {
            btnSalvar.Enabled = true;
            btnSalvar.Image = Properties.Resources.salvar;
        }

        private void HabilitarBtnEditar()
        {
            btnEditar.Enabled = true;
            btnEditar.Image = Properties.Resources.editar;
        }

        private void HabilitarBtnExcluir()
        {
            btnExcluir.Enabled = true;
            btnExcluir.Image = Properties.Resources.excluir;
        }

        private void DesabilitarBtnSalvar()
        {
            btnSalvar.Enabled = false;
            btnSalvar.Image = Properties.Resources.salvarInativo;
        }

        private void DesabilitarBtnEditar()
        {
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.editarInativo;
        }

        private void DesabilitarBtnExcluir()
        {
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.excluirInativo;
        }

        private void DesabilitarTodosBtns()
        {
            DesabilitarBtnSalvar();
            DesabilitarBtnEditar();
            DesabilitarBtnExcluir();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEmpresa.Text = "";
            txtCargo.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string empresa = txtEmpresa.Text;
                string cargo = txtCargo.Text;
                Contato contato = new Contato(nome, email, telefone, empresa, cargo);
                controladorContato.InserirNovo(contato);
                MessageBox.Show("Adicionado");
                AtualizarDadosDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                controladorContato.Excluir(id);
                MessageBox.Show("Excluido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

            AtualizarDadosDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos();
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string empresa = txtEmpresa.Text;
                string cargo = txtCargo.Text;
                Contato contato = new Contato(nome, email, telefone, empresa, cargo);
                int id = Convert.ToInt32(txtId.Text);
                controladorContato.Editar(id, contato);
                MessageBox.Show("Editado");
                AtualizarDadosDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

      
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            DesabilitarTodosBtns();
            HabilitarBtnSalvar();
        }

        private void dgCompromisso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            DesabilitarTodosBtns();
            HabilitarBtnEditar();
            HabilitarBtnExcluir();
            txtNome.Text = dgContato.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEmail.Text = dgContato.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dgContato.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCargo.Text = dgContato.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmpresa.Text = dgContato.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtId.Text = dgContato.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void FrmContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }
    }
}
