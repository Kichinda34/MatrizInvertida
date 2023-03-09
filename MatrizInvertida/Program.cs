internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        int[,] matriz2 = new int[5, 5];
        Random n = new Random();


        //Somar valores na matriz
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                matriz[l, c] = n.Next(1000);
            }
        }


        int ultimaLinha = matriz.GetLength(0) - 1;
        int ultimaColuna = matriz.GetLength(1) - 1;

        for(int l = 0; l <matriz.GetLength(0); l++)
        {
            for (int c = 0;c < matriz.GetLength(1); c++)
            {
                matriz2[ultimaLinha - l,ultimaColuna - c] = matriz[l, c];
            }
        }

        //impressão da Matriz
        for (int l = 0; l < matriz.GetLength(0); l++)
        {
            for (int c = 0; c < matriz.GetLength(1) - 1; c++)
            {
                Console.Write("\tMat[" + l + "][" + c + "] " + matriz[l, c].ToString("d4"));
            }
            Console.WriteLine();
        }



        //impressão da MatrizInversa
        Console.WriteLine();
        for (int l = 0; l < matriz2.GetLength(0); l++)
        {
            for (int c = 0; c < matriz2.GetLength(1) - 1; c++)
            {
                Console.Write("\tMat2[" + l + "][" + c + "]=" + matriz2[l, c].ToString("d4"));
            }
            Console.WriteLine();
        }

        //uma maneira de utilizar a mesma lógica, porém sem usar as variáveis de substituição no código
        //para inverter a matriz.
        /*
        for (int l = 0, l2 = mat.GetLngth(0) -1; l < mat.GetLength(0); l++, l2--)
        {
            for (int c = 0, c2 = mat.GetLength(1)-1; c < mat.GetLength(1); c++, c2--)
            {
                mat2[l2,c2] = mat[l,c]
            }
        }
        */
    }
}