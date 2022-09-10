using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Server.Core
{
    public static class Utilidades
    {

        public static double SetPesoIdeal(string sexo, double altura)   // double para dizer qual tipo de dado a função deve retornar e declaração das variavéis que virão do local principal.
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

        public static void RealizarProcessamento(bool rbnTrueTurno, bool rbnTrueCategoria, double horasTrabalhadas, double valorSalarioMinimo, string textoTurno, string textoCategoria)
        {
            double valorCoeficiente = GetCoeficiente(textoTurno);
            double valorGratificacao = GetGratificacao(rbnTrueTurno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnTrueCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetAuxilioAlimentacao(rbnTrueCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;

            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);

        }

        public static void GetCoeficiente(string textoTurno, double valorSalarioMinimo)
        {
            double valorCoeficiente = 0;
            
            switch (textoTurno)
            {
                case "Matutino":
                    valorCoeficiente = valorSalarioMinimo * 0.01;
                    break;

                case "Vespertino":
                    valorCoeficiente = valorSalarioMinimo * 0.02;
                    break;

                case "Noturno":
                    valorCoeficiente = valorSalarioMinimo * 0.03;
                    break;
            }
        }

        public static double GetGratificacao(string textoTurno, double horasTrabalhadas)
        {
            double valorGratificacao = 30;

            if (textoTurno == "Noturno" && horasTrabalhadas > 80)          
                valorGratificacao = 50;
              
            return valorGratificacao;
           

        }

        public static double GetValorImposto(string textoCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (textoCategoria)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.02;                   
                    break;

                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }

            return valorImposto;
        }

        public static double GetAuxilioAlimentacao(string textoCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;

            if (textoCategoria == "Calouro" && (valorSalarioBruto < valorSalarioMinimo / 2))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            
            return valorAuxilioAlimentacao;
            
        }

        public static void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            string situacaoDoUsuario = GetSituacaoUsuario(valorSalarioLiquido);
        }

        public static string GetSituacaoUsuario(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
                return "Mal Remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem Remunerado";
        }
        

    }
}
