using System;

namespace Praticando
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] matrizAlunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            do
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Insira o Nome do Aluno:");
                        Aluno meualuno = new Aluno();
                        // var meualuno = new Aluno();
                        meualuno.Nome = Console.ReadLine();

                        Console.WriteLine("Insira a Nota do Aluno:");
                        if (decimal.TryParse( Console.ReadLine() , out decimal notaDigitada ))
                        {
                            meualuno.Nota = notaDigitada;
                        }
                        else
                        {
                            throw new ArgumentException("A Nota deve ser um número Decimal.");
                        }

                        matrizAlunos[indiceAluno] = meualuno;
                        indiceAluno++;
                        break;
                    case "2":
                        foreach (var a in matrizAlunos)
                        {   
                            if ( !string.IsNullOrEmpty(a.Nome) )
                            {   
                                Conceito meuConceito = CalcularConceito(a.Nota);
                                Console.WriteLine($"{a.Nome} tirou Nota {a.Nota} e seu Conceito é {meuConceito}.");
                            }
                        }
                        
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;

                        for (int i = 0; i < matrizAlunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(matrizAlunos[i].Nome))
                            {
                                notaTotal = notaTotal + matrizAlunos[i].Nota;
                                numAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numAlunos;
                        Conceito conceitoGeral = CalcularConceito(mediaGeral);

                        Console.WriteLine($"A média de {numAlunos} aluno(s) foi {mediaGeral} e o conceito é {conceitoGeral}.");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            } while (opcaoUsuario.ToUpper() != "X");
        }

        private static Conceito CalcularConceito(decimal notaAluno)
        {
            Conceito conceitoCalculado;
            if (notaAluno == 0)
            {
                conceitoCalculado = Conceito.F;
            }
            else if (notaAluno <= 2)
            {
                conceitoCalculado = Conceito.E;
            }
            else if (notaAluno <= 4)
            {
                conceitoCalculado = Conceito.D;
            }
            else if (notaAluno <= 6)
            {
                conceitoCalculado = Conceito.C;
            }
            else if (notaAluno <= 8)
            {
                conceitoCalculado = Conceito.B;
            }
            else
            {
                conceitoCalculado = Conceito.A;
            }
            return conceitoCalculado;
        }

        private static string ObterOpcaoUsuario()
        {   
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1. Inserir novo aluno");
            Console.WriteLine("2. Listar alunos");
            Console.WriteLine("3. Calcular média geral");
            Console.WriteLine("X. Sair e Fechar");
            Console.WriteLine();

            string opcaoMenu = Console.ReadLine();
            return opcaoMenu;
        }

    }
}
