using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Orientação_a_objeto
{
    class Aluno : Pessoa
    {
        //RA e Curso
        private string ra;
        private string curso;

        //Construtor
        public Aluno()
        {
            this.id = 0;
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.ra = "";
            this.curso = "";
        }
        public Aluno(int _id, string _nome, string _rg, string _cpf, string _ra, string _curso)
        {
            this.id = _id;
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.ra = _ra;
            this.curso = _curso;
        }
        public Aluno retornaAluno()
        {
            Aluno obj = new Aluno();
            obj.id = this.id;
            obj.nome = this.nome;
            obj.rg = this.rg ;
            obj.cpf = this.cpf;
            obj.ra = this.ra ;
            obj.curso = this.curso;
            return obj;
        }
        public string RA
        {
            get { return this.ra; }
            set { this.ra = value; }
        }
        public string CURSO
        {
            get { return this.curso; }
            set { this.curso = value; }
        }
    }
}
