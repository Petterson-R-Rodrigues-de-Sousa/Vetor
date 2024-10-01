using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Cadastro
    {
        protected string nome { get; set; }
        protected int idade { get; set; }
        private string dataNasc;
        private string email;
        private string telefone;
        private string cpf;
        private string cep;
        private string rg;
        protected string tipoSangu { get; set; }
        protected string historicoSaud { get; set; }
        protected string sintomas { get; set; }
        protected string alergias { get; set; }
        protected string doencasPregre { get; set; }
        protected string estado { get; set; }

        protected string[] infTot;
        public string[] InfTot
        {
            get => infTot;

            set => infTot = value;
        }

        protected string[] infMed;

        public string[] InfMed
        {
            get => infMed;

            set => infMed = value;
        }

        protected string[] id;

        public string[] Id
        {
            get => id;

            set => id = value;
        }

        public string Cadastrar()
        {
            infTot = new string[14];
            infMed = new string[9];
            id = new string[15];

            Console.WriteLine("Informações pessoais:");
            Console.WriteLine("\nNome completo:");
            nome = Console.ReadLine();
            InfTot[0] = nome;
            InfMed[0] = nome;
            id[0] = nome;

            Console.WriteLine("\nIdade:");
            idade = int.Parse(Console.ReadLine());
            infTot[1] = idade.ToString();
            infMed[1] = idade.ToString();

            Console.WriteLine("\nData de nascimento:");
            dataNasc = Console.ReadLine();
            infTot[2] = dataNasc.ToString();

            Console.WriteLine("\nE-mail:");
            email = Console.ReadLine();
            infTot[3] = email;

            Console.WriteLine("\nTelefone:");
            telefone = Console.ReadLine();
            infTot[4] = telefone;

            Console.WriteLine("\nRG:");
            rg = Console.ReadLine();
            infTot[5] = rg;

            Console.WriteLine("\nCPF:");
            cpf = Console.ReadLine();
            infTot[6] = cpf;

            Console.WriteLine("\nCep:");
            cep = Console.ReadLine();
            infTot[7] = cep;

            Console.WriteLine("\nInformações médicas:");
            Console.WriteLine("\nHistórico de saúde:");
            historicoSaud = Console.ReadLine();
            infTot[8] = historicoSaud;
            infMed[2] = historicoSaud;

            Console.WriteLine("\nTipo sanguíneo:");
            tipoSangu = Console.ReadLine();
            infTot[9] = tipoSangu;
            infMed[3] = tipoSangu;

            Console.WriteLine("\nSintomas:");
            sintomas = Console.ReadLine();
            infTot[10] = sintomas;
            infMed[4] = sintomas;

            Console.WriteLine("\nAlergias:");
            alergias = Console.ReadLine();
            infTot[11] = alergias;
            infMed[5] = alergias;

            Console.WriteLine("\nDoenças prévias:");
            doencasPregre = Console.ReadLine();
            infTot[12] = doencasPregre;
            infMed[6] = doencasPregre;

            Console.WriteLine("\nEstado atual(Gravíssimo, grave, de gravidade moderada, menos grave ou de menor complexidade):");
            estado = Console.ReadLine();
            infTot[13] = estado;
            infMed[7] = estado;

            return "Cadastro realizado.";
        }



        /*public string exibirInfoTotal()
        {
            return string.Format("Nome completo: { 0}." +
                "\nIdade: {1}." +
                "\nData de Nascimento: {2}." +
                "\nE-mail: {3}." +
                "\nTelefone: {4}." +
                "\nCPF: {5}." +
                "\nCep: {6}." +
                "\nRG: {7}." +
                "\nHistórico de saúde: {8}.\nTipo sanguíneo: {9}." +
                "\nSintomas: {10}." +
                "\nAlergias: {11}." +
                "\nDoenças prévias: {12}." +
                "\nEstado: {12}.", nome, idade, dataNasc, email, telefone, cpf, cep, rg, historicoSaud, tipoSangu, sintomas, alergias, doencasPregre, estado);
        }*/
    }
}

