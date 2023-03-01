namespace CountdownSong;
public class Song
{
    private string quantityText(int number){
        switch (number){
            case 0: return "no more cans";
            case 1: return "1 can";
            default: return $"{number} cans";
        }
    }

    private string action(int number){
        switch (number){
            case 0: return "Go to the store and buy some more";
            case 1: return "Take it down and pass it around";
            default: return "Take one down and pass it around";
        }
    }

    private int nextQuantity(int number){
        return number > 0 ? number -1 : 99; 
    }

    private string capitalize(string str)
{
    if (str == null)
        return null;

    if (str.Length > 1)
        return char.ToUpper(str[0]) + str.Substring(1);

    return str.ToUpper();
}

    public string Verse( int number){
      
        return 
            $"{capitalize(quantityText(number))} of Lilt on the wall, {quantityText(number)} of Lilt.\n" +
            $"{action(number)}, {quantityText(nextQuantity(number))} of Lilt on the wall.\n";
        
    }

}
