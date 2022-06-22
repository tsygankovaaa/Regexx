using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Regtext_;
using static Regtext_.Regextext;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Regextext regtext = new Regextext();
        string a = "12";
        //Class212 cl212 = new Regextext.Class212();
        [TestMethod]
        public void TestMethod1()
        {
            string str = "This is my code";
            bool result = regtext.regtext(str);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Regextext regtext = new Regextext();
            string str = "class";
            bool result = regtext.regtext(str);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string str = "мама";
            string s = regtext.regreplace(str);
            Assert.AreEqual("момо", s);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string str = "момо";
            string s = regtext.regreplace(str);
            Assert.AreEqual("момо", s);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string str = "пароль:77623";
            int result = regtext.regciv(str);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string str = "пароль:апельсин";
            int result = regtext.regciv(str);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string str = "tsygankova@mail.ru";
            bool s = regtext.regmail(str);
            Assert.AreEqual(true, s);
        }
        [TestMethod]
        public void TestMethod8()//EMAIL
        {
            string str = "tsygankova";
            bool s = regtext.regmail(str);
            Assert.AreEqual(false, s);
        }
        [TestMethod]
        public void TestMethod09()//СНИЛС
        {
            string str = "123-123-2343 23";
            bool s = regtext.regsnils(str);
            Assert.AreEqual(true, s);
        }
        [TestMethod]
        public void TestMethod010()//НОМЕР
        {
            string str = "89088703057";
            bool s = regtext.regnomer(str);
            Assert.AreEqual(true, s);
        }
        [TestMethod]

        public void TestMethod011()//НОМЕР
        {
            string str = "+79088703057";
            bool s = regtext.regnomer(str);
            Assert.AreEqual(true, s);
        }
        [TestMethod]
        public void TestMethod012()//ПАСПОРТ
        {
            string str = "7116 567857";
            bool s = regtext.regpasport(str);
            Assert.AreEqual(true, s);
        }
        [TestMethod]
        public void TestMethod013()
        {
            double str = Convert.ToDouble(regtext.regperevod(0, 1024));
            Assert.AreEqual(1, str);
        }

        [TestMethod]
        public void TestMethod9()
        {
            string str = "user=5";
            var result = regtext.reguserid(str);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string res = Convert.ToString(regtext.reguserid("user=12"));
            Assert.AreEqual("12", res);
        }

        [TestMethod]
        public void TestMethod11()
        {

        }
    }

}
