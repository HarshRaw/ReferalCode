using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace cs_con_LibMgmtSys
{
    internal class Library 
        : System.Collections.IEnumerable
    {
        public string LibraryName { get; private set; }
        List<Borrowable> borrowables;

        public Library(string name)
        {
            LibraryName = name;
            borrowables = null;                 // Late-Instantiation Pattern
        }

        public void Add(Book2 book)
        {
            if(borrowables == null)
            {
                borrowables = new List<Borrowable>();
            }
            borrowables.Add(new Borrowable(book));
        }

        public void Add(Newspaper newspaper)
        {
            if(borrowables == null)
            {
                borrowables = new List<Borrowable>();
            }
            borrowables.Add(new Borrowable(newspaper));
        }


        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            if(borrowables == null)
            {
                yield break;
            }
            else
            {
                foreach(var item in this.borrowables)
                {
                    yield return item;
                }
            }
        }

        #endregion

        public void DisplayLibraryItems()
        {
            Console.WriteLine($"----- {this.LibraryName}");
            foreach (var item in this.borrowables)
            {
                Console.WriteLine(item);
                Console.WriteLine("=============");
            }
        }


    }
}
