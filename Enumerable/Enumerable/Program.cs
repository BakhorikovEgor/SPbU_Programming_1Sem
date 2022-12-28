using System.Collections;
using System.Text;

class Programm
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());
        StrGenerator s = new(lenght);
        int counter = 0;
        foreach (var i in s)
        {
            
            counter++;

        }
        Console.WriteLine(counter);
    }
}
class StrGenerator : IEnumerable<StringBuilder>
{
    private readonly int lenght;
    public StrGenerator(int l) => lenght = l;

    public IEnumerator<StringBuilder> GetEnumerator()
    {
        return new StrEnum(string.Concat(Enumerable.Repeat('a', lenght)));
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

class StrEnum : IEnumerator<StringBuilder>
{
    private readonly StringBuilder str;
    private int cursor;
    public StrEnum(string inputString)
    {
        str = new StringBuilder(inputString);
        cursor = str.Length;
    }

    public StringBuilder Current => str;

    public bool MoveNext()
    {

        //изначально курсор ничего не меняет,чтобы получить изначальную строку
        if (cursor == str.Length)
        {
            if (str.Length == 1) cursor -= 1;
            else cursor -= 2;
            return true;
        }

        //если для префикса от курсора на копили строку из z то нужно переходить к следующему "разряду" букв
        if (str.ToString().Substring(cursor).Count(i => i == 'z') == str.Length - cursor)
        {
            if (cursor == 0) return false;

            FillPrefix(cursor);
            str[cursor - 1] = 'b';
            cursor--;
            return true;
        }

        GetNext();
        return true;
    }


    //получаем следующую лексикографическую перестановку
    private void GetNext()
    {
        for (int i = str.Length - 1; i != cursor - 1; i--)
        {
            if (str[i] != 'z')
            {
                str[i] = (char)(str[i] + 1);
                FillPrefix(i + 1);
                break;
            }
        }
    }

    //при смене ведущей буквы меняем префикс за ней
    private void FillPrefix(int start)
    {
        for (int i = start; i < str.Length; i++)
        {
            str[i] = 'a';
        }
    }

    public void Reset() => cursor = str.Length;


    void IDisposable.Dispose() { }
    object IEnumerator.Current => Current;



}