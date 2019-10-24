using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtask
{
    class LinqThings
    {
        public void MakeWords()

        {
            var words = new List<string>(){ "the","mathematics","tenth","it","this",
            "bike" };
            var wordswithth = words.Where(word => word.Contains("th"));
            foreach (string word in wordswithth)
            {
                Console.WriteLine(wordswithth);
            }
        }
        //2. Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
        public void RemoveDuplicates()
        {
           var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var dName = names.Where(n => n.Equals(n));
            foreach(string n in dName)
            {
                names.Remove(n);
                Console.WriteLine(names);
                break;
                
            }


        }
        //    Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, 
    //    averages the rest of the grades from that string, then averages the averages.List<string> classGrades = new List<string>() 
    //{ "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };Expected output: 86.12
                 
    public void GetAverageDropLowest()
        {
        
            var classGrades = new List<string>() { "80,100,92,89,65", "93, 81, 78, 84, 69", "73, 88, 83, 99, 64", "98,100,66,75,55" };
            string average = classGrades.Where(a => a.Remove(a.LastIndexOf(a)));
            
            foreach (char a in average)
            {
                
            }

            

           
        }
    }
}
