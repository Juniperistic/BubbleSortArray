using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Ch18Ex5.cs                                          */
/* Date:             05/02/2022                                          */
/* Programmer:       Miranda Morris                                 	 */
/* Class:            CSCI 234                               	         */
/*                                                                       */
/* Program Description: The purpose of this program is to create a       */
/* program that uses bubble sort to sort an array of elements.           */
/*                                                                       */
/* Input: hard coded array such as	int[] n = { 25, 85, 10, 52, 45 };    */
/*                                                                       */
/* Output: the hard coded array such as 25 85 10 52 45;                  */
/* and the array sorted such as 10 25 45 52 85;                          */
/*                                                                       */
/* Givens: None 								                         */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data:                                          */
/*                            int[] n = { 5, 70, 25, 45 };               */
/*                            int[] n = { 100, 65, 5 };                  */
/*                                                                       */
/* List the Testing Output Data:                                         */
/*                            5 25 45 70;                                */
/*                            5 65 100;                                  */
/* Bubble Sort is o(n^2) because of the nested for loop that is included */
/* within the sort method. This is because of the fact it has to go      */
/* all the elements atleast once to find the order                       */
/*************************************************************************/

class ch18ex5
{
    static void swap(int[] array, int n1, int n2)
    {
        int t;

        t = array[n1];
        array[n1] = array[n2];
        array[n2] = t;
    }

    static void print(int[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
            Console.Write("{0} ", array[i]);
        Console.WriteLine();
    }
    
    static void sort(int[] array)
    {
        int i, j;
        for (i = 0; i < array.Length; i++)
            for (j = i; j < array.Length - 1; j++)
                if (array[j + 1] < array[i])
                    swap(array, i, j + 1);
    }

    public static void Main(string[] args)
    {
        int[] n = { 100, 65, 5 };

        print(n);
        sort(n);
        print(n);
        Console.ReadLine();
    }
}
