namespace PrimeiroForm
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
            this.Paulo = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_confsenha = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_confsenha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.maks_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_diferentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Paulo
            // 
            this.Paulo.AutoSize = true;
            this.Paulo.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Paulo.Location = new System.Drawing.Point(183, 51);
            this.Paulo.Name = "Paulo";
            this.Paulo.Size = new System.Drawing.Size(409, 57);
            this.Paulo.TabIndex = 0;
            this.Paulo.Text = "Cadastro de Usuário";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(169, 157);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(203, 20);
            this.tx_nome.TabIndex = 1;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.BackColor = System.Drawing.SystemColors.Window;
            this.lb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_nome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(102, 157);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(49, 18);
            this.lb_nome.TabIndex = 6;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.BackColor = System.Drawing.SystemColors.Window;
            this.lb_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(119, 194);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(32, 18);
            this.lb_cpf.TabIndex = 7;
            this.lb_cpf.Text = "Cpf:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.BackColor = System.Drawing.SystemColors.Window;
            this.lb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(103, 233);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(50, 18);
            this.lb_email.TabIndex = 8;
            this.lb_email.Text = "E-mail:";
            // 
            // lb_confsenha
            // 
            this.lb_confsenha.AutoSize = true;
            this.lb_confsenha.BackColor = System.Drawing.SystemColors.Window;
            this.lb_confsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_confsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confsenha.Location = new System.Drawing.Point(69, 360);
            this.lb_confsenha.Name = "lb_confsenha";
            this.lb_confsenha.Size = new System.Drawing.Size(84, 18);
            this.lb_confsenha.TabIndex = 9;
            this.lb_confsenha.Text = "Conf. Senha:";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.BackColor = System.Drawing.SystemColors.Window;
            this.lb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(102, 314);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(51, 18);
            this.lb_senha.TabIndex = 10;
            this.lb_senha.Text = "Senha:";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(169, 231);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(203, 20);
            this.tx_email.TabIndex = 11;
            this.tx_email.TextChanged += new System.EventHandler(this.tx_email_TextChanged);
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(169, 314);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(100, 20);
            this.tx_senha.TabIndex = 13;
            // 
            // tx_confsenha
            // 
            this.tx_confsenha.Location = new System.Drawing.Point(169, 360);
            this.tx_confsenha.Name = "tx_confsenha";
            this.tx_confsenha.PasswordChar = '*';
            this.tx_confsenha.Size = new System.Drawing.Size(107, 20);
            this.tx_confsenha.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(580, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maks_cpf
            // 
            this.maks_cpf.Location = new System.Drawing.Point(169, 194);
            this.maks_cpf.Mask = "000,000,000-00";
            this.maks_cpf.Name = "maks_cpf";
            this.maks_cpf.Size = new System.Drawing.Size(100, 20);
            this.maks_cpf.TabIndex = 16;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.BackColor = System.Drawing.Color.White;
            this.lb_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(96, 273);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(57, 18);
            this.lb_telefone.TabIndex = 17;
            this.lb_telefone.Text = "telefone";
            // 
            // mask_telefone
            // 
            this.mask_telefone.Location = new System.Drawing.Point(169, 273);
            this.mask_telefone.Mask = "(00) 00000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(100, 20);
            this.mask_telefone.TabIndex = 18;
            // 
            // lb_diferentes
            // 
            this.lb_diferentes.AutoSize = true;
            this.lb_diferentes.Location = new System.Drawing.Point(166, 402);
            this.lb_diferentes.Name = "lb_diferentes";
            this.lb_diferentes.Size = new System.Drawing.Size(35, 13);
            this.lb_diferentes.TabIndex = 19;
            this.lb_diferentes.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.lb_diferentes);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.maks_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tx_confsenha);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_confsenha);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.Paulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Paulo;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_confsenha;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_confsenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maks_cpf;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.Label lb_diferentes;
    }
}

