using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog_test_3
{
    public class Board
    {
        public Board()
        {
            for (int e = 1; e<10; e++)
            {
            arr[e]= '-';
            }
        }
         
         
        char [] arr = {'0','1','2','3','4','5','6','7','8','9'};
            
        public void GB()
        {
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", arr[1], arr[2], arr[3]);
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", arr[4], arr[5], arr[6]);
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", arr[7], arr[8], arr[9]);
    Console.WriteLine("   |   |   ");
        }

        public void Pos(int v, char player)
        {
            arr[v] = player;
        }

        public bool Occupied(int v)
        {
            return arr[v] != '-';
        }

public int Win()
{
    if (arr[1]==arr[2] && arr[2]== arr[3])
    {
        return(arr[1]);
    }
    else if (arr[4]==arr[5] && arr[5]== arr[6])
    {
        return(arr[4]);
    }
    else if (arr[7]==arr[8] && arr[8]==arr[9])
    {
        return(arr[7]);
    }
    else if (arr[1]==arr[4]&& arr[4] == arr[7])
    {
        return(arr[1]);
    }
    else if (arr[2]==arr[5]&& arr[5] == arr[8])
    {
        return(arr[2]);
    }
    else if (arr[3]==arr[6]&& arr[6] == arr[9])
    {
        return(arr[3]);
    }
    else if (arr[1]==arr[5] && arr[5]==arr[9])
    {
        return(arr[1]);
    }
    else if (arr[3]==arr[5] && arr[5]==arr[7])
    {
        return(arr[3]);
    }
    else
    {
        return(-1);
    }
}
    }
}