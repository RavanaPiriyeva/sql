using ConsoleApp2.Data;
using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StadiumData stadiumData = new StadiumData();
            UserData userData = new UserData();
           RezelvationData rezelvationdata = new RezelvationData();

            bool check = true;
            do
            {
                Console.WriteLine(" 1. Stadion elave et");
                Console.WriteLine(" 2. Stadionları goster");
                Console.WriteLine(" 3. Verilmiş id-li stadionu goster");
                Console.WriteLine(" 4. Verilmiş id-li stadionu sil");
                Console.WriteLine(" 5. İstifadeci elave et");
                Console.WriteLine(" 6. İstifadecileri goster");
                Console.WriteLine(" 7. Rezervasiya yarat");
              
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.WriteLine("inser");
                        byte cap = 4;
                        decimal price = 45;
                        string name = "aaaa";

                        Stadium stadium = new Stadium
                        {
                            Capacity = cap,
                            Name = name,
                            HourlyPrice = price,
                        };

                        stadiumData.Add(stadium);
                        break;
                    case "2":
                        var stadiums = stadiumData.GetAll();

                        foreach (var item in stadiums)
                        {
                            Console.WriteLine(item.Id+ " - " + item.Name + " - " + item.HourlyPrice);
                        }
                        break;
                    case "3":

                        Console.WriteLine("Id daxil et:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Stadium std = stadiumData.GetById(id);

                        Console.WriteLine(std.Name);
                        break;
                    case "4":
                        Console.WriteLine("Id daxil et:");
                        int iddel = Convert.ToInt32(Console.ReadLine());
                        stadiumData.Delete(iddel);
                        break;
                    case "5":
                        Console.WriteLine("inser");
                        
                        string nameusre = "Revane Piriyeva";
                            string email = "Revane@gamil.com";

                        User user = new User
                        {
                            FullName = nameusre,
                            Emaile = email
                        };

                        userData.Add(user);
                        break;
                    case "6":
                        var users = userData.GetAll();

                        foreach (var item in users)
                        {
                            Console.WriteLine(item.Id + " - " + item.FullName + " - " + item.Emaile);
                        }
                        break;
                    case "7":
                        Console.WriteLine("inser");
                        int stid = 1;
                        int usid = 1;
                       DateTime dateTime = DateTime.Now;
                        DateTime dateTime1 = DateTime.Now;

                        Rezelvation rezervation = new Rezelvation
                        {
                            StadionId = stid,
                            UserId = usid,
                            StartDate = dateTime,
                            EndDate = dateTime1,
                        };

                        rezelvationdata.Add(rezervation);
                        break;
                    
                }
            }
            while (check);
        }
    }
    }

