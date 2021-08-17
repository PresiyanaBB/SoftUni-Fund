using System;
using System.Text;

namespace SoftuniFinal_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            string helper;
            input.AppendLine(Console.ReadLine());
            string[] loop = Console.ReadLine().Split(">>>",StringSplitOptions.RemoveEmptyEntries);

            while (loop[0]!="Generate")
            {
                if (loop[0]=="Slice")
                {
                    input.Remove(int.Parse(loop[1]),int.Parse(loop[2])-int.Parse(loop[1]));
                }
                else if (loop[0]=="Flip")
                {
                    helper = input.ToString();
                    helper = helper.Substring(int.Parse(loop[2]),int.Parse(loop[3])-int.Parse(loop[2]));
                    input.Remove(int.Parse(loop[2]), int.Parse(loop[3]) - int.Parse(loop[2]));
                    if (loop[1] == "Lower") { input.Insert(int.Parse(loop[2]), helper.ToLower()); }
                    else if (loop[1] == "Upper") { input.Insert(int.Parse(loop[2]), helper.ToUpper()); }
                }
                else if (loop[0]=="Contains")
                {
                    if ((input.ToString().Trim()).Contains(loop[1]))
                    {
                        Console.WriteLine($"{input.ToString().Trim()} contains {loop[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                    loop = Console.ReadLine().Split(">>>");
                    continue;
                }

                Console.Write(input);
                loop = Console.ReadLine().Split(">>>",StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
