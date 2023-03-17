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
                action = (Console.ReadLine() ?? "").ToUpper();
                if ( action == "P"){
                    theWordle.playWordle();
                }
            }

             Console.WriteLine("Goodbye and thanks from Wordle!");

        }
    }
    class Wordle {
        WordList myWordList;
        public Wordle(){
            myWordList = new WordList();
            Console.WriteLine("Hello from Wordle!");

        }

        public void playWordle(){
            string target = myWordList.getRandomWord();
            Console.WriteLine("Apologies, playing not yet implemented. Target was {0}", target);
        }


    }

    class WordList {
        private string[] myWords;
        private Random random;
        public WordList(){
            string[] someWords = new string[]{ "anvil", "boxes", "croft", "dance"};
            myWords = someWords;
            Console.WriteLine("WordList {0}", string.Join(",", myWords) );
            random = new Random();
        }

        public string getRandomWord(){
            int index = random.Next(myWords.Length);
            return myWords[index];
        }


    }
}