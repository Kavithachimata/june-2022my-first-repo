Feature: TMFeature

As a TurnUp portal Admin
I would like to Creare, Edit and Delete time and meterial recors
so that I can manage employees ''Time and meterial' successfully

Scenario: Create meterial record with valid details
	Given I logged into TrnUp portal successfully
	When  I navigate to Time and Meterial page
	And   I create new meterial record
	Then  The record should be created sucessfully
