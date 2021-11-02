using System;

namespace Atividade_20_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Data d = new Data();

            d.setData(15,9,2000);
            Console.WriteLine(d.ToString());

            Contato c = new Contato("aa", "bb", "cc", d);
            Contato c2 = new Contato("ab", "bc", "ca", d);
            Contatos cc = new Contatos();
            Contatos cc1 = new Contatos();
            Console.WriteLine(c.ToString());
            Console.WriteLine(c.getIdade());
            Console.WriteLine("ADD:" + cc.adicionar(c));
            Console.WriteLine("ADD:" + cc.adicionar(c2));
            Console.WriteLine("ADD:" + cc.adicionar(c2));



            Console.WriteLine(cc.ToString() + "\n");

            Console.WriteLine(cc.pesquisar(c2).ToString());
            d.setData(15, 9, 2010);
            Contato c3 = new Contato("ab", "vvvvvv", "ca", d);
            Contato c4 = new Contato("aaaaaaaa", "bc", "ca", d);
            Console.WriteLine("\nAlterado: " + cc.alterar(c3).ToString());
            Console.WriteLine(cc.pesquisar(c3).ToString());
            Console.WriteLine("\nRemover: " + cc.remover(c3).ToString());
            Console.WriteLine("\naaaaaaaaaaaaaaaa:"+cc.ToString());*/


            //Console.WriteLine("\nAlterado: " + cc.alterar(c3).ToString());
            //Console.WriteLine(cc.pesquisar(c3).ToString());



            //Console.WriteLine(DateTime.Now.ToString("dd"));
            Contatos cc = new Contatos();
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| 0.Sair                             |");
                Console.WriteLine("| 1.Adicionar contato                |");
                Console.WriteLine("| 2.Pesquisar contato                |");
                Console.WriteLine("| 3.Alterar contato                  |");
                Console.WriteLine("| 4.Remover contato                  |");
                Console.WriteLine("| 5.Listar contatos                  |");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(DateTime.Now.Year);


                i = Convert.ToInt32(Console.ReadLine());


                switch (i)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\nPrograma finalizado!\n\n");
                    break;


                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------\nAdicionar contato:");

                        Console.WriteLine("Digite o nome do contato:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o Email do contato:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o Telefone do contato:");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Data de Nascimento:");
                        int a = -1;
                        bool bissextos = false;
                        int mes = 0;
                        int dia = 0;
                        int ano = 0;
                        while (a != 0)
                        {
                            Console.WriteLine("Digite o ano de nascimento:");
                            ano = Convert.ToInt32(Console.ReadLine());
                            if(ano >0 && ano<= DateTime.Now.Year)
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
                                a = 0;
                            }
                            
                        }
                        int m = -1;
                        while(m !=0)
                        {
                            Console.WriteLine("Digite o mes de nascimento:");
                            mes = Convert.ToInt32(Console.ReadLine());
                            if(mes>0  && mes<13)
                            {
                                m = 0;
                            }
                        }
                        int d = -1;
                        while(d !=0)
                        {
                            Console.WriteLine("Digite o dia de nascimento:");
                            dia = Convert.ToInt32(Console.ReadLine());
                            if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                            {
                                if(dia <=31 && dia>0)
                                {
                                    d = 0;
                                }

                            }else if(mes == 4 || mes == 6 || mes == 9 || mes == 11){
                                if (dia <= 30 && dia > 0)
                                {
                                    d = 0;
                                }
                            }
                            else if (mes == 2)
                            {
                                if (bissextos)
                                {
                                    if (dia <= 29 && dia > 0)
                                    {
                                        d = 0;
                                    }
                                }
                                else
                                {
                                    if (dia <= 28 && dia > 0)
                                    {
                                        d = 0;
                                    }
                                }
                            }
                        }

                        Data data = new Data(dia, mes, ano);
                        Contato c = new Contato(email, nome, telefone, data);
                        if(cc.adicionar(c))
                        {
                            Console.WriteLine("Contato adicionado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao adicionar o contato");
                        }
                        


                        Console.WriteLine("\nPrograma finalizado!\n\n");
                    break;

                    case 2:
                        Console.WriteLine("--------------------------------------------------------------------------\nPesquisar contato:");
                        Console.WriteLine("Digite o email do contato que deseja pesquisar:");
                        string co = Console.ReadLine();
                        Data da = new Data();
                        Contato ca = new Contato(co, "", "", da);
                        Console.WriteLine(cc.pesquisar(ca));
                 
                    break;

                    case 3:
                        Console.WriteLine("--------------------------------------------------------------------------\nPesquisar contato:");
                        Console.WriteLine("Digite o email do contato a ser alterado:");
                        string em = Console.ReadLine();
                        Console.WriteLine("Digite o nome:");
                        string nm = Console.ReadLine();
                        Console.WriteLine("Digite o telefone:");
                        string tel = Console.ReadLine();
                        bool bis = false;
                        int me = 0;
                        int di = 0;
                        int an = 0;
                        int k = -1;
                        while (k != 0)
                        {
                            Console.WriteLine("Digite o ano de nascimento:");
                            an = Convert.ToInt32(Console.ReadLine());
                            if (an > 0 && an <= DateTime.Now.Year)
                            {
                                if ((an / 4) == 0)
                                {
                                    if ((an / 100) != 0)
                                    {
                                        bis = true;
                                    }
                                }
                                else if ((an / 400) == 0)
                                {
                                    bis = true;
                                }
                                k = 0;
                            }

                        }
                        int n = -1;
                        while (n != 0)
                        {
                            Console.WriteLine("Digite o mes de nascimento:");
                            me = Convert.ToInt32(Console.ReadLine());
                            if (me > 0 && me < 13)
                            {
                               n = 0;
                            }
                        }
                        int daa = -1;
                        while (daa != 0)
                        {
                            Console.WriteLine("Digite o dia de nascimento:");
                            di = Convert.ToInt32(Console.ReadLine());
                            if (me == 1 || me == 3 || me == 5 || me == 7 || me == 8 || me == 10 || me == 12)
                            {
                                if (di <= 31 && di > 0)
                                {
                                    daa = 0;
                                }

                            }
                            else if (me == 4 || me == 6 || me == 9 || me == 11)
                            {
                                if (di <= 30 && di > 0)
                                {
                                    daa = 0;
                                }
                            }
                            else if (me == 2)
                            {
                                if (bis)
                                {
                                    if (di <= 29 && di > 0)
                                    {
                                        daa = 0;
                                    }
                                }
                                else
                                {
                                    if (di <= 28 && di > 0)
                                    {
                                        daa = 0;
                                    }
                                }
                            }
                        }

                        Data dta = new Data(di, me, an);
                        Contato cx = new Contato(em, nm, tel, dta);
                        if (cc.alterar(cx))
                        {
                            Console.WriteLine("Contato alterado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao alterar o contato");
                        }

                   break;

                    case 4:
                        Console.WriteLine("--------------------------------------------------------------------------\nRemover contato:");
                        Console.WriteLine("Digite o email do contato que deseja remover:");
                        string ce = Console.ReadLine();
                        Data das = new Data();
                        Contato c1 = new Contato(ce, "", "", das);
                        if (cc.remover(c1))
                        {
                            Console.WriteLine("Contato removido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao remover o contato");
                        }

                        break;

                    case 5:
                        Console.WriteLine("--------------------------------------------------------------------------\nLista contatos:");
                        Console.WriteLine(cc.ToString());
                    break;


                }

            }



            Console.ReadKey();
        }
    }
}
