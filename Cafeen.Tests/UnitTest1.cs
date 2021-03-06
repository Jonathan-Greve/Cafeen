﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafeen.Controllers;
using System.Web.Mvc;
using Cafeen.Models;

namespace Cafeentest.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestDefaultView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("", result.ViewName);
        }
    }
    [TestClass]
    public class AccountingsControllerTest
    {
        [TestMethod]
        public void TestCreate()
        {
            var controller = new AccountingsController();
            var result = controller.Create() as ViewResult;
            Assert.AreEqual("", result.ViewName);
        }


    }
}

