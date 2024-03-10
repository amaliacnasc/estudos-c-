 // Crie um programa de cadastro de pacientes em uma clinica medica
// Adicione Nome, Idade e  email de cada paciente e imprima os dados 
using System;
namespace pacientes
{
    class Program
    {

        static void Main()
        {
             List<Paciente> pacientes = new List<Paciente>();
            int menu1;
            int menu2;  
            Console.WriteLine("Cadastro de Pacientes\n");
            Console.WriteLine("Digite (1)Para cadastrar paciente e (2)Para finalizar sistema\n");
            do
            {    menu1 = Convert.ToInt32(Console.ReadLine());
                Paciente p1 = new Paciente();
                Console.WriteLine("Por favor, Insira o Nome e Sobrenome do paciente\n");
                p1.NomePacientes = Console.ReadLine();
                Console.WriteLine("Agora digite a idade do paciente\n");
                p1.Idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite email do paciente para contato\n");
                p1.Email = Console.ReadLine();
                Console.WriteLine($"Nome: {p1.NomePacientes}\nIdade: {p1.Idade}\nEmail: {p1.Email}\nPaciente Cadastrado com sucesso");
                pacientes.Add(p1); 
                Console.WriteLine("Gostaria de cadastrar outro paciente?\n(1)Para Sim e (2)Para Não"); 
                menu2 =Convert.ToInt32(Console.ReadLine());
            } while (menu2 == 1); 
            
            if (menu1==2 || menu2==2){
                Console.WriteLine("Sistema Finalizado com sucesso\n"); 
            }


        }
    }
}