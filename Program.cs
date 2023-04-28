namespace task4_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<University> universities = new List<University>();

            string? inp = null;
            while (inp != null || inp != "")
            {
                Console.WriteLine("\n1 - Add University \n2 - Add EmployedUniversity\n3 - Show");
                inp = Console.ReadLine();
                if (int.TryParse(inp, out int cmd))
                {
                    switch (cmd)
                    {
                        case 1:
                            Console.WriteLine("\nEnter name, number of enrolled, number of graduated of University (separate with spaces:)");
                            string? pInp = Console.ReadLine();
                            if (pInp != null)
                            {
                                string[] splittedInp = pInp.Split(' ');
                                if (
                                        splittedInp.Length == 3 &&
                                        int.TryParse(splittedInp[1], out int enrolled) &&
                                        int.TryParse(splittedInp[2], out int graduated)
                                    )
                                {   
                                    universities.Add(new University(splittedInp[0], enrolled, graduated));
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("\nEnter name, number of enrolled, number of graduated, percentage of employed of EmployedUniversity (separate with spaces:)");
                            pInp = Console.ReadLine();
                            if (pInp != null)
                            {
                                string[] splittedInp = pInp.Split(' ');
                                if (
                                        splittedInp.Length == 4 &&
                                        int.TryParse(splittedInp[1], out int enrolled) &&
                                        int.TryParse(splittedInp[2], out int graduated) &&
                                        double.TryParse(splittedInp[3], out double employed)
                                    )
                                {
                                    universities.Add(new EmployedUniversity(splittedInp[0], enrolled, graduated, employed));
                                }
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nUniversities:");
                            foreach(University university in universities)
                            {
                                Console.WriteLine(university.ToString());
                            }
                            break;

                        default:
                            Console.WriteLine("\nUnrecognised");
                            break;
                    }
                }
            }
        }
    }
}