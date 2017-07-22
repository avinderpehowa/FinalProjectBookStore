using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   public class Date
    {
         int day { get; set; }
         int month { get; set; }
         int year { get; set; }
       public  Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int GetDay() {
            return this.day;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void SetDay(int day)
        {
             this.day=day;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
       public void SetDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return this.GetDay() + "/" + this.GetMonth() + "/" + this.GetYear();
        }
    }
}
