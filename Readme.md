# FsMongoExample

A small project dedicated to learning **F#** and exploring its capabilities while interacting with **MongoDB**.

## Goal
The primary objective of this project is to get hands-on experience with F# syntax, functional programming paradigms, and integrating with external databases like MongoDB. It serves as a playground for trying out "cool things" and experimental features.

## Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/) and Docker Compose

## Getting Started

### 1. Start MongoDB
The project uses Docker Compose to spin up a local MongoDB instance.
```bash
docker-compose up -d
```

### 2. Run the Application
Once the database is running, you can start the F# application:
```bash
dotnet run
```

### 3. Build an Executable
To create a release-ready executable, you can use the provided build script or the .NET CLI directly.

**Using the script:**
```bash
./build.sh
```

**Using the .NET CLI:**
```bash
dotnet publish -c Release -o ./publish
```

The executable and dependencies will be placed in the `./publish` directory. You can run it with:
```bash
./publish/FsMongoExample
```

## Features (Current)
- Connection to a MongoDB instance with authentication.
- Verification of the connection via a "ping" command.
- Listing of all databases available on the server.

## Future Ideas
- Implementing a full CRUD (Create, Read, Update, Delete) module.
- Exploring F# Type Providers (if applicable).
- Adding asynchronous operations with F# `async` workflows or Task-based async.
