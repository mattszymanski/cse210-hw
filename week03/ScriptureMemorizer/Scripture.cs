using System.ComponentModel;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

         
    public Scripture(Reference reference, string text)//Construct that accepts a reference and the text of the scripture.
    {
        _reference = reference;

        string[] temp = text.Split(" ");

        _words = new List<Word>();


        foreach (string word in temp)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }

    }
    public void HideRandomWords(int numberToHide)//hides random words
    {
        Random rand = new Random();

        // Loop numbertohide
        for (int i = 0; i < numberToHide; i++)
        {
           
            int index = rand.Next(_words.Count);
            _words[index].Hide();
            //how to only choose index once?
        }
        
    }
    public string GetDisplayText()//displays text and underscores
    {
        // Loop over the list
        // calll the getDisplayText on each Word
        // Combine those strings into a single string

        // return the combined string
        string returnString = "";
        foreach (Word word in _words)
        {
            string wordText = word.GetDisplayText();
            returnString = returnString + " " + wordText;


        }


        return returnString;
    }
    public bool IsCompletelyHidden()//Is the scripture completely hidden?
    {
        if (_words.Count != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
        
    }
}