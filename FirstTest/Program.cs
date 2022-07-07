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

