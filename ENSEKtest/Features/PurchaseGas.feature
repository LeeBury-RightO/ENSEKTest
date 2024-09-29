Feature: PurchaseGas

As a user I should be able to purchase units of Gas

@tag1
Scenario: User purchases 100 units of gas
	Given I am on the main page
	And I click on the buy energy button
	When I enter an amount of gas and click buy
	Then I am taken to the confirmation page showing the amount of gas i purhcased and amount remaining
