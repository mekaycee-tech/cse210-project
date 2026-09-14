using System;

namespace JournalProgram
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        public string _mood; // Extra feature to exceed requirements

        public Entry(string date, string promptText, string entryText, string mood = "Neutral")
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
            _mood = mood;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine($"Mood: {_mood}");
            Console.WriteLine($"Entry: {_entryText}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}