namespace gestordeestudantesTessete
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.textboxuser = new System.Windows.Forms.TextBox();
            this.logarbotao = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxusuario = new System.Windows.Forms.PictureBox();
            this.cancelarbutao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxuser
            // 
            this.textboxuser.Location = new System.Drawing.Point(86, 181);
            this.textboxuser.Multiline = true;
            this.textboxuser.Name = "textboxuser";
            this.textboxuser.Size = new System.Drawing.Size(237, 44);
            this.textboxuser.TabIndex = 0;
            // 
            // logarbotao
            // 
            this.logarbotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logarbotao.ForeColor = System.Drawing.Color.Yellow;
            this.logarbotao.Location = new System.Drawing.Point(44, 362);
            this.logarbotao.Name = "logarbotao";
            this.logarbotao.Size = new System.Drawing.Size(125, 49);
            this.logarbotao.TabIndex = 1;
            this.logarbotao.Text = "entra";
            this.logarbotao.UseVisualStyleBackColor = true;
            this.logarbotao.Click += new System.EventHandler(this.logarbotao_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(21, 181);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(45, 22);
            this.user.TabIndex = 2;
            this.user.Text = "user";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "senha";
            // 
            // textBoxsenha
            // 
            this.textBoxsenha.Location = new System.Drawing.Point(86, 250);
            this.textBoxsenha.Multiline = true;
            this.textBoxsenha.Name = "textBoxsenha";
            this.textBoxsenha.Size = new System.Drawing.Size(237, 40);
            this.textBoxsenha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-367, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxusuario
            // 
            this.pictureBoxusuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxusuario.Image")));
            this.pictureBoxusuario.Location = new System.Drawing.Point(-97, 55);
            this.pictureBoxusuario.Name = "pictureBoxusuario";
            this.pictureBoxusuario.Size = new System.Drawing.Size(579, 105);
            this.pictureBoxusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxusuario.TabIndex = 6;
            this.pictureBoxusuario.TabStop = false;
            // 
            // cancelarbutao
            // 
            this.cancelarbutao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbutao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancelarbutao.Location = new System.Drawing.Point(191, 362);
            this.cancelarbutao.Name = "cancelarbutao";
            this.cancelarbutao.Size = new System.Drawing.Size(132, 49);
            this.cancelarbutao.TabIndex = 7;
            this.cancelarbutao.Text = "cancelar";
            this.cancelarbutao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "ACESSAR";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelarbutao);
            this.Controls.Add(this.pictureBoxusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsenha);
            this.Controls.Add(this.user);
            this.Controls.Add(this.logarbotao);
            this.Controls.Add(this.textboxuser);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxuser;
        private System.Windows.Forms.Button logarbotao;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxusuario;
        private System.Windows.Forms.Button cancelarbutao;
        private System.Windows.Forms.Label label2;
    }
}

