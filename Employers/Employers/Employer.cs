using System.IO;

namespace Employers
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sallery { get; set; }

        public Employer(string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] darabol = sr.ReadLine().Split(';');

            Id = int.Parse(darabol[0]);
            Name = darabol[1];
            Age = int.Parse(darabol[2]);
            Sallery = int.Parse(darabol[3]);

        }
    }
}
