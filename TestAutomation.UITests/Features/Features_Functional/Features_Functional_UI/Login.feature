Feature: Login
	In order to access to book store application
	As a registered user
	I want to be login to Book store application

Background: 
	When I access Book store Application

@browser @functional
Scenario: Verify UI for login page
	Given I Navigate to login page
	Then I should be able to view desired fields for login page