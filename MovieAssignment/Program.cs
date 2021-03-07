using System;
using System.Collections.Generic;
using System.IO;
namespace MovieAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieID = new List<int>();
            var titles = new List<string>();
            var genres = new List<string>();
            var exit = false;
            var file = "movies.csv";

            var reader = new StreamReader(file);
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var split = line.Split(',');
                movieID.Add(Convert.ToInt32(split[0]));
                titles.Add(split[1]);
                genres.Add(split[2]);
            }
            reader.Close();

            while(!exit)
            {
                System.Console.WriteLine("1. List movies");
                System.Console.WriteLine("2. Add movie");
                System.Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();
                var display = 0;
                if(choice == "1")
                {
                    Console.Clear();
                    var format = "{0, 5}\t{1,25}\t{2}";
                    var exitview = false;
                    var displaybool = true;
                    while(!exitview)
                    {
                        if(displaybool == true)
                        {
                        for(int i = 0; i < 10; i++)
                        {
                            System.Console.WriteLine(format, movieID[display], titles[display], genres[display]);
                            display++;
                        }
                        
                        System.Console.WriteLine("1. View more");
                        System.Console.WriteLine("2. Return to menu");
                        }
                        var choiceview = Console.ReadLine();
                        if(choiceview == "1")
                        {
                            displaybool = true;
                            Console.Clear();
                        }
                        else if(choiceview == "2")
                        {
                            exitview = true;
                        }
                        else
                        {
                            displaybool = false;
                            System.Console.WriteLine("Try again");
                        }
                    }
                }
                else if(choice == "2")
                {
                    Console.Clear();
                    var newGenreList = new List<string>();
                    System.Console.Write("Enter Title: ");
                    var newTitle = Console.ReadLine();
                    System.Console.WriteLine(newTitle);
                    var newGenreBool = false;
                    do
                    {
                        System.Console.Write("Enter genre: ");
                        var newGenre = Console.ReadLine();
                        System.Console.WriteLine(newGenre);
                        newGenreList.Add(newGenre);
                        System.Console.WriteLine("Add more genres? (Y/N)");
                        var moreGenres = Console.ReadLine();
                        if(moreGenres.ToUpper() == "Y")
                        {
                            break;
                        }
                        else
                        {
                            newGenreBool = true;
                        }
                    }while(!newGenreBool);
                    var joinedGenres = String.Join("|", newGenreList.ToArray());
                    var newID = 0;
                    foreach(int i in movieID)
                    {
                        if(i > newID)
                        {
                            newID = i + 1;
                        }
                    }
                    movieID.Add(newID);
                    titles.Add(newTitle);
                    genres.Add(joinedGenres);
                    var readyAddition = $"{newID},{newTitle},{joinedGenres}";
                    var writer = new StreamWriter(file);
                }
                else if(choice == "3")
                {
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Try again.");
                }
            }
        }
    }
}
