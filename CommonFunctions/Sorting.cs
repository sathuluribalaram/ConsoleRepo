﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class Sorting
    {
        int[] arr;

        public void ReadConsoleData()
        {

            Console.WriteLine("Enter Array Size");
            arr = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
        public int MaxelementofArray()
        {
            int temp;
            int reference = 0;
            for (int j = 0; reference < (arr.Length - 2) && j < (arr.Length - 1); j++)
            {
                if (arr[reference] < arr[j])
                {
                    temp = arr[j];
                    arr[j] = arr[reference];
                    arr[reference] = temp;
                }
            }
            return arr[reference];

        }




    }

}

