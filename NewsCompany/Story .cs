using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Story
    {
        public string title;
        public string body;
        public string visualStyle;

        public override string ToString()
        {
            return $"\nTitle: {title}\n ===\n{body}\n ===\nVisual Style: {visualStyle} ";
        }
    }
}
