using DavFileCenter.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavFileCenter.Exceptions
{
    public class NullConfigException : BaseException
    {
        internal NullConfigException()
        {
        
        }

        public override string Message
        {
            get
            {
                return ExceptionMessages.NullConfigMessage + Environment.NewLine + ExceptionHelps.NullConfigHelp;
            }
        }


    }

}
