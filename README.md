# SimpleTranslator
Yet Another Simple Translator

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

![alt text](https://github.com/user-attachments/assets/e4b92630-1651-44e4-a30b-a3b352d827d6)
![alt text](https://github.com/user-attachments/assets/cfafff8e-314f-4883-bb88-7c0394b2c7c9)
![alt text](https://github.com/user-attachments/assets/613d8333-cc3a-4b45-948a-74f354276ef0)

## Running Unit Tests
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


## Models OOP Design
The application implemenets essential OOP concepts and design principles. The main models include:
- Abstraction:
- Encapsulation:
- Inheritence: 
- Polymorphism:


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
