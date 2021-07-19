using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class FrmCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso;
        ControladorContato controladorContato;
        public FrmCompromisso()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            InitializeComponent();
        }

        private void FrmCompromisso_Load(object sender, EventArgs e)
        {
            AtualizarDadosDataGrid();


        }

        private void AtualizarDadosDataGrid()
        {
            try
            {

                this.tBCONTATOTableAdapter.Fill(this.dBeAgendaDataSet.TBCONTATO);

                this.tBCOMPROMISSOTableAdapter.Fill(this.dBeAgendaDataSet.TBCOMPROMISSO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
     
        private void HabilitarCampos()
        {
            txtAssunto.Enabled = true;
            txtLink.Enabled = true;
            txtLocal.Enabled = true;
            cbContato.Enabled = true;
            dtData.Enabled = true;
            tmInicio.Enabled = true;
            tmTermino.Enabled = true;
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
            txtAssunto.Text = "";
            txtLink.Text = "";
            txtLocal.Text = "";
            cbContato.Text = "";
            dtData.Text = "";
            tmInicio.Text = "";
            tmTermino.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string assunto = txtAssunto.Text;
                string local = txtLocal.Text;
                string link = txtLink.Text;
                DateTime data = dtData.Value;
                DateTime dtInicio = tmInicio.Value;
                TimeSpan horaInicio = new TimeSpan(dtInicio.Hour, dtInicio.Minute, dtInicio.Second);
                DateTime dtTermino = tmTermino.Value;
                TimeSpan horaTermino = new TimeSpan(dtTermino.Hour, dtTermino.Minute, dtTermino.Second);
                Contato contato =controladorContato.SelecionarPorId(Convert.ToInt32(cbContato.SelectedValue));
                Compromisso compromisso = new Compromisso(assunto,local,link,data,  horaInicio, horaTermino, contato);
                controladorCompromisso.InserirNovo(compromisso);
                MessageBox.Show("Adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            
            AtualizarDadosDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                controladorCompromisso.Excluir(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            MessageBox.Show("Excluido");
            AtualizarDadosDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //HabilitarCampos();
                //int id = Convert.ToInt32(txtId.Text);
                //Tarefa tarefa = controladorTarefa.SelecionarPorId(id);
                //string titulo = txtTitulo.Text;
                //int percentual = Convert.ToInt32(txtPercentual.Text);
                //int prioridade = Convert.ToInt32(txtPrioridade.Text);
                //Tarefa tarefaNova = new Tarefa(titulo, tarefa.DataCriacao, tarefa.DataConclusao, (PrioridadeEnum)prioridade, percentual);
                //controladorTarefa.Editar(id, tarefaNova);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            MessageBox.Show("Editado");
            AtualizarDadosDataGrid();
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
            txtAssunto.Text = dgCompromisso.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLocal.Text = dgCompromisso.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLink.Text = dgCompromisso.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtData.Value = (DateTime)dgCompromisso.Rows[e.RowIndex].Cells[3].Value;
            //tmInicio.Value = (DateTime)dgCompromisso.Rows[e.RowIndex].Cells[4].Value;
            //tmTermino.Value = (DateTime)dgCompromisso.Rows[e.RowIndex].Cells[5].Value;
            txtId.Text = dgCompromisso.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
