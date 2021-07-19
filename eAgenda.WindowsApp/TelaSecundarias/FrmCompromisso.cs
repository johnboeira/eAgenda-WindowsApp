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
        int idCompromissoSelecionado = 0;
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
                Contato contato = controladorContato.SelecionarPorId(Convert.ToInt32(cbContato.SelectedValue));
                Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
                string validar = controladorCompromisso.InserirNovo(compromisso);
                if (validar == "ESTA_VALIDO")
                {
                    MessageBox.Show("Inserido com sucesso", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new FormatException();
                }
                
            }
            catch (Exception ex)
            {           
                MessageBox.Show(ex.Message, "Erro ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarDadosDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {              
                bool validado = controladorCompromisso.Excluir(idCompromissoSelecionado);
                if (validado)
                {
                    MessageBox.Show("Excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
            AtualizarDadosDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos();
                string assunto = txtAssunto.Text;
                string local = txtLocal.Text;
                string link = txtLink.Text;
                DateTime data = dtData.Value;
                DateTime dtInicio = tmInicio.Value;
                TimeSpan horaInicio = new TimeSpan(dtInicio.Hour, dtInicio.Minute, dtInicio.Second);
                DateTime dtTermino = tmTermino.Value;
                TimeSpan horaTermino = new TimeSpan(dtTermino.Hour, dtTermino.Minute, dtTermino.Second);
                Contato contato = controladorContato.SelecionarPorId(Convert.ToInt32(cbContato.SelectedValue));
                Compromisso compromissoNovo = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
                string valido = controladorCompromisso.Editar(idCompromissoSelecionado, compromissoNovo);
                if (valido == "ESTA_VALIDO")
                {
                    MessageBox.Show("Editado com sucesso", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            try
            {
                //pega id do compromisso pelo
                idCompromissoSelecionado = Convert.ToInt32(dgCompromisso.Rows[e.RowIndex].Cells[6].Value.ToString());
                Compromisso compromisso = controladorCompromisso.SelecionarPorId(idCompromissoSelecionado);
                tmInicio.Value = Convert.ToDateTime(compromisso.HoraInicio.ToString());
                tmTermino.Value = Convert.ToDateTime(compromisso.HoraTermino.ToString());
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtLink.Text = compromisso.Link;
                dtData.Value = compromisso.Data;
                cbContato.SelectedValue = compromisso.Contato.Id;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro ao popular campos: ", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void FrmCompromisso_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }
    }
}
