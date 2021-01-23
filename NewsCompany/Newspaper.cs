using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        private Story[] stories;
        private float price;

        public Story[] GetStories() {
            return this.stories;
        }

        public void SetStories(Story[] stories) {
            this.stories = stories;
        }

        public float GetPrice() {
            return this.price;
        }

        public void SetPrise(float price) {
            this.price = price;        
        }

        public void Read() {
            for (int i = 0; i < stories.Length; i++) {
                Console.WriteLine($"\nStories: {stories[i]}"); 
            }
        }

        public override string ToString()
        {
            GetStories();
            GetPrice();
            return $"Stories: {stories}\nPrice: {price}";
        }


    }
}
