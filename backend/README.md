# URL Shortener - Backend (Minimal API)

## 📌 Overview
This is the backend service for the URL Shortener project, built using **.NET 8 Minimal API**, deployed as a **serverless application** using AWS Lambda and DynamoDB.

## 🚀 Tech Stack
- **Framework**: .NET 8 Minimal API
- **Cloud Platform**: AWS Lambda, API Gateway
- **Database**: AWS DynamoDB (NoSQL, Auto-scaling, TTL for expiry)
- **CI/CD**: GitHub Actions, Serverless Framework

## 📂 Project Structure
```
📦 backend
├── 📁 API                 # Minimal API project
├── 📁 Core                # Business Logic & Models
├── 📁 Infrastructure      # DynamoDB Services
├── 📁 tests               # Unit & Integration Tests
├── serverless.yml        # AWS Lambda & API Gateway config
├── Dockerfile            # Containerized local testing
└── README.md
```

## 🔧 Setup & Installation
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/somasundar-work/url-shortener.git
cd url-shortener/backend
```

### 2️⃣ Install Dependencies
```sh
dotnet restore
```

### 3️⃣ Run Locally
```sh
dotnet run
```
The backend will be available at `http://localhost:5000`.

### 4️⃣ Deploy to AWS Lambda
Ensure **Serverless Framework** is installed:
```sh
npm install -g serverless
```
Deploy:
```sh
serverless deploy
```

## 📖 API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| `POST` | `/api/shorten` | Shorten a long URL |
| `GET` | `/api/{shortUrl}` | Redirect to the original URL |
| `GET` | `/api/stats/{shortUrl}` | Get usage statistics |

## ✅ Testing
Run unit tests:
```sh
dotnet test
```

## 📜 License
This project is licensed under the **MIT License**.

## 🤝 Contributing
Contributions are welcome! See [`CONTRIBUTING.md`](../CONTRIBUTING.md) for guidelines.

---
🚀 **Happy Coding!** 🔗

