# .NET Clean Architecture Web API

A simple and production-oriented example of how to structure a .NET Web API using Clean Architecture principles.

This project is designed for learning purposes and as a base template for real-world applications.

---

## 🚀 Tech Stack

- ASP.NET Core Web API
- .NET 10
- Entity Framework Core
- SQL Server
- Clean Architecture
- Dependency Injection

---

## 🧱 Architecture Overview

The project follows Clean Architecture principles:
```
API → Application → Domain
↑
Infrastructure → Application
```

### Layers:

#### 🔵 API
- Controllers
- HTTP layer only
- No business logic

#### 🟡 Application
- Business logic (Services)
- Models (Requests/Responses)
- Abstractions (Interfaces)

#### 🟣 Domain
- Entities
- Core business rules
- No external dependencies

#### 🟢 Infrastructure
- Database access (EF Core)
- Repository implementations
- External services

---

## 📁 Project Structure

```

src
├── TaskManager.Api
├── TaskManager.Application
├── TaskManager.Domain
└── TaskManager.Infrastructure

```

🧑‍💻 Author

Built as a learning template for Clean Architecture in .NET Web API projects.

⭐ If you like this project

Give it a star and use it as a starting point for your own applications.
