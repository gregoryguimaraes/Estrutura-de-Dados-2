using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_20_10_2021
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc = new Data();

        public Contato()
            :this("","","", new Data())
        {
            
        }

        public Contato(string email, string nome, string telefone, Data data)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.DtNasc = data;
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }

        public int getIdade()
        {
            int idade = 0;
            int ano = Convert.ToInt32(this.dtNasc.Ano.ToString());
            int atano = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            if (ano  <= atano)
            {
                if(atano == ano)
                {
                    idade = 0;
                }
                else
                {
                    int mes = Convert.ToInt32(this.dtNasc.Mes.ToString());
                    int atomes = Convert.ToInt32(DateTime.Now.ToString("MM"));
                    if(mes == atomes)
                    {
                        int dia = Convert.ToInt32(this.dtNasc.Dia.ToString());
                        int atdia = Convert.ToInt32(DateTime.Now.ToString("dd"));
                        if(dia > atdia)
                        {
                            idade = atano - ano -1;
                        }
                        else if(dia <= atdia)
                        {
                            idade = atano - ano ;
                        }
                    }
                    else if(mes<atomes)
                    {
                        idade = atano - ano ;
                    }
                    else if (mes > atomes)
                    {
                        idade = atano - ano - 1;
                    }
                }
            }


            return idade;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "\nE-mail: " + this.email + "\nTelefone: " + this.telefone + "\nData de Nasc. : " + this.dtNasc.ToString() + "\nIdade: " + getIdade() ;
        }
    }
}
