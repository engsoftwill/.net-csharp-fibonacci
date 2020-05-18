using System;
using System.Collections.Generic;
namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            int maxfibo = 350;                                          // maxfibo is maximum number desired the fibonacci series    
            List<int> fibo = new List<int>();                           // creation of the list named fibo
            var aux = 1;                                                // aux is utilized to receiver fibo'
            var i = 0;                                                  //counter
            fibo.Add(0);                                                // first value of fibonacci's series    
            while ((fibo[i] + aux) < maxfibo)                           // while value < maxfibo implement new number 
            {
                i += 1;
                fibo.Add(fibo[i - 1] + aux);
                aux = fibo[i - 1];
            }
            return fibo;                                                // return the list with the fibonacci series
        }
        public bool IsFibonacci(int numberToTest)                       // test if the list contains the numberToTest
        {
            List<int> listfibo = Fibonacci();
            return listfibo.Contains(numberToTest) ? (true) : (false);
        }
    }
}