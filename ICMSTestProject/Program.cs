
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMSTestProject
{
    class Program
    {
        // Browser web reference
        // IWebDriver driver = new ChromeDriver();
        Dictionary<int, string> testResult = new Dictionary<int, string>();
        Dictionary<int, string> errorMessage = new Dictionary<int, string>();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chrome");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PropertiesCollection.driver.Manage().Window.Maximize();
            testResult.Add(0, "Status");
            errorMessage.Add(0, "Reason of failure");


        }
        [Test]
        public void CaseForm()
        {
            List<ThirdPage> thirdPageList = new List<ThirdPage>();

            List<FourthPage> fourthPageList = new List<FourthPage>();

            List<FifthPage> fifthPageList = new List<FifthPage>();

            List<Datacollection> dataFirst = new List<Datacollection>();
            dataFirst = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "First");

            List<Datacollection> dataSecond = new List<Datacollection>();
            dataSecond = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Second - RP");

            List<Datacollection> dataThird = new List<Datacollection>();
            dataThird = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Third - Complainant");

            for (int index = 1; index <= dataThird.Count; index++)
            {

                if (ReadData(index, "Employee Number", dataThird) != null)
                {
                    ThirdPage thirdPage = new ThirdPage(ReadData(index, "Employee Number", dataThird),
                    ReadData(index, "First Name", dataThird),
                    ReadData(index, "Middle Initial", dataThird),
                    ReadData(index, "Last Name", dataThird),
                    ReadData(index, "Title", dataThird),
                    ReadData(index, "Unit of Assignment", dataThird),
                    ReadData(index, "Work Phone", dataThird),
                    ReadData(index, "Ext", dataThird),
                    ReadData(index, "Mobile Phone", dataThird),
                    ReadData(index, "Work Hours", dataThird),
                    ReadData(index, "RDO", dataThird),
                    ReadData(index, "Department", dataThird),
                    ReadData(index, "Supervisor First Name", dataThird),
                    ReadData(index, "Supervisor Middle Initial", dataThird),
                    ReadData(index, "Supervisor Last Name", dataThird),
                    ReadData(index, "Supervisor Phone Number", dataThird),
                    ReadData(index, "Same as reporting party", dataThird),
                    ReadData(index, "Add CP to Case#", dataThird));


                    thirdPageList.Add(thirdPage);
                }

            }
            List<Datacollection> dataFourth = new List<Datacollection>();
            dataFourth = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Fourth - Involved Party");

            for (int index = 1; index <= dataThird.Count; index++)
            {

                if (ReadData(index, "Employee Number", dataFourth) != null)
                {
                    FourthPage fourthPage = new FourthPage(ReadData(index, "Employee Number", dataFourth),
                    ReadData(index, "First Name", dataFourth),
                    ReadData(index, "Middle Initial", dataFourth),
                    ReadData(index, "Last Name", dataFourth),
                    ReadData(index, "Title", dataFourth),
                    ReadData(index, "Unit of Assignment", dataFourth),
                    ReadData(index, "Work Phone", dataFourth),
                    ReadData(index, "Ext", dataFourth),
                    ReadData(index, "Mobile Phone", dataFourth),
                    ReadData(index, "Work Hours", dataFourth),
                    ReadData(index, "RDO", dataFourth),
                    ReadData(index, "Department", dataFourth),
                    ReadData(index, "Supervisor First Name", dataFourth),
                    ReadData(index, "Supervisor Middle Initial", dataFourth),
                    ReadData(index, "Supervisor Last Name", dataFourth),
                    ReadData(index, "Supervisor Phone Number", dataFourth),
                    ReadData(index, "Add IP to Case#", dataFourth));


                    fourthPageList.Add(fourthPage);
                }

            }

            List<Datacollection> dataFifth = new List<Datacollection>();
            dataFifth = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Fifth - Witness");

            for (int index = 1; index <= dataFifth.Count; index++)
            {

                if (ReadData(index, "Employee Number", dataFifth) != null)
                {
                    FifthPage fifthPage = new FifthPage(ReadData(index, "Employee Number", dataFifth),
                        ReadData(index, "First Name", dataFifth),
                        ReadData(index, "Middle Initial", dataFifth),
                        ReadData(index, "Last Name", dataFifth),
                        ReadData(index, "Title", dataFifth),
                        ReadData(index, "Unit of Assignment", dataFifth),
                        ReadData(index, "Work Phone", dataFifth),
                        ReadData(index, "Ext", dataFifth),
                        ReadData(index, "Mobile Phone", dataFifth),
                        ReadData(index, "Work Hours", dataFifth),
                        ReadData(index, "RDO", dataFifth),
                        ReadData(index, "Department", dataFifth),
                        ReadData(index, "Supervisor First Name", dataFifth),
                        ReadData(index, "Supervisor Middle Initial", dataFifth),
                        ReadData(index, "Supervisor Last Name", dataFifth),
                        ReadData(index, "Supervisor Phone Number", dataFifth),
                        ReadData(index, "Add Witness to Case#", dataFifth));


                    fifthPageList.Add(fifthPage);
                }

            }

            List<Datacollection> dataSixth = new List<Datacollection>();
            dataSixth = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Sixth - Nature");

            List<Datacollection> dataSeventh = new List<Datacollection>();
            dataSeventh = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Seventh - VoluntaryEEO");

            List<Datacollection> dataEighth = new List<Datacollection>();
            dataEighth = ExcelLibrary.PopulateInCollection(@"C:\ICMSDataV2-1.1.xlsx", "Eighth - Confirmation");

            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\ICMSDataV2-1.1.xlsx", "First"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);


                    PropertiesCollection.driver.Navigate().GoToUrl("http://ceopn01.isd.lacounty.gov/");
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                    Console.WriteLine("Opened URL");

                    FormIntake addData = new FormIntake();

                    addData.FillFirstPage(FormIntake.ReadData(i, "LA County employee", dataFirst),
                                            FormIntake.ReadData(i, "Anonymous", dataFirst),
                                            FormIntake.ReadData(i, "Whos filling complaint", dataFirst));
                    Console.WriteLine("Second Page");

                    addData.FillSecondPage(FormIntake.ReadData(i, "Employee Number", dataSecond), FormIntake.ReadData(i, "Title", dataSecond), FormIntake.ReadData(i, "First Name", dataSecond),
                                            FormIntake.ReadData(i, "Middle Initial", dataSecond), FormIntake.ReadData(i, "Last Name", dataSecond), FormIntake.ReadData(i, "Work Phone", dataSecond),
                                            FormIntake.ReadData(i, "Mobile Phone", dataSecond), FormIntake.ReadData(i, "Work Extension", dataSecond), FormIntake.ReadData(i, "Work Hours", dataSecond),
                                            FormIntake.ReadData(i, "RDO", dataSecond), FormIntake.ReadData(i, "RP Unit of Assignment", dataSecond), FormIntake.ReadData(i, "RP Department", dataSecond),
                                            FormIntake.ReadData(i, "Email", dataSecond), FormIntake.ReadData(i, "Rp Street Address", dataSecond), FormIntake.ReadData(i, "RP Address Line", dataSecond),
                                            FormIntake.ReadData(i, "City", dataSecond), FormIntake.ReadData(i, "State", dataSecond), FormIntake.ReadData(i, "I.Supervisor F Name", dataSecond),
                                            FormIntake.ReadData(i, "I.Supervisor M Initial", dataSecond), FormIntake.ReadData(i, "I.Supervisor L Name", dataSecond), FormIntake.ReadData(i, "I.Supervisor Ph No", dataSecond),
                                            FormIntake.ReadData(i, "Same as reporting party", dataSecond), FormIntake.ReadData(i, "RP F Name", dataSecond), FormIntake.ReadData(i, "RP M Initial", dataSecond),
                                            FormIntake.ReadData(i, "RP L Name", dataSecond), FormIntake.ReadData(i, "Notified Supervisor", dataSecond), FormIntake.ReadData(i, "Supervisor F Name", dataSecond),
                                            FormIntake.ReadData(i, "Supervisor M Name", dataSecond), FormIntake.ReadData(i, "Supervisor L Name", dataSecond), FormIntake.ReadData(i, "Notification Date", dataSecond),
                                            FormIntake.ReadData(i, "Time HH", dataSecond), FormIntake.ReadData(i, "Time MM", dataSecond), FormIntake.ReadData(i, "Time AmPM", dataSecond), FormIntake.ReadData(i, "Notification Method", dataSecond));
                    Console.WriteLine("Third page");

                    addData.FillThirdPage(thirdPageList.Where(data => data.NOC == i.ToString()));


                    Console.WriteLine("Fourth page");
                    addData.FillFourthPage(fourthPageList.Where(data => data.NOIP == i.ToString()));


                    Console.WriteLine("Fifth page");
                    addData.FillFifthPage(fifthPageList.Where(data => data.NOW == i.ToString()));


                    Console.WriteLine("Sixth Page");

                    addData.FillSixthPage(FormIntake.ReturnDate(), FormIntake.ReadData(i, "Nature of complaint", dataSixth),
                                            FormIntake.ReadData(i, "Reason for occurance", dataSixth));
                    Console.WriteLine("Seventh Page");

                    addData.FillSeventhPage(FormIntake.ReadData(i, "Race / Ethnicity", dataSeventh), FormIntake.ReadData(i, "Gender", dataSeventh),
                                            FormIntake.ReadData(i, "DOB", dataSeventh));
                    Console.WriteLine("Eighth Page");

                    addData.FillEighthPage(FormIntake.ReadData(i, "Email Conformation", dataEighth), FormIntake.ReadData(i, "Email Address", dataEighth),
                                            FormIntake.ReadData(i, "Secuity Check", dataEighth));


                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }



                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            // PropertiesCollection.driver.Close();

        }



        [TearDown]
        public void CleanUp()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
            PropertiesCollection.driver.Close();

            Console.WriteLine("Close the browser");
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