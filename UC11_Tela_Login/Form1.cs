using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Tela_Login
{
    public partial class Form1 : Form
    {
        string usuario = "admin";
        string senha = "admin";
        int tentativas = 0;
        string funcLIMPAR = "L";
        string funcALTERAR = "A";

        public Form1()
        {
            InitializeComponent();

            labelCONFSENHA.Visible = false;
            textBoxCONFSENHA.Visible = false;
            labelERROS.Text = string.Empty;
            labelUSUARIOInforme.Visible = false;
            labelSENHAInforme.Visible = false;
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            textBoxUSUARIO.BackColor = SystemColors.Window;
            textBoxSENHA.BackColor = SystemColors.Window;

            labelUSUARIOInforme.Visible = false;
            labelSENHAInforme.Visible = false;

            if (textBoxUSUARIO.Text != string.Empty && textBoxSENHA.Text != string.Empty)
            {
                if (textBoxUSUARIO.Text == usuario && textBoxSENHA.Text == senha)
                {
                    MessageBox.Show("Usuário Logado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tentativas = 0;
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tentativas++;
                }
            }
            else
            {
                if (textBoxUSUARIO.Text == string.Empty)
                {
                    textBoxUSUARIO.BackColor = Color.LightCoral;
                    labelUSUARIOInforme.Visible = true;
                }
                if (textBoxSENHA.Text == string.Empty)
                {
                    textBoxSENHA.BackColor = Color.LightCoral;
                    labelSENHAInforme.Visible = true;
                }
            }
            if (tentativas == 3)
            {
                buttonENTRAR.Enabled = false;
                buttonALTSENHA.Enabled = false;
                buttonLIMPAR.Enabled = false;
                textBoxUSUARIO.Enabled = false;
                textBoxSENHA.Enabled = false;
                labelERROS.Text = "Limite de 3 tentativas atingido!";
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            if (funcLIMPAR == "L")
            {
                textBoxUSUARIO.BackColor = SystemColors.Window;
                textBoxSENHA.BackColor = SystemColors.Window;
                labelUSUARIOInforme.Visible = false;
                labelSENHAInforme.Visible = false;
                textBoxUSUARIO.Text = string.Empty;
                textBoxSENHA.Text = string.Empty;
                labelERROS.Text = string.Empty;
                textBoxUSUARIO.Focus();
            }
            else
            {
                textBoxUSUARIO.Enabled = true;
                textBoxUSUARIO.Text = string.Empty;
                textBoxSENHA.Text = string.Empty;
                textBoxCONFSENHA.Text = string.Empty;
                textBoxCONFSENHA.Visible = false;
                labelCONFSENHA.Visible = false;
                buttonENTRAR.Enabled = true;
                buttonALTSENHA.Text = "Alterar Senha";
                buttonLIMPAR.Text = "Limpar";
                buttonLIMPAR.Image = UC11_Tela_Login.Properties.Resources.botaoLIMPAR;
                funcLIMPAR = "L";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonALTSENHA_Click(object sender, EventArgs e)
        {
            if (funcALTERAR == "A")
            {
                if (textBoxUSUARIO.Text == usuario && textBoxSENHA.Text == senha)
                {
                    textBoxUSUARIO.Enabled = false;
                    textBoxSENHA.Text = string.Empty;
                    labelCONFSENHA.Visible = true;
                    textBoxCONFSENHA.Visible = true;
                    buttonALTSENHA.Text = "Salvar Alterações";
                    buttonLIMPAR.Text = "Cancelar";
                    buttonLIMPAR.Image = UC11_Tela_Login.Properties.Resources.botaoCANCELAR;
                    buttonENTRAR.Enabled = false;
                    labelERROS.Text = string.Empty;
                    funcLIMPAR = "C";
                    funcALTERAR = "S";
                }
                else
                {
                    labelERROS.Text = "Credenciais Inválidas!";
                }
            }
            else
            {
                if (textBoxSENHA.Text == textBoxCONFSENHA.Text && textBoxSENHA.Text != string.Empty)
                {
                    senha = textBoxSENHA.Text;
                    textBoxUSUARIO.Enabled = true;
                    textBoxUSUARIO.Text = string.Empty;
                    textBoxSENHA.Text = string.Empty;
                    textBoxCONFSENHA.Text = string.Empty;
                    textBoxCONFSENHA.Visible = false;
                    labelCONFSENHA.Visible = false;
                    buttonENTRAR.Enabled = true;
                    buttonALTSENHA.Text = "Alterar Senha";
                    funcALTERAR = "A";
                    buttonLIMPAR.Text = "Limpar";
                    buttonLIMPAR.Image = UC11_Tela_Login.Properties.Resources.botaoLIMPAR;
                    funcLIMPAR = "L";
                }
                else
                {
                    labelERROS.Text = "Senhas não conferem!";
                }
            }
        }

        private void textBoxSENHA_MouseHover(object sender, EventArgs e)
        {
            textBoxSENHA.PasswordChar = '\0';
        }

        private void textBoxSENHA_MouseLeave(object sender, EventArgs e)
        {
            textBoxSENHA.PasswordChar = '*';
        }

        private void textBoxCONFSENHA_MouseHover(object sender, EventArgs e)
        {
            textBoxCONFSENHA.PasswordChar = '\0';
        }

        private void textBoxCONFSENHA_MouseLeave(object sender, EventArgs e)
        {
            textBoxCONFSENHA.PasswordChar = '*';
        }

        private void labelOLHO1_MouseHover(object sender, EventArgs e)
        {
            textBoxSENHA.PasswordChar = '\0';
            labelOLHO1.Image = UC11_Tela_Login.Properties.Resources.olho_hide;
        }

        private void labelOLHO1_MouseLeave(object sender, EventArgs e)
        {
            textBoxSENHA.PasswordChar = '*';
            labelOLHO1.Image = UC11_Tela_Login.Properties.Resources.olho_view;
        }
    }
}
