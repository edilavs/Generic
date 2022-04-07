using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Library
    {
        List<Book> Books = new List<Book>(0);
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> newBooks = new List<Book>();
            for (int i = 0; i < Books.Count ; i++)
            {
                if (Books[i].Name.Contains(value))
                {
                    newBooks.Add(Books[i]);
                }
            }
            Books = newBooks;
            return Books; 
        }
        public void RemoveAllBookByName(string value)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(value))
                {
                    Books.RemoveAt(i);
                  //Books.Remove(Books[i]);
                }
            }
        }
        public List<Book> SearchBooks(string value)
        {
           
            for (int i = 0; i < Books.Count; i++)
            {
                List<Book> newBooks = new List<Book>();
                if (Books[i].Name.Contains(value) || Books[i].AuthorName.Contains(value)|| Books[i].PageCount.Contains(value))
                {
                    newBooks.Add(Books[i]);
                }
                Books = newBooks;
            }
            return Books;
        }
    }
}
