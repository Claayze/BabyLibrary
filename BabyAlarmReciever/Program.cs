using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using BabyLibrary;

namespace BabyAlarmReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 0);


            using (var client = new UdpClient(7000))
            {
                while (running)
                {
                    try
                    {
                        int unitno = 0;
                        int breath = 0;
                        int cry = 0;

                        Byte[] databytes = client.Receive(ref ipend);
                        string dataresult = Encoding.ASCII.GetString(databytes);
                        Console.WriteLine($"Raw data recieved: {dataresult}");
                        string[] datasplit = dataresult.Split(',');
                        for (int i = 0; i < datasplit.Length; i++)
                        {
                            Console.Write($"Index {i}: {datasplit[i]} ");
                        }
                        Console.WriteLine();
                        //Console.WriteLine(datasplit[0]); -- Virker på samme måde som for løkken
                        //Console.WriteLine(datasplit[1]);
                        //Console.WriteLine(datasplit[2]);
                        unitno = int.Parse(datasplit[0]);
                        breath = int.Parse(datasplit[1]);
                        cry = int.Parse(datasplit[2]);
                        Console.WriteLine($"{unitno},{breath},{cry}");
                        Console.WriteLine($"Alarm Breath: {BabyCool.AlarmBreath(breath)}");
                        Console.WriteLine($"Alarm Cry: {BabyCool.AlarmCry(cry)}");

                        Console.WriteLine("------------------------------------------------------------");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        running = false;
                        //client.Dispose();
                    }

                }
            }
        }
    }
}
