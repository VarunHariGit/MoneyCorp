# MoneyCorp - Automation Framework to Validate MoneyCorp Site using Selenium with C# programming language

Steps followed for Framework & Tests:

•	Download and install Visual Studio IDE to run the automation
•	Create a new Project
•	Set Up Selenium with Visual Studio in C#
•	Chromedriver from selenium to be installed
•	Create a new Package
•	Set Up NUnit & Test Adapter
•	Create the POM framework with following details:
  •	Base Class - Including Launch Chrome Browsers & Quit Browsers function
  •	Page Class - Including the Methods and associated Elements 
  •	ObjectRepository Class - Including different Locators definition 
  •	Test Data Class - Including set of data to be used by Tests
  •	Scenarios Class - Including calling of all the methods defined in Page class and its assertions


Benefits of POM Framework:
•	Reusability of code
•	Easy to maintain the code
•	Eliminate duplicate code
•	Data Driven Test
•	Optimized code
•	Simplifying the visualization and model of the web page under test


Further Enhancements that can be incorporated:
•	BDD Framework integration to write test in Gherkin language.
•	Create logging Mechanism
•	Generate HTML reports when test is executed
