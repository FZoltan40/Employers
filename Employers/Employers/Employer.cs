namespace Employers
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sallery { get; set; }
        public Employer(string row)
        {

            string[] darabol = row.Split(';');

            Id = int.Parse(darabol[0]);
            Name = darabol[1];
            Age = int.Parse(darabol[2]);
            Sallery = int.Parse(darabol[3]);

        }
    }
}
