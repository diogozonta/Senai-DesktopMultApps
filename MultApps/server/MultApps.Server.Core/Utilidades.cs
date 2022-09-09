using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Server.Core
{
    public static class Utilidades
    {
                                        //declaração das variavéis que virão do local principal.
        public static double SetPesoIdeal(string sexo, double altura)   // double para dizer qual tipo de dado a função deve retornar.
        {
            var pesoIdeal = 0.0;

            if (sexo == "Masculino")
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else
                pesoIdeal = (62.1 * altura) - 44.7;

            return pesoIdeal; //return da variavél desejada.

        }

        public static string MatriculaAluno(int idade, string categoria)
        {

            categoria = string.Empty;

            if (idade > 17)
            {
                categoria = "Adulto";
            }
            else if (idade > 13)
            {
                categoria = "Juvenil B";
            }
            else if (idade > 10)
            {
                categoria = "Juvenil A";
            }
            else if (idade > 7)
            {
                categoria = "Infantil B";
            }
            else if (idade >= 5)
            {
                categoria = "Infantil A";
            }
            else
            {
                categoria = "Não existe categoria";
            }

            return categoria;
        }
    }
}
