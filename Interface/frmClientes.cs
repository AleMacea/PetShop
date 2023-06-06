using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importar o projeto RegraNegocio
using RegraNegocio;

//Importar a classe dos correios - CEP
using Correios;

namespace Interface
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instância da classe DadosClientes
            //Instância = carregar a classe na memória
            //Criar um objeto = atribuir a classe a uma variável
            DadosClientes clientes = new DadosClientes();
            clientes.codigo = Convert.ToInt32(txtCodigo.Text);
            clientes.nome = txtNome.Text;
            clientes.cep = txtCep.Text;
            clientes.email = txtEmail.Text;

            MessageBox.Show(clientes.nome + clientes.codigo.ToString());

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            //Instância da classe CorreiosApi
            CorreiosApi correios = new CorreiosApi();
            try
            {
                var retornoCep = correios.consultaCEP(txtCep.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    txtEndereco.Text = retornoCep.end;
                    txtUF.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
    }
}
