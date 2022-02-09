using System;
using System.Text;
using static System.Console;

namespace MovieQuoteApp
{
    internal class MovieQuote
    {
        private string QuoteText;
        private string Movie;
       
        public MovieQuote(string quote, string movie)
        {
            QuoteText = quote;
            Movie = movie;
           
        }
        public void Display()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine($"\n\"{QuoteText}\"");
            WriteLine($" - {Movie} \n");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
