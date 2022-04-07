using HomeWork;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HWGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(15);
            numbers.Add(18);
            numbers.Add(21);
            numbers.Add(27);
            numbers.Remove(12);
            numbers.RemoveAt(1);
            Console.WriteLine(numbers.Contains(18));
            Console.WriteLine("Numbers siyahisinin elementleri:");
            foreach (var num in numbers)
            Console.WriteLine(num);
            List<string> names = new List<string>();
            names.Add("Ali");
            names.Add("Nermin");
            names.Add("Fidan");
            names.Add("Aydan");
            names.Remove("Nermin");
            names.RemoveAt(2);
            Console.WriteLine("Adlar siyahisinin elementleri:");
            foreach (var name in names)
                Console.WriteLine(name);
            List<int> evenNums = new List<int>()
            {
                46,
                84,
                90,
                102
            };
            evenNums.Insert(3, 98);
            List<int> numsDevisibleBy4 = new List<int>();
            numsDevisibleBy4.AddRange(evenNums);
            List<int> numsDevisibleBy8 = new List<int>();
            numsDevisibleBy8.AddRange(numsDevisibleBy4);
            Console.WriteLine("========================");
            #endregion;
            #region ArrayList
            ArrayList arrList1 = new ArrayList();
            arrList1.Add(" ");
            arrList1.Add(44);
            arrList1.Add(7.8);
            arrList1.Add("name1");
            arrList1.Add(null);
            arrList1.Add(true);
            arrList1.Insert(0, "Hello!");
            foreach (var item in arrList1)
                Console.WriteLine(item);
            ArrayList arrList2 = new ArrayList();
            int[] nums = { 1, 2, 3, 4, 5 };
            Queue myQueue = new Queue();
            myQueue.Enqueue("name2");
            myQueue.Enqueue("name3");
            arrList2.AddRange(arrList1);
            arrList2.AddRange(nums);
            arrList2.AddRange(myQueue);
            arrList2[0] = 999;
            var firstElement = arrList2[0];
            Console.WriteLine("------ArrayList elementleri:------ ");
            foreach (var item in arrList2)
                Console.WriteLine(item);
            Console.WriteLine($"First element:{firstElement}");
            ArrayList arrList3 = new ArrayList();
            arrList3.Add(30);
            arrList3.Add(40);
            arrList3.Add(50);
            arrList3.Add(80);
            ArrayList arrList4 = new ArrayList();
            arrList4.Add(60);
            arrList4.Add(70);
            arrList3.InsertRange(3, arrList4);
            arrList3.Remove(80);
            arrList3.RemoveRange(0, 1);
            arrList3.RemoveAt(3);
            Console.WriteLine("------arrList3 elementleri:------");
            foreach (var item in arrList3)
                Console.WriteLine(item);
            Console.WriteLine(arrList3.Contains("name1"));
            Console.WriteLine(arrList3.Contains(40));
            Console.WriteLine("========================");
            #endregion;
            #region SortedList
            SortedList<int, string> months = new SortedList<int, string>();
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");
            Console.WriteLine("-------Aylar:-------");
            for (int i = 0; i < months.Count; i++)
                Console.WriteLine(months.Keys[i] + "-" + months.Values[i]);
            SortedList<string, string> studentsInfo = new SortedList<string, string>()
            {
                {"BP202","Aliyev Ali"},
                {"BP203","Abbasova Fidan"},
                {"P204","Huseynova Deniz"}
            };
            studentsInfo["BP202"] = "Shafiyeva Valida";
            studentsInfo["P100"] = "Memmedova Leman";
            studentsInfo.RemoveAt(1);
            studentsInfo.Remove("P204");
            Console.WriteLine(studentsInfo["BP202"]);
            Console.WriteLine(studentsInfo.ContainsKey("P203"));
            Console.WriteLine(studentsInfo.ContainsValue("Valida"));
            Console.WriteLine("-------Telebeler siyahisi-------");
            for (int i = 0; i < studentsInfo.Count; i++)
                Console.WriteLine(studentsInfo.Keys[i] + "-" + studentsInfo.Values[i]);
            Console.WriteLine("========================");
            #endregion
            #region Dictionary
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "one");
            numberNames.Add(5, "five");
            numberNames.Add(3, "three");
            numberNames.Add(10, "ten");
            IDictionary<string, string> cities = new Dictionary<string, string>(){
            {"UK", "London"},
            {"USA", "Chicago"},
            {"India", "Mumbai"}
            };
            Console.WriteLine(cities["India"]);
            Console.WriteLine(cities.ContainsKey("France"));
            string result = "";
            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }
            if (cities.ContainsKey("India"))
            {
                cities.Remove("India");
            }
            Console.WriteLine("------Cities:-------");
            foreach (var city in cities)
                Console.WriteLine(city);
            Console.WriteLine("=========================");
            #endregion
            #region Stack
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            foreach (var item in stack1)
                Console.WriteLine(item);
            Console.WriteLine(stack1.Peek());
            stack1.Pop();
            Console.WriteLine(stack1.Contains(5));
            if (stack1.Contains(2))
                stack1.Pop();
            string[] arr = { "word1", "word2", "word3" };
            Stack<string> stack2 = new Stack<string>(arr);
            foreach (var item in stack2)
                Console.WriteLine(item);
            foreach (var item in stack1)
                Console.Write(item);
            Console.WriteLine("\n=========================");
            #endregion
            #region Queue
            Queue<int> no = new Queue<int>();
            no.Enqueue(5);
            no.Enqueue(15);
            no.Enqueue(25);
            no.Enqueue(35);
            Console.WriteLine("PEEK-" + no.Peek());
            Console.WriteLine("1.Say:" + no.Count);
            no.Dequeue();
            Console.WriteLine("2.Say:" + no.Count);
            Console.WriteLine("------NO------");
            foreach (var item in no)
                Console.WriteLine(item);
            Console.WriteLine(no.Contains(35));
            if (no.Count > 0)
                Console.WriteLine(no.Peek());
            #endregion

            Console.WriteLine("-------------------------------------------------------------------");
            Book book1 = new Book();
            book1.Name = "Hayvanistan";
            book1.AuthorName = "George Orwell";
            book1.PageCount = "352";

            Book book2 = new Book();
            book2.Name = "Manipulyator";
            book2.AuthorName = "Cingiz Abdullayev";
            book2.PageCount = "190";

            Book book3 = new Book();
            book3.Name = "Xeyanet";
            book3.AuthorName = "Elxan Elatli";
            book3.PageCount = "376";

            Library library = new Library();
            List<Book> Books = new List<Book>();
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            

            library.RemoveAllBookByName("Hayvanistan");
            Console.WriteLine("Kitablar:");
            foreach (var item in Books)
            {
                Console.WriteLine($"{item.Name},{item.AuthorName},{item.PageCount}");
            }

            foreach (var item in library.SearchBooks("190"))
            {
                Console.WriteLine($"{item.Name},{item.AuthorName},{item.PageCount}");
            }







        }
    }
}
