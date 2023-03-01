using CountdownSong;

class Program
{
    static void Main(string[] args)
    {
      
            Song mySong = new Song();
            string songText = "Singing ...";
            for ( int i = 99; i >=0 ; i--){
                songText += mySong.Verse(i);
            }

            Console.WriteLine($"{songText}");
  
    }
}
