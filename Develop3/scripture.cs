using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                if (visibleWords.Count == 0)
                    break;

                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
