using System.Diagnostics;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public readonly List<string> _prompts = new List<string>();
    {
        "Who did I interact with today?"
        "How did the Lord help me today?"
        "What was my mood today?"
    }
    public void AddEntry()

    Random random = new Random();


    {
        string prompt = _prompts[random.Next(.Count)];
        
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
}