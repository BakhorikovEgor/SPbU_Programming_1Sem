using System;
using System.Runtime.ExceptionServices;

class Programm
{
    static void Main()
    { 
        while (true)
        {
            string[] simple_str = {"uno","dos","tres","cuatro","cinco",
                "seis","siete","ocho","nueve","diez","once","doce","trece",
                "catorce","quince","dieciseis","diecisiete","dieciocho",
                "diecinueve","veinte","veintiuno","veintidos","ventitres","venticuatro",
                "venticinco","ventiseis","ventisiete","ventiocho","ventinueve","treinta","cuarenta","cincuenta",
                "sesenta","setenta","ochenta","noventa"};

            int[] simple_int = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                            15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 40, 50, 60, 70, 80, 90 };
            string[] inp = Console.ReadLine().Split();
            int num = int.Parse(inp[0]);

            try
            {
                if (inp[1] == "m")
                {
                    simple_str[0] = "un";
                    simple_str[20] = "veintiun";
                }
                else if (inp[1] == "w")
                {
                    simple_str[0] = "una";
                    simple_str[20] = "veintiuna";
                }
                else if (inp[1] == "n") ;
                else
                {
                    RaiseError();
                    continue;
                }
            }
            catch 
            {
                RaiseError();
                continue;
            }
            if (num == 0) Console.WriteLine("cero");

            Console.WriteLine(Translator(num, simple_str, simple_int));
        }
    }
    static string Translator(int num, string[] simple_str, int[] simple_int)
    {
        if (num == 0) return "";
        if (simple_int.Contains(num))  return simple_str[Array.IndexOf(simple_int, num)];

        int[] parts = new int[10];string num_str = num.ToString();

        for(int i = 0;i<num_str.Length;i++)  parts[i] = Convert.ToInt16(num_str[i] - '0');

        switch (num_str.Length)
        {
            case 2:
                return string.Format("{0} y {1}", simple_str[parts[0] - 3 + 29], simple_str[parts[1] - 1]);

            case 3:
                if (num == 100) return "ciento";

                if (num < 200)
                {
                    return string.Format("{0} {1}", "ciento", Translator(num % 100, simple_str, simple_int));
                }
                else if (parts[0] == 5)
                {
                    if (simple_str[0] == "una")
                    {
                        string local_output = string.Format("quinientas {0}", Translator(num % 100, simple_str, simple_int));
                        return local_output;
                    }
                    string output2 = string.Format("quinientos {0}", Translator(num % 100, simple_str, simple_int));
                    return output2;
                }
                else
                {
                    
                    string[] starts = { "empty", "dos", "tres", "cuatro", "lala", "seis", "sete", "ocho", "nove" };
                    if (simple_str[0] == "una")
                    {
                        string local_output = string.Format("{0}cientas {1}", starts[parts[0] - 1], Translator(num % 100, simple_str, simple_int));
                        return local_output;
                    }
                    string output3 = string.Format("{0}{1}s {2}", starts[parts[0] - 1], "ceinto", Translator(num % 100, simple_str, simple_int));
                    return output3;
                }

            case 4:
                if (num < 1000) return "mil";

                else if (num < 2000)
                {
                    string output4 = string.Format("{0} {1}", "mil", Translator(num % 1000, simple_str, simple_int));
                    return output4;
                }
                else
                {
                    string output4 = string.Format("{0} {1} {2}", simple_str[parts[0]-1], "mil", Translator(num % 1000, simple_str, simple_int));
                    return output4;
                }

            case 5:
                if (num == 10000)  return "diez mil";
                int first_part5 = int.Parse(num.ToString().Substring(0, 2));
                string output5 = string.Format("{0} {1} {2}", Translator(first_part5, simple_str, simple_int), "mil", Translator(num % 1000, simple_str, simple_int));
                return output5;

            case 6:
                if (num == 100000)  return "cient mil";
                int first_part6 = int.Parse(num.ToString().Substring(0, 3));
                string output6 = string.Format("{0} {1} {2}", Translator(first_part6, simple_str, simple_int), "mil", Translator(num % 1000, simple_str, simple_int));
                return output6;

            case 7:
                if (num == 1000000) return "un million";

                else
                {
                    if (parts[0] < 2)
                    {
                        string output7 = string.Format("un {0} {1}", "millon", Translator(num % 1000000, simple_str, simple_int));
                        return output7;
                    }
                    else
                    {
                        string[] starts = { "un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
                        string output7 = string.Format("{0} {1}es {2}", starts[parts[6] - 1], "millon", Translator(num % 1000000, simple_str, simple_int));
                        return output7;
                    }
                }
            case 8:
                int first_part8 = int.Parse(num.ToString().Substring(0, 2));
                string output8 = string.Format("{0} {1}es {2}", Translator(first_part8, simple_str, simple_int), "millon", Translator(num % 1000000, simple_str, simple_int));
                return output8;

            case 9:
                int first_part9 = int.Parse(num.ToString().Substring(0, 3));
                string output9 = string.Format("{0} {1}es {2}", Translator(first_part9, simple_str, simple_int), "millon", Translator(num % 1000000, simple_str, simple_int));
                return output9;

            case 10:
                if (num == 1000000000) return "mil millones";
                return "Eror: Your number not in range [0,10**9]";

            default:
                return "Eror: Your number not in range [0,10**9]";
        }
    }
    static void RaiseError()
    {
        Console.WriteLine("Wrong format !\nCorrect: Number gender(m-man,w-women,n-neuter).");
    }
}