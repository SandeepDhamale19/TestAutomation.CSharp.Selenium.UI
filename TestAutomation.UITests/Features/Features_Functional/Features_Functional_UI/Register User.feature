Feature: Register User
	In order to get access to book store
	As a New user
	I want to be registered to Demo QA application

Background: 
	When I access Book store Application

@browser @functional
Scenario: Verify UI for registration page
	Given I Navigate to registration form
	Then I should be able to view desired fields

@browser @functional
Scenario Outline: Register to Demo QA application
	Given I Navigate to registration form
	And I provide required details <firstname>, <lastname>, <username> and <password>
	And I register myself to book store
	Then I should be registers successfully to book store
Examples: 
| firstname | lastname | username        | password  |
| Steve     | Rogers   | Captain America | MyP@ss123 |	