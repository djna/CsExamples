namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Wordle theWordle = new Wordle();

            string action = "";
            while( action != "X"){
               
                Console.WriteLine("(P)lay or e(X)it)");
                action = Console.ReadLine().ToUpper();
                if ( action == "P"){
                    theWordle.playWordle();
                }
            }

             Console.WriteLine("Goodbye and thanks from Wordle!");

        }
    }

    class Wordle {
        public Wordle(){
            Console.WriteLine("Hello from Wordle!");
        }

        public void playWordle(){
            Console.WriteLine("Apologies, playing not yet implemented");
        }


    }
}