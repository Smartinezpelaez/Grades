using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
   public class NameChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
