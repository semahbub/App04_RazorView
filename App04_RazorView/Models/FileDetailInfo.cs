using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App04_RazorView.Models
{
    public class FileDetailInfo
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }
    }
}
