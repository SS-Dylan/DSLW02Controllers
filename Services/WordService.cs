using DSLW02Controllers.Models;

namespace DSLW02Controllers.Services;

public class WordService : IWordService
{
    private static List<MyDictionaryEntry> _words = new List<MyDictionaryEntry>();

    public void AddWord(string word, string meaning)
    {
        MyDictionaryEntry dictionaryEntry = new() { Word = word, Meaning = meaning };
        _words.Add(dictionaryEntry);
    }

    public List<MyDictionaryEntry> GetWords()
    {
        return _words;
    }
}
