using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story = new Story();
            Console.WriteLine("Please enter Title of the post: ");
            story.title = Console.ReadLine();

            Console.WriteLine("Please enter Body of the post: ");
            story.body = Console.ReadLine();
        }
    }
}
