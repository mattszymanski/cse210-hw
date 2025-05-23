public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)//construct
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)//construct
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()//method that displays the scripture reference.
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}  ";
    }

}