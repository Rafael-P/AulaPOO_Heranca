using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {            
            //menu de escolha
            int escolha;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("[1] - PF");
                Console.WriteLine("[2] - PJ");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
            
                switch (escolha)
                {
                    case 1:
                    //PF
                    //instancia da classe PessoaFisica
                    PessoaFisica pf = new PessoaFisica();
                    
                    //Atribuimos um valor ao atributo
                    Console.WriteLine("Digite seu nome: ");
                    pf.nome = Console.ReadLine();

                    Console.WriteLine("Digite seu CPF: ");
                    pf.cpf = Console.ReadLine();

                    Console.WriteLine("Digite seu RG");
                    pf.rg = Console.ReadLine();

                    //Mostrar o metodo no console
                    Console.WriteLine( pf.BoasVindas(pf.nome) );

                    //Mostrar o metodo no console
                    Console.WriteLine( pf.ValidarCPF(pf.cpf) );

                    //FIM DO PF
                    break;

                    case 2:
                    //PJ
                    //Instancia da classe PessoaJuridica
                    PessoaJuridica pj = new PessoaJuridica();

                    //Atribuir um valor ao atributo da classe PessoaJuridica
                    Console.WriteLine("Digite seu nome: ");
                    pj.nome = Console.ReadLine();

                    Console.WriteLine("Digite seu CNPJ: ");
                    pj.cnpj = Console.ReadLine();

                    Console.WriteLine("Digite sua Inscrição Estadual");
                    pj.inscricaoEstadual = Console.ReadLine();

                    //Mostrar o metodo no console
                    Console.WriteLine( pj.BoasVindas(pj.nome) );

                    Console.WriteLine( pj.ValidarCNPJ(pj.cnpj) );

                    break;

                    case 0:
                    //sair
                    Console.WriteLine("Volte sempre!");
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }                        
            } while (escolha != 0);
            

        }//MAIN
    }
}
