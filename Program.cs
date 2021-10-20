using System;

namespace exerciciosGama
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double imc;
            double salarioMinimo = 1192.4;
            double salario;
            double resultado2;
            double raio;
            double volume;
            double nota1;
            double nota2;
            double nota3;
            double media;
            Animais animal = new Animais();
            Animais animal2 = new Animais();
            Animais animal3 = new Animais();
            Animais animal4 = new Animais();
            Animais animal5 = new Animais();
           
            int opcao;

            Console.WriteLine("Bem-vindo a Central C#! Insira qual opção você quer realizar:");
            Console.WriteLine("(1) Calculadora IMC");
            Console.WriteLine("(2) Calculadora Salário Mínimo");
            Console.WriteLine("(3) Calculadora Volume Esfera");
            Console.WriteLine("(4) Calculadora Média Escolar");
            Console.WriteLine("(5) Animais de Estimação");

            opcao = Convert.ToInt16(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.WriteLine("Insira sua altura em metros:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira seu peso em KG:");
                    peso = Convert.ToDouble(Console.ReadLine());

                    imc = peso / (altura*altura);

                    if (imc <20){
                        Console.WriteLine("Seu IMC é {0.00} e você está abaixo do peso", imc);
                    } else if (imc <25){
                        Console.WriteLine("Seu IMC é {0.00} e você está no peso ideal", imc);
                    } else {
                        Console.WriteLine("Seu IMC é {0.00} e você está acima do peso", imc);
                    }
                    break;
                case 2:
                    Console.WriteLine("Insira o seu salário:");
                    salario = Convert.ToDouble(Console.ReadLine());
                    resultado2 = salario/salarioMinimo;
                    Console.WriteLine("Seu salário corresponde a {0} salários mínimos", resultado2);
                    break;
                case 3:
                    Console.WriteLine("Insira o raio da esfera a ser calculada:");
                    raio = Convert.ToDouble(Console.ReadLine());
                    volume = raio*raio*raio*3.1415*4/3;
                    Console.WriteLine("O volume da esfera é de {0} unidade de medida", volume);
                    break;
                case 4:
                    Console.WriteLine("Insira sua primeira nota:");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira sua segunda nota:");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira sua terceira nota:");
                    nota3 = Convert.ToDouble(Console.ReadLine());
                    media = (nota1+nota2+nota3)/3;
                    if (media >=7){
                        Console.WriteLine("Aprovado! Sua média foi {0}", media);
                    } else{
                        double nota4;
                        double novaMedia;
                        Console.WriteLine("Insira a nota da prova final:");
                        nota4 = Convert.ToDouble(Console.ReadLine());
                        novaMedia = (media+nota4)/2;
                        if (media>=5){
                            Console.WriteLine("Aprovado em exame, sua média foi de {0}", media);
                        } else{
                            Console.WriteLine("Reprovado com a média de {0}", media );
                        }
                    }
                    break;
                case 5:
                    cadastrarPet(animal);
                    cadastrarPet(animal2);
                    cadastrarPet(animal3);
                    cadastrarPet(animal4);
                    cadastrarPet(animal5);

                    exibirPet(animal);
                    exibirPet(animal2);
                    exibirPet(animal3);
                    exibirPet(animal4);
                    exibirPet(animal5);
                    
                    contadorTipo(animal);
                    contadorTipo(animal2);
                    contadorTipo(animal3);
                    contadorTipo(animal4);
                    contadorTipo(animal5);

                    Console.WriteLine("A quantidade de gatos é {0}, a de cachorros é {1} e a de peixes é {2}", contadorGato, contadorCachorro, contadorPeixe);
                    break;
                default:
                    Console.WriteLine("Insira uma opção válida");
                    break;
            }
        }
        static int contadorGato;
        static int contadorCachorro;
        static int contadorPeixe;

        static public void cadastrarPet(Animais animal){
            Console.WriteLine("Insira o nome do animalzinho de estimação");
            animal.setNome(Console.ReadLine());
            Console.WriteLine("Insira o tipo do animalzinho de estimação");
            animal.setTipo(Console.ReadLine());
        }

        static public void exibirPet(Animais animal){
            Console.WriteLine("O nome do animalzinho é {0} e ele é do tipo {1}", animal.getNome(), animal.getTipo());
        }
        static public void contadorTipo(Animais animal){
            if(animal.getTipo() == "gato") {
                contadorGato = contadorGato + 1; 
            } else if(animal.getTipo() == "cachorro"){
                contadorCachorro = contadorCachorro +1; 
            } else {
                contadorPeixe = contadorPeixe + 1;
            }
        }
    }
}
