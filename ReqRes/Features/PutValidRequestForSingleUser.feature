Feature: PutValidRequestForSingleUser

@mytag
Scenario: Update Single User Details
	Given first name is george
	And id is "1"
	Then we update user job
	Then we should see success response code

