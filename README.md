# C# Learning Portfolio

A collection of C# projects for learning and experimentation.

## Projects

### 1. ConsoleApp - Character Builder
A simple console application that generates random character stats for RPG characters.

**Features:**
- Interactive character creation (name, race, class)
- Random stat generation (strength, dexterity, intelligence, speed, constitution, wisdom, charisma)
- Continuous character generation loop

### 2. Web API - Weather Service
A minimal ASP.NET Core Web API that provides weather data using the OpenWeatherMap API.

**Features:**
- Weather endpoint that accepts latitude and longitude coordinates
- Static file serving for frontend
- Dependency injection for HttpClient and configuration
- Swagger/OpenAPI documentation

## Prerequisites

- .NET 8.0 SDK
- Git

## How to Run Locally

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd csharplearning
   ```

### Running the Console Application

```bash
cd ConsoleApp
dotnet run
```

### Running the Web API

```bash
cd web-api
dotnet run
```

The API will be available at `https://localhost:5001` or `http://localhost:5000`.

**API Endpoint:**
- `GET /weather?lat={latitude}&lon={longitude}` - Get weather data for coordinates

**Note:** The weather API requires a valid OpenWeatherMap API key configured in `appsettings.json`.

## Project Structure

```
csharplearning/
├── ConsoleApp/          # Character builder console application
├── web-api/            # Weather API web application
└── README.md           # This file
```