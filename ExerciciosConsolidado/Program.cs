using System;

namespace ExerciciosConsolidado
{
    class Program
    {
        static void Main(string[] args)
        {

            int operacao = 0;

            do
            {
                if (operacao == 0)
                {
                    Console.WriteLine("Hello World!");

                    TesteFormatacao2();
                }

                    Console.Write("Digite a operacação: ");
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case -1:
                        Console.WriteLine("Fechando programa.");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        ContratoIndividual();
                        break;
                    case 2:
                        RetornaSoma();
                        break;
                    case 3:
                        AreaCirculo();
                        break;
                    case 4:
                        DiferencaProduto();
                        break;
                    case 5:
                        SalarioFuncionario();
                        break;
                    case 6:
                        FormasGeometricas();
                        break;
                    case 7:
                        Sinal();
                        break;
                    case 8:
                        ImparPar();
                        break;
                    case 9:
                        Multiplos();
                        break;
                    case 10:
                        HorasJogo();
                        break;
                    case 11:
                        Exponenciacao();
                        break;
                    case 12:
                        Quadrantes();
                        break;
                    case 13:
                        PostoIpiranga();
                        break;
                    case 14:
                        Impares();
                        break;
                    case 15:
                        NumeroNoIntervalo();
                        break;
                    case 16:
                        MediaPonderada();
                        break;
                    case 17:
                        CadastrarNomes();
                        break;
                    case 18:
                        NumerosEspeciais();
                        break;
                    case 19:
                        CompraCarro();
                        break;
                    case 20:
                        Titulo("Exercicio 20", 1);
                        Console.WriteLine("Calcula uma determinada média das notas fornecidas");
                        Console.WriteLine("Médias calculáveis: Média Aritmética(A), Média Ponderada(P)");
                        Console.Write("Informe a média (A/P): ");
                        char media = char.Parse(Console.ReadLine());
                        Console.Write("Informe a primeira nota: ");
                        double nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Informe a segunda nota: ");
                        double nota2 = double.Parse(Console.ReadLine());
                        Console.Write("Informe a terceira nota: ");
                        double nota3 = double.Parse(Console.ReadLine());
                        NotasAluno(nota1, nota2, nota3, media);
                        break;
                    case 21:
                        Titulo("Exercicio 21", 1);
                        Console.WriteLine("Verifica em qual categoria o nadador se encaixa de acordo com sua idade");
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Categoria: {CategoriaNadador(idade)}");
                        break;
                    case 22:
                        FolhaDePagamento();
                        break;
                    case 23:
                        CedulasSaque();
                        break;
                    default:
                        Console.WriteLine("Operacão inválida!");
                        break;
                }
            }
            while (operacao != -1);
        }

        public static void ContratoIndividual()
        {
            Titulo("Exercício 01\n", 1);

            string nomeEmpresa = "Faz Tudo Frito";
            string cnpjEmpresa = "01.234.456/7890-1";
            string enderecoEmpresa = "Bairro da Galinha, Rua Desfiada nº 10";
            string cidadeEmpresa = "Cidade do Óleo";
            string estadoEmpresa = "Estado da Fritura";

            string nomeFuncionario = "Rei Coxinha";
            string estadoCivil = "Solteiríssimo";
            string cpfFuncionario = "123.456.789-00";
            string CTPS = "123.456.789-00";
            string enderecoFuncionario = "Bairro da Farinha, Rua Peneirada nº 563";
            string cidadeFuncionario = "Cidade do Óleo";
            string estadoFuncionario = "Estado da Fritura";
            string cepFuncionario = "12345-678";
            string funcao = "Provador Real das Coxinhas(e muito obrigado)";
            double remuneracaoMensal = 25000.00;

            string[] texto = new string[5];
            texto[0] = "Pelo presente instrumento e na melhor forma de direito, as partes, de um " +
                String.Format("lado, a {0}, pessoa jurídica de direito privado, {1}", nomeEmpresa, $"inscrita no CNPJ  sob n.º {cnpjEmpresa}, com sede localizada na rua") +
                String.Format("{0}, {1}, {2}, {3}", enderecoEmpresa, cidadeEmpresa, estadoEmpresa, ", que por força do presente contrato passa a ser") +
                "simplesmente denominada CONTRATANTE, e do outro lado, " + nomeFuncionario + $", brasileiro (a), estado civil {estadoCivil}," +
                $"inscrito (a) no CPF sob nº {cpfFuncionario}, portador (a) da CTPS Nº {CTPS}" +
                $"residente e domiciliado(a) na rua {enderecoFuncionario}, {cidadeFuncionario}/{estadoFuncionario}" +
                $"CEP {cepFuncionario}, Doravante denominado CONTRATADO(A), firmam o presente CONTRATO INDIVIDUAL " +
                "DE TRABALHO, a título de experiência, nos termos da Lei e nas seguintes cláusulas:";

            texto[1] = "O (A) CONTRATADO A) obriga-se a prestar seus serviços no quadro de " +
                $"funcionários da CONTRATANTE na função de {funcao}, ficando certo " +
                "e ajustado, que poderá exercer outras funções que lhe sejam compatíveis, " +
                "nos diversos setores da Contratante, sem que isto signifique alteração contratual.";

            texto[2] = $"Em contraprestação aos serviços, receberá mensalmente a importância de + {remuneracaoMensal:c} " +
                "a ser paga até o 5º (quinto) dia útil do mês subseqüente ao vencido.";

            texto[3] = "O (A) CONTRATADO (A) cumprirá uma jornada de trabalho de 44 (quarenta e " +
                "quatro) horas semanais, ficando ajustada a possibilidade de compensação " +
                "de horas, mediante o acréscimo de jornada em determinados dias, para redução em outros.";

            texto[4] = "Dentro das 44 (quarenta e quatro) horas semanais de serviços " +
                "prestados à CONTRATANTE pelo (a) CONTRATADO (A), o início e o encerramento das atividades " +
                "poderão ser modificados de acordo a necessidade da CONTRATANTE.";

            string[] titulos =
            {
                "Contrato Individual de Trabalho",
                "Cláusula Primeira - Da Função",
                "Cláusula Segunda – Da Remuneração",
                "Cláusula Segunda – Da Remuneração",
                "Parágrafo Único:"
            };

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        Titulo(titulos[i], 1, 5);
                        break;
                    case 4:
                        Titulo(titulos[i], 0, 6, true);
                        Console.Write(' ');
                        break;
                    default:
                        Titulo(titulos[i], 1, 3);
                        break;
                }
                Console.WriteLine(texto[i] + "\n");
            }

        }

        public static void RetornaSoma()
        {
            Titulo("Exercicio 02", 1);

            Console.Write("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;

            Console.WriteLine("SOMA = {0}", soma);
        }

        public static void AreaCirculo()
        {
            Titulo("Exercicio 03", 1);

            const double pi = 3.14159;
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = raio * raio * pi;

            Console.WriteLine($"A área do círculo é: {area:n4}");
        }

        public static void DiferencaProduto()
        {
            Titulo("Exercicio 04", 1);

            Console.Write("Digite um número inteiro para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número inteiro para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite um número inteiro para C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite um número inteiro para D: ");
            int d = int.Parse(Console.ReadLine());

            int resultado = a * b - c * d;
            Console.WriteLine("O resultado de (A*B - C*D) é: " + resultado);
        }

        public static void SalarioFuncionario()
        {
            Titulo("Exercicio 05", 1);

            Console.Write("Digite o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de horas trabalhadas por esse funcionário? ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Quanto esse funcionário ganha por hora? ");
            double salarioHora = double.Parse(Console.ReadLine());
            double salarioMensal = horas * salarioHora;

            Console.WriteLine($"O número desse funcionário é {numFuncionario}");
            Console.WriteLine($"Seu salário é {salarioMensal:c}");
        }

        public static void FormasGeometricas()
        {
            Titulo("Exercicio 06", 1);

            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            const double pi = 3.14159;
            double areaTriangulo = a * c / 2;
            double areaCirculo = c * c * pi;
            double areaTrapezio = (a + b) * c / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"A área do triângulo é: {areaTriangulo:n3}");
            Console.WriteLine($"A área do circulo é: {areaCirculo:n3}");
            Console.WriteLine($"A área do trapézio é: {areaTrapezio:n3}");
            Console.WriteLine($"A área do quadrado é: {areaQuadrado:n3}");
            Console.WriteLine($"A área do retângulo é: {areaRetangulo:n3}");
        }

        public static void Sinal()
        {
            Titulo("Exercicio 07", 1);
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("Número positivo");
            else if (numero == 0)
                Console.WriteLine("Zero");
            else
                Console.WriteLine("Número negativo");
        }

        public static void ImparPar()
        {
            Titulo("Exercicio 08", 1);
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }

        public static void Multiplos()
        {
            Titulo("Exercicio 09", 1);
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
                Console.WriteLine("São múltiplos");
            else
                Console.WriteLine("Não são múltiplos");
        }

        public static void HorasJogo()
        {
            Titulo("Exercicio 10", 1);
            Console.Write("Qual a hora de início do jogo? ");
            int horaInicio = int.Parse(Console.ReadLine());
            Console.Write("Qual a hora de término do jogo? ");
            int horaFim = int.Parse(Console.ReadLine());
            int duracao;

            if (horaFim > horaInicio)
                duracao = horaFim - horaInicio;
            else
                duracao = 24 + horaFim - horaInicio;

            Console.WriteLine($"O jogo durou {duracao} horas");
        }

        public static void Exponenciacao()
        {
            Titulo("Exercicio 11", 1);
            Console.Write("Digite um número de 1 a 100: ");
            int n = int.Parse(Console.ReadLine());
            
            if (n < 1 || n > 100)
            {
                Console.WriteLine("Erro! O número está fora do intervalo!");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
            }
        }

        public static void Quadrantes()
        {
            Titulo("Exercicio 12", 1);
            Console.WriteLine("Digite as 2 coordenadas de um ponto no plano carteziano");
            Console.WriteLine("Para parar, atribua 0 a uma delas");

            while (true)
            {
                Console.Write("x = ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y = ");
                double y = double.Parse(Console.ReadLine());

                if (x == 0 || y == 0)
                    break;

                if (y > 0)
                {
                    if (x > 0)
                        Console.WriteLine("Primeiro Quadrante");
                    else
                        Console.WriteLine("Segundo Quadrante");
                } else
                {
                    if (x < 0)
                        Console.WriteLine("Terceiro Quadrante");
                    else
                        Console.WriteLine("Quarto Quadrante");
                }
            }

            // Quadrantes:
            // https://pt.khanacademy.org/math/basic-geo/basic-geo-coord-plane/x7fa91416:points-in-all-four-quadrants/a/coordinate-plane-parts-review#:~:text=Quadrantes,-O%20plano%20cartesiano
        }

        public static void PostoIpiranga()
        {
            Titulo("Exercicio 13", 1);
            Console.WriteLine();
            Titulo("Bem-vindo ao console do Posto Ipiranga!", 1, 7);
            Console.WriteLine(
                "Por favo digite qual o combustível que nossos clientes estão comprando um a um, usando seus códigos\n" +
                "Os códigos são: 1 - Álcool, 2 - Gasolina, 3 - Diesel, 4 - Finaliza programa");

            int i = 1, alcool = 0, gasolina = 0, diesel = 0, combustivel = 0;

            while (combustivel != 4)
            {
                Console.Write($"Cliente {i}: ");
                combustivel = int.Parse(Console.ReadLine());

                switch (combustivel)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("Alcool: " + alcool + "\nGasolina: " + gasolina + "\nDiesel: " + diesel + "\nFinalizando programa");
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }
        }

        public static void Impares()
        {
            Titulo("Exercicio 14", 1);

            Console.Write("Digite um valor de 1 a 1000: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write('{');
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i);
                    if (!((num % 2 == 0 && i == num - 1) || (num % 2 == 1 && i == num)))
                        Console.Write(", ");
                }
            }
            Console.WriteLine('}');
        }

        public static void NumeroNoIntervalo()
        {
            Titulo("Exercicio 15", 1);
            Console.WriteLine("Quantos números estão no intervalor [10, 20]?");
            Console.Write("Informe quantos números serão lidos: ");
            int nums = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;
            for (int i = 0; i < nums; i++)
            {
                Console.Write("Digite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine("Dentro: " + dentro + "\nFora: " + fora);
        }

        public static void MediaPonderada()
        {
            Titulo("Exercicio 16", 1);
            Console.Write("Digite o número de testes: ");
            int nums = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums; i++)
            {
                Console.Write("Número 1: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Número 3: ");
                double num3 = double.Parse(Console.ReadLine());

                double media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

                Console.WriteLine("Média ponderada: " + media.ToString("n1"));
            }
        }

        public static void CadastrarNomes()
        {
            Titulo("Exercicio 17", 1);
            Console.Write("Digite o número de nomes: ");
            int numNomes = int.Parse(Console.ReadLine());

            string[] nomes = new string[numNomes];

            for (int i = 0; i < numNomes; i++)
            {
                Console.Write($"Digite o nome[{i}]: ");
                nomes[numNomes] = Console.ReadLine();
            }

            Console.Write("Digite o número que você deseja verificar: ");
            int numConsulta = int.Parse(Console.ReadLine());
            if (numConsulta < 0 || numConsulta >= numNomes)
            {
                Console.WriteLine("Número fora do intervalo! Encerrando");
                return;
            }
            Console.WriteLine("O nome correspondente é " + nomes[numConsulta]);
        }

        public static void NumerosEspeciais()
        {
            Titulo("Exercicio 18", 1);
            Console.WriteLine("Números especiais em um intervalo definido");
            Console.Write("Número inicial: ");
            int numInicial = int.Parse(Console.ReadLine());
            Console.Write("Número final: ");
            int numFinal = int.Parse(Console.ReadLine());

            Console.Write("Números especiais = {");
            for (int num = numInicial; num <= numFinal; num++)
            {
                if ((num / 3 == 0) && (num / 5 == 0))
                {
                    Console.Write(num);
                    if ((num + 15) <= numFinal)
                        Console.Write(", ");
                }
            }
            Console.Write("}");
        }

        public static void CompraCarro()
        {
            Titulo("Exercicio 19", 1);
            Console.WriteLine("Valor do carro de acordo com as parcelas");
            Console.Write("Digite o valor do carro: ");
            double carro = double.Parse(Console.ReadLine());
            // Quant Parcelas, % Variação, Valor Parcela, Valor Final
            int numParcelas = 1;
            double variacao = -20;
            double valParcela = carro * (1 + variacao / 100);
            double valFinal = valParcela;
            Console.WriteLine("Quant Parcelas\t% Variação\tValor Parcela\tValor Final");
            Console.WriteLine($"À vista\t{variacao}%\t{valParcela:c}\t{valFinal:c}");
            for (numParcelas = 6; numParcelas <= 60; numParcelas += 6)
            {
                variacao = numParcelas / 3;
                valParcela = carro / numParcelas * (1 + variacao / 100);
                valFinal = valParcela * numParcelas;
                Console.WriteLine($"{numParcelas}\t{variacao}%\t{valParcela:c}\t{valFinal:c}");
            }
        }
        
        public static void NotasAluno(double nota1, double nota2, double nota3, char letra)
        {
            // Exercicio 20

            double media;
            switch (letra)
            {
                case 'A':
                    media = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine("Média aritmética: " + media);
                    break;
                case 'P':
                    media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
                    Console.WriteLine("Média ponderada: " + media);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static string CategoriaNadador(int idade)
        {
            // Exercicio 21

            if (idade < 5)
                return "Sem categoria. Muito novo.";
            else if (idade >= 5 && idade <= 7)
                return "Infantil A";
            else if (idade >= 8 && idade <= 10)
                return "Infantil B";
            else if (idade >= 11 && idade <= 13)
                return "Juvenil C";
            else if (idade >= 14 && idade < 17)
                return "Juvenil B";
            else
                return "Adulto";
        }

        public static void FolhaDePagamento()
        {
            Titulo("Exercicio 22", 1);
            Console.WriteLine("Folha de pagamento");
            Console.Write("Informe a quantidade de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Digite quanto você receber por hora: ");
            double pagHora = double.Parse(Console.ReadLine());

            double salarioBruto = pagHora * (double)horas;
            double descontoINSS = salarioBruto * 0.1;
            double descontoFGTS = salarioBruto * 0.11;
            
            double descontoIR;
            if (salarioBruto <= 900)
                descontoIR = 0;
            else if (salarioBruto <= 1500)
                descontoIR = 5;
            else if (salarioBruto <= 2500)
                descontoIR = 10;
            else
                descontoIR = 20;

            descontoIR *= salarioBruto;

            double salarioLiquido = salarioBruto - descontoIR - descontoINSS;
            Console.WriteLine($"Salário Bruto: {salarioBruto:c}");
            if (descontoIR == 0)
                Console.WriteLine("IR: Isento");
            else
                Console.WriteLine($"IR ({descontoIR / salarioBruto}): {descontoIR:c}");
            Console.WriteLine($"INSS(10%): {descontoINSS:c}");
            Console.WriteLine($"FGTS(11%): {descontoFGTS:c}");
            Console.WriteLine($"Salário líquido: {salarioLiquido:c}");
        }

        public static void CedulasSaque()
        {
            Titulo("Exercicio 23", 1);
            Console.WriteLine("Cálcula as cédulas de um saque");
            Console.WriteLine("Somente existem as cédulas 5, 10, 20, 50 e 100");
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int ced100 = 0, ced50 = 0, ced20 = 0, ced10 = 0, ced5 = 0, resto = 0;

            for (int i = valor; i > 0; i++)
            {
                if (i / 100 > 0)
                {
                    ced100++;
                    i -= 100;
                }
                else if (i / 50 > 0)
                {
                    ced50++;
                    i -= 50;
                }
                else if (i / 20 > 0)
                {
                    ced20++;
                    i -= 20;
                }
                else if (i / 10 > 0)
                {
                    ced10++;
                    i -= 10;
                }
                else if (i / 5 > 0)
                {
                    ced5++;
                    i -= 5;
                }
                else
                {
                    resto = i;
                    i = 0;
                }
            }

            if (ced100 > 0)
                Console.WriteLine("Células de 100: " + ced100);
            if (ced50 > 0)
                Console.WriteLine("Células de 50: " + ced50);
            if (ced20 > 0)
                Console.WriteLine("Células de 20: " + ced20);
            if (ced10 > 0)
                Console.WriteLine("Células de 10: " + ced10);
            if (ced5 > 0)
                Console.WriteLine("Células de 5: " + ced5);
            if (resto > 0)
                Console.WriteLine("Esse terminal não possui todas as cédulas necessárias\nFicou faltando " + resto.ToString("c"));
        }

        public static void Titulo(string text, sbyte alignment = 0, sbyte colorScheme = 0, bool subtitulo = false)
        {
            if (alignment == 1)
                Console.CursorLeft = 60 - text.Length / 2;

            switch (colorScheme)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }

            if (subtitulo == false)
                Console.WriteLine(text);
            else
                Console.Write(text);
            
            Console.ResetColor();
        }

        public static void TesteFormatacao()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Teste");
            Console.ResetColor();
            Console.WriteLine("Console BufferWidth: " + Console.BufferWidth);
            Console.CursorLeft = 60;
            Console.WriteLine("oi");
            Console.CursorLeft = 0;
            Console.WriteLine(0);
            Console.CursorLeft = 1;
            Console.WriteLine(1);
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("thcau");
            Console.SetCursorPosition(50, 2);
        }

        public static void TesteFormatacao2()
        {
            string testText = "oi";
            Titulo("tchau");
            for (sbyte i = 0; i <= 5; i++)
                Titulo(testText + i.ToString(), 1, i);
        }
    }
}
