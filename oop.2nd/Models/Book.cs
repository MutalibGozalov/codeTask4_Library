using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2nd.Models
{
    internal class Book
    {
        private static int id=1;
        public int Id { get; set; } = id;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        public Book(string _name, string _AuthorName, int _PageCount, double _Price)
        {
            this.Name = _name;
            this.AuthorName = _AuthorName;  
            this.PageCount = _PageCount;
            this.Price = _Price;
            id+=1;
            if (Name.Split(" ").Length>0)
            {
                string[] name = new string[Name.Split(" ").Length];
                name = Name.Split(" ");
                string codeName = "";
                foreach (var part in name)
                {
                    codeName += part[0];
                }
                this.Code = $"{codeName}-{Id}".ToUpper();
            }
            else
            {
                this.Code = $"{Name[0]}-{Id}".ToUpper();
            }
           
        }
    }
}
