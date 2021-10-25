using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Final
{
    public partial class frmAtendente : UserControl
    {
        public frmAtendente()
        {
            InitializeComponent();
        }

        //Estabelecendo conecção com banco de dados SQL Server

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4N2PD7U\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void desabilitaCampos()
        {
            lblCodigo.Visible = false;
            lbl_Cod.Visible = false;
            btnNovo.Enabled = true;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnGravar.Enabled = true;            
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
            txtBusca.Text = "";
            dgvFunc.DataSource = null;
        }

        private void limparCampos()
        {
            lblCodigo.Visible = false;
            lbl_Cod.Visible = false;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Focus();
            txtBusca.Clear();
            dgvFunc.DataSource = null;
            rdbAtivo.Checked = true;
        }

        private void manipularDados()
        {
            lblCodigo.Visible = true;
            lbl_Cod.Visible = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;

        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            btnNovo.Enabled = true;
            limparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if(txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if(txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbInativo.Checked)
            {
                MessageBox.Show("Impossível cadastrar um funcionário se o STATUS tiver INATIVO", "Erro ao tentar Gravar o registro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    string strSql = "insert into tbl_atendente(ds_Login,ds_Senha,nm_Atendente,ds_status)values(@login,@senha,@atendente,1)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;                    

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Os dados foram gravado com sucesso", "Inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    limparCampos();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if(txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where nm_atendente like ('" + txtBusca.Text + "%')";
                    cm.Connection = cn;

                    //Recebe os dados de uma tabela após a execusão de uma "select"
                    SqlDataAdapter da = new SqlDataAdapter();

                    //O objeto DataTable pode representar uma ou mais tabelas de dados, as quais permanecem alocadas em memomria
                    DataTable dt = new DataTable();

                    //Recebendo os dados da instrução select
                    da.SelectCommand = cm;
                    //Preenchendo o DataTable
                    da.Fill(dt);
                    dgvFunc.DataSource = dt;
                    cn.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dgvFunc.DataSource = null;
            }
        }

        private void carregaAtendente()
        {
            lbl_Cod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtLogin.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dgvFunc.SelectedRows[0].Cells[3].Value.ToString();
            string valor = dgvFunc.SelectedRows[0].Cells[4].Value.ToString();
            
            //MessageBox.Show(valor);

            
            if(valor == "True")
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }
            
            manipularDados();
        }

        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaAtendente();
            if (rdbAtivo.Checked)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbInativo.Checked)
            {
                MessageBox.Show("Para INATIVAR um Funcionário, é preciso clicar no botão remover", "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    int cd = Convert.ToInt32(lbl_Cod.Text);

                    string strSql = "update tbl_atendente set ds_Login=@login,ds_Senha=@senha,nm_Atendente=@atendente, ds_status=1 where cd_Atendente=@cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Os dados foram alterados com sucesso", "Alteração de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    limparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbAtivo.Checked)
            {
                MessageBox.Show("Para remover o registro você precisa alterar o status para Inativo", "Erro ao tentar Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover este registro?","Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lbl_Cod.Text);
                        cn.Open();
                        string strSql = "update tbl_Atendente set ds_status = 0 where cd_Atendente=@cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("A exclusão foi executada com sucesso", "Exclusão de registro concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                        limparCampos();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
    }
}
