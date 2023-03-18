using System.Text.RegularExpressions;
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
           
            try {
                string contents = File.ReadAllText("Wonder.txt");
                string pattern = @"(?!.{0,4}\d)(?!.{0,4}_)\b\w{5}\b";
                myWords = Regex.Matches(contents, pattern)
                       .Cast<Match>()
                       .Select(m => m.Value.ToLower())
                       .Distinct()
                       .Where(word => 
                                 word.Length 
                                 == new HashSet<char>(word.ToCharArray()).Count()    
                       )
                       .ToArray();
                Array.Sort(myWords);
                
            } catch (Exception e) {
                Console.WriteLine("Error reading word list {0}", e.Message);
                myWords = new string[]{ "anvil", "boxes", "croft", "dance"};
            }
            
            Console.WriteLine("WordList {0} entries: {1}", 
                        myWords.Length,
                        string.Join(",", myWords) );
            random = new Random();
        }

        public string getRandomWord(){
            int index = random.Next(myWords.Length);
            return myWords[index];
        }
    }
}