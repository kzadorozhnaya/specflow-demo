Feature: SpecFlowMenuTests1
	In order to easily find needed documentation
	As a specflow user
	I want to be able to navigate to pages through main menu

@smoke
Scenario Outline: Clicking menu option from the main menu should open corresponding page1
	Given I open official SpecFlow web site
	When I hover the '<menuItem>' menu item from the main menu
	And I click '<subMenuItem>' option from the main menu
	Then Page with '<title>' title should be opened

	Examples: 
	| menuItem | subMenuItem     | title           |
	| Why BDD? | BDD Intro       | What is BDD?    |