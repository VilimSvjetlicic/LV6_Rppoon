using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class PasswordValidator
    {
        private StringChecker first;
        private StringChecker lastAdded;

        public PasswordValidator(StringChecker first)
        {
            this.first = first;
            this.lastAdded = first;
        }
        public void AddChecker(StringChecker checker) {
            lastAdded.SetNext(checker);
            lastAdded = checker;
        }
        public bool checkValidation(string stringToCheck)
        {
            return first.Check(stringToCheck);
        }
        

    }
}
