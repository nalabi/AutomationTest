Feature: UserLogin
	Login Check in
Background: 
 Given I loging with a registered user 
@mytag @positive
Scenario: Check Login with a correct username and Password
	Given I am in the Hotrave Web Login Page
	When I enter UserName and Password 
	| UserName             | Password            |
	| nalabi@webmail.co.za | #@Ntuli0123456789%$ |
	Then I click login button