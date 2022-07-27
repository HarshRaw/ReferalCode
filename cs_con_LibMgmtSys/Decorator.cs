using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    /// <summary>
    ///     The Decorator
    /// </summary>
    public abstract class Decorator
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem item)
        {
            this.libraryItem = item;
        }

        public override string ToString()
        {
            return this.libraryItem.ToString();
        }
    }
}
