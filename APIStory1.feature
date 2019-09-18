@RestTesting
Feature: RESTAPI
	
@APITest
Scenario: Get API response using given endpoint

	Given I have an endpoint
	When I call get method of API
	Then I get API response in json format

@Test2
Scenario Outline: Call a userID

	Given I have an endpoint
	When I call get method to get user information using '<userid>'
	Then I get user information

Examples: User Info
	|userid|
	|user10001|

@Test3
Scenario Outline: Get User account information using userid and account number

	Given I have an endpoint
	When I call get method for user account information using '<userid>' and '<accountNumber>'
	Then I am able to get user account information
	
Examples: User Data
| userid		  | accountNumber |
| user10002       | 5435945161212 |

@Test4
Scenario: User Registration for a given endpoint

	Given I have an endpoint
	When I call a Post method to register a user
	Then user will be registered successfully
