# RaceDay.API
Part 2 - RESTful API

### Setup Instructions
1. Clone repo
2. Open `RaceDay.sln` in Visual Studio
3. Run `Update-Database` in Package Manager Console
4. Press F5 to start the API
5. Navigate to `/swagger` for the API UI

### Roles
- **Organiser**: Can create/update/delete events, manage categories, capture results
- **Participant**: Can view events, enroll in events, view own results
![Build Status] https://github.com/lynettechokoe/RaceDay.API.git
# 🏁 RaceDay API - RESTful API Development

![Build Status](https://github.com/YOUR-USERNAME/RaceDay/actions/workflows/ci.yml/badge.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-blue)
![License](https://img.shields.io/badge/License-Academic-green)

A production-grade RESTful API for the **RaceDay event management system**, built with **ASP.NET Core Web API**, **Entity Framework Core**, and **SQL Server**.

This API serves as the backbone of the RaceDay platform — handling authentication, event management, participant enrollments, and race results. It is designed to be consumed by the MVC frontend built in Part 3.

---

## 📖 Table of Contents

- [Project Overview](#-project-overview)
- [Technologies Used](#-technologies-used)
- [System Architecture](#-system-architecture)
- [Getting Started](#-getting-started)
- [Authentication & Authorization](#-authentication--authorization)
- [API Endpoints](#-api-endpoints)
- [Testing the API with Swagger](#-testing-the-api-with-swagger)
- [Unit Tests](#-unit-tests)
- [CI/CD Pipeline](#-cicd-pipeline)
- [Project Structure](#-project-structure)
- [Troubleshooting](#-troubleshooting)
- [Author](#-author)

---

## 🎯 Project Overview

The **RaceDay API** is a RESTful backend service that allows:

- **Organisers** to create and manage sporting events (runs, walks, cycles)
- **Participants** to register and enroll in events
- **Role-based access control** ensuring data security
- **Race result tracking** for participants

This API was built as **Part 2 of the Programming 2B POE (Portfolio of Evidence)**.

---

## 🛠 Technologies Used

| Technology | Version | Purpose |
|------------|---------|---------|
| **ASP.NET Core Web API** | 8.0 | RESTful API framework |
| **Entity Framework Core** | 8.0.8 | ORM for database operations |
| **SQL Server** | 2022 / LocalDB | Relational database |
| **JWT Bearer** | 8.0.8 | Token-based authentication |
| **BCrypt.Net-Next** | 4.0.3 | Password hashing |
| **Swashbuckle (Swagger)** | 6.5.0 | Interactive API documentation |
| **xUnit** | Latest | Unit testing framework |
| **Moq** | 4.20.72 | Mocking framework |
| **GitHub Actions** | — | CI/CD pipeline |

---

## 🏗 System Architecture

### Layers:
- **Controllers** — Receive HTTP requests, return responses
- **Services** — Handle business logic (authentication, hashing, JWT)
- **DTOs** — Data Transfer Objects for secure communication
- **Models** — Database entities
- **DbContext** — Entity Framework Core database context

---

## 🚀 Getting Started

### Prerequisites

- **Windows OS**
- **Visual Studio 2022** (Community Edition or higher)
- **.NET 8.0 SDK** — [Download](https://dotnet.microsoft.com/download)
- **SQL Server** (LocalDB or full instance)
- **Git** — [Download](https://git-scm.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone vhttps://github.com/lynettechokoe/RaceDay.API.git

   A complete, full-stack event management system for **RaceDay**. This repository contains the ASP.NET Core Web API (Part 2) and the ASP.NET Core MVC front-end (Part 3), fully containerized with Docker.

---

## 📖 Table of Contents

- [Project Overview](#-project-overview)
- [Technologies Used](#-technologies-used)
- [System Architecture](#-system-architecture)
- [Getting Started (Local Run)](#-getting-started-local-run)
- [Docker Instructions](#-docker-instructions)
- [Authentication & Roles](#-authentication--roles)
- [Feature Breakdown](#-feature-breakdown)
- [Azure Blob Storage](#-azure-blob-storage)
- [CI/CD Pipeline](#-cicd-pipeline)
- [Project Structure](#-project-structure)
- [Author](#-author)

---

## 🎯 Project Overview

The **RaceDay** platform allows sporting event organizers to create and manage events (runs, walks, cycles), and allows participants to browse and enroll in those events.

This solution is split into two main projects:
1. **`RaceDay.API` (Part 2):** A headless RESTful API handling all data operations, authentication, and Azure Blob Storage uploads.
2. **`RaceDay.MVC` (Part 3):** A dynamic front-end that consumes the API. It uses session management to handle user roles and provides distinct dashboards for Organisers and Participants.

---

## 🛠 Technologies Used

| Technology | Version | Purpose |
|------------|---------|---------|
| **ASP.NET Core Web API** | 8.0 | RESTful backend (Part 2) |
| **ASP.NET Core MVC** | 8.0 | Frontend web app (Part 3) |
| **Entity Framework Core** | 8.0.8 | ORM & Database migrations |
| **SQL Server** | 2022 / LocalDB | Relational database |
| **JWT Bearer** | 8.0.8 | Authentication |
| **Azure.Storage.Blobs** | 12.x | Cloud image storage |
| **Docker** | Latest | Containerization |
| **Bootstrap 5** | 5.x | Frontend styling |
| **xUnit & Moq** | Latest | Unit Testing |
| **GitHub Actions** | — | CI/CD Pipeline |

---

## 🏗 System Architecture

┌─────────────────────────┐ ┌─────────────────────────┐
│ RaceDay.MVC │ HTTP │ RaceDay.API │
│ (Front-End) │ ───────> │ (Back-End) │
│ │ JSON │ │
│ - Session Management │ │ - JWT Auth │
│ - HTML/CSS/Bootstrap │ │ - Entity Framework │
│ - Consumes API │ │ - Azure Blob Storage │
└─────────────────────────┘ └─────────────────────────┘
│
▼
┌─────────────────────────┐
│ SQL Server │
│ Database │
└─────────────────────────┘

text

---

## 🚀 Getting Started (Local Run)

### Prerequisites
- Visual Studio 2022
- .NET 8.0 SDK
- SQL Server (LocalDB is fine)
- Docker Desktop (for containerization)

### Setup Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/YOUR-USERNAME/RaceDay.git
Open the solution:
Double-click RaceDay.sln to open it in Visual Studio.

Update the Database:

In Visual Studio, go to Tools → NuGet Package Manager → Package Manager Console.

Ensure the Default Project is set to RaceDay.API.

Run:

powershell
Update-Database
Configure API URL:

In RaceDay.MVC, open appsettings.json.

Ensure "ApiSettings": { "BaseUrl": "https://localhost:7123" } matches the port your API runs on.

Run the solution:

Right-click the Solution → Properties.

Select Multiple startup projects.

Set both RaceDay.API and RaceDay.MVC to Start.

Press F5.

🐳 Docker Instructions
The RaceDay.MVC application is fully containerized. A Dockerfile is included in the root directory.

How to run the container:
Ensure Docker Desktop is running on your machine.

Open a terminal (Command Prompt or PowerShell) in the root folder of the project.

Build the Docker image:

bash
docker build -t raceday-mvc -f RaceDay.MVC/Dockerfile .
Run the container:

bash
docker run -d -p 8080:8080 -p 8081:8081 --name raceday-app raceday-mvc
Open your browser and navigate to: http://localhost:8080

🔐 Authentication & Roles
The platform uses Session Management to store the JWT Token and User Role upon login.

Organiser
Access to the Organiser Dashboard.

Can create, edit, and delete events.

Can upload event banner images (via Azure Blob Storage).

Can define age/distance categories.

Can capture results for participants.

Participant
Access to the Participant Dashboard.

Can browse and filter upcoming events.

Can enroll in events.

Can view their personal race history and results.

Can update their profile and profile picture.

✨ Feature Breakdown
Part 3 Implemented Features:
Session-Based Auth: User state is maintained across pages using ASP.NET Core Sessions.

Role-Specific UI: Organisers and Participants see completely different navigation menus and dashboards.

Dynamic API Calls: MVC uses HttpClient to fetch data from the Part 2 API. No direct database access exists in the MVC project.

Graceful Error Handling: Validation messages are displayed if the API returns errors (e.g., invalid login).

☁️ Azure Blob Storage
File handling is done entirely through the API.

The MVC front-end sends an IFormFile to the API.

The API receives the file, connects to Azure Blob Storage, creates a container (event-images), and uploads the file.

The API returns the public URL of the uploaded image.

The MVC app displays the image using the returned URL.

🔄 CI/CD Pipeline
This project uses GitHub Actions for continuous integration.

Workflow: Triggers on every push to main or part3-mvc.

Build: Builds both RaceDay.API and RaceDay.MVC in Release mode.

Test: Runs all xUnit tests.

CI Status:
https://ci-success.png/

📂 Project Structure
text
RaceDay/
├── .github/workflows/ci.yml     ← GitHub Actions
├── RaceDay.API/                 ← Part 2 (Web API)
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   └── Program.cs
├── RaceDay.MVC/                 ← Part 3 (Frontend)
│   ├── Controllers/             ← Account, Organiser, Participant
│   ├── Views/                   ← HTML Pages
│   ├── Services/                ← ApiService (HttpClient logic)
│   └── Program.cs
├── Dockerfile                   ← Docker configuration
├── ci-success.png
└── README.md
👤 Author
Name: [Your Full Name]
Student Number: [Your Student Number]
Module: PROG 2B — Programming 2B
Institution: The Independent Institute of Education (IIE)
Year: 2026

📄 License
This project is submitted as part of academic requirements for Programming 2B (PROG 2B) at The IIE. All rights reserved.

Built with ❤️ in South Africa — Ready, Set, RaceDay! 🏁

text

---

## 🚀 Getting Started (Local Run)

### Prerequisites
- Visual Studio 2022
- .NET 8.0 SDK
- SQL Server (LocalDB is fine)
- Docker Desktop (for containerization)

### Setup Steps

1. **Clone the repository:**
   ```bash
   git clone 