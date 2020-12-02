Feature: PostValidRequest


@mytag
Scenario: Get Valid post request
	Given the first name is morpheus
	And job is leader
	When we create a user
	Then we should see a success response code