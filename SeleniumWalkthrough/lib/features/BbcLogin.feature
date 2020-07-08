Feature: BbcLogin
	In order to login into my account
	AS a user
	I want to be see my account page

@login
Scenario: Invalid passwords - all digits
	Given I am on the login page
		And I have entered a username of "testing@xquz.col"
		And I have entered a password of "12345678"
	When I press login
	Then I should see the password error message "Sorry, that password isn't valid. Please include a letter."

@login
Scenario: Invalid passwords - too short
	Given I am on the login page
		And I have entered a username of "testing@xquz.col"
		And I have entered a password of "hi"
	When I press login
	Then I should see the password error message "Sorry, that password is too short. It needs to be eight characters or more."

@login
Scenario: Invalid email - no account
	Given I am on the login page
		And I have entered a username of "testing@gamil.com"
		And I have entered a password of "hello1234"
	When I press login
	Then I should see the email error message "Sorry, we can’t find an account with that email. You can register for a new account or get help here."

@login
Scenario:  Need help
    Given I am on the login page
    When I press Need help signing in
    Then I should be redirected to the Need Help Signing In Page

@login
Scenario: Register now
	Given I am on the login page
	When I press Register now
	Then I should be redirected to the Register Page