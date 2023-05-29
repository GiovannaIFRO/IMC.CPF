using System;
public static class Validacoes
{
    public static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if(cpf.Length != 11)
        {
            return false;
        }

        else
        {
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int cont1 = 0;

            for(int i = 0; i < cpf.Length-2; i++)
            {
                cont1 += int.Parse(cpf[i].ToString()) * array[i] ;
            }

            int resto = cont1 % 11;
            if(resto < 2)
            {
                cont1 = 0;
            }
            else
            {
                cont1 = (11- resto);
            }

            if (cpf[9] != cont1)
            {
                return false;
            }

            int[] array2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int cont2 = 0;

            for (int i = 0; i < cpf.Length - 1; i++)
            {
                cont2 += array2[i] * cpf[i];//multiplicando e somando ao mesmo tempo
            }

            int resto2 = cont2 % 11;//pegando o resto da divisão e armazenando numa variável
            if (resto2 < 2)
            {
                cont2 = 0;
            }
            else
            {
                cont2 = (resto2 - 11);
            }

            if (cpf[10] != cont2)//!= diferente
            {
                return false;
            }

            else
            {
                return true;
            }

        }

       
    }
 
}

