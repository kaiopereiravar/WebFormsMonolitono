using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV211601
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text; 
            string repetirSenha = txtRepetirSenha.Text;
            string email = txtEmail.Text; 
            DateTime dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            DateTime dataAtual = DateTime.Now;

            decimal idade = 0;

            idade = dataAtual.Subtract(dataNascimento).Days/ 365 ;
            if(idade < 18)
            {
                lbResultado.Text = "Não permitido para menores de 18 anos";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
            }
            else if(string.IsNullOrEmpty(nome))
            {
                lbResultado.Text = "Preencha seu nome";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtNome.BorderColor = Color.Red;
            }
            else if(string.IsNullOrEmpty(email))
            {
                lbResultado.Text = "Preencha seu email";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtNome.BorderColor = Color.Red;
            }
            else if(senha != repetirSenha)
            {
                lbResultado.Text = "As senhas são divergentes!";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtSenha.BorderColor = Color.Red;
                txtRepetirSenha.BorderColor = Color.Red;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}