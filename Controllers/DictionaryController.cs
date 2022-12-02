using DSLW02Controllers.Services;
using Microsoft.AspNetCore.Mvc;

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
        var dictionary = _dictionary.GetWords();
        return View(dictionary);
    }

    public IActionResult AddWord()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddNewWord()
    {
        return View();
    }
}
