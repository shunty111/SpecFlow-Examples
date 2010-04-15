﻿using System;
using System.Linq;
using Bookshop.Models;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            var db = new BookShopEntities();
            //            foreach (var lineItem in db.LineItem)
            //            {
            //                db.DeleteObject(lineItem);
            //            }
            //            foreach (var order in db.OrderSet)
            //            {
            //                db.DeleteObject(order);
            //            }
            foreach (var book in db.Books)
            {
                db.DeleteObject(book);
            }
            db.SaveChanges();

        }
    }
}
