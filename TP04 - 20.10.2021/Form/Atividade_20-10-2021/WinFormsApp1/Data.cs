using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }

        public Data()
            : this(0, 0, 0)
        {

        }

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            return this.dia + "/" + this.mes + "/" + this.ano;
        }
    }
}
