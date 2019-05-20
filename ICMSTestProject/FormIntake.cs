using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICMSTestProject
{
    class FormIntake
    {
        public FormIntake()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        /// <FirstPage>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>

 

        [FindsBy(How = How.Id, Using = "gform_fields_5")]
        public IWebElement StartComplaint { get; set; }

        
        [FindsBy(How = How.Id, Using = "grve-body")]
        public IWebElement TestCLick { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'FILE A COMPLAINT')]")]
        public IWebElement FileComplaintBtn { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_95_0")]
        public IWebElement EmployeeYes { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_95_1")]
        public IWebElement EmployeeNo { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_6_0")]
        public IWebElement AnonymousYes { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_6_1")]
        public IWebElement AnonymousNo { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_7_0")]
        public IWebElement YourSelfCb { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_7_1")]
        public IWebElement SomeoneElseCb { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_7_2")]
        public IWebElement SupervisorCb { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_12_1")]
        public IWebElement AcknowledgeCb { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_10")]
        public IWebElement FPBtnNext { get; set; }
        /// <SecondPage>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>
        [FindsBy(How = How.Id, Using = "input_5_94")]
        public IWebElement ENumber { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_15")]
        public IWebElement ETitle { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_11_3")]
        public IWebElement EFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_11_4")]
        public IWebElement EMiddleInitial { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_11_6")]
        public IWebElement ELastName { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_31")]
        public IWebElement EWorkNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_30")]
        public IWebElement EMobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_17")]
        public IWebElement EWorkExt { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_19")]
        public IWebElement EWorkHr { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_20")]
        public IWebElement ERDO { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_24")]
        public IWebElement EUnitAssignement { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_25")]
        public IWebElement RPDept { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_26_3")]
        public IWebElement RPHeadFN { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_26_4")]
        public IWebElement RPHeadMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_26_6")]
        public IWebElement RPHeadLN { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_27_1")]
        public IWebElement RPStreetAddress { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_27_2")]
        public IWebElement RPAddressLine2 { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_27_3")]
        public IWebElement RPCity { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_27_4")]
        public IWebElement RPState { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_27_5")]
        public IWebElement RPZip { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_28_3")]
        public IWebElement RPISFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_28_4")]
        public IWebElement RPISMInitial { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_28_6")]
        public IWebElement RPISLastName { get; set; }
        
        [FindsBy(How = How.Id, Using = "input_5_29")]
        public IWebElement RPISPhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_55_1")]
        public IWebElement SameAsReportingPartyCb { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_62_3")]
        public IWebElement ReportingPartyFN { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_62_4")]
        public IWebElement ReportingPartyMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_62_6")]
        public IWebElement ReportingPartyLN { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_33_0")]
        public IWebElement NotifySuperVisorYes { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_32_3")]
        public IWebElement NotifedSupervisorFN { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_32_4")]
        public IWebElement NotifedSupervisorMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_32_6")]
        public IWebElement NotifedSupervisorLN { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_63")]
        public IWebElement NotifedSupervisorDate { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_64_1")]
        public IWebElement NotifedSupervisorHH { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_64_2")]
        public IWebElement NotifedSupervisorMM { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_64_3")]
        public IWebElement NotifedSupervisorAM { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_65")]
        public IWebElement NotificationMedium { get; set; }
        
        [FindsBy(How = How.Id, Using = "choice_5_33_1")]
        public IWebElement NotifySuperVisorNo { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_33_2")]
        public IWebElement NotifySuperVisorDontKnow { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_34")]
        public IWebElement SPBtnNext { get; set; }
        /// <ThirdPage>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add Complainant')]")]
        public IWebElement AddComplaintantBtn { get; set; }


        [FindsBy(How = How.Id, Using = "choice_6_17_1")]
        public IWebElement CSameAsReportingParty { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_18")]
        public IWebElement ComplainantENo { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_3_3")]
        public IWebElement ComplainantFName { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_3_6")]
        public IWebElement ComplainantLName { get; set; }

       

        [FindsBy(How = How.Id, Using = "input_6_3_4")]
        public IWebElement ComplainantMName { get; set; }

       

        [FindsBy(How = How.Id, Using = "input_6_4")]
        public IWebElement ComplainantTitle { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_5")]
        public IWebElement ComplainantUnit { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_7")]
        public IWebElement ComplainantWorkNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_12")]
        public IWebElement ComplainantExt { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_8")]
        public IWebElement ComplainantMobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_9")]
        public IWebElement ComplainantWorkHr { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_11")]
        public IWebElement ComplainantRDO { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_13")]
        public IWebElement ComplainantDept { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_14_3")]
        public IWebElement ComplainantSuperviorFN { get; set; }


        
        [FindsBy(How = How.Id, Using = "input_6_14_4")]
        public IWebElement ComplainantSuperviorMI{ get; set; }

        [FindsBy(How = How.Id, Using = "input_6_14_6")]
        public IWebElement ComplainantSupervisorLN { get; set; }

        [FindsBy(How = How.Id, Using = "input_6_15")]
        public IWebElement ComplainantSupervisorPhone { get; set; }

        [FindsBy(How = How.Id, Using = "gform_submit_button_6")]
        public IWebElement SubmitPopUpBtn { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_36")]
        public IWebElement ThridPageNext { get; set; }
        /// <FourthPage>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add Party')]")]
        public IWebElement AddPartyBtn { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_14")]
        public IWebElement PartyEmpNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_2_3")]
        public IWebElement PartyFName { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_2_4")]
        public IWebElement PartMInitial { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_2_6")]
        public IWebElement PartyLName { get; set; }
      
        [FindsBy(How = How.Id, Using = "input_7_3")]
        public IWebElement PartyTitle { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_4")]
        public IWebElement PartyUnit { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_5")]
        public IWebElement PartyWorkPhone { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_6")]
        public IWebElement PartyExt { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_7")]
        public IWebElement PartyMobileNo { get; set; }


        [FindsBy(How = How.Id, Using = "input_7_8")]
        public IWebElement PartyWorkHr { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_9")]
        public IWebElement PartyRDO { get; set; }


        [FindsBy(How = How.Id, Using = "input_7_10")]
        public IWebElement PartyDept { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_11_3")]
        public IWebElement PartySupervisorFN { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_11_4")]
        public IWebElement PartySupervisorMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_11_6")]
        public IWebElement PartySupervisorLN { get; set; }

        [FindsBy(How = How.Id, Using = "input_7_12")]
        public IWebElement PartySupervisorPhNo { get; set; }

        [FindsBy(How = How.Id, Using = "gform_submit_button_7")]
        public IWebElement PartyPopupSubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_38")]
        public IWebElement FourthNextBtn { get; set; }
        
        /// <FifthPage>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add Witness')]")]
        public IWebElement AddWitnessBtn { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_14")]
        public IWebElement WitnessEmpNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_4_3")]
        public IWebElement WitnessFName { get; set; }
        
        [FindsBy(How = How.Id, Using = "input_8_4_4")]
        public IWebElement WitnessMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_4_6")]
        public IWebElement WitnessLName { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_2")]
        public IWebElement WitnessTitle { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_3")]
        public IWebElement WitnessUnit { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_5")]
        public IWebElement WitnessWorkPhone { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_6")]
        public IWebElement WitnessExt { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_7")]
        public IWebElement WitnessMobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_8")]
        public IWebElement WitnessWorkHr { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_9")]
        public IWebElement WitnessRDO { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_10")]
        public IWebElement WitnessDept { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_11_3")]
        public IWebElement WitnessSupervisorFN { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_11_4")]
        public IWebElement WitnessSupervisorMI { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_11_6")]
        public IWebElement WitnessSupervisorLN { get; set; }

        [FindsBy(How = How.Id, Using = "input_8_12")]
        public IWebElement WitnessSupervisorPh { get; set; }
        
        [FindsBy(How = How.Id, Using = "gform_submit_button_8")]
        public IWebElement WitnessPopUpSubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_40")]
        public IWebElement FifthNextBtn { get; set; }

        /// <SixthPage>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        [FindsBy(How = How.Id, Using = "input_5_41")]
        public IWebElement DateOfIncident { get; set; }

        [FindsBy(How = How.Id, Using = "gform_fields_5_6")]
        public IWebElement RandonmClick { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_42")]
        public IWebElement NatureOfComplaint { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_43")]
        public IWebElement ReasonForOccurance { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_44")]
        public IWebElement  SixthNextBtn { get; set; }
        /// <SeventhPage>
        /// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        
        [FindsBy(How = How.Id, Using = "input_5_48")]
        public IWebElement RaceOfPersonVol { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_46_0")]
        public IWebElement GenderMaleVol { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_46_1")]
        public IWebElement GenderFemaleVol { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_46_2")]
        public IWebElement GenderNotDisclosedVol { get; set; }

        [FindsBy(How = How.Id, Using = "input_5_47")]
        public IWebElement  DOBVol { get; set; }
        

        [FindsBy(How = How.Id, Using = "gform_fields_5_7")]
        public IWebElement RandomClickVol { get; set; }

        [FindsBy(How = How.Id, Using = "gform_next_button_5_49")]
        public IWebElement SeventhNextBtn { get; set; }
/// <EightPage>
/// ///////////////////////////////////////////////////////////////////////////////
/// </summary>
        [FindsBy(How = How.Id, Using = "input_5_53")]
        public IWebElement SupportingDocBtn { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_52_1")]
        public IWebElement  EmailConfirmationCb{ get; set; }

        [FindsBy(How = How.Id, Using = "input_5_51")]
       public IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "choice_5_116_1")]
        public IWebElement  NotRebortCb { get; set; }

        [FindsBy(How = How.Id, Using = "gform_submit_button_5")]
        public IWebElement  FinishBtn { get; set; }
        /// <Final>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        [FindsBy(How = How.Id, Using = "gform_confirmation_message_5")]
        public IWebElement ConfirmationMessage { get; set; }



        public void FillFirstPage(String isEmployee, String isAnonymous, String complaintFillingBy)
        {


            FileComplaintBtn.Clicks();

            //string getKLinkMessage = StartComplaint.Text;
            //Assert.IsTrue(getKLinkMessage.Contains("Begin Complaint"));

            if (isEmployee.ToLower() == "yes")
            {
                EmployeeYes.Clicks();
            }
            else
            {
                EmployeeNo.Clicks();
            }

            if (isAnonymous.ToLower() == "yes")
            {
                AnonymousYes.Clicks();
            }
            else
            {
                AnonymousNo.Clicks();
            }
            if (complaintFillingBy.ToLower() == "yourself")
            {
                YourSelfCb.Clicks();
            }
            else if (complaintFillingBy.ToLower() == "someone else")
            {
                SomeoneElseCb.Clicks();
            }
            else
            {
                SupervisorCb.Clicks();
            }

            AcknowledgeCb.Click();
            FPBtnNext.Clicks();

        }

        public void FillSecondPage(string empNumber, string empTitle, string empFistName, string empMInitial,
            string empLastName, string empWorkNum, string empMobileNum, string empWorkExt, string empWorkHr,
            string empRdo, string empUnitAssignment, string empRPDept, string empRPStreetAddress,
            string empRPAddressline, string empRPCity, string empRPState, string empRPZip,
            string empRPISFirstName, string empRPISMInitial, string empRPISLastName, string empRPISPhoneNo,
            string sameAsReportingParty, string ReportingFN, string ReportingMI, string ReportingLN, string notifySupervisor,
            string supervisorFN, string supervisorMI, string supervisorLN, string dateNotified, string timeHH, string timeMM,
            string timeAmPm, string notificationMean)
        {
            waitForPageUntilElementIsVisible(By.Id("input_5_94"), 10);

            ENumber.EnterText(empNumber);
            ETitle.EnterText(empTitle);
            EFirstName.EnterText(empFistName);
            EMiddleInitial.EnterText(empMInitial);
            ELastName.EnterText(empLastName);
            EWorkNo.EnterText(empWorkNum);
            EMobileNo.EnterText(empMobileNum);
            EWorkExt.EnterText(empWorkExt);
            EWorkHr.EnterText(empWorkHr);
            ERDO.EnterText(empRdo);
            EUnitAssignement.EnterText(empUnitAssignment);
            RPDept.EnterText(empRPDept);
            //RPHeadFN.EnterText("Andrew");
            //RPHeadMI.EnterText("T");
            //RPHeadLN.EnterText("Tran");
            RPStreetAddress.EnterText(empRPStreetAddress);
            RPAddressLine2.EnterText(empRPAddressline);
            RPCity.EnterText(empRPCity);
            RPState.EnterText(empRPState);
            RPZip.EnterText(empRPZip);

            RPISFirstName.EnterText(empRPISFirstName);
            RPISMInitial.EnterText(empRPISMInitial);
            RPISLastName.EnterText(empRPISLastName);
            RPISPhoneNumber.EnterText(empRPISPhoneNo);

            if (sameAsReportingParty.ToLower() == "yes")
            {
                SameAsReportingPartyCb.Clicks();
            }
            else
            {
                ReportingPartyFN.EnterText(ReportingFN);
                ReportingPartyMI.EnterText(ReportingMI);
                ReportingPartyLN.EnterText(ReportingLN);
            }
            if (notifySupervisor.ToLower() == "yes")
            {
                NotifySuperVisorYes.Clicks();
                NotifedSupervisorFN.EnterText(supervisorFN);
                //NotifedSupervisorMI.EnterText(supervisorMI);
                NotifedSupervisorLN.EnterText(supervisorLN);
                NotifedSupervisorDate.EnterText(dateNotified);
                NotifedSupervisorHH.EnterText(timeHH);
                NotifedSupervisorMM.EnterText(timeMM);
                NotifedSupervisorAM.EnterText(timeAmPm);
                NotificationMedium.EnterText(notificationMean);
            }
            else if (notifySupervisor.ToLower() == "no")
            {
                NotifySuperVisorNo.Clicks();
            }
            else
            {
                NotifySuperVisorDontKnow.Clicks();
            }



            SPBtnNext.Clicks();

        }




        internal void FillThirdPage(IEnumerable<ThirdPage> completelist)
        {


            var enterlist = completelist.Where(data => data.SameAsReportingParty.ToLower() == "no").ToList();
            var sasList = completelist.Where(data => data.SameAsReportingParty.ToLower() != "no").ToList();
            if (sasList.Count > 0)
            {
                AddComplaintantBtn.Clicks();
                CSameAsReportingParty.Clicks();
                waitForPageUntilElementIsVisible(By.Id("gform_submit_button_6"), 10);
                SubmitPopUpBtn.Clicks();


            }
            else
            {
                foreach (var item in enterlist)
                {
                    AddComplaintantBtn.Clicks();
                    waitForPageUntilElementIsVisible(By.Id("input_6_18"), 10);
                    ComplainantENo.EnterText(item.EmployeeNumber);
                    ComplainantFName.EnterText(item.FirstName);
                    //ComplainantMName.EnterText(item.MiddleName);
                    ComplainantLName.EnterText(item.LastName);
                    ComplainantTitle.EnterText(item.Title);
                    ComplainantUnit.EnterText(item.UnitOfAssignmnet);
                    ComplainantWorkNo.EnterText(item.WorkPhone);
                    ComplainantExt.EnterText(item.Extension);
                    ComplainantMobileNo.EnterText(item.MobileNumber);
                    ComplainantWorkHr.EnterText(item.WorkHours);
                    ComplainantRDO.EnterText(item.RDO);
                    ComplainantDept.EnterText(item.Department);
                    ComplainantSuperviorFN.EnterText(item.SFName);
                   // ComplainantSuperviorMI.EnterText(item.SMName);
                    ComplainantSupervisorLN.EnterText(item.SLN);
                    ComplainantSupervisorPhone.EnterText(item.SPhoneNumber);
                    SubmitPopUpBtn.Clicks();
                    //    if (item != enterlist.Last())

                }
            }



            ThridPageNext.Clicks();
        }

        internal void FillFourthPage(IEnumerable<FourthPage> completelist)
        {

            foreach (var item in completelist)
            {
                AddPartyBtn.Clicks();
                waitForPageUntilElementIsVisible(By.Id("input_7_14"), 10);
                PartyEmpNo.EnterText(item.EmployeeNumber);
                PartyFName.EnterText(item.FirstName);
                //PartMInitial.EnterText(item.MiddleName);
                PartyLName.EnterText(item.LastName);
                PartyTitle.EnterText(item.Title);
                PartyUnit.EnterText(item.UnitOfAssignmnet);
                PartyWorkPhone.EnterText(item.WorkPhone);
                PartyExt.EnterText(item.Extension);
                PartyMobileNo.EnterText(item.MobileNumber);
                PartyWorkHr.EnterText(item.WorkHours);
                PartyRDO.EnterText(item.RDO);
                PartyDept.EnterText(item.Department);
                PartySupervisorFN.EnterText(item.SFName);
                //PartySupervisorMI.EnterText(item.SMName);
                PartySupervisorLN.EnterText(item.SLN);
                PartySupervisorPhNo.EnterText(item.SPhoneNumber);
                PartyPopupSubmitBtn.Clicks();
            }


            FourthNextBtn.Clicks();
        }

        internal void FillFifthPage(IEnumerable<FifthPage> completelist)
        {

            foreach (var item in completelist)
            {
                AddWitnessBtn.Clicks();
                waitForPageUntilElementIsVisible(By.Id("input_8_14"), 10);
                WitnessEmpNo.EnterText(item.EmployeeNumber);
                WitnessFName.EnterText(item.FirstName);
                //WitnessMI.EnterText(item.MiddleName);
                WitnessLName.EnterText(item.LastName);
                WitnessTitle.EnterText(item.Title);
                WitnessUnit.EnterText(item.UnitOfAssignmnet);
                WitnessWorkPhone.EnterText(item.WorkPhone);
                WitnessExt.EnterText(item.Extension);
                WitnessMobileNo.EnterText(item.MobileNumber);
                WitnessWorkHr.EnterText(item.WorkHours);
                WitnessRDO.EnterText(item.RDO);
                WitnessDept.EnterText(item.Department);
                WitnessSupervisorFN.EnterText(item.SFName);
                //WitnessSupervisorMI.EnterText(item.SMName);
                WitnessSupervisorLN.EnterText(item.SLN);
                WitnessSupervisorPh.EnterText(item.SPhoneNumber);
                WitnessPopUpSubmitBtn.Clicks();
            }


            FifthNextBtn.Clicks();
        }



        public void FillSixthPage(string dateOfIncident, string complaintNature, string reasonOfOccurance)
        {
            DateOfIncident.EnterText(dateOfIncident);
            RandonmClick.Clicks();
            NatureOfComplaint.EnterText(complaintNature);
            ReasonForOccurance.EnterText(reasonOfOccurance);
            SixthNextBtn.Clicks();
        }

        public void FillSeventhPage(string race, string gender, string dateOfBirth)
        {
            RaceOfPersonVol.EnterText(race);
            if (gender.ToLower() == "male")
            {
                GenderMaleVol.Clicks();
            }
            else if (gender.ToLower() == "female")
            {
                GenderFemaleVol.Clicks();
            }
            else
            {
                GenderNotDisclosedVol.Clicks();
            }
            if (dateOfBirth != "" || dateOfBirth != null)
            {
                DOBVol.EnterText(dateOfBirth);
            }
            else
            {

            }

            RandomClickVol.Clicks();
            SeventhNextBtn.Clicks();
        }

        public void FillEighthPage(string emailCheck, string emailAddress, string securityCheck)
        {
            if (emailCheck.ToLower() == "yes")
            {
                EmailConfirmationCb.Clicks();
            }
            else
            {

            }

            EmailAddress.EnterText("ICMS.UAT.TEST@hr.lacounty.gov");
            if (securityCheck.ToLower() == "check")
            {
                NotRebortCb.Clicks();
            }

            // SupportingDocBtn.UploadFile(@"C:\CaseData.xlxs");
            FinishBtn.Clicks();
        }

        public void FillFinalPage()
        {
            string getKLinkMessage = ConfirmationMessage.Text;
            Assert.IsTrue(getKLinkMessage.Contains("Thank you for contacting us! For your records, please take note of the Reference number below"));
        }

        public static string ReturnDate()
        {
            DateTime today = DateTime.Today;

            string result = today.ToString("MM/dd/yyyy");
            return result;
        }

        public IWebElement waitForPageUntilElementIsVisible(By locator, int maxSec)
        {
            return new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(maxSec))
                 .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }



        public static string ReadData(int rowNumber, string columnName, List<Datacollection> collectionName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in collectionName
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }


}
