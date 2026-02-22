# EMI Loan Calculator API

This project is a simple EMI (Equated Monthly Installment) calculator built using **ASP.NET Core Web API** and **MySQL**.

## 🚀 Features
- Calculate EMI based on:
  - Principal
  - Interest Rate
  - Tenure
  - Monthly Income
- Store loan details in database
- REST API with Swagger UI

## 🛠️ Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- Swagger (OpenAPI)
- Visual Studio Code

## 📌 API Endpoints

### POST /api/Loan
Calculate EMI and save loan data

```json
{
  "principal": 500000,
  "rate": 10,
  "tenure": 60,
  "income": 40000
}

### GET /api/Loan
Fetch all calculated loans

Response:
```json
[
  {
    "principal": 500000,
    "rate": 10,
    "tenure": 60,
    "income": 40000,
    "emi": 10623.52
  }
]

Response:

{
  "emi": 10623.52
}

▶️ How to Run

Clone the repository

Update MySQL connection string in appsettings.json

Run:

dotnet run

Open Swagger:

http://localhost:5014/swagger
📷 Output Screenshots

Screenshots are added in the screenshots folder.

👩‍💻 Author

Ch. Mounya Sai


Then:
```bash
git add README.md
git commit -m "Add README documentation"
git push
