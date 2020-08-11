Feature: HomePage
	In order to access to book store application
	As a valid user
	I want to be land to Book store application

@browser @functional
Scenario: Access Book store application
	Given I access Demo QA application
	And I navigate to store Application
	Then I am navigated to Book store 'https://demoqa.com/books'