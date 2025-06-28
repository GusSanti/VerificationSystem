using System.Collections.Specialized;
using System.Security;
using System.Security.Cryptography.X509Certificates;

public class Verify
{
    public static bool VerifyName(string name)
    {
        string[] part = name.Split(' ');
        string partOne = part[0];
        int space = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == ' ')
            {
                space++;
            }
        }

        if (partOne.Length < 1)
        {
            return false;
        }
        if (space < 1)
        {
            return false;
        }

        return true;
    }
    public static bool VerifyEmail(string email)
    {
        int contSign = 0;
        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@')
            {
                contSign++;
            }
        }

        if (contSign != 1)
        {
            return false;
        }

        string[] part = email.Split('@');
        string partOne = part[0];
        string partTwo = part[1];

        if (partOne.Length < 2)
        {
            return false;
        }
        if (partTwo.Length > 4 && partTwo.EndsWith(".com"))
        {
            return true;
        }
        return false;
    }
    public static bool VerifyPass(string pass)
    {
        int contChar = 0;
        int contUpper = 0;
        for (int i = 0; i < pass.Length; i++)
        {
            char c = pass[i];
            if (!char.IsLetterOrDigit(pass[i]))
            {
                contChar++;
            }
            if (c >= 'A' && c <= 'Z')
            {
                contUpper++;
            }
        }

        if (pass.Length < 6)
        {
            return false;
        }
        if (contChar >= 1 && contUpper >= 1)
        {
            return true;
        }
        return false;
    }

    public static bool VerifyAge(int age)
    {
        if (age > 150 || age < 0)
        {
            return false;
        }
        return true;
    }
}