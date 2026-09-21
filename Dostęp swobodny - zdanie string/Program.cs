using System.IO;

class Program
{
    public void Zdanie()
    {
        FileStream F;
        string zdanie = "PROGRAMOWANIE W C#";
        int znak;
        StreamWriter zapis = new StreamWriter("zdanie.txt"); 
        zapis.Write(zdanie);
        zapis.Close();
        F = new FileStream("zdanie.txt", FileMode.Open);
        while ((znak = F.ReadByte()) != -1)
        {
            Console.Write((char)znak);
        }
        Console.WriteLine();
        
        F.Seek(1, SeekOrigin.Begin);
            Console.Write((char)F.ReadByte());
        F.Seek(2, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(6, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(5, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(10, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Close();


    }





    static void Main(string[] args)
    {

        Program program = new Program();
        program.Zdanie();


    }
}