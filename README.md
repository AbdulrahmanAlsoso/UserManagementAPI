# User Management API

This project is a simple **User Management API** built with **ASP.NET Core**. The API provides basic CRUD operations for managing users, including creating, reading, updating, and deleting user records. It also includes middleware for logging, error handling, and authentication.

## Features
- **CRUD Operations**: Create, Read, Update, and Delete user records.
- **Logging Middleware**: Logs all incoming requests and outgoing responses.
- **Authentication Middleware**: Secures the API using token-based authentication.
- **Error Handling Middleware**: Catches unhandled exceptions and returns consistent error responses.
- **Swagger Integration**: Provides an interactive UI for testing the API.

## Tech Stack
- **ASP.NET Core** 6.0 (or higher)
- **Swagger UI** for API documentation
- **JWT Token Authentication** for securing endpoints
- **Middleware** for logging and error handling

## Getting Started

Follow these steps to run the application locally.

### Prerequisites

Before starting, make sure you have the following tools installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or higher)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.microsoft.com/)
- [Postman](https://www.postman.com/) or any API testing tool

### Clone the Repository

Clone this repository to your local machine using the following command:

```bash
git clone https://github.com/AbdulrahmanAlsoso/UserManagementAPI.git
Install Dependencies
Navigate to the project directory and restore the dependencies:

bash

cd UserManagementAPI
dotnet restore
Running the Application
To run the application locally, use the following command:

bash

dotnet run
By default, the application will run on http://localhost:5000.

Testing the API
You can test the CRUD endpoints using tools like Postman or Swagger UI.

GET /api/users: Retrieves all users.
GET /api/users/{id}: Retrieves a specific user by ID.
POST /api/users: Creates a new user.
PUT /api/users/{id}: Updates an existing user's details.
DELETE /api/users/{id}: Deletes a user by ID.
Authentication
This API uses JWT Token Authentication. To access secured endpoints, you must send a valid token in the Authorization header.

Example of how to send a token in Postman:

Add a Authorization header with the value: Bearer {your_token_here}.
Swagger UI
Once the application is running, you can access the Swagger UI at the following URL:

arduino
ن
http://localhost:5000
Here, you can test the endpoints directly from the browser.

Middleware
This API includes the following middleware:

LoggingMiddleware: Logs HTTP requests and responses, including HTTP method, request path, and response status code.
ErrorHandlingMiddleware: Catches unhandled exceptions and returns a consistent error response.
AuthenticationMiddleware: Validates JWT tokens and ensures secure access to protected routes.
API Endpoints
Method	Endpoint	Description
GET	/api/users	Retrieve all users.
GET	/api/users/{id}	Retrieve a specific user by ID.
POST	/api/users	Add a new user.
PUT	/api/users/{id}	Update an existing user's information.
DELETE	/api/users/{id}	Delete a user by ID.
Project Structure
scss

/UserManagementAPI
├── /Controllers
│   └── UsersController.cs
├── /Middleware
│   └── ErrorHandlingMiddleware.cs
│   └── LoggingMiddleware.cs
│   └── AuthenticationMiddleware.cs
├── /Models
│   └── User.cs
├── /Services
│   └── UserService.cs
├── Program.cs
└── Startup.cs (if applicable)
How to Deploy
To deploy this API to a production environment:

Set up your production server with .NET Core installed.
Publish the application using the dotnet publish command.
Configure a reverse proxy (e.g., Nginx or Apache) to route requests to the application.
Configure your authentication service (e.g., JWT) in production settings.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgments
ASP.NET Core Documentation: https://docs.microsoft.com/en-us/aspnet/core/
Swagger: https://swagger.io/
JWT Authentication: https://jwt.io/
markdown