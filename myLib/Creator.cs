using System;

namespace myLib
{
    public class Creator
    {
        public static int[] Generate(int size, int min, int max)
        {
            Random random = new Random();
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
                mas[i] = random.Next(min, max);
            return mas;            
        }
        public static int[,] Generate(int sizeX, int sizeY, int min, int max)
        {
            Random random = new Random();
            int[,] mas = new int[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for(int j = 0; j < sizeY; j++)
                    mas[i,j] = random.Next(min, max);
            return mas;
        }
    }
}
