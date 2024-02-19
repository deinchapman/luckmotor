using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMotorcito7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Andas en tu motorcito y vas de camino para tu casa. <press enter to continue>");
            Console.ReadKey();

            string keyname = Name();
            int keynumber = Abcmath();
            Console.WriteLine($"Tu motorista se llama {keyname}");
            Console.WriteLine($"Tu numero de la suerte es {keynumber}");
            Console.ReadKey();

            string Name()
            {
                while (true)
                {
                    Console.WriteLine("¿Cual es el nombre del motorista? (No pueden ser numeros ni dejarse vacío)");
                    string username = Console.ReadLine();

                    if (int.TryParse(username, out int value))
                    {
                        Console.WriteLine("No pueden ser numeros ni dejarse vacío");
                        continue;
                    }
                    else if (String.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("No pueden ser numeros ni dejarse vacío");
                        continue;
                    }
                    else
                        return username;
                }
            }

            int Abcmath()
            {
                List<int> charlist = Main1();
                List<int> keyint = Keynumber(); //Now we create a function called keynumber that will generate a random number, check if it is in the list, if yes, then it will be used as key number, otherwise. It will generate another number until it gets one that matches the list.
                foreach (int b in charlist)
                    Console.WriteLine(b);
                int keyreturn = keyint[0];
                return keyreturn;

                List<int> Keynumber()
                {
                    List<int> charkey = new List<int>();
                    while (true)
                    {
                        int randomnumber = GenerateUniqueNumber();

                        if (charlist.Contains(randomnumber))
                        {
                            charkey.Add(randomnumber);
                            break;
                        }
                        else
                            continue;
                    }
                    return charkey;
                }

                int GenerateUniqueNumber()
                {
                    // Logic to generate a unique number
                    // You can implement your own logic here
                    return new Random().Next(0, 9); // For demonstration, generating a random number between 1 and 1000
                }

                List<int> Main1()
                {
                    //   List<char> ABC1 = new List<char> { 'a', 'b', 'c' };
                    // List<char> ABC2 = new List<char> { 'd', 'e', 'f' };
                    //   List<char> ABC3 = new List<char> { 'g', 'h', 'i' };
                    //   List<char> ABC4 = new List<char> { 'j', 'k', 'l' };
                    //   List<char> ABC5 = new List<char> { 'm', 'n', 'o' };
                    //   List<char> ABC6 = new List<char> { 'p', 'q', 'r' };
                    //  List<char> ABC7 = new List<char> { 's', 't', 'u' };
                    // List<char> ABC8 = new List<char> { 'v', 'w' };
                    // List<char> ABC9 = new List<char> { 'x', 'y' };
                    // List<char> ABC0 = new List<char> { 'z', 'ñ' };
                    List<int> charList = new List<int>();
                    string str = keyname;
                    while (true)
                    {
                        foreach (char c in str)
                        {
                            switch (c)
                            {
                                case 'a':
                                    charList.Add(1);
                                    continue;
                                case 'b':
                                    charList.Add(1);
                                    continue;
                                case 'c':
                                    charList.Add(1);
                                    continue;
                                case 'd':
                                    charList.Add(2);
                                    continue;
                                case 'e':
                                    charList.Add(2);
                                    continue;
                                case 'f':
                                    charList.Add(2);
                                    continue;
                                case 'g':
                                    charList.Add(3);
                                    continue;
                                case 'h':
                                    charList.Add(3);
                                    continue;
                                case 'i':
                                    charList.Add(3);
                                    continue;
                                case 'j':
                                    charList.Add(4);
                                    continue;
                                case 'k':
                                    charList.Add(4);
                                    continue;
                                case 'l':
                                    charList.Add(4);
                                    continue;
                                case 'm':
                                    charList.Add(5);
                                    continue;
                                case 'n':
                                    charList.Add(5);
                                    continue;
                                case 'o':
                                    charList.Add(5);
                                    continue;
                                case 'p':
                                    charList.Add(6);
                                    continue;
                                case 'q':
                                    charList.Add(6);
                                    continue;
                                case 'r':
                                    charList.Add(6);
                                    continue;
                                case 's':
                                    charList.Add(7);
                                    continue;
                                case 't':
                                    charList.Add(7);
                                    continue;
                                case 'u':
                                    charList.Add(7);
                                    continue;
                                case 'v':
                                    charList.Add(8);
                                    continue;
                                case 'w':
                                    charList.Add(8);
                                    continue;
                                case 'x':
                                    charList.Add(9);
                                    continue;
                                case 'y':
                                    charList.Add(9);
                                    continue;
                                case 'z':
                                    charList.Add(0);
                                    continue;
                                case 'ñ':
                                    charList.Add(0);
                                    continue;
                                default:
                                    break;
                            }

                        }
                        return charList;
                    }

                }
            }
        }
    }
}

