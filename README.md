# monetary-code-challange
## Description
This is a my implementation of the received code challange. This is for demo purposes only.

## Table of contents
Project breakdown of the solution: 
- Monetary.Service : ASP.NET Core-based WEB API for the REST Endpoint.
Swagger is located in the default URL: https://localhost:44345/

- Monetary.Common: Interfaces, models, enums that are commonly used in the solution.
- Monetary.Assessment: Implementation of the IAssessment interface, which used to assest the credit decision and interest rate.
- Monetary.Decision: Implementation of the IDecision interface, which is used to decide if the user can have the desired credit amount.
- Monetary.InterestRate: Implementation of the IInterestRate interface, which is used to calculate the interface.
- Monetary.Tests: Unit tests.

## Usage
Set the startup project to Monetary.Service and debug the solution. 
