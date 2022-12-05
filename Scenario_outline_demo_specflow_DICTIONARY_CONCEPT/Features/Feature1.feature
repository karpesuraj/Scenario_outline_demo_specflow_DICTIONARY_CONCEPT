Feature: LogIn_Feature
	In order to access my account
    As a user of the website
   I want to log into the website

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the Home Page
	And Navigate to LogIn Page
	When User enter credentials
	| Key       | Value      |
	| Username  | pravin     |
	| Password  | pravin@123 |
	| Username1 | aakash     |
	| Password1 | aakash@123 |
	| Username3 | komal      |
	| Password3 | sanjay     |
	| Orderid | santosh123     |
	| Productid | santosh99123     |
	And Click on the LogIn button
	Then Successful LogIN message should display

Scenario: Successful LogOut
	When User LogOut from the Application
	Then Successful LogOut message should display

