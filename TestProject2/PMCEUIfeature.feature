Feature: PMCEUIfeature
	Tests EUI feature 

@mytag
Scenario: PMC EUI Submit test
	Given User Navigates to "www.dell.com/preferences/listremoval"
	When User input text ""
	When User Click on  submit ""
	Then the result should be "", closes the browser.