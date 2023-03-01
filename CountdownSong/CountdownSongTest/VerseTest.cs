namespace CountdownSongTest;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountdownSong;

[TestClass]
public class VerseTest
{
    [TestMethod]
    public void TestVerse99()
    {
        Song song = new Song();
        string verse = song.Verse(99);
        string expected =
            "99 cans of Lilt on the wall, " +
            "99 cans of Lilt.\n" +
            "Take one down and pass it around, " +
            "98 cans of Lilt on the wall.\n";
         Assert.AreEqual(verse, expected);
    }

    [TestMethod]
    public void TestVerse2()
    {
        Song song = new Song();
        string verse = song.Verse(2);
        string expected =
            "2 cans of Lilt on the wall, " +
            "2 cans of Lilt.\n" +
            "Take one down and pass it around, " +
            "1 can of Lilt on the wall.\n";
         Assert.AreEqual(verse, expected);
    }

    [TestMethod]    
        public void TestVerse1()
    {
        Song song = new Song();
        string verse = song.Verse(1);
        string expected =
            "1 can of Lilt on the wall, " +
            "1 can of Lilt.\n" +
            "Take it down and pass it around, " +
            "no more cans of Lilt on the wall.\n";
         Assert.AreEqual(verse, expected);
    }

        [TestMethod]    
        public void TestVerseZero()
    {
        Song song = new Song();
        string verse = song.Verse(0);
        string expected =
            "No more cans of Lilt on the wall, " +
            "no more cans of Lilt.\n" +
            "Go to the store and buy some more, " +
            "99cans of Lilt on the wall.\n";
         Assert.AreEqual(verse, expected);
    }
}