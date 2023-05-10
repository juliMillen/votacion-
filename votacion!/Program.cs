using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votacion_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreC, nombreL, nombreG;
            int cantLocalidades, cantCandidatos, canVotantes,cantVotos, votos=0, ganador=0;
            int localidadConMayorVotacion, porcentajeVotosXLocalidad=0, totalVotosXLocalidad=0, totalVotos=0;
            localidadConMayorVotacion = 0;
            ganador = 0;
            nombreG = "";
            Console.Title = "votaciones 1.0";
            Console.WindowHeight = 8;
            Console.WindowHeight = 20;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de localidades: ");
            cantLocalidades = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < cantLocalidades; i++)
            {
                Console.WriteLine("Ingrese nombre de la localidad: ");
                nombreL = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de votantes: ");
                canVotantes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de candidatos: ");
                cantCandidatos = Convert.ToInt32(Console.ReadLine());

                for(int c=0; c < cantCandidatos; c++)
                {
                    Console.WriteLine("Ingrese el nombre del candidato: ");
                    nombreC = Console.ReadLine();
                    Console.WriteLine("Ingrese cantidad de votos recibido por el candidato: ");
                    cantVotos = Convert.ToInt32(Console.ReadLine());
                    votos = votos + cantVotos;

                    if (cantVotos > ganador) 
                    {
                        ganador = cantVotos;
                        nombreG = nombreC;
                    }
                   
                }
                Console.WriteLine("El ganador de la localidad {0} fue: {1} con {2} votos",i, nombreG, ganador);
                Console.ReadLine();
                totalVotosXLocalidad = totalVotosXLocalidad + votos;
                porcentajeVotosXLocalidad = totalVotosXLocalidad / canVotantes;
                if (totalVotosXLocalidad > localidadConMayorVotacion)
                {
                    localidadConMayorVotacion = totalVotosXLocalidad;
                }
               
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            totalVotos =  totalVotosXLocalidad*cantLocalidades;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 10;
            Console.WindowWidth = 40;
            Console.WriteLine("total de votos: {0}", totalVotos);
            Console.WriteLine("total votos por localidad: {0}", totalVotosXLocalidad);
            Console.WriteLine("porcentaje de votos por localidad: {0:f2}", porcentajeVotosXLocalidad);
            Console.ReadKey();
        }
    }
}
