using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Contatos
    {
        private List<Contato> agenda = new List<Contato>();

        public Contatos()
            : this(new List<Contato>())
        {

        }

        public Contatos(List<Contato> agenda)
        {
            this.agenda = agenda;
        }

        internal List<Contato> Agenda { get => agenda; }


        public bool adicionar(Contato c)
        {
            bool res = false;
            if (!agenda.Exists(p => p.Email.ToString() == c.Email.ToString()))
            {
                res = true;
                this.agenda.Add(c);
            }
            return res;
        }


        public Contato pesquisar(Contato c)
        {
            Contato res = new Contato();
            List<Contato> co = agenda.FindAll(delegate (Contato p) { return p.Email.ToString() == c.Email.ToString(); });

            co.ForEach(delegate (Contato p)
            {
                res = new Contato(p.Email.ToString(), p.Nome.ToString(), p.Telefone.ToString(), p.DtNasc);
            });
            return res;

        }

        public bool alterar(Contato c)
        {
            bool res = false;
            List<Contato> co = agenda.FindAll(delegate (Contato p) { return p.Email.ToString() == c.Email.ToString(); });

            co.ForEach(delegate (Contato p)
            {
                p.Nome = c.Nome.ToString();
                p.Email = c.Email.ToString();
                p.Telefone = c.Telefone.ToString();
                Data d = new Data(Convert.ToInt32(c.DtNasc.Dia.ToString()), Convert.ToInt32(c.DtNasc.Mes.ToString()), Convert.ToInt32(c.DtNasc.Ano.ToString()));
                p.DtNasc = d;
                res = true;
            });
            return res;
        }


        public bool remover(Contato c)
        {
            bool res = false;
            agenda.RemoveAll(p => p.Email == c.Email);
            if (!agenda.Exists(x => x == c))
            {
                res = true;
            }
            return res;
        }



        public override string ToString()
        {
            string pa = "";
            foreach (Contato a in this.agenda)
            {
                pa += a.ToString() + "\n\n";
            }
            return pa;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
