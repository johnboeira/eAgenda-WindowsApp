using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class FrmTarefa : Form
    {
        ControladorTarefa controladorTarefa;
        public FrmTarefa()
        {
            InitializeComponent();
            controladorTarefa = new ControladorTarefa();
        }

        private void FrmTarefa_Load(object sender, EventArgs e)
        {
           
          
            AtualizarDadosDataGrid();
        }

        private void AtualizarDadosDataGrid()
        {
            try
            {
                this.tBTarefaTableAdapter.Fill(this.dBeAgendaDataSet.TBTarefa);
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
            txtPercentual.Enabled = false;           
            DesabilitarTodosBtns();
            HabilitarBtnSalvar();
        }

        private void HabilitarCampos()
        {
            txtPercentual.Enabled = true;
            txtPrioridade.Enabled = true;
            txtTitulo.Enabled = true;
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

        private void dtTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            DesabilitarTodosBtns();
            HabilitarBtnEditar();
            HabilitarBtnExcluir();
            txtId.Text = dtTarefa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitulo.Text = dtTarefa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrioridade.Text = dtTarefa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPercentual.Text = dtTarefa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void LimparCampos()
        {
            txtTitulo.Text = "";
            txtPrioridade.Text = "";
            txtPercentual.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                int prioridade = Convert.ToInt32(txtPrioridade.Text);
                Tarefa tarefa = new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade);
                controladorTarefa.InserirNovo(tarefa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            MessageBox.Show("Adicionado");
            AtualizarDadosDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {              
                int id = Convert.ToInt32(txtId.Text);
                controladorTarefa.Excluir(id);
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
                HabilitarCampos();
                int id = Convert.ToInt32(txtId.Text);
                Tarefa tarefa = controladorTarefa.SelecionarPorId(id);          
                string titulo = txtTitulo.Text;
                int percentual = Convert.ToInt32(txtPercentual.Text);
                int prioridade = Convert.ToInt32(txtPrioridade.Text);
                Tarefa tarefaNova = new Tarefa(titulo,tarefa.DataCriacao,tarefa.DataConclusao, (PrioridadeEnum)prioridade ,percentual);
                controladorTarefa.Editar(id,tarefaNova);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            MessageBox.Show("Editado");
            AtualizarDadosDataGrid();
        }

        private void btnAdicionar_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
