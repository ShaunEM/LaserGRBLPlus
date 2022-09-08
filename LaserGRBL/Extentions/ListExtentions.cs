﻿using System.Collections.Generic;


namespace LaserGRBL.Extentions
{
    public static class ListExtentions
    {
        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            (list[indexB], list[indexA]) = (list[indexA], list[indexB]);
        }
    }


    
}
