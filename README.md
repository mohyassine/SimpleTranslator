
# SimpleTranslator
Yet Another Simple Translator

- [Overview](#overview)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Required Packages and Tools](#required-packages-and-tools)
  - [Running the Project](#running-the-project)
- [Web App UI](#web-app-ui)
  - [Homepage](#homepage)
  - [Translation Page](#translation-page)
- [Unit Tests and Coverage](#unit-tests-and-coverage)
  - [Running Unit Tests](#running-unit-tests)
  - [Generate The Coverage Rport](#generate-the-coverage-rport)
  - [Coverage Report](#coverage-report)
- [Models OOP Design](#models-oop-design)
- [Singlton Design Pattern](#singlton-design-pattern)
- [Controllers Actions](#controllers-actions)
- [Features in Program.cs](#features-in-programcs)
- [Contact](#contact)

## Overview
SimpleTranslator is a .NET application designed to provide translation services. This README provides instructions on how to run the project, execute unit tests, and explains the OOP design of the models, the actions of the controllers, and the features implemented in `Program.cs`.


## Getting Started

### Prerequisites
- .NET Core installed on your machine
- A code editor like Visual Studio or Visual Studio Code

### Required Packages and Tools
- Google Cloud Service
- Moq
- xUnit
- Coverlet
- [ReportGeneratoor](https://github.com/danielpalme/ReportGenerator)

### Running the Project
1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/SimpleTranslator.git
    ```
2. Navigate to the project directory:
    ```sh
    cd SimpleTranslator
    ```
3. Restore the dependencies:
    ```sh
    dotnet restore
    ```
4. Build the project:
    ```sh
    dotnet build
    ```
5. Run the application:
    ```sh
    dotnet run
    ```

## Web App UI
The app has a simple 2-pages UI - Home page and Translate page

### Homepage
![Homepage - UI](https://github.com/user-attachments/assets/2ac7d313-a5fb-419c-922e-b3cd84e6f866)

### Translation Page
![Translation Page - UI](https://github.com/user-attachments/assets/cfb494b0-fd64-4452-a398-136362b7fb15)

## Unit Tests and Coverage
The project includes several unit tests. I wrote the musing xUnit framwork. It also has a testing coverage report included. The following show how to run the unit tests and generate the coverage report.

### Running Unit Tests
1. Navigate to the test project directory:
    ```sh
    cd SimpleTranslator.Tests
    ```
2. Run the tests:
    ```sh
    dotnet test
    ```
3. To Run tests with coverage data collection:
    ```sh
    dotnet test --collect:"XPlat Code Coverage"
    ```
![alt text](https://github.com/user-attachments/assets/b717f249-0a34-4676-9e94-4e4a803c32fe)

### Generate The Coverage Rport
1. Make sure to run the test with coverage data collection option enabled as in step 3 of the previous section
2. Install the coverage generation tools:
    ```sh
    dotnet tool install -g dotnet-coverage
    dotnet tool install -g dotnet-reportgenerator-globaltool
    ```
3. Generate an HTML using ReportGenerator tool:
    ```sh
    reportgenerator -reports:"./TestResults/64a9a3e3-ec57-4152-96e4-61b67fed056a/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
    ```
### Coverage Report
You can check the generated HTML report under folder *SimpleTranslator.Tests/coveragereport* Here is how the generated report looks like
![alt text](https://github.com/user-attachments/assets/cfafff8e-314f-4883-bb88-7c0394b2c7c9)

The following screenshot show the coverage per Class:
![alt text](https://github.com/user-attachments/assets/e4b92630-1651-44e4-a30b-a3b352d827d6)

The following shows coverage details for Class *HomeController.cs*
![alt text](https://github.com/user-attachments/assets/613d8333-cc3a-4b45-948a-74f354276ef0)

## Models OOP Design
The application implemenets essential OOP concepts and design principles. The main models include:
- Abstraction:
- Encapsulation:
- Inheritence: 
- Polymorphism:

## Singlton Design Pattern
The Translator Class follows the Singlton design pattern. This pattern was selected to ensure inilizing a single static translation object that will be reused for all web requests.


## Controllers Actions
The controllers handle HTTP requests and provide endpoints for the translation services. Key actions include:
- `Translate`: returns a view with ViewData containing the translated text.

## Features in Program.cs
The `Program.cs` file configures and starts the application. Key features include:
- Setting up dependency injection for services.
- Configuring middleware for request handling.
- Add Swagger API documentation.
- Defining the routing for the application.

## Contact
For any questions or feedback, please contact yassine.moh@gmail.com.
