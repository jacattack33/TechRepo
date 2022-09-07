using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public double SelfieNumber { get; set; }

        public SmartPhone(double ram, double storage, bool hasKeyboard, double selfieNumber) : base(ram, storage, hasKeyboard)
        {
            SelfieNumber = selfieNumber;
        }

        public bool TakeSelfie()
        {
            if (SelfieNumber > 1.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
