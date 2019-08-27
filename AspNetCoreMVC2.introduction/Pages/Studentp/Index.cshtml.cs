using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Entities;
using AspNetCoreMVC2.introduction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreMVC2.introduction.Pages.Studentp
{
    public class IndexModel : PageModel
    {
        public void OnGet(string search)
        {
            students = string.IsNullOrEmpty(search)
               ? _context.Students.ToList() :
               _context.Students.Where(s => s.FirstName.ToLower().Contains(search)).ToList();


        }
        public List<Student> students { get; set; }
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }
        //razor page den alınan input verisini bind propertisiyle alt satırdaki

        //Student nesnesine eşitleyim onPost default metoduyla entityframwork kapsamında db ye set ediyoruz
        [BindProperty]
        public Student Student { get; set; }
        public IActionResult Onpost()
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToPage("/studentp/Index");

        }
    


    }
}