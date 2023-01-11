using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_FrameWork.Application
{
    public class OperationResult
    {
        public bool Issuccedded { get; set; }
        public string Message { get; set; }

        public OperationResult()
        {
            Issuccedded = false;
        }
        public OperationResult Succeded(string message="عملیات با موفقیت انجام شد.")
        {
            Issuccedded = true;
            Message = message;

            return this;
        }
        public OperationResult Failed(string message )
        {
            Issuccedded = false;
            Message = message;

            return this;
        }

    }
}
