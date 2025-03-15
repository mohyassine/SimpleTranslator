# SimpleTranslator

## Overview
SimpleTranslator is a .NET application designed to provide translation services. This README provides instructions on how to run the project, execute unit tests, and explains the OOP design of the models, the actions of the controllers, and the features implemented in `Program.cs`.

## Getting Started

### Prerequisites
- .NET SDK installed on your machine
- A code editor like Visual Studio or Visual Studio Code

### Required Packages and Tools

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

## Running Unit Tests
1. Navigate to the test project directory:
    ```sh
    cd SimpleTranslator.Tests
    ```
2. Run the tests:
    ```sh
    dotnet test
    ```

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
