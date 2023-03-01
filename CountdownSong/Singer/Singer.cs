using CountdownSong;

class Program
{
    static void Main(string[] args)
    {
      
 
            Console.WriteLine("Singing ...");

            Song mySong = new Song();
        
            string song = mySong.Verse(99);

            Console.WriteLine($"{song}");

        
    }
}
