using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV211601
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.BorderColor = System.Drawing.Color.Red;
                lbResultadoUsuario.Text = "*Informe um email/usuario";
                lbResultadoUsuario.ForeColor = Color.Red;
                lbResultadoUsuario.Visible = true;
            }
            else
            {
                txtUsuario.BorderColor = Color.Black;
                lbResultadoUsuario.Visible = false;
            }
            
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BorderColor = System.Drawing.Color.Red;
                lbResultadoSenha.Text = "*Informe uma senha";
                lbResultadoSenha.ForeColor = Color.Red;
                lbResultadoSenha.Visible = true;
            }
            else
            {
                txtSenha.BorderColor = Color.Black;
                lbResultadoSenha.Visible = false;
            }

            //consultar no banco de dados
            if(!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                Response.Redirect("Home.aspx");
            }
        }
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}