using System;
using System.Collections.Generic;
using System.Linq;

// Define an Ad class with common properties and methods
class Ad
{
    public int AdID { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PublishDate { get; set; }
    public DateTime ArchiveDate { get; set; }
    public string Status { get; set; } // "LIVE" or "ARCHIVED"

    public virtual void PrintAdDetails()
    {
        Console.WriteLine($"Ad ID: {AdID}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Publish Date: {PublishDate}");
        Console.WriteLine($"Archive Date: {ArchiveDate}");
        Console.WriteLine($"Status: {Status}");
    }
}

// Define derived classes for different ad types (Free, Standard, Corporate)
class FreeAd : Ad { }
class StandardAd : Ad { }
class CorporateAd : Ad { }

class Program
{
    static List<Ad> ads = new List<Ad>();

    static void Main(string[] args)
    {
        int option;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Set up data");
            Console.WriteLine("2. Display data");
            Console.WriteLine("3. Search by ad ID");
            Console.WriteLine("4. Delete ad");
            Console.WriteLine("5. Renew ad");
            Console.WriteLine("6. Display publication");
            Console.WriteLine("7. Archive");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice (1-8): ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        SetUpData();
                        break;
                    case 2:
                        DisplayData();
                        break;
                    case 3:
                        SearchByID();
                        break;
                    case 4:
                        DeleteAd();
                        break;
                    case 5:
                        RenewAd();
                        break;
                    case 6:
                        DisplayPublication();
                        break;
                    case 7:
                        ArchiveAds();
                        break;
                    case 8:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (1-8).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

            Console.WriteLine();
        } while (option != 8);
    }

    static void SetUpData()
    {
        // Implement data setup logic here (creating ads and adding them to the 'ads' list).
        // Example:
        var freeAd = new FreeAd
        {
            AdID = 1,
            Type = "Free",
            Title = "Free Ad 1",
            Description = "This is a free ad.",
            PublishDate = DateTime.Now,
            ArchiveDate = DateTime.Now.AddDays(7),
            Status = "LIVE"
        };
        ads.Add(freeAd);

        // Add more ads here for Standard and Corporate types.
    }

    static void DisplayData()
    {
        foreach (var ad in ads)
        {
            ad.PrintAdDetails();
            Console.WriteLine();
        }
    }

    static void SearchByID()
    {
        Console.Write("Enter Ad ID to search: ");
        if (int.TryParse(Console.ReadLine(), out int adID))
        {
            var ad = ads.FirstOrDefault(a => a.AdID == adID);
            if (ad != null)
            {
                ad.PrintAdDetails();
            }
            else
            {
                Console.WriteLine("Ad not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid Ad ID.");
        }
    }

    static void DeleteAd()
    {
        Console.Write("Enter Ad ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int adID))
        {
            var ad = ads.FirstOrDefault(a => a.AdID == adID);
            if (ad != null)
            {
                ads.Remove(ad);
                Console.WriteLine("Ad deleted successfully.");
            }
            else
            {
                Console.WriteLine("Ad not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid Ad ID.");
        }
    }

    static void RenewAd()
    {
        // Implement ad renewal logic here.
        Console.WriteLine("Renew Ad function not implemented.");
    }

    static void DisplayPublication()
    {
        // Implement displaying ads for a given date.
        Console.WriteLine("Display Publication function not implemented.");
    }

    static void ArchiveAds()
    {
        // Implement archiving logic here.
        Console.WriteLine("Archive Ads function not implemented.");
    }
}
