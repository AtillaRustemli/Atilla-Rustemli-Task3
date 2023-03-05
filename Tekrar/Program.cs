namespace RustemliAtillaTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say;
        l1:
            Console.Write("Telebelerin sayini qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out say) || say <= 0)
            {
                goto l1;
            }
            Student[] information=new Student[say];
            for(int i=0;i<information.Length;i++)
            {
                Student inform = new Student();

                Console.Write($"{i+1}.Telebenin adi: ");
                inform.name = Console.ReadLine();
                Console.Write($"{i + 1}.Telebenin soyadi: ");
                inform.surname = Console.ReadLine();
                l2:
                Console.Write($"{i + 1}.Telebenin yashi: ");
                if(!int.TryParse(Console.ReadLine(),out inform.age))
                {
                    goto l2;
                }
                Console.Write($"{i + 1}.Telebenin ixtisasi: ");
                inform.speciality = Console.ReadLine();
                Console.Write($"{i + 1}.Telebenin qrup nomresi: ");
                inform.groupNo = Console.ReadLine();


                information[i] = inform;
                
            }
            Console.WriteLine(information);

        }
    }
}