using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
        }
        public static void Exercicio5()
        {
            Console.WriteLine("here ex5 will be encoded");
        }
        public static void Exercicio6()
        {
            Console.WriteLine("here ex6 will be encoded");
        }
        public static void Exercicio7()
        {
            Console.WriteLine("here ex7 will be encoded");
        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_MENU-_-_-_-_-_-_-_-_-_-_");
                Console.WriteLine("para realizar o ex 1 - digite 1");
                Console.WriteLine("para realizar o ex 2 - digite 2");
                Console.WriteLine("para realizar o ex 3 - digite 3");
                Console.WriteLine("para realizar o ex 4 - digite 4");
                Console.WriteLine("para realizar o ex 5 - digite 5");
                Console.WriteLine("para realizar o ex 6 - digite 6");
                Console.WriteLine("para realizar o ex 7 - digite 7");
                Console.WriteLine("para sair do programa    -    digite 0");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("thank you for using my system!");
                        break;

                    case 1:
                        Exercicio1();

                        int q, qt;
                        double v, vt;
                        qt = 0;
                        q = 1;
                        vt = 0;

                        do
                        {
                            Console.WriteLine("quantos produtos vc deseja comprar ? ");
                            q = int.Parse(Console.ReadLine());
                            qt += q;

                            Console.WriteLine("digite o preço do produto:");
                            v = double.Parse(Console.ReadLine());
                            v = q * v;
                            vt += v;
                        }
                        while (q != 0);

                        Console.WriteLine("vc comprou o total de produtos igual a : " + qt + "Sua compra ficou em: " + vt);
                        break;

                    case 2:
                        Exercicio2();

                        double vl, qq, vtt, vm = 0, vmm = 0;
                        string nom, nm, nmm;

                        Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                        nom = Console.ReadLine();
                        if (nom == "parar")
                        {
                            break;
                        }
                        Console.WriteLine("digite o valor do produto");
                        vl = double.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade dos produtos");
                        qq = double.Parse(Console.ReadLine());
                        vtt = qq * vl;
                        vm = vtt;
                        nm = nom;
                        vmm = vtt;
                        nmm = nom;

                        do
                        {
                            Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                            nom = Console.ReadLine();
                            if (nom == "parar")
                            {
                                break;
                            }
                            Console.WriteLine("digite o valor do produto");
                            vl = double.Parse(Console.ReadLine());
                            Console.WriteLine("digite o valor do produto");
                            qq = double.Parse(Console.ReadLine());

                            vtt = qq * vl;

                            if (vtt > vm)
                            {
                                vm = vtt;
                                nm = nom;
                            }
                            if (vtt < vmm)
                            {
                                vmm = vtt;
                                nmm = nom;
                            }
                        }
                        while (nom != "parar");

                        Console.WriteLine("o produto com maior valor é: " + nm + " com um com valor de R$" + vm + " e o de menor valor é: " + nmm + " com um valor de R$" + vmm);

                        break;

                    case 3:
                        Exercicio3();

                        double na, pa, pt;

                        Console.WriteLine("quantas avaliações terão neste bimestre?");
                        na = double.Parse(Console.ReadLine());
                        pt = 0;
                        int i = 0;
                        i++;

                        do
                        {
                            Console.WriteLine("Qual o peso q esta avaliação tera no bimestre?");
                            pa = double.Parse(Console.ReadLine());
                            pt += pa;
                            i++;
                        }
                        while (i <= na);

                        pt *= 10;

                        if (pt > 100)
                        {
                            Console.WriteLine("\nOs pesos ultrapassam 100%");
                            break;
                        }
                        if (pt == 100)
                        {
                            Console.WriteLine("\nOs pesos resultam em 100%");
                            break;
                        }
                        if (pt < 100)
                        {
                            Console.WriteLine("\nOs pesos nao atingem 100%");
                            break;
                        }

                        break;

                    case 4:
                        Exercicio4();

                        string estado;

                        Console.WriteLine("digite a sigla do estado");
                        estado = Console.ReadLine();

                        switch (estado)
                        {
                            case "AC":
                                Console.WriteLine("o estado é: Acre");
                                break;
                            case "AL":
                                Console.WriteLine("o estado  é: Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("o estado  é: Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("o estado  é: Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("o estado  é: Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("o estado  é: Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal ,porém não é classificado como estado");
                                break;
                            case "ES":
                                Console.WriteLine("o estado é: Espírito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("o estado  é: Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("o estado é: Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("o estado  é: Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("o estado  é: Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("o estado  é: Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("o estado  é: Pará");
                                break;
                            case "PB":
                                Console.WriteLine("o estado  é: Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("o estado  é: Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("o estado  é: Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("o estado  é: Piauí");
                                break;
                            case "RJ":
                                Console.WriteLine("o estado  é: Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("o estado  é: Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("o estado  é: Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("o estado  é: Rondônia");
                                break;
                            case "RR":
                                Console.WriteLine("o estado  é: Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("o estado  é: Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("o estado  é: São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("o estado  é: Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("o estado  é: Tocantins");
                                break;

                            default:
                                Console.WriteLine("nao existe estado com essa sigla");
                                break;
                        }

                        break;

                    case 5:
                        Exercicio5();

                        int m, d;

                        Console.WriteLine("digite o mês");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("a estação desse mês é: verão");
                                break;

                            case 2:
                                Console.WriteLine("a estação desse mês é: verão");
                                break;

                            case 3:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 20 && d > 1)
                                    Console.WriteLine("a estação desse mês é: verão");
                                if (d >= 20 && d < 31)
                                    Console.WriteLine("a estação desse mês é: outono");
                                break;

                            case 4:
                                Console.WriteLine("a estação desse mês é: verão");
                                break;

                            case 5:
                                Console.WriteLine("a estação desse mês é: verão");
                                break;

                            case 6:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 21 && d > 1)
                                    Console.WriteLine("a estação dessemês é: outono");
                                if (d >= 21 && d < 30)
                                    Console.WriteLine("a estação desse mês é: inverno");
                                break;

                            case 7:
                                Console.WriteLine("a estação desse é: inverno");
                                break;

                            case 8:
                                Console.WriteLine("a estação desse é: inverno");
                                break;

                            case 9:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 23 && d > 1)
                                    Console.WriteLine("a estação desse mês é: inverno");
                                if (d >= 23 && d < 30)
                                    Console.WriteLine("a estação desse mês é: primavera");
                                break;

                            case 10:
                                Console.WriteLine("a estação desse mês é: primavera");
                                break;

                            case 11:
                                Console.WriteLine("a estação desse mês é: primavera");
                                break;

                            case 12:
                                Console.WriteLine("qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 22 && d > 1)
                                    Console.WriteLine("a estação desse mês é: primavera");
                                if (d >= 22 && d < 30)
                                    Console.WriteLine("a estação desse mês é: verão");
                                break;

                            default:
                                Console.WriteLine("não compreendi oq vc escreveu");
                                break;
                        }

                        break;

                    case 6:
                        Exercicio6();

                        double alt, kg, imc;

                        Console.WriteLine("Digite sua altura em metros: ");
                        alt = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu peso em kilos: ");
                        kg = double.Parse(Console.ReadLine());

                        imc = kg / (alt * alt);

                        if (imc < 18.5)
                        {
                            Console.WriteLine("você está abaixo do peso");
                            break;
                        }
                        if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine("você está no peso normal");
                            break;
                        }
                        if (imc >= 25 && imc <= 29.9)
                        {
                            Console.WriteLine("você está com sobrepeso");
                            break;
                        }
                        if (imc >= 30 && imc < 34.9)
                        {
                            Console.WriteLine("você está com obesidade grau 1");
                            break;
                        }
                        if (imc >= 35 && imc < 39.9)
                        {
                            Console.WriteLine("você está com obesidade grau 2");
                            break;
                        }
                        if (imc >= 40)
                        {
                            Console.WriteLine("você está com obesidade grau 3");
                            break;
                        }

                        break;

                    case 7:
                        Exercicio7();

                        int num, numtotal;

                        Console.WriteLine("digite um numero");
                        num = int.Parse(Console.ReadLine());
                        i = 1;

                        do
                        {
                            if (num % i == 0)
                            {
                                numtotal = i;
                                Console.WriteLine(numtotal);
                                i++;
                            }
                            else
                                i++;
                        }
                        while (i != num);

                        break;
                    default:
                        Console.WriteLine("programa inválido!");
                        break;
                }

            } while (option != 0);

        }
    }
}
