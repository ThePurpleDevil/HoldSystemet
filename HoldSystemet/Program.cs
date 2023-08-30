namespace HoldSystemet
{

    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Opgave 2");

            //Opgave 1 
            Studerende St1 = new Studerende(1, "Maria", "Krike Værløsevej 12","123345678");
            Studerende St2 = new Studerende(2, "Jack", "Sofiavej 21", "12345613479");

            // Opgave 2 
            Hold hold1 = new Hold("Datamatiker", "Roskilde", "a", 2023, true);
            Hold hold2 = new Hold ("It-Tekolog", "Køge", "b",2023,false);
            //Console.WriteLine(St1);


            //Opgave 3

            //Console.WriteLine("Opgave 3");
            hold1.adderStuderende(St1);
            //hold1.adderStuderende(St2);
            //hold1.FjernStuderende(St1);
            //hold1.FjernStuderende(St2);

            Console.WriteLine(hold1); 
            hold1.PrintStuderende();
          
            
            Console.WriteLine("Test CPR fejl");
            try
            {
                Studerende St3 = new Studerende(7, "Martin", "Sofiavej 21", "1234563479");

            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}