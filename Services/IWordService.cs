using DSLW02Controllers.Models;

namespace DSLW02Controllers.Services;

public interface IWordService
{
    void AddWord(string word, string meaning);
    List<MyDictionaryEntry> GetWords();
}
