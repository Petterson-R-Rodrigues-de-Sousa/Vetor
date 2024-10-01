using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital
{
    internal class Fila : Cadastro
    {
        string[] fila = new string[11];
        int[] senhaPacientes = new int[11];
        int senhaFila = 0;
        private int adjacentePaciente = 0;

        string[] filaAdjacente = new string[11];
        int posFilaAdjacente = 0;


        public void Pacientes()
        {
            if (infMed != null)
            {
                string infoMedicas = string.Join(".\n", infMed);


                if (idade >= 60)
                {

                    for (int i = fila.Length - 1; i > 0; i--)
                    {
                        fila[i] = fila[i - 1];
                        senhaPacientes[i] = senhaPacientes[i - 1];
                    }


                    fila[0] = infoMedicas;
                    senhaPacientes[0] = senhaFila;
                    Console.WriteLine("Paciente idoso {0} foi adicionado à fila na posição 0.", infMed[0]);
                }
                else
                {
                    if (senhaFila < fila.Length)
                    {
                        fila[senhaFila] = infoMedicas;
                        senhaPacientes[senhaFila] = senhaFila;
                        senhaFila++;

                        Console.WriteLine("Paciente {0} foi adicionado à fila na posição {1}.", infMed[0], senhaFila - 1);
                    }
                    else
                    {
                        Console.WriteLine("Fila cheia, não é possível adicionar mais pacientes.");
                    }
                }
            }
        }

    }
}
