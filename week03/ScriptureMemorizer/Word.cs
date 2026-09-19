public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor initializing the text and setting visibility[cite: 1]
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods to manipulate and check the hidden state[cite: 1]
    public void Hide() 
    { 
        _isHidden = true; 
    }

    public void Show() 
    { 
        _isHidden = false; 
    }

    public bool IsHidden() 
    { 
        return _isHidden; 
    }

    // Returns either the word itself or underscores based on _isHidden[cite: 1]
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Creates a string of underscores exactly the length of the original word
            return new string('_', _text.Length);
        }
        return _text;
    }
}