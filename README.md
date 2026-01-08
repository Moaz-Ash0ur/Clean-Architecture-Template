# 🧱 Clean Architecture Template – .NET Core

A **production-ready Clean Architecture template** built with **ASP.NET Core** and **CQRS**, designed to help you start real-world backend projects quickly and correctly.

This template provides all common infrastructure and API concerns out of the box, allowing you to focus on **domain analysis and business logic**, not boilerplate setup.

---

## 📌 What is Clean Architecture?

Clean Architecture is an architectural approach that aims to:

- Make the **Domain the core of the system**
- Isolate business logic from technical and framework concerns
- Enforce **dependency flow from outer layers to inner layers**
- Improve maintainability, testability, and scalability

### 🔁 Dependency Rule

All dependencies must point **inward**:

- **Domain** → depends on nothing
- **Application** → depends only on Domain
- **Infrastructure** → depends on Application & Domain
- **API** → depends on Application

🎯 The main goal is to **fully isolate the Domain** from databases, frameworks, and external services.

---

## 🧩 Project Structure

## 🏗️ Domain Layer (Core of the System)

The Domain layer follows a **Sliced Architecture** approach:

- Each **Aggregate / Table** has its own folder
- Each slice contains:
  - Entity
  - Value Objects
  - Owned Entities (if any)
  - Domain-specific errors
- Uses the **Result Pattern** to unify:
  - Success results
  - Expected domain errors

### ✅ Benefits
- Clear and expressive domain
- Reduced complexity
- Easy mapping of domain errors to API errors
- Framework-independent business logic

---

## ⚙️ Application Layer

- Implements **CQRS (Command Query Responsibility Segregation)**
- Clear separation between:
  - Commands
  - Queries
- Uses Result Pattern for consistent result handling
- Contains application use cases only
- **No dependency on Infrastructure**

---

## 🔌 Infrastructure Layer

Fully configured and ready to use:

- Entity Framework Core
- `ApplicationDbContext`
- ASP.NET Core Identity
- JWT Authentication
- Database connection string setup
- Example implementations for:
  - Services
  - Persistence
  - Repositories

Infrastructure depends on Application, **never the opposite**.

---

## 🌐 API Layer (Production Ready)

The API layer comes fully prepared with essential services and middleware:

### 🛠️ Built-in Features

- Logging
- Rate Limiting
- Custom Exception Handling Middleware
- Unified error responses using **Problem Details (RFC 9457)**
- Output Caching
- Hybrid Caching
- CORS Policy
- API Versioning
- OpenAPI / Swagger UI with security configuration
- JWT Bearer Authentication
- Dependency Injection fully configured

🎯 Everything is ready — you only need to:
> Analyze your project → Design the domain → Write business logic

---

## 🚀 Getting Started

### 1️⃣ Clone the repository
```bash
git clone https://github.com/Moaz-Ash0ur/Clean-Architecture-Template.git


