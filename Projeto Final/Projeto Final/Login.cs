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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string usuario;
        public static string codUsuario;

        //Estabelecendo conexão com banco de dados SQL Server

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-4N2PD7U\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencher todos os campos", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where ds_Login = ('" + txtLogin.Text + "') and ds_Senha = ('" + txtSenha.Text + "') and ds_status = 1";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

;                    //dt = cm.ExecuteReader();

                    if (dt.Rows.Count > 0)//contagem de linhas no DataTable > 0
                    {
                        usuario = dt.Rows[0]["nm_Atendente"].ToString();
                        codUsuario = dt.Rows[0]["nm_Atendente"].ToString();
                        FrmMenu menu = new FrmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {   
                        MessageBox.Show("Usuário ou Senha inválidos","Ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



