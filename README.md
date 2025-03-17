
# SimpleTranslator
Yet Another Simple Translator


- [SimpleTranslator](#simpletranslator)
  - [Overview](#overview)
  - [Getting Started](#getting-started)
    - [Check Web App on Azure Cloud](#check-web-app-on-azure-cloud)
    - [Run using Docker Hub](#run-using-docker-hub)
    - [Prerequisites](#prerequisites)
    - [Required Packages and Tools](#required-packages-and-tools)
    - [Google Cloud Authentication](#google-cloud-authentication)
    - [Running the Project](#running-the-project)
  - [Web App UI](#web-app-ui)
    - [Homepage](#homepage)
    - [Translation Page](#translation-page)
  - [API Docs](#api-docs)
  - [Unit Tests and Coverage](#unit-tests-and-coverage)
    - [Running Unit Tests](#running-unit-tests)
    - [Generate The Coverage Rport](#generate-the-coverage-rport)
    - [Coverage Report](#coverage-report)
  - [OOP Principles and Design Patterns](#oop-principles-and-design-patterns)
    - [OOP Principles](#oop-principles)
    - [OOP Design Pattern](#oop-design-pattern)
  - [Controllers Actions](#controllers-actions)
  - [Features in Program.cs](#features-in-programcs)
  - [Contact](#contact)

## Overview
SimpleTranslator is a ASP.NET core MVC (v9) application designed to provide English to French translation. The project is backed by Google Cloud AI Translation service. It uses the [basic version](https://cloud.google.com/translate/docs/basic/translating-text) of [Google Cloud Translation API](https://console.cloud.google.com/apis/api/translate.googleapis.com/metrics?hl=en&inv=1&invt=AbruXA&project=rival-translator). This README provides instructions on how to run the project, execute unit tests, and explains the OOP design of the models, the actions of the controllers, and the features implemented in `Program.cs`.

## Getting Started

### Check Web App on Azure Cloud
An instance of the .NET Core web applciation is running on Azure Cloud:
![Azure Portal Screenshot](https://github.com/user-attachments/assets/f2480c73-3516-400f-ace4-5f635e6cf6b8)

You can test it by opening the following URL: https://simple-translate.azurewebsites.net/

### Run using Docker Hub
A Docker image is available in [this public repository](https://hub.docker.com/r/may05/simple-translator-image). To run using your Docker Desktop, pull the image uinsg the following command:
```sh
docker pull may05/simple-translator-image:latest
```
Then run with the following command:
```sh
docker run --env=GOOGLE_APPLICATION_CREDENTIALS=/App/rival-translator-e11f22b79f4b.json -p 5000:8080 -d may05/simple-translator-image
```

### Prerequisites
- .NET Core installed on your machine
- A code editor like Visual Studio or Visual Studio Code

### Required Packages and Tools
- Google Cloud Service: ```dotnet add package Google.Cloud.Language.V1```
- Moq: ```dotnet add {PATH_TO_SOLUTION}/SimpleTranslator/SimpleTranslator.Tests package Moq```
- xUnit: ```dotnet new install xunit.v3.templates```
- [ReportGeneratoor](https://github.com/danielpalme/ReportGenerator)

### Google Cloud Authentication
You need to set "the environment variable GOOGLE_APPLICATION_CREDENTIALS to the path of the JSON file that contains your credentials. This variable applies only to your current shell session, so if you open a new session, set the variable again." For dev purpose, a service account key was created from Google Cloud dahsboard and saved as a json file.

More info:
*  [Enable Google Translation API](https://cloud.google.com/translate/docs/setup)
*  [Authenticate to Cloud Translation](https://cloud.google.com/translate/docs/authentication)
*  [Setup Authentication in Local Dev Environment](https://cloud.google.com/docs/authentication/set-up-adc-local-dev-environment#local-key).

To add Google Cloud authentication to a Docker image:
```sh
gcloud auth activate-service-account --key-file=MY_KEY_FILE.json
```

Then pass the path as an environment variable of the image during docker image creation:
```sh
docker run -d -p 5000:8080 -e GOOGLE_APPLICATION_CREDENTIALS=/PATH/TO/SERVICE/ACCOUNT/KEY/FILE/rival-translator-e11f22b79f4b.json simple-translator-image 
```

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

## API Docs
The project uses Swagger UI to generate API docs. After running the project, you can access them using the URL http://localhost:5239/swagger/index.html


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

## OOP Principles and Design Patterns
### OOP Principles
The application implemenets essential OOP concepts and design principles. The main models include:
- Abstraction:
- Encapsulation:
- Inheritence: 
- Polymorphism:

### OOP Design Pattern
The Translator Class follows the `Singlton` design pattern. This pattern was selected to ensure inilizing a single static translation object that will be reused for all web requests.


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
