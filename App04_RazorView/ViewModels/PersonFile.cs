using App04_RazorView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App04_RazorView.ViewModels
{
    public class PersonFile
    {
        public int Id { get; set; }
        public List<FileDetailInfo> FileList { get; set; }
        public List<Person> PersonList { get; set; }
    }
}
