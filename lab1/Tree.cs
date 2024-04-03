using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Tree
    {
        public List<Tree> Book { get; set; }
        public string book { get; set; }
        public Tree(string value)
        {
            this.book = value;
            Book = new List<Tree>();
        }
        public Tree(string value, Tree otec)
        {
            this.book = value;
            this.Book = new List<Tree>();
            otec.Book.Add(this);
        }
        public void AddBook(Tree addbook)
        {
            Book.Add(addbook);
        }
        public void PrintList()
        {
            if (Book.Count > 0)
            {
                Console.WriteLine($"Книги {book}:");
                for (int i = 0; i < Book.Count; i++)
                {
                    Console.WriteLine(Book[i].book);
                }
                for (int i = 0; i < Book.Count; i++)
                {
                    Book[i].PrintList();
                }
            }
        }
    }
}
