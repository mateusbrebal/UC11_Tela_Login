namespace UC11_Tela_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.labelCONFSENHA = new System.Windows.Forms.Label();
            this.textBoxCONFSENHA = new System.Windows.Forms.TextBox();
            this.labelERROS = new System.Windows.Forms.Label();
            this.buttonALTSENHA = new System.Windows.Forms.Button();
            this.labelUSUARIOInforme = new System.Windows.Forms.Label();
            this.labelSENHAInforme = new System.Windows.Forms.Label();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.labelOLHO1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(119, 84);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(184, 20);
            this.textBoxSENHA.TabIndex = 2;
            this.textBoxSENHA.MouseLeave += new System.EventHandler(this.textBoxSENHA_MouseLeave);
            this.textBoxSENHA.MouseHover += new System.EventHandler(this.textBoxSENHA_MouseHover);
            // 
            // labelCONFSENHA
            // 
            this.labelCONFSENHA.AutoSize = true;
            this.labelCONFSENHA.Location = new System.Drawing.Point(25, 127);
            this.labelCONFSENHA.Name = "labelCONFSENHA";
            this.labelCONFSENHA.Size = new System.Drawing.Size(88, 13);
            this.labelCONFSENHA.TabIndex = 7;
            this.labelCONFSENHA.Text = "Confirmar Senha:";
            // 
            // textBoxCONFSENHA
            // 
            this.textBoxCONFSENHA.Location = new System.Drawing.Point(119, 124);
            this.textBoxCONFSENHA.Name = "textBoxCONFSENHA";
            this.textBoxCONFSENHA.PasswordChar = '*';
            this.textBoxCONFSENHA.Size = new System.Drawing.Size(184, 20);
            this.textBoxCONFSENHA.TabIndex = 6;
            this.textBoxCONFSENHA.MouseLeave += new System.EventHandler(this.textBoxCONFSENHA_MouseLeave);
            this.textBoxCONFSENHA.MouseHover += new System.EventHandler(this.textBoxCONFSENHA_MouseHover);
            // 
            // labelERROS
            // 
            this.labelERROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelERROS.ForeColor = System.Drawing.Color.DarkRed;
            this.labelERROS.Location = new System.Drawing.Point(19, 212);
            this.labelERROS.Name = "labelERROS";
            this.labelERROS.Size = new System.Drawing.Size(342, 23);
            this.labelERROS.TabIndex = 8;
            this.labelERROS.Text = "labelERROS";
            this.labelERROS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonALTSENHA
            // 
            this.buttonALTSENHA.Location = new System.Drawing.Point(251, 172);
            this.buttonALTSENHA.Name = "buttonALTSENHA";
            this.buttonALTSENHA.Size = new System.Drawing.Size(110, 28);
            this.buttonALTSENHA.TabIndex = 5;
            this.buttonALTSENHA.Text = "Alterar Senha";
            this.buttonALTSENHA.UseVisualStyleBackColor = true;
            this.buttonALTSENHA.Click += new System.EventHandler(this.buttonALTSENHA_Click);
            // 
            // labelUSUARIOInforme
            // 
            this.labelUSUARIOInforme.AutoSize = true;
            this.labelUSUARIOInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSUARIOInforme.ForeColor = System.Drawing.Color.Maroon;
            this.labelUSUARIOInforme.Location = new System.Drawing.Point(132, 68);
            this.labelUSUARIOInforme.Name = "labelUSUARIOInforme";
            this.labelUSUARIOInforme.Size = new System.Drawing.Size(96, 13);
            this.labelUSUARIOInforme.TabIndex = 10;
            this.labelUSUARIOInforme.Text = "* Informe o Usuário";
            // 
            // labelSENHAInforme
            // 
            this.labelSENHAInforme.AutoSize = true;
            this.labelSENHAInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSENHAInforme.ForeColor = System.Drawing.Color.Maroon;
            this.labelSENHAInforme.Location = new System.Drawing.Point(132, 107);
            this.labelSENHAInforme.Name = "labelSENHAInforme";
            this.labelSENHAInforme.Size = new System.Drawing.Size(92, 13);
            this.labelSENHAInforme.TabIndex = 11;
            this.labelSENHAInforme.Text = "* Informe a Senha";
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(119, 45);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(184, 20);
            this.textBoxUSUARIO.TabIndex = 1;
            // 
            // labelOLHO1
            // 
            this.labelOLHO1.Image = global::UC11_Tela_Login.Properties.Resources.olho_view;
            this.labelOLHO1.Location = new System.Drawing.Point(300, 84);
            this.labelOLHO1.Name = "labelOLHO1";
            this.labelOLHO1.Size = new System.Drawing.Size(25, 20);
            this.labelOLHO1.TabIndex = 13;
            this.labelOLHO1.MouseLeave += new System.EventHandler(this.labelOLHO1_MouseLeave);
            this.labelOLHO1.MouseHover += new System.EventHandler(this.labelOLHO1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 108);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // labelSENHA
            // 
            this.labelSENHA.Image = global::UC11_Tela_Login.Properties.Resources.loginSENHA;
            this.labelSENHA.Location = new System.Drawing.Point(79, 79);
            this.labelSENHA.Name = "labelSENHA";
            this.labelSENHA.Size = new System.Drawing.Size(29, 29);
            this.labelSENHA.TabIndex = 5;
            this.labelSENHA.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.Image = global::UC11_Tela_Login.Properties.Resources.loginUSUARIO;
            this.labelUSUARIO.Location = new System.Drawing.Point(77, 36);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(32, 37);
            this.labelUSUARIO.TabIndex = 4;
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Image = global::UC11_Tela_Login.Properties.Resources.botaoLIMPAR;
            this.buttonLIMPAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLIMPAR.Location = new System.Drawing.Point(135, 172);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(110, 28);
            this.buttonLIMPAR.TabIndex = 4;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.Image = global::UC11_Tela_Login.Properties.Resources.botaoENTRAR;
            this.buttonENTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonENTRAR.Location = new System.Drawing.Point(19, 172);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(110, 28);
            this.buttonENTRAR.TabIndex = 3;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 278);
            this.Controls.Add(this.labelOLHO1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.labelSENHAInforme);
            this.Controls.Add(this.labelUSUARIOInforme);
            this.Controls.Add(this.buttonALTSENHA);
            this.Controls.Add(this.labelERROS);
            this.Controls.Add(this.labelCONFSENHA);
            this.Controls.Add(this.textBoxCONFSENHA);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.textBoxSENHA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelSENHA;
        private System.Windows.Forms.Label labelCONFSENHA;
        private System.Windows.Forms.TextBox textBoxCONFSENHA;
        private System.Windows.Forms.Label labelERROS;
        private System.Windows.Forms.Button buttonALTSENHA;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelUSUARIOInforme;
        private System.Windows.Forms.Label labelSENHAInforme;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOLHO1;
    }
}

