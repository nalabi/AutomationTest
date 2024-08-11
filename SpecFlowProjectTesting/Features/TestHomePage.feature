Feature: Home Page Landing
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectTesting/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Navigate Home Page and acess the Hotrave Page
	Given I am on the landing page
    Then I should see the title "Welcome to Our Site"
    And I should see a call-to-action button
    And I should see the navigation menu