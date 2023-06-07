
namespace Interface
{
    partial class frmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblLimpar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.grpClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpClientes.Controls.Add(this.txtComplemento);
            this.grpClientes.Controls.Add(this.rdoFeminino);
            this.grpClientes.Controls.Add(this.rdoMasculino);
            this.grpClientes.Controls.Add(this.label2);
            this.grpClientes.Controls.Add(this.label1);
            this.grpClientes.Controls.Add(this.txtCidade);
            this.grpClientes.Controls.Add(this.txtUF);
            this.grpClientes.Controls.Add(this.lblUF);
            this.grpClientes.Controls.Add(this.lblNumero);
            this.grpClientes.Controls.Add(this.txtNumero);
            this.grpClientes.Controls.Add(this.txtEmail);
            this.grpClientes.Controls.Add(this.lblEmail);
            this.grpClientes.Controls.Add(this.txtTelefone);
            this.grpClientes.Controls.Add(this.txtCep);
            this.grpClientes.Controls.Add(this.txtBairro);
            this.grpClientes.Controls.Add(this.txtEndereco);
            this.grpClientes.Controls.Add(this.txtNome);
            this.grpClientes.Controls.Add(this.txtCodigo);
            this.grpClientes.Controls.Add(this.lblSexo);
            this.grpClientes.Controls.Add(this.lblTelefone);
            this.grpClientes.Controls.Add(this.lblBairro);
            this.grpClientes.Controls.Add(this.lblEndereco);
            this.grpClientes.Controls.Add(this.lblCep);
            this.grpClientes.Controls.Add(this.lblNome);
            this.grpClientes.Controls.Add(this.lblCodigo);
            this.grpClientes.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientes.Location = new System.Drawing.Point(3, 12);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(794, 317);
            this.grpClientes.TabIndex = 0;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "Clientes";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(464, 226);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(302, 26);
            this.txtComplemento.TabIndex = 27;
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(246, 272);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(93, 21);
            this.rdoFeminino.TabIndex = 26;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(125, 272);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(99, 21);
            this.rdoMasculino.TabIndex = 25;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Complemento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cidade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(464, 187);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(193, 26);
            this.txtCidade.TabIndex = 22;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(718, 187);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(48, 26);
            this.txtUF.TabIndex = 21;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(682, 193);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(30, 17);
            this.lblUF.TabIndex = 20;
            this.lblUF.Text = "UF";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(686, 147);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(26, 17);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(718, 141);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 26);
            this.txtNumero.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(421, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(285, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 17);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-mail";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(125, 226);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 26);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(125, 103);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(110, 26);
            this.txtCep.TabIndex = 14;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(125, 184);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(197, 26);
            this.txtBairro.TabIndex = 12;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(125, 144);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(532, 26);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(641, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(74, 274);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 17);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(48, 232);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 17);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(68, 189);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 17);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(42, 149);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 17);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(77, 108);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 17);
            this.lblCep.TabIndex = 2;
            this.lblCep.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(249, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(60, 59);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(374, 348);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 59);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(502, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 59);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Font = new System.Drawing.Font("Revit_HEB_DWG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvar.Location = new System.Drawing.Point(245, 420);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(65, 21);
            this.lblSalvar.TabIndex = 4;
            this.lblSalvar.Text = "Salvar";
            // 
            // lblLimpar
            // 
            this.lblLimpar.AutoSize = true;
            this.lblLimpar.Font = new System.Drawing.Font("Revit_HEB_DWG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpar.Location = new System.Drawing.Point(370, 420);
            this.lblLimpar.Name = "lblLimpar";
            this.lblLimpar.Size = new System.Drawing.Size(69, 21);
            this.lblLimpar.TabIndex = 5;
            this.lblLimpar.Text = "Limpar";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Revit_HEB_DWG", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(518, 420);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(44, 21);
            this.lblSair.TabIndex = 6;
            this.lblSair.Text = "Sair";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblLimpar);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblLimpar;
        private System.Windows.Forms.Label lblSair;
    }
}

