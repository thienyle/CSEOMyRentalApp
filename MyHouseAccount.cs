using System;
using System.Collections.Generic;
using System.Text;

namespace CSEOMyRentalApp
{
    enum TypeProperty
    { 
        Single,
        Multifamily,
        Condo,
        Townhome }
    //Single line comment
    /*Practice line
     * Practice line
     * Practice line
     */
     /// <summary>
     /// This is an application that will allow you to keep track of your house rental expenses. 
     /// </summary>
    class MyHouseAccount
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Account number for the rental place
        /// </summary>
        public int AccountNumber { get; private set; }
        public DateTime CreatedDate{ get; private set; }
        public string Address { get; set; }
        public int YearBought { get; set; }
        public int PurchasePrice { get; set; }
        public int MarketValue { get; set; }
        public TypeProperty PropertyType { get; set;}
        public int TotalRentalIncome{ get; private set; }
        #endregion

        #region Method
        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(int amount)
        {
            //Balance = Balance + amount
            TotalRentalIncome += amount;
         }
        /// <summary>
        /// Costs from rental property such as fixing roof, hiring plumber, etc. 
        /// </summary>
        /// <param name="amount">Amount it costs to maintain the rental property</param>
        /// <returns>Total rent paid - cost to maintain rental property</returns>
        public int Withdraw(int amount)
        {
            TotalRentalIncome -= amount;
            return TotalRentalIncome;
         }
        #endregion

        #region Constructor
        //Default constructor
        public MyHouseAccount()
        {
            //lastAccountNumber = lastAccountNumber + 1; 
            //lastAccountNumber++; ++ means increment by 1
            //AccountNumber = lastAccountNumber;
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;

        }
        #endregion
    }
}
