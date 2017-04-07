using DavFileCenter.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter.Exceptions
{
    public class EmptyFileException : BaseException
    {
        internal EmptyFileException()
        {
        
        }

        public override string Message
        {
            get
            {
                return ExceptionMessages.EmptyFileMessage;
            }
        }
    }
}
