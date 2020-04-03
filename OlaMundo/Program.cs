using System.Collections.Generic;
using static System.Console;
using System;
using System.Collections;
using System.Linq;

namespace OlaMundo //namespace é um pacote de classes
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
            int idade = 30;          
            int dataNascimento;
            string nome = "Jose da Silva";
            string empresa = "XPTO";
            bool ativoNoSistema = true;
            //bool ativoNoSistema = true;
            decimal salario = 1000.00m;
            float descontos = 123.22f;
            var cidade = "São Paulo";
         
            //interpolação
            WriteLine($"O colaborador {nome} trabalha na empresa {empresa}" +
                $" tem {idade} anos e tem renda mensal de {salario}, tem desconto de {descontos}, está {ativoNoSistema} no sistema e mora em {cidade}.");
            WriteLine("\n******************************************************\n");

            dynamic x = "Esta variável é uma String";
            WriteLine(x);

            x = 10;
            WriteLine(x);

            x = true;
            WriteLine(x);
            
            Stack<int> p1 = new Stack<int>();
            p1.Push(1);
            p1.Push(3);
            p1.Push(0);
            p1.Push(-1);
            p1.Push(41);
            p1.Push(-4);
            //na pilha o ultimo elemento a ser colocado é o primeiro a ser retirado.
            WriteLine("A pilha tem "+p1.Count+" itens.");//retorna a quantidade de itens na pilha
            //WriteLine(p1.ToArray().GetValue(1));//Converte em array e retorna o elemento indicado de baixo para cima.
            WriteLine(p1.Peek());//retorna o último item adicionado à pilha
            p1.Pop();//retira da pilha o último item adicionado.

            WriteLine("A pilha tem " + p1.Count + " itens.");//retorna a quantidade de itens na pilha
            WriteLine(p1.ToArray().GetValue(4));//Converte em array e retorna o elemento indicado de baixo para cima.
            WriteLine(p1.Peek());//retorna o último item adicionado à pilha

            p1.Clear();
            WriteLine("A pilha tem " + p1.Count + " itens.");//retorna a quantidade de itens na pilha

            //*tuplas
            //(string, string, double) brasil = ("Brasil", "Brasília", 1202.00);
            //WriteLine($"O {brasil.Item1} tem sua capital sediada em { brasil.Item2} e sua RPC é de R$ { brasil.Item3} reais.");
            //outra forma de fazer uma tupla:
            (string pais, string tipoGoverno, int populacao, string capital, double rpc) brasil = ("Brasil", "presidencialista" ,2300000,"Brasília", 1202.01);
            WriteLine($"O {brasil.pais} tem {brasil.populacao} de habitantes, sua capital está sediada em { brasil.capital} e sua RPC é de R$ { brasil.rpc} reais.");
            
            double salario, despesas;
            char temDecimoTerceiro;

            Write("Informe o salario/mês: ");
            salario = Convert.ToDouble(ReadLine());
            WriteLine();

            Write("Informe a despesa/mês: ");
            despesas = Convert.ToDouble(ReadLine());
            WriteLine();

            Write("Tem décimo terceiro? Y/N ");
            //Boolean.TryParse(ReadLine(), out temDecimoTerceiro);
            //temDecimoTerceiro = Convert.ToBoolean(ReadLine());
            temDecimoTerceiro = Convert.ToChar(ReadLine());
            if (temDecimoTerceiro == 'Y' || temDecimoTerceiro == 'y')
            {
                salario += (salario / 12);
            }

            if (salario > despesas)
            {
            WriteLine("Parabéns você está no caminho certo, seu saldo disponível é de R$ "+(salario-despesas));
            } 
            else if (salario == despesas){
            WriteLine("Saldo disponível zero.");
            } 
            else 
                WriteLine("Seu saldo está negativo em R$ " + (salario - despesas));
                    
                    WriteLine("Salario atual R$ "+salario);
            
            



            //numa pilha vale o conceito de FIFO:
            Queue fila = new Queue();
            fila.Enqueue("Georg");
            fila.Enqueue("Lucas");
            fila.Enqueue("Scirovicza");
            fila.Enqueue(1233);

            WriteLine(fila.Peek()); //obtém o primeiro item da fila.

            WriteLine($"A fila tem {fila.Count} itens.");
            WriteLine($"O item {fila.Dequeue()} foi removido.");
            WriteLine($"A fila tem {fila.Count} itens.");
            WriteLine($"O item {fila.Dequeue()} foi removido.");
            WriteLine($"A fila tem {fila.Count} itens.");
            WriteLine($"O item {fila.Dequeue()} foi removido.");
            WriteLine($"A fila tem {fila.Count} itens.");
            WriteLine($"O item {fila.Dequeue()} foi removido.");
            WriteLine($"A fila tem {fila.Count} itens.");

            //pattern matching
            //Switch-Case

            Write("Informe o saldo da conta/cartão: ");
            var eSaldo = Convert.ToDouble(ReadLine());

            Write("Informe o valor da compra: ");
            var eValor = Convert.ToDouble(ReadLine());

            Write("Informe o tipo de pagamento( C para credito ou D para debito): ");
            var eTipo = Convert.ToChar(ReadLine());


            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            switch(pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra efetuada com cartão de crédito não aprovada.");
                    break;
                case 'c' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra efetuada com cartão de crédito não aprovada.");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra efetuada no cartão de débito não aprovada. ");
                    break;
                case 'd' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra efetuada no cartão de débito não aprovada. ");
                    break;
                default:
                    WriteLine("Compra aprovada.");
                    break;
                    

            //Estruturas de repetição
            //While >> DoWhile, For e ForEach
            int i = 1;
            while (i <= 10)
            {
                WriteLine($"{i}º Ola Mundo.");
                i++;
            }
           
            string[] nomes = new string[] {"Georg Lucas", "Batman","Joker","Spider man"};
            int i = 0;

            while (i < nomes.Length)
            {
                WriteLine($"Bem vindo {nomes[i]}");
                i++;
                

            }WriteLine(nomes.Count()); 
            
            int i = 0;
            do
            {
                i++;
                if (i == 8)
                {
                    WriteLine($"parando o laço de repetição na {i}ª volta.");

                    break;
                }
                WriteLine($"{i} Imprimindo");
                
            } while (i<=10);
           
            string[] nomes = new string[] { "Georg Lucas", "Batman", "Joker", "Spider man" };

            for (int i = 0; i<nomes.Length ; i++)
            {
                WriteLine($"Olá {nomes[i]}.");
                
            }
            string[] diasSemana = new string[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", 
                                                "Quinta-feira", "Sexta-feira", "Sábado" };

            foreach (string dia in diasSemana)
            {
                WriteLine($"Hoje é {dia}");
            }
            */
            
            Queue fila = new Queue();
            fila.Enqueue("Georg");
            fila.Enqueue("Lucas");
            fila.Enqueue("Scirovicza");
            fila.Enqueue("até a próxima.");
                
                foreach (string nome in fila)
                {
                WriteLine($"Nome -> {nome}");
                }


        }

    }

}



