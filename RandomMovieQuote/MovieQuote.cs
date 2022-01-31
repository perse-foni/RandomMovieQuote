using System;
using System.Text;
using static System.Console;

namespace MovieQuoteApp
{
    internal class MovieQuote
    {
        private string QuoteText;
        private string Movie;
        //  private int Year;

        public MovieQuote(string quote, string movie)
        {
            QuoteText = quote;
            Movie = movie;
            // Year = year;
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
