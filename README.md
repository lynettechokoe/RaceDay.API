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