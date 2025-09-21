using System;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words;



    public Scripture(Reference r1, string s1)
    {
        _reference = r1;
        _words = new List<Word>();

        string[] words = s1.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[random.Next(visibleWords.Count)];

            word.Hide();

            visibleWords.Remove(word);
        }
    }    
    public string GetDisplayText()
    {
        string _createdText = string.Join(" ",_words);
        return $"{_reference} - {_createdText}";
    }
    public override string ToString()
    {
        return GetDisplayText();
    }
    public bool IsCompletelyHidden()=> _words.All(w => w.IsHidden());
    
}