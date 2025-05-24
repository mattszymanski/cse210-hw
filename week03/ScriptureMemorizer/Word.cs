public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()//hide a word
    {
        _isHidden = true;
    }
    public void Show()//show a word
    {
        _isHidden = false;
    }
    public bool IsHidden()//check to see if a word is hidden or not
    {
        return _isHidden;

    }
    public string GetDisplayText()//displays either the word or ___
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            return "___";
        }  
    }


}