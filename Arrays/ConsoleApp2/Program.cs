using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean dupe = false;
            int[] nums = new int[50];
            Random rnd = new Random();
            for(int i = 0;i < nums.Length; i ++)
            {
                dupe = false;
                int ran = rnd.Next(0, 51);
                for (int j = 0; j < nums.Length; j++)
                {
                     
                    if (nums[j] == ran)
                    {
                        dupe = true; 
                    }
                    
                }

                if(dupe != true)
                {
                    nums[i] = ran;
                }
               
                
            }
            
            for(int i = 0; i <50; i++)
            {
                if(nums[i] != 0)
                {
                    Console.WriteLine(nums[i]);
                }
               
            }
        }
    }
}
