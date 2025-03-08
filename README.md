# URL Shortener 🔗🚀

A serverless URL shortener built with .NET 8 Minimal API, AWS Lambda, and DynamoDB. The frontend is powered by Angular, providing a simple and efficient way to generate and manage short links. The project is fully automated with GitHub Actions for CI/CD.

## 📌 Features
- 🔗 **Shorten Long URLs** - Convert long URLs into short, easy-to-share links.
- 📈 **Track Usage** - Monitor the number of times a short URL is accessed.
- ⚡ **Serverless & Scalable** - Built using AWS Lambda and DynamoDB for high availability.
- 🖥️ **Modern Web UI** - User-friendly Angular frontend.
- 🛠️ **Automated CI/CD** - GitHub Actions for seamless deployment.

## 🚀 Tech Stack
- **Backend:** .NET 8 Minimal API, AWS Lambda
- **Database:** AWS DynamoDB (NoSQL)
- **Frontend:** Angular (TypeScript)
- **Infrastructure:** AWS CDK / Terraform
- **CI/CD:** GitHub Actions

## 📂 Project Structure
```
📦 url-shortener
├── 📁 backend                 # .NET 8 Minimal API (AWS Lambda)
│   ├── 📁 API                 # Minimal API project
│   ├── 📁 Core                # Business Logic & Models
│   ├── 📁 Infrastructure      # DynamoDB Services
│   ├── 📁 tests               # Unit & Integration Tests
│   ├── serverless.yml        # AWS Lambda & API Gateway config
│   ├── Dockerfile            # Containerized local testing
│   └── README.md
│
├── 📁 frontend                # Angular Web Frontend
│   ├── 📁 src
│   │   ├── 📁 components      # UI Components
│   │   ├── 📁 pages           # App Pages
│   │   ├── 📁 services        # API calls to backend
│   │   ├── 📁 assets          # Static files (icons, styles)
│   ├── package.json          # Dependencies
│   ├── angular.json          # Angular Config
│   ├── Dockerfile            # Containerized frontend
│   └── README.md
│
├── 📁 infra                   # Infrastructure as Code (AWS CDK/Terraform)
│   ├── cdk.json               # AWS CDK Configuration
│   ├── stacks.ts              # Stack Definitions
│   ├── terraform              # Terraform scripts
│   └── README.md
│
├── 📁 .github                 # GitHub Actions for CI/CD
│   ├── workflows
│   │   ├── backend-ci.yml    # Backend CI/CD
│   │   ├── frontend-ci.yml   # Frontend CI/CD
│   │   ├── security.yml      # Security Scans
│   └── README.md
│
├── 📁 docs                    # Documentation
│   ├── architecture.md        # System Architecture
│   ├── api.md                 # API Documentation
│   ├── frontend.md            # Frontend Guide
│   ├── deployment.md          # Deployment Steps
│   ├── roadmap.md             # Future Enhancements
│   └── README.md
│
├── .editorconfig              # Formatting Rules
├── .gitignore                 # Ignore files
├── LICENSE                    # License (MIT or other)
├── README.md                  # Main project documentation
└── CONTRIBUTING.md             # Contribution guidelines
```

## 🔧 Setup & Installation
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/somasundar-work/url-shortener.git
cd url-shortener
```

### 2️⃣ Backend Setup
```sh
cd backend
# Install dependencies
dotnet restore
# Run locally
dotnet run
```

### 3️⃣ Frontend Setup
```sh
cd frontend
# Install dependencies
yarn install
# Start development server
yarn start
```

### 4️⃣ Deploy to AWS
```sh
cd infra
# Deploy backend (AWS Lambda + API Gateway)
npx cdk deploy
```

## 📖 API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| `POST` | `/api/shorten` | Shorten a long URL |
| `GET` | `/api/{shortUrl}` | Redirect to the original URL |
| `GET` | `/api/stats/{shortUrl}` | Get usage statistics |

## 📜 License
This project is licensed under the **MIT License**.

## 🤝 Contributing
Contributions are welcome! See [`CONTRIBUTING.md`](./CONTRIBUTING.md) for guidelines.

---
🚀 **Happy Coding!** 🔗

