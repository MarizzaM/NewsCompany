using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    abstract internal class NewsTeam
    {
        protected Story story;

        abstract internal void CreateStory();

        internal Story GetStory() {
            return this.story;
        }

        internal virtual void AddStyle() { 
        
        }

        public override string ToString()
        {
            return $"{story}";
        }


    }
}
