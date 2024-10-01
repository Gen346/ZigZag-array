namespace ConsoleApplication
{
    class Program
    {

        public static void Main()
        {
            int[,] array;
            int rows, columns;
            Console.Write("Input number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("input number of columns: ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            array = new int[rows, columns];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0, a = 0; j < columns; j++, a++)
                {
                    if (i == 0 & j == 0)
                        array[i, j] = 0;
                    else
                    {
                        if (j == 0)
                            array[i, j] = array[i - 1, j + 1] + 1;
                        else
                        {
                            if ((columns - j <= i) & i > 0)
                            {
                                if (rows > columns)
                                {

                                    if ((columns - j + rows - i - 1) >= columns)

                                        array[i, j] = array[i, j - 1] + columns - 1;
                                    else
                                        array[i, j] = array[i, j - 1] + (columns - j + rows - i - 1);
                                }
                                else
                                {
                                    array[i, j] = array[i, j - 1] + (columns - j + rows - i - 1);
                                }

                            }
                            else
                            {
                                if (j + i < rows)
                                    array[i, j] = array[i, j - 1] + j + i;
                                else
                                    array[i, j] = array[i, j - 1] + rows;
                            }
                        }
                    }
                }

            }



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}