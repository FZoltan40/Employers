using System.Collections.Generic;

namespace Employers
{
    internal class Program
    {
        public List<Employer> employers = new List<Employer>();
        static void Main(string[] args)
        {
            Employer emp = new Employer("tulajdonsagok_100sor.txt");
        }
    }
}
