using MARS_QA1_Task2.Pages;
using MARS_QA1_Task2.Shareskill;
using MarsQA_1.pages;
using MarsQA_1.ProfilePage;
using MarsQA_1.Utilities;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

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
            
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);
            
        }
        [Test]
        public void ShareskillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageShareSkill manageshareskillobj = new ManageShareSkill(driver);
            manageshareskillobj.AddShareSkill(driver);


        }
        [Test]
        public void CancleSkillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageShareSkill manageshareskillobj = new ManageShareSkill(driver);
            manageshareskillobj.CancleShareskill(driver);
        }
        
        
        [Test]
        public void ViewTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.Listings(driver);


        }
        [Test]
        public void EditSkillTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.EditSkill(driver);

        }
        [Test]
        public void DeleteTest()
        {
            SignInpage SignInpageobj = new SignInpage(driver);
            SignInpageobj.addlogindetail(driver);

            ManageListings manageListingobj = new ManageListings();
            manageListingobj.DeleteSkill(driver);


        }
    }
}