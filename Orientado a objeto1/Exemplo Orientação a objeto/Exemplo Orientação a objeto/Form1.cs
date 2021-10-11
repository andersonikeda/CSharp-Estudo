using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Orientação_a_objeto
{
    public partial class Form1 : Form
    {
        int tipo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAluno.Checked == true)
            {
                pnlAluno.Visible = true;
               pnlProfessor.Visible = false;
                this.tipo = 1;
            }
            else
            {
                pnlProfessor.Visible = true;
                pnlAluno.Visible = false;
                this.tipo = 2;
            }
        }

        private void rbProfessor_CheckedChanged(object sender, EventArgs e)
        {
            rbAluno_CheckedChanged(sender, e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textCursos.Text = "";
            txtFormacao.Text = "";
            txtNome.Text = "";
            txtRA.Text = "";
            txtRegistro.Text = "";
            textCPF.Text = "";
            textRG.Text = "";
            rbAluno.Checked = false;
            rbProfessor.Checked = false;
            pnlAluno.Visible = false;
            pnlProfessor.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Aluno aluno =new Aluno();
            if (this.tipo == 1)
            {
                Aluno aluno = new Aluno(
                    0,
                    txtNome.Text,
                    textRG.Text,
                    textCPF.Text,
                    txtRA.Text, 
                    textCursos.Text
                    );
                try
                {
                    string[] linhas =
                    {
                    "Nome:"+txtNome.Text,
                    "RG:"+textRG.Text,
                    "CPF:"+textCPF.Text,
                    "RA:"+txtRA.Text,
                    "Cursos"+textCursos.Text
                    };
                    System.IO.File.WriteAllLines(@"C:\Users\Kayky\Desktop\TP(C#)\3-13-07_2020 Orientado a objeto\Exemplo Orientação a objeto.txt",
                        linhas);
                    string [] linhas2 = System.IO.File.ReadAllLines(@"C:\Users\Kayky\Desktop\TP(C#)\3-13-07_2020 Orientado a objeto\Exemplo Orientação a objeto.txt");
                    lblResultado.Text = "";

                    foreach(string linha in linhas2)
                    {
                        lblResultado.Text += "\n" + linha;
                    }

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }

               /* Aluno aluno2 = new Aluno();
                aluno2 = aluno.retornaAluno();
                lblResultado.Text = "Nome:" + aluno2.NOME + "\nRG:" +
                    aluno2.RG+"\nCPF:"+ aluno2.CPF+"\nRA:"+aluno2.RA + "\nCurso:" + aluno2.CURSO;
                    */
            }
            else if(this.tipo == 2)
            {
                Professor Professor = new Professor();
                Professor.ID = 0;
                Professor.NOME =txtNome.Text;
                Professor.RG = textRG.Text;
                Professor.CPF =textCPF.Text;
                Professor.REGISTRO =txtRegistro.Text;
                Professor.FORMACAO= txtFormacao.Text;
                lblResultado.Text = "Nome:" + Professor.NOME + "\nRG:" +
                 Professor.RG + "\nCPF:" + Professor.CPF + "\nRA:" + Professor.REGISTRO + "\nCurso:" + Professor.FORMACAO;
            }
        }
    }
}
