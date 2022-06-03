Feature: CreateUser
	

#Scenario: Add a user
#	Given I Input name "Mike"
#	And I Input job "OQ"
#	When I send create user request
#	Then validate user is created

Scenario: Get BPMS Case
	Given I have an Identity Jwt
	#And I have a Consumer JWT for TestConsumer
	#And I have a GetCase URL
	#| Key |  Value |
	#|  Endpoint   |   endpoint   |
	#And I set query string with below parameters
	#| Key  | Value      |
	#| ID | caseid |
	#| LookupClassName | casename |
	#| ClassName | domain-CS-Work-RL-HomeLoanEnquiry |
	#When I make a GET request
	#Then the response status code should be OK