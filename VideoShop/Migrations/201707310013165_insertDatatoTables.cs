namespace VideoShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertDatatoTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");
            //Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (1, 'Tony Park', 'False', 1, 03/04/2001)");
            //Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (1, 'Yesol Lee', 'True', 2, 25/12/2001)");
            //Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (1, 'Jowon Shin', 'True', 3, 01/01/2001)");
        }
        
        public override void Down()
        {
        }
    }
}
