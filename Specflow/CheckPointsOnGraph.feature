

@mytag
Scenario: Checking grapph
	Given I open website with my graph
	When I move mouse  through graph I see dates
	| Point | Date          |
	| 1     | February 2010 |
	| 2     | March 2010    |
	| 3     | April 2010    |
	| 4     | May 2010      |
	| 5     | June 2010     |
	Then I verify dates
