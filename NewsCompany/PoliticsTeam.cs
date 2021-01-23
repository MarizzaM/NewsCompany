using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class PoliticsTeam : NewsTeam
    {

        internal override void CreateStory()
        {
            story = new Story();
            Console.WriteLine("Please enter Title of the post: ");
            story.title = Console.ReadLine();

            Console.WriteLine("Please enter Body of the post: ");
            story.body = Console.ReadLine();
        }

        internal override void AddStyle()
        {
            Console.WriteLine("Please enter visual style of the post: ");
            story.visualStyle = Console.ReadLine();
        }
    }
}
