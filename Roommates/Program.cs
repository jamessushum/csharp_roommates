using System;
using System.Collections.Generic;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";
        static void Main(string[] args)
        {
            //RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            //Console.WriteLine("Getting All Rooms:");
            //Console.WriteLine();

            //List<Room> allRooms = roomRepo.GetAll();

            //foreach (Room room in allRooms)
            //{
            //    Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            //}

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Room with Id 1");

            //Room singleRoom = roomRepo.GetById(1);

            //Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            //Room bathroom = new Room
            //{
            //    Name = "Bathroom",
            //    MaxOccupancy = 1
            //};


            //roomRepo.Insert(bathroom);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Added the new Room with id {bathroom.Id}");

            //bathroom.MaxOccupancy = 2;

            //roomRepo.Update(bathroom);

            //Console.WriteLine("-------------------------------");

            //allRooms = roomRepo.GetAll();

            //foreach (Room room in allRooms)
            //{
            //    Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            //}

            //roomRepo.Delete(8);

            //Console.WriteLine("-------------------------------");

            //allRooms = roomRepo.GetAll();

            //foreach (Room room in allRooms)
            //{
            //    Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            //}

            RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            Console.WriteLine("Getting All Roommates:");
            Console.WriteLine();

            List<Roommate> allRoommates = roommateRepo.GetAll();

            foreach (Roommate roommate in allRoommates)
            {
                Console.WriteLine($"{roommate.Id} {roommate.Firstname} {roommate.Lastname} {roommate.RentPortion} {roommate.MovedInDate} {roommate.Room}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Roommate with Id 1");

            Roommate aRoommate = roommateRepo.GetById(1);

            Console.WriteLine($"{aRoommate.Id} {aRoommate.Firstname} {aRoommate.Lastname} {aRoommate.RentPortion} {aRoommate.MovedInDate} {aRoommate.Room}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Roommates with roomId 1");

            List<Roommate> allRoommatesWithRoomId = roommateRepo.GetRoommmatesByRoomId(1);

            foreach (Roommate roommate in allRoommatesWithRoomId)
            {
                Console.WriteLine($"{roommate.Firstname} {roommate.Lastname} {roommate.Room.Name}");
            }

            Roommate newRoommate = new Roommate
            {
                Firstname = "Jimmy",
                Lastname = "Rocket",
                RentPortion = 2,
                MovedInDate = DateTime.Now,
                RoomId = 1
            };

            /*roommateRepo.Insert(newRoommate);*/

            newRoommate.RentPortion = 10;

            /*roommateRepo.Update(newRoommate);*/

            roommateRepo.Delete(5);
        }
    }
}
