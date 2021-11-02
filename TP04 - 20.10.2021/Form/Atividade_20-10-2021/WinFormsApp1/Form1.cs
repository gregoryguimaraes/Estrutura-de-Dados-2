using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Contatos cc = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDIA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDIA.Clear();
            txtMes.Clear();
            txtAno.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtFone.Clear();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(txtDIA.Text == null || txtDIA.Text == "" || txtMes.Text == null || txtMes.Text == "" || txtAno.Text == null || txtAno.Text == "" ||  txtEmail.Text == null || txtEmail.Text == "" || txtNome.Text == null || txtNome.Text == "" || txtFone.Text == null || txtFone.Text == "")
            {
                MessageBox.Show("Error! Preencha todos os campos");
            }
            else
            {
                int ano = Convert.ToInt32(txtAno.Text);
                bool bissextos = false;

                if (ano > 0 && ano <= DateTime.Now.Year)
                {
                    if ((ano / 4) == 0)
                    {
                        if ((ano / 100) != 0)
                        {
                            bissextos = true;
                        }
                    }
                    else if ((ano / 400) == 0)
                    {
                        bissextos = true;
                    }

                    int mes = Convert.ToInt32(txtMes.Text);
                    if (mes > 0 && mes < 13)
                    {
                        int dia = Convert.ToInt32(txtDIA.Text);
                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            if (dia <= 31 && dia > 0)
                            {
                                Data data = new Data(dia, mes, ano);
                                Contato c = new Contato(txtEmail.Text, txtNome.Text, txtFone.Text, data);
                                if (cc.adicionar(c))
                                {
                                    MessageBox.Show("Contato adicionado com sucesso");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao adicionar o contato");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro! Dia invalido");
                            }

                        }
                        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                        {
                            if (dia <= 30 && dia > 0)
                            {
                                Data data = new Data(dia, mes, ano);
                                Contato c = new Contato(txtEmail.Text, txtNome.Text, txtFone.Text, data);
                                if (cc.adicionar(c))
                                {
                                    MessageBox.Show("Contato adicionado com sucesso");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao adicionar o contato");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro! Dia invalido");
                            }
                        }
                        else if (mes == 2)
                        {
                            if (bissextos)
                            {
                                if (dia <= 29 && dia > 0)
                                {
                                    Data data = new Data(dia, mes, ano);
                                    Contato c = new Contato(txtEmail.Text, txtNome.Text, txtFone.Text, data);
                                    if (cc.adicionar(c))
                                    {
                                        MessageBox.Show("Contato adicionado com sucesso");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falha ao adicionar o contato");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro! Dia invalido");
                                }
                            }
                            else
                            {
                                if (dia <= 28 && dia > 0)
                                {
                                    Data data = new Data(dia, mes, ano);
                                    Contato c = new Contato(txtEmail.Text, txtNome.Text, txtFone.Text, data);
                                    if (cc.adicionar(c))
                                    {
                                        MessageBox.Show("Contato adicionado com sucesso");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Falha ao adicionar o contato");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro! Dia invalido");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro! Mes invalido");
                    }
                }
                else
                {
                    MessageBox.Show("Erro! Ano invalido");
                }
            }


            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ( txtEmail.Text == null || txtEmail.Text == "" )
            {
                MessageBox.Show("Error! Preencha todos os campos");
            }
            else
            {
                string email = txtEmail.Text;
                Data das = new Data();
                Contato c = new Contato(email, "", "", das);
                if (cc.remover(c))
                {
                    MessageBox.Show("Contato removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao remover o contato");
                }
            }
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            lbContatos.Items.Clear();
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("Error! Preencha todos os campos");
            }
            else
            {
                string email = txtEmail.Text;
                Data das = new Data();
                Contato c = new Contato(email, "", "", das);
                lbContatos.Items.Add(cc.pesquisar(c));
            }
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbContatos.Items.Clear();
            foreach (Contato a in cc.Agenda)
            {
                lbContatos.Items.Add( a.ToString());
            }
        }
    }
    
}
