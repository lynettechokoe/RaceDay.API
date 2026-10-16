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
![Build Status]
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
