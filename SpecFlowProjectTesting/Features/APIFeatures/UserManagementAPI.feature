Feature: UserManagementAPI

A short summary of the feature

@tag1
  Scenario: Register a new account
    Given I have a registration request with username "testuser" and password "Test@1234"
    When I send a registration request
    Then the registration should be successful

  Scenario: Login with valid credentials
    Given I have login credentials with username "testuser" and password "Test@1234"
    When I send a login request
    Then I should receive a token