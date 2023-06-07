using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;

namespace Interface
{
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //Instância da classe TesteConexao = Carregar na memória
            //Atribuir a uma variável
            TesteConexao teste = new TesteConexao();
            //Executar o método que está dentro da classe TesteConexao
            teste.Verificar();
            //Verificação do resultado do teste
            if (teste.conectar == null)
            {
                lblMensagem.BackColor = Color.Red;
                lblMensagem.Text = "Falha!";
                MessageBox.Show(teste.mensagem, "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                lblMensagem.BackColor = Color.Green;
                lblMensagem.Text = "Sucesso!";
            }
        }
    }
}
