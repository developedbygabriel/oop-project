using OOPProject.Helpers;
using OOPProjectLibrary.Interfaces;
using OOPProjectLibrary.Promoters;
using OOPProjectLibrary.Writers;
using System;
using System.Collections.Generic;

namespace OOPProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var promoters = new List<Promoter>
            {
                new XSClubPromoter("Jon", "Jones", "1111-111-1111"),
                new XSClubPromoter("Jim", "Jones", "2222-222-2222"),
                new OmniaClubPromoter("Jane", "Jones", "3333-333-3333")
            };

            foreach (var promoter in promoters)
            {
                promoter.PromotionDetails().PrintToConsole();
            }

            var writers = new List<Writer>
            {
                new BookWriter("Jon", "Jones"),
                new BookWriter("Jim", "Jones"),
                new BlogWriter("Jane", "Jones")
            };

            foreach (var writer in writers)
            {
                writer.WritingDetails().PrintToConsole();
            }

            var bodyBuilders = new List<IBodyBuilder>
            {
                new XSClubPromoter("Jon", "Jones", "1111-111-1111"),
                new XSClubPromoter("Jim", "Jones", "2222-222-2222"),
            };

            foreach (var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.WorkoutDetails().PrintToConsole();
            }

            var vloggers = new List<IVlogger>
            {
                new XSClubPromoter("Jon", "Jones", "1111-111-1111"),
                new BlogWriter("Jim", "Jones")
            };

            foreach (var vlogger in vloggers)
            {
                vlogger.VloggingDetails().PrintToConsole();
            }

            Console.ReadLine();
        }
    }
}
