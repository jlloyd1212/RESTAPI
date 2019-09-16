@RestTesting
Feature: RESTAPI
	

@APITest
Scenario: Get API response using given endpoint

	Given I have an endpoint '<endpoint>'
	When I call get method of API
	Then I get API response in json format

@Test2
Scenario Outline: Call a userID

	Given I have an endpoint '<endpoint>'
	When I call get method to get user information using <userid>
	Then I get user information

Examples: User Info
	|userid|
	|user10001|
	