using System;
using System.IO;

namespace TicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string file = "Tickets.csv";
            string format = "{0,-10}\t{1,-25}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-40}";
            while (!end)
            {
                System.Console.WriteLine("1) View tickets");
                System.Console.WriteLine("2) Add new ticket");
                System.Console.WriteLine("3) Exit application");
                var choice = System.Console.ReadLine();
                
                if(choice == 1)
                {
                    StreamReader reader = new StreamReader(file);

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] arr = line.Split(',');
                        System.Console.WriteLine(format, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                        System.Console.ReadLine();
                    }
                }
                else if(choice == 2)
                {
                    int ticketID = 0;
                    StreamReader sR = new StreamReader(file);
                    while (!sR.EndOfStream)//get next TicketID number
                    {
                        string toArray = sR.ReadLine();
                        if (sR.EndOfStream)
                            {
                                string[] stringArray = toArray.Split(',');
                                int ticketIDOld = Convert.ToInt32(stringArray[0]);
                                ticketID = ticketIDOld + 1;
                            }
                    }
                    reader.Close();
                    System.Console.WriteLine("Enter the ticket summary");
                    string p1 = Console.ReadLine();
                    System.Console.WriteLine("Enter the ticket status");
                    string p2 = Console.ReadLine();
                    System.Console.WriteLine("Enter the ticket priority");
                    string p3 = Console.ReadLine();
                    System.Console.WriteLine("Enter the ticket submitter");
                    string p4 = Console.ReadLine();
                    System.Console.WriteLine("Enter who is assigned to this ticket");
                    string p5 = Console.ReadLine();
                    string p6 = $"{ticketSubmitter}|{ticketAssigned}|Bill Jones";
                    string ticketCSV = "{0},{1},{2},{3},{4},{5},{6}";
                    System.Console.WriteLine("Ticket added");
                    System.Console.ReadLine();
                    StreamWriter writer = new StreamWriter(file, true);
                    writer.WriteLine(ticketCSV, p1, p2, p3, p4, p5, p6);
                    writer.Close();
                }
                else
                {
                    end = true;
                }
        }
    }
}
