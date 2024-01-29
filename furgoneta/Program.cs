namespace furgoneta
{
    class program
    {
        public static void Main(String[] args)
        {
            
                int carga;
                int sacos;

                carga = Convert.ToInt32(Console.ReadLine());

                if (carga / 3 > 4000)
                {

                    sacos = 12000 / carga;

                    Console.WriteLine(sacos / 3);

                }
                else
                {
                    Console.WriteLine("la carga es demasiado pesada para un solo camión");
                }




            
        }
    }
}