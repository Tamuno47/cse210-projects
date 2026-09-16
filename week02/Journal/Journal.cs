using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
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
        StreamWriter writer = new StreamWriter(file);

        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry.GetEntry());
        }

        writer.Close();
    }

    public void LoadFromFile(string file)
    {
        StreamReader reader = new StreamReader(file);

        string line = reader.ReadLine();

        _entries.Clear();

        while (line != null)
        {
            string[] parts = line.Split('~');
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            _entries.Add(entry);

            line = reader.ReadLine();
        }

    

        reader.Close();

    }

    public Journal()
    {
        _entries = new List<Entry>();
    }
}