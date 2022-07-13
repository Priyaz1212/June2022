using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();
// Maximize chrome browser
driver.Manage().Window.Maximize();

//Launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify the Username Text box
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
//Send inputusername
usernametextbox.SendKeys("hari");


//Identify the Password Text box
IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

//Identify the Login Button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//Check if the user successfully logged in
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in Sucessfully,Test passed");
}
else 
{ 
    Console.WriteLine("Login failed, Test failed"); 
}

//--------------07072022---------------------
//Navigate to Administration > Time and Material
IWebElement adminDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminDropDown.Click();

//Open Time & Materials
IWebElement tmDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmDropDown.Click();


//Click Create New
IWebElement createNewTxtBox = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewTxtBox.Click();

//input Code TextBox
IWebElement codeTxtBox = driver.FindElement(By.Id("Code"));
codeTxtBox.SendKeys("Test12");

//input Code TextBox
IWebElement descTxtBox = driver.FindElement(By.Id("Description"));
descTxtBox.SendKeys("Test12Desc");

//input Code TextBox
IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceTag.Click();

// input price
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("6456");

// click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

// go to the last page
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastPageButton.Click();


// check if material record has been created successfully
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "Test12")
{
    Console.WriteLine("New record created successfully.");
}
else
{
    Console.WriteLine("New Record not created");
}
///Edit Functionality
///
// go to the last page
IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastPageButton1.Click();

IWebElement lastRecEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")); 
lastRecEdit.Click();

//input Code TextBox
IWebElement codeTxtBox1 = driver.FindElement(By.Id("Code"));
codeTxtBox1.Clear();
codeTxtBox1.SendKeys("Test12New");

//input Code TextBox
IWebElement descTxtBox1 = driver.FindElement(By.Id("Description"));
descTxtBox1.Clear();
descTxtBox1.SendKeys("Test12DescNew");

//input Code TextBox
IWebElement priceTag1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceTag1.Click();

// input price
IWebElement priceTextbox1 = driver.FindElement(By.Id("Price"));
priceTextbox1.Clear();
priceTag1.Click();
priceTextbox1.SendKeys("645653");

// click on save button
IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
saveButton1.Click();
Thread.Sleep(3000);

//Delete
//Go to Last Page
// go to the last page
IWebElement goToLastPageButton3 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastPageButton3.Click();

IWebElement deletRecLast = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deletRecLast.Click();

driver.SwitchTo().Alert().Accept();


