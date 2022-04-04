
namespace Formulario_Banco_Monitoria_
{
    partial class Form1
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(54, 303);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(116, 48);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(124, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(46, 22);
            this.Id.TabIndex = 14;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(124, 78);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(344, 22);
            this.Nome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // Endereço
            // 
            this.Endereço.Location = new System.Drawing.Point(124, 119);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(344, 22);
            this.Endereço.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Endereço";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(124, 161);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(344, 22);
            this.Bairro.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bairro";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(124, 198);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(252, 22);
            this.Cidade.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cidade";
            // 
            // UF
            // 
            this.UF.Location = new System.Drawing.Point(422, 200);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(46, 22);
            this.UF.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Uf";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Sexo
            // 
            this.Sexo.Location = new System.Drawing.Point(124, 243);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(89, 22);
            this.Sexo.TabIndex = 26;
            this.Sexo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sexo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(485, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 324);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(203, 303);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(116, 48);
            this.Excluir.TabIndex = 29;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(352, 303);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(116, 48);
            this.Sair.TabIndex = 30;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 372);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Endereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Sair;
    }
}

