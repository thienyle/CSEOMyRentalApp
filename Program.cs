using System;

namespace CSEOMyRentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable name; everything is a variable when you store data
            var myAccount = new MyHouseAccount();
            myAccount.Address = "ABC Street";
            myAccount.YearBought = 1984;
            myAccount.PurchasePrice = 500000;
            myAccount.MarketValue = 600000;
            myAccount.PropertyType = TypeProperty.Single;
            myAccount.Deposit(1000);
            Console.WriteLine($"AN:{myAccount.AccountNumber}, AD:{myAccount.Address}, YearBought: {myAccount.YearBought}, " +
                $"PurchasePrice: {myAccount.PurchasePrice:C}, MarketValue: {myAccount.MarketValue:C}, PropertyType: {myAccount.PropertyType}, " +
                $"TotalRentalIncome: {myAccount.TotalRentalIncome:C}, CreatedDate: {myAccount.CreatedDate}");


            var myAccount2 = new MyHouseAccount();
            myAccount2.Address = "XYZ Avenue";
            myAccount2.YearBought = 1990;
            myAccount2.PurchasePrice = 300000;
            myAccount2.MarketValue = 400000;
            myAccount2.PropertyType = TypeProperty.Multifamily;
            Console.WriteLine($"AN:{myAccount2.AccountNumber}, AD:{myAccount2.Address}, YearBought: {myAccount2.YearBought}, " +
               $"PurchasePrice: {myAccount2.PurchasePrice:C}, MarketValue: {myAccount2.MarketValue:C}, PropertyType: {myAccount2.PropertyType}, " +
               $"TotalRentalIncome: {myAccount2.TotalRentalIncome:C}, CreatedDate: {myAccount2.CreatedDate}");

            //This is just a test area
        }
    }
}
