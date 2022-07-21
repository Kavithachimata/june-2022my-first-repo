Feature: TM featureEdit

As a TurnUp portal Admin
I would like to Creare, Edit and Delete time and meterial recors
so that I can manage employees ''Time and meterial' successfully

Scenario: Edit existed meterial record with valid details
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Meterial page,  I edit existed meterial record
	Then The record should be edited sucessfully
