Feature: GetValidRequestForOneUser


@mytag
Scenario:Get API Response for a valid endpoint
	Given I have an endpoint /endpoint/
	When I call get method of api
	Then i get API response in json format



	