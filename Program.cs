namespace VerificationSystem;

class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter sw = new StreamWriter("TEST.txt"))
        {
            sw.WriteLine("RECORD");
            sw.WriteLine();
        }

        int lengthPerson = 3;
        Person[] person = new Person[lengthPerson];

        for (int i = 0; i < lengthPerson; i++)
        {
            person[i] = new Person();
            bool validName;
            string n;
            do
            {
                Console.WriteLine($"Enter the name of the person: {i + 1}");
                n = Console.ReadLine();
                validName = Verify.VerifyName(n);
                if (!validName)
                {
                    Console.WriteLine("Invalid name. Try again.");
                }

            } while (!validName);
            person[i].name = n;

            bool validEmail;
            string e;

            do
            {
                Console.WriteLine($"Enter the email of the person: {i + 1}");
                e = Console.ReadLine();
                validEmail = Verify.VerifyEmail(e);
                if (!validEmail)
                {
                    Console.WriteLine("Invalid email. Try again.");
                }
            } while (!validEmail);
            person[i].email = e;

            bool validPass;
            string p;
            do
            {
                Console.WriteLine($"Enter the password of the person: {i + 1}");
                p = Console.ReadLine();
                validPass = Verify.VerifyPass(p);
                if (!validPass)
                {
                    Console.WriteLine("Invalid password. Try again.");
                }
            } while (!validPass);
            person[i].password = p;

            using (StreamWriter sw = new StreamWriter("TEST.txt", true))
            {
                sw.WriteLine($"Person: {i + 1}");
                sw.WriteLine($"Name: {person[i].name}");
                sw.WriteLine($"Email: {person[i].email}");
                sw.WriteLine($"Password: {person[i].password}");
                sw.WriteLine("-------------------------------");
            }
        }
    }
}
