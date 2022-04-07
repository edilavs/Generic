using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Book
    {
        public Book()
        {
            TotalCount++;
            No = TotalCount;
        }
        public static int TotalCount;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string PageCount { get; set; }
    }
}

