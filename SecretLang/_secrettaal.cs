using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretLang
{
    class _secrettaal
    {
        string[] row_1 = { "q", "a", "z", " " };
        string[] row_2 = { "w", "s", "x" };
        string[] row_3 = { "e", "d", "c" };
        string[] row_4 = { "r", "f", "v" };
        string[] row_5 = { "t", "g", "b" };
        string[] row_6 = { "y", "h", "n" };
        string[] row_7 = { "u", "j", "m" };
        string[] row_8 = { "i", "k", "," };
        string[] row_9 = { "o", "l", "." };
        string[] row_0 = { "p", ";", "/" };
        public string decode(string todecode)
        {
            try
            {
                string spacer = "";
                string decoded = "";
                
                for (int x = 0; x < todecode.Length; x++)
                {
                    if ((x % 2) == 0)
                    {
                        if (todecode[x].ToString() == "1")
                        {
                            decoded += row_1[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "2")
                        {
                            decoded += row_2[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "3")
                        {
                            decoded += row_3[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "4")
                        {
                            decoded += row_4[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "5")
                        {
                            decoded += row_5[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "6")
                        {
                            decoded += row_6[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "7")
                        {
                            decoded += row_7[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "8")
                        {
                            decoded += row_8[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "9")
                        {
                            decoded += row_9[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                        if (todecode[x].ToString() == "0")
                        {
                            decoded += row_0[int.Parse(todecode[x + 1].ToString()) - 1] + spacer;
                        }
                    }
                }
                return decoded;
            }
            catch { return "SecretLang is incorrect!"; }
        }
        public string encode(string userinput)
        {
            string encoded = "";
            string spacer = "";

            try
            {
                for (int x = 0; x < userinput.Length; x++)
                {
                    int counter = 1;
                    int actual_row = 1;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_1)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 2;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(),userinput[x].ToString(),actual_row.ToString()));
                    foreach (string y in row_2)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 3;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_3)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 4;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_4)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 5;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_5)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;

                    }

                    counter = 1;
                    actual_row = 6;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_6)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;


                    }

                    counter = 1;
                    actual_row = 7;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_7)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 8;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_8)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 9;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_9)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                    counter = 1;
                    actual_row = 0;
                    //Console.WriteLine(String.Format("x={0},char={1},row={2}", x.ToString(), userinput[x].ToString(), actual_row.ToString()));
                    foreach (string y in row_0)
                    {
                        if (userinput[x].ToString().Contains(y))
                        {
                            encoded += actual_row.ToString() + counter.ToString() + spacer;

                        }
                        counter = counter + 1;
                    }

                }
                return encoded;
            }
            catch { return "Error while encoding!"; }
        }
    }
}
