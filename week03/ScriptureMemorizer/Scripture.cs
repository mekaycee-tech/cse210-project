using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor creates the Reference and populates the Word list[cite: 1]
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the raw text string into individual words
        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Hides a specified number of random words[cite: 1]
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Find all words that are currently NOT hidden
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        // If there are no unhidden words left, do nothing
        if (unhiddenWords.Count == 0) return;

        // Ensure we don't try to hide more words than are available
        int wordsToHideThisTurn = Math.Min(numberToHide, unhiddenWords.Count);

        for (int i = 0; i < wordsToHideThisTurn; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            // Remove the word from our temporary list so we don't select it again in this loop
            unhiddenWords.RemoveAt(index);
        }
    }

    // Assembles the reference and all words into the final display string[cite: 1]
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        // Combines the reference and the formatted words
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    // Checks if every word in the scripture has been hidden[cite: 1]
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            // If even one word is not hidden, return false
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}