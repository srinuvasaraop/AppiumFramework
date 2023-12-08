Feature: Takemedemomode

A short summary of the feature
1. whenerver we are launching the app we will move enter the demo mode
2. and validate the price validation of Hearing devices prompt is appeared ? or not ?
3. Price point of His prompt will be displayed only once at the fresh installation

@tag1
Scenario:Entering into demo mode and HA's price point validation
	Given I am in 'welome screen' after installing app
	When I click on 'No, take me to demo mode'
	Then Validate the Demo mode Price point prompt will be dispalyed for the first time

