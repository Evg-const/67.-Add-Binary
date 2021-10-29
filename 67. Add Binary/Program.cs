using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string aaa = "1";
            string bbb = "111";


            Console.WriteLine(aaa);
            Console.WriteLine(bbb);

            Console.WriteLine(AddBinary(aaa, bbb));

            Console.Read();


            string AddBinary(string a, string b)
            {
                bool flag = false;
                List<char> revers_ansver = new List<char>();

                char[] aa = a.ToCharArray();
                Array.Reverse(aa);

                char[] bb = b.ToCharArray();
                Array.Reverse(bb);

                if (aa.Length < bb.Length)
                {
                    Array.Resize(ref aa, bb.Length);
                    for(int i = a.Length; i < bb.Length; i++)
                    {
                        aa[i] = '0';
                    }
                }

                if (bb.Length < aa.Length)
                {
                    Array.Resize(ref bb, aa.Length);
                    for (int i = b.Length; i < aa.Length; i++)
                    {
                        bb[i] = '0';
                    }
                }

                int ToInt(char c)
                {
                    return (c - '0');
                }

                for (int i = 0; i < aa.Length; i++)
                {
                    if (flag == false)
                    {
                        if ((ToInt(aa[i]) + ToInt(bb[i])) == 0)
                        {
                            revers_ansver.Add('0');
                        }
                        else if ((ToInt(aa[i]) + ToInt(bb[i])) == 1)
                        {
                            revers_ansver.Add('1');
                        }
                        else
                        {
                            revers_ansver.Add('0');
                            flag = true;
                        }
                    }

                    else//(flag == true)
                    {
                        if ((ToInt(aa[i]) + ToInt(bb[i])) == 0)
                        {
                            revers_ansver.Add('1');
                            flag = false;
                        }
                        else if ((ToInt(aa[i]) + ToInt(bb[i])) == 1)
                        {
                            revers_ansver.Add('0');
                            flag = true;
                        }
                        else
                        {
                            revers_ansver.Add('1');
                            flag = true;
                        }
                    }

                    if (i == aa.Length-1 && flag == true)
                    {
                        revers_ansver.Add('1');
                    }
                }

                char[] answer = revers_ansver.ToArray();
                Array.Reverse(answer);
                string final_answer = new string(answer);
                return final_answer;

            }



    }
    }
}
