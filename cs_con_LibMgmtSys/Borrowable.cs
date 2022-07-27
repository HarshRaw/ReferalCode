using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    /// <summary>
    ///     The Concrete Decorator
    /// </summary>
    public class Borrowable : Decorator
    {
        protected System.Collections.ArrayList borrowers;

        public Borrowable(LibraryItem item) 
            : base(item)
        {
            borrowers = new System.Collections.ArrayList();
        }

        public void BorrowItem(string memberName)
        {
            this.borrowers.Add(memberName);
            base.libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string memberName)
        {
            this.borrowers.Remove(memberName);
            base.libraryItem.NumberOfCopies++;
        }

        public override string ToString()
        {
            string output = base.ToString();
            if (this.borrowers.Count != 0)
            {
                Console.WriteLine("\tList of Borrowers:");
                foreach (string membername in this.borrowers)
                {
                    output += $"\t{membername}\n";
                }
            }
            return output;
        }
    }
}
