using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter
{
    public class UploadResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; } 
        public string ThumbUrl { get; set; }
        public string Extension { get; set; }
    }
}
