
using System;

namespace _0_FrameWork
{
    public class Entitybase
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Entitybase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
