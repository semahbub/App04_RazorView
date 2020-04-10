using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App04_RazorView.Models;
using System.IO;
using App04_RazorView.ViewModels;

namespace App04_RazorView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FileData()
        {
            string f = @"D:\WorkSpace\agent.log";
            string content = System.IO.File.ReadAllText(f);
            string[] lines = System.IO.File.ReadAllLines(f);
            
            ViewBag.con = content;
            ViewBag.line = lines;

            return View();
        }

        public IActionResult ShowFileInfo()
        {
            string curdir = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(curdir);

            List<FileDetailInfo> filelist = new List<FileDetailInfo>();

            //List<Page> Book = new List<Page>();
            int i = 1;
            foreach (var f in files)
            {
                FileDetailInfo fd = new FileDetailInfo();
                fd.FileName = Path.GetFileNameWithoutExtension(f);
                fd.FileExtension = Path.GetExtension(f);
                fd.FileSize = new FileInfo(f).Length;
                fd.FilePath = f;
                fd.Id = i;

                filelist.Add(fd);

                i++;
            }

            return View(filelist);
        }

        public IActionResult SIngleFileInfo()
        {
            FileDetailInfo fd = new FileDetailInfo();
            fd.FileName = "ASPNETCore";
            fd.FileExtension = ".cs";
            fd.FileSize = 245;
            fd.FilePath = @"C:\Framework\ASPNETCore.cs";
            fd.Id = 1;

            return View(fd);
        }
        public JsonResult getFileInfo()
        {
            string curdir = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(curdir);

            List<FileDetailInfo> filelist = new List<FileDetailInfo>();

            //List<Page> Book = new List<Page>();
            int i = 1;
            foreach (var f in files)
            {
                FileDetailInfo fd = new FileDetailInfo();
                fd.FileName = Path.GetFileNameWithoutExtension(f);
                fd.FileExtension = Path.GetExtension(f);
                fd.FileSize = new FileInfo(f).Length;
                fd.FilePath = f;
                fd.Id = i;

                filelist.Add(fd);

                i++;
            }

            return Json(filelist);
        }

        public IActionResult FileNPerson()
        {
            string curdir = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(curdir);
            List<FileDetailInfo> filelist = new List<FileDetailInfo>();

            int i = 1;
            foreach (var f in files)
            {
                FileDetailInfo fd = new FileDetailInfo();
                fd.FileName = Path.GetFileNameWithoutExtension(f);
                fd.FileExtension = Path.GetExtension(f);
                fd.FileSize = new FileInfo(f).Length;
                fd.FilePath = f;
                fd.Id = i;

                filelist.Add(fd);
                i++;
            }

            List<Person> people = new List<Person>()
            {
                new Person{ Id=1, Name="Tajul Islam", Age=30, Country="Bangladesh"},
                new Person{ Id=2, Name="Shamsul Islam", Age=25, Country="USA"},
                new Person{ Id=3, Name="Tajul Hasan", Age=23, Country="Bangladesh"},
                new Person{ Id=4, Name="Hasan Mahmud", Age=32, Country="Australia"},
                new Person{ Id=5, Name="Javed Sattar", Age=34, Country="UK"}
            };

            PersonFile pf = new PersonFile() { Id = 1, FileList = filelist, PersonList = people };
            
            return View(pf);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
