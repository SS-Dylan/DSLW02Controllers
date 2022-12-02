using DSLW02Controllers.Services;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace DSLW02Controllers.Controllers;

public class DictionaryController : Controller
{
    private readonly IWordService _dictionary;

    public DictionaryController(IWordService dictionary)
    {
        _dictionary = dictionary;
    }

    public IActionResult Index()
    {
        return View(_dictionary.GetWords());
    }

    public IActionResult AddWord()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddNewWord(string word, string meaning)
    {
        word = HttpUtility.HtmlEncode(word);
        meaning = HttpUtility.HtmlEncode(meaning);
        _dictionary.AddWord(word, meaning);
        return RedirectToAction("Index");
    }
}
