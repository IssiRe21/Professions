using System;

namespace Professions
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Phoenix = new Person("Phoenix", "Wright", "attorney");
            Phoenix.presentation();

            Person Will = new Person("Will", "Powers", "Actor");
            Will.presentation();

            Person Lotta = new Person("Lotta", "Heart", "Photographer");
            Lotta.presentation();
        }
    }
}
