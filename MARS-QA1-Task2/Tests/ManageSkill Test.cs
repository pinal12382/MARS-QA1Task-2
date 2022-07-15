using MARS_QA1_Task2.Pages;
using MarsQA_1.pages;
using MarsQA_1.ProfilePage;
using MarsQA_1.Utilities;
using NUnit.Framework;

namespace MARS_QA1_Task2
{
    [TestFixture]
    public class Tests:CommonDriver
    {  
        

        [Test]
        public void HomepageTest()
        {

            Homepage Homepageobj = new Homepage(driver);
            Homepageobj.JoinInpage(driver);
        
         }

        [Test]
        public void SignInTest1()
        {
            SignInpage SignInpageobj =new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);
        }
        [Test]
        public void ShareskillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageShareSkill manageshareskillobj = new ManageShareSkill();
            manageshareskillobj.AddShareSkill(driver);


        }
    }
}