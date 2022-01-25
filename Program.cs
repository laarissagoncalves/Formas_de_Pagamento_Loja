namespace Formas_de_Pagamento_Loja{
    class Program{
        public static void Main (string[] args){

            /*Construa um programa que calcule e apresente o total 
            da compra realizada pelo cliente em uma loja. São fornecidos 
            para o programa, o preço da etiqueta (PE) de cada um dos produtos 
            comprados e, com a compra encerrada, a condição de pagamento escolhida 
            pelo cliente (CP). Utilize para os cálculos a tabela de condições 
            de pagamento a seguir:

                 Código  |           Condição de pagamento

                    1    | À vista em dinheiro ou cheque, com 10% de desconto
                    2    | À vista com cartão de crédito, com 5% de desconto
                    3    | Em 2 vezes, preço normal de etiqueta sem juros
                    4    | Em 3 vezes, preço de etiqueta com acréscimo de 10%
      
            Uma compra pode ser composta por mais do que um produto, portanto, 
            deve ser indicado para o programa quando a compra deve ser encerrada 
            (escolha a forma que desejar).*/

            int cp;
            double pe, ptt, tt;

            Console.WriteLine("Valor a ser pago pela compra.");
            Console.WriteLine("- Para encerrar a compra digite 0 no valor a ser pago.");
            Console.WriteLine("");
            ptt=0;
            //Soma da compra
            do {
                Console.Write("Entre com o valor do preço da etiqueta: ");
                pe = double.Parse(Console.ReadLine());
                ptt = ptt+pe;
                if (pe==0)
                    Console.WriteLine("");
            } while (pe!=0);
            //Condições de pagamento
            Console.WriteLine("Condições de pagamento:");
            Console.WriteLine("1. À vista em dinheiro ou cheque, com 10% de desconto.");
            Console.WriteLine("2. À vista com cartão de crédito, com 5% de desconto.");
            Console.WriteLine("3. Em 2 vezes, preço normal de etiqueta sem juros.");
            Console.WriteLine("4. Em 3 vezes, preço etiqueta com acréscimo de 10%.");
            Console.Write("Digite a opção escolhida: ");
            cp = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            //Calculo das formas de pagamentos
            switch (cp){
                case 1:
                    tt = ptt - (ptt*0.1);
                    Console.WriteLine("O valor a ser pago é R${0:N}.", tt);
                    Console.WriteLine("");
                break;
                case 2:
                    tt = ptt - (ptt*0.05);
                    Console.WriteLine("O valor a ser pago é R${0:N}.", tt);
                    Console.WriteLine("");
                break;
                case 3:
                    tt = ptt/2;
                    Console.WriteLine("O valor total é R${0:N} e a parcela é 3x de R${0:N}.", ptt, tt);
                    Console.WriteLine("");
                break;
                case 4:
                    tt = (ptt+(ptt*0.1))/3;
                    Console.WriteLine("O valor total é R${0:N} e a parcela é 2x de R${1:N}.", ptt, tt);
                    Console.WriteLine("");
                break;
            }
        }
    }
}
