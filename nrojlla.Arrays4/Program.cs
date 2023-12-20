namespace nrojlla.Arrays4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del vector:");
            int NumeroSolicitado = Convert.ToInt32(Console.ReadLine());

            int[] limite = new int[NumeroSolicitado];                    
            Random r = new Random();   
            
            for (int i = 0; i < NumeroSolicitado; i++)
            {   
                limite[i] = r.Next(0, 101);
                
            }
            Console.WriteLine("Resultado: ");

            Array.Sort(limite);

            foreach (int num in limite)
            {
                Console.WriteLine(num);
            }
        }
    }
}