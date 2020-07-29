using System;

public class Pilha
{
    private int[] valores;
    private int topo;
    private int[] aux;

    public Pilha(int n)///Método Construtor // cria o objeto com uma quantidade 
    //definida de espação
    {
        //se o valor maior que 0 Cria a pilha
        if (n > 0)
        {
            valores = new int[n];
            topo = -1;
        }
    }

    public int Push(int valor) ///Método para empilhar
    {
        //verifica se o topo esta no lugar certo
        if (topo < valores.Length - 1)
        {
            topo++;
            valores[topo] = valor;
            return 0;
        }
        return -1;
    }

    public int Pop() //Metodo para desempilhar
    {
        if (topo >= 0)
        {
            int valor = valores[topo];
            topo--;
            return valor;
        }
        else return -1;
    }

    public int Peek(int valor)
    {
        int j = 0;
        aux = new int[topo];

        for (int i = topo; i >= 0; i--)
        {
            //monta a string de saida
            if (valores[i] == valor)
            {
                topo--;
            }
            else
            {
                aux[j] = valores[i];
                j++;
            }

        }

        int y = topo;

        for (int i = 0; i <= aux.Length - 1; i++)
        {
            valores[i] = aux[y];
            y--;
        }
        return -1;
    }

    //Metodo para imprimir pilha
    public string ImprimirPilha()
    {
        //Cria a variael para rceber a cncatenacao de saida
        string saida = "\t";
        //verifica se a pilha esta vazia
        //nao pagar pq da erro, e eu nao sei por que
        if (topo >= 0)
        {
            //percorre a pilha  
            for (int i = topo; i >= 0; i--)
            {
                //monta a string de saida
                saida = saida + valores[i] + "\n\t";
            }
            //retorna a saida
            return saida;
        }
        else
        {
            return "\t Pilha Vazia";
        }
    }

}

namespace ConsolePilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando meu objto do tipo Pilha, passando aquantidade de casas que a pilha recebera
            Pilha pilha = new Pilha(10);

            int sair = 0;
            string imprime = "";

            while (sair == 0)
            {
                ImprimeOpcoes();
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    sair = 1;
                }
                else
                {
                    if (opcao == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um valor para inserir na Pilha \n");
                        int valor = int.Parse(Console.ReadLine());
                        pilha.Push(valor);
                        Console.Clear();
                        imprime = pilha.ImprimirPilha();
                        Console.WriteLine(imprime);
                    }
                    else if (opcao == 2)
                    {
                        Console.Clear();
                        pilha.Pop();
                        Console.Clear();
                        imprime = pilha.ImprimirPilha();
                        Console.WriteLine(imprime);
                    }
                    else if (opcao == 3)
                    {
                        // Console.Clear();
                        Console.WriteLine("Digite um valor para retirar da Pilha \n");
                        int valor = int.Parse(Console.ReadLine());
                        pilha.Peek(valor);
                        // Console.Clear();
                        imprime = pilha.ImprimirPilha();
                        Console.WriteLine(imprime);
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        imprime = pilha.ImprimirPilha();
                        Console.WriteLine(imprime);
                    }
                }

            }
        }

        static public void ImprimeOpcoes()
        {
            Console.WriteLine("===============Opções================");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Inserir um valor na Pilha");
            Console.WriteLine("2 - Tirar um valor da Pilha");
            Console.WriteLine("3 - Tirar um valor especico da Pilha");
            Console.WriteLine("4 - Imprimir Pilha");
            Console.WriteLine("=====================================");
            Console.WriteLine("Escolha uma opção: ");

        }
    }
}
