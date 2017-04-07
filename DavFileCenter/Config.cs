using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter
{
    public class Config
    {
        public bool AutoDeleteUnusedFiles { get; set; }
        public string RelativePath { get; set; }
        public string ThumbnailRelativePath { get; set; }

        /// <summary>
        ///  Gets or sets the interval, expressed in milliseconds.
        /// </summary>
        public int? DeleteTimerInterval { get; set; }

        /// <summary>
        ///  Gets or sets the 'waiting to use file', expressed in minutes.
        /// </summary>
        public int? WaitingToUseFile { get; set; }
    }
}
