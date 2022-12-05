#Feature: LogIn_Feature
#	In order to access my account
#    As a user of the website
#   I want to log into the website
#
#//@mytag
#Scenario Outline: Successful Login with Valid Credentials
#	Given User is at the Home Page
#	And Navigate to LogIn Page
#	When User enter <username> and <password>
#	And Click on the LogIn button
#	Then Successful LogIN message should display
#Examples:
#| username   | password |
#| pravin | pravin@123 |
#| vaishali | vaishali@153 |
#| sanjay | sanjay@123 |
#| pranit | pranit@153 |
#
#Scenario: Successful LogOut
#	When User LogOut from the Application
#	Then Successful LogOut message should display
