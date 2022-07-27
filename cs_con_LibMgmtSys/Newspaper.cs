using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    internal class Newspaper : LibraryItem
    {
        public string Title { get; private set; }

        public DateTime PublishedOn { get; private set; }

        public Newspaper(string title, DateTime publishedOn)
        {
            Title = title;
            PublishedOn = publishedOn;
            base.NumberOfCopies = 1;
        }

        public override string ToString()
        {
            return $"Title: {this.Title} [ {this.PublishedOn.ToString("dd-MMM-yyyy")} ]\n"
                  + $"Number of Copies: {base.NumberOfCopies}";
        }
    }
}
