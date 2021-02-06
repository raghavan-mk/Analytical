using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");      
            Console.WriteLine(Analytical.CharCount("aaaabbbcca"));
        }   
    }

    public class Analytical
    {
        //input "aaabbcca" 
        //output "[("a",3),("b",2),("c",2),("a",1)]
        public static string CharCount(string input)
        {           
            if(!string.IsNullOrEmpty(input))
            {
                
                int count = 0;
                
                StringBuilder charCountSet = new StringBuilder();
                charCountSet.Append("[");
                
                for(int i=0;i<input.Length;)
                {
                    var curr = input[i]; 
                    while(i < input.Length && curr == input[i]){
                        i++;
                        count++;
                    }
                    charCountSet.Append($"(\"{curr}\",{count}),");
                    count = 0;
                  
                }
                charCountSet.Length--; //remove trailing comma
                charCountSet.Append("]");             
                return charCountSet.ToString();

            }   
            throw new Exception("Input is null or empty");
        }
    }
}
