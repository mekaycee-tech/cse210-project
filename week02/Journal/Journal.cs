using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("\nYour journal is currently empty.");
                return;
            }

            Console.WriteLine("\n--- Journal Entries ---");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
                    }
                }
                Console.WriteLine($"Journal successfully saved to '{file}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving: {ex.Message}");
            }
        }

        public void LoadFromFile(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"Error: File '{file}' does not exist.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(file);
                _entries.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~|~");
                    if (parts.Length >= 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string text = parts[2];
                        string mood = parts.Length >= 4 ? parts[3] : "Neutral";

                        Entry entry = new Entry(date, prompt, text, mood);
                        _entries.Add(entry);
                    }
                }
                Console.WriteLine($"Journal successfully loaded from '{file}'. ({_entries.Count} entries loaded)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading: {ex.Message}");
            }
        }
    }
}