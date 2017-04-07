using DavFileCenter.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter.Exceptions
{
    public class NullFileException : BaseException
    {
        internal NullFileException()
        {
        
        }

        public override string Message
        {
            get
            {
                return ExceptionMessages.NullFileMessage;
            }
        }
    }
}
