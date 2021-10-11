namespace Exemplo_Orientação_a_objeto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textRG = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.boxTipo = new System.Windows.Forms.GroupBox();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProfessor = new System.Windows.Forms.Panel();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAluno = new System.Windows.Forms.Panel();
            this.textCursos = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.boxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlProfessor.SuspendLayout();
            this.pnlAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(40, 77);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(36, 126);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 3;
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(77, 77);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(122, 20);
            this.textRG.TabIndex = 4;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(77, 126);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(122, 20);
            this.textCPF.TabIndex = 5;
            // 
            // boxTipo
            // 
            this.boxTipo.Controls.Add(this.rbProfessor);
            this.boxTipo.Controls.Add(this.rbAluno);
            this.boxTipo.Location = new System.Drawing.Point(235, 36);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(93, 77);
            this.boxTipo.TabIndex = 6;
            this.boxTipo.TabStop = false;
            this.boxTipo.Text = "Tipo";
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Location = new System.Drawing.Point(6, 43);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(69, 17);
            this.rbProfessor.TabIndex = 8;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            this.rbProfessor.CheckedChanged += new System.EventHandler(this.rbProfessor_CheckedChanged);
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(6, 19);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(52, 17);
            this.rbAluno.TabIndex = 7;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            this.rbAluno.CheckedChanged += new System.EventHandler(this.rbAluno_CheckedChanged);
            // 
            // pnlProfessor
            // 
            this.pnlProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfessor.Controls.Add(this.txtFormacao);
            this.pnlProfessor.Controls.Add(this.txtRegistro);
            this.pnlProfessor.Controls.Add(this.label2);
            this.pnlProfessor.Controls.Add(this.label1);
            this.pnlProfessor.Location = new System.Drawing.Point(361, 39);
            this.pnlProfessor.Name = "pnlProfessor";
            this.pnlProfessor.Size = new System.Drawing.Size(176, 100);
            this.pnlProfessor.TabIndex = 7;
            this.pnlProfessor.Visible = false;
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(69, 48);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(100, 20);
            this.txtFormacao.TabIndex = 3;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(69, 14);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // pnlAluno
            // 
            this.pnlAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAluno.Controls.Add(this.textCursos);
            this.pnlAluno.Controls.Add(this.txtRA);
            this.pnlAluno.Controls.Add(this.txtCurso);
            this.pnlAluno.Controls.Add(this.label3);
            this.pnlAluno.Location = new System.Drawing.Point(361, 39);
            this.pnlAluno.Name = "pnlAluno";
            this.pnlAluno.Size = new System.Drawing.Size(176, 100);
            this.pnlAluno.TabIndex = 8;
            this.pnlAluno.Visible = false;
            // 
            // textCursos
            // 
            this.textCursos.Location = new System.Drawing.Point(69, 55);
            this.textCursos.Name = "textCursos";
            this.textCursos.Size = new System.Drawing.Size(100, 20);
            this.textCursos.TabIndex = 11;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(69, 21);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 20);
            this.txtRA.TabIndex = 10;
            // 
            // txtCurso
            // 
            this.txtCurso.AutoSize = true;
            this.txtCurso.Location = new System.Drawing.Point(7, 56);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(45, 13);
            this.txtCurso.TabIndex = 9;
            this.txtCurso.Text = "CURSO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RA";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(116, 180);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(218, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(74, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlAluno);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pnlProfessor);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxTipo.ResumeLayout(false);
            this.boxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlProfessor.ResumeLayout(false);
            this.pnlProfessor.PerformLayout();
            this.pnlAluno.ResumeLayout(false);
            this.pnlAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.GroupBox boxTipo;
        private System.Windows.Forms.RadioButton rbProfessor;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlProfessor;
        private System.Windows.Forms.Panel pnlAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox textCursos;
        private System.Windows.Forms.TextBox txtRA;
    }
}

