public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        // TODO: format this data
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
         
        Console.WriteLine(_date);
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }


}