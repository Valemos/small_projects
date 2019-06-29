﻿/*

Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:

1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...

It can be seen that P4 + P7 = 22 + 70 = 92 = P8. However, their difference, 70 − 22 = 48, is not pentagonal.

Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = |Pk − Pj| is minimised; what is the value of D?

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euler44
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 1000;
            int[] sequence = new int[len];

            //fill the sequence
            for(int seqLoop = 1; seqLoop <= len; seqLoop++)
            {
                sequence[seqLoop-1] = (seqLoop * (3 * seqLoop - 1)) / 2;
            }


            //start from fifth number
            for(int i = 1; i <= len; i++)
            {
                //Pn=n(3n−1)/2
                 int num = sequence[i-1];//(i * (3 * i - 1)) / 2

                for (int bk = i-1; bk > 0; bk--)
                {
                    //find the substraction of current i-number 
                    //to number less than this number
                    int bkNum = (bk * (3 * bk - 1)) / 2;
                    
                    int subst = num - bkNum;
                    for(int sq = 1; sq < len; sq++)
                    {
                        if(sequence[sq] == subst)
                        {
                            int sum = num + bkNum;
                            foreach (int el in sequence)
                            {
                                if (sum == el)
                                {
                                    Console.WriteLine("P{0} - {1} ; P{2} - {3} ; subst - {4}", i, num, bk, bkNum, subst);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            


            Console.ReadKey();
            /*
            
            Pj and Pk, for which their sum and difference are pentagonal and 
            D = |Pk − Pj| is minimised
             
            Pj + Pk = Pn;
            Pj - Pk = Pm;

            D = |Pk − Pj|

            Pj - ?
            Pj > Pk - finaly (to avoid modullus in formula) 

            Pk - ?

            construction:
            -cycle from our number to begin
            -if we find numbers where their substraction will be pentagonal
            find their sum and create other cycle 
             
             */
        }
    }
}
