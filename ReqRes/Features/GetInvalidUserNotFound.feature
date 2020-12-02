Feature: GetInvalidUserNotFound


	@mytag
	Scenario:Get API Response for a invalid users
    Given I have endpoint endpoint
	Then I call get api method
	And I get API response as user not found 