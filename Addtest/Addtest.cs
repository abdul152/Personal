using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

    [TestClass]
    public class Addtest
    {
        [TestMethod]
        public void Test_add()
        {
            // Arrange
            int expectedresult = 10;
            int num1 = 9;
            int num2 = 1;
            int actural_result;

                       



            // Act

            actural_result = EX11.Calculator.Add(num1, num2);


            //Assert
            Assert.AreEqual(expectedresult, actural_result);



        }

    [TestMethod]
    public void Test_divide()
        {

        //arrange
            int wow = 4;
            int wow1 = 20;
            int wow2 = 5;


        //act

        int actreslt = EX11.Calculator.Divide(wow1, wow2);

        //assert

        Assert.AreEqual(wow, actreslt);

        }



    
    }