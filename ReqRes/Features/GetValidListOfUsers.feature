Feature: GetValidRequestForListOfUsers

	@mytag
Scenario:Get API Response for list of users
    Given I have a endpoint /endpoint/
	Then I call get method of api
	And I get API response in json format with list of users