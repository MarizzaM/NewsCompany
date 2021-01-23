using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            PoliticsTeam politicPost = new PoliticsTeam();
            politicPost.CreateStory();
            politicPost.AddStyle();

            HealthTeam healthPost = new HealthTeam();
            healthPost.CreateStory();
            healthPost.AddStyle();

            GossipTeam gossipPost = new GossipTeam();
            gossipPost.CreateStory();

            Story[] stories = new Story[]
            {
                politicPost.GetStory(),
                healthPost.GetStory(),
                gossipPost.GetStory()
            };
            Newspaper sunday = new Newspaper();
            sunday.SetStories(stories);
            sunday.SetPrise(24.99f);

            sunday.Read();
            Console.WriteLine(NewspaperCalculator.CalcNumberOfChars(sunday));
            
        }
    }
}
