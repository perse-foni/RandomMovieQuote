using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace MovieQuoteApp
{
    internal class MovieQuoteApp
    {
        private string QuotesFilePath = "MovieQuotes.txt";
        public void Run()
        {
            Title = "Movie Quote of the Day";

            List<MovieQuote> movieQuotes = new List<MovieQuote>();

            string[] lines = File.ReadAllLines(QuotesFilePath);
            for (int i = 0; i < lines.Length; i += 3)
            {
                string quoteText = lines[i];
                string movieInfo = lines[i + 1];
              
                MovieQuote quote = new MovieQuote(quoteText, movieInfo);
                movieQuotes.Add(quote);
               
            }

            Random random = new Random();
            int randomQ = random.Next(movieQuotes.Count);

            movieQuotes[randomQ].Display();

            WaitForKey();
        }

        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Press any key");
            ReadKey(true);
        }
    }
}
