using System;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry)
    {
        _entries.Add(_newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} | Prompt:{entry._promptText} | {entry._entryText}");
            }

        }
        Console.WriteLine("File has been Saved");
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Console.WriteLine("Loaded File...");

        foreach (string line in lines)
        {


            string[] parts = line.Split("|");

            Entry loadedEntry = new Entry();

            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            _entries.Clear();
            _entries.Add(loadedEntry);
        }
    }
    
}
    
