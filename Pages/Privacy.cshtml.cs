﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [BindProperty]
    public Form Data { get; set; }

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Data = new Form();
        Data.Mail = "test@gmail.com";
        Data.Password = "12345";
    }

    public IActionResult OnPost(){
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var formValues = Data;
        
        return RedirectToPage("Index");
    }
}

