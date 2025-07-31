
``` markdown

# InventoryHub

**InventoryHub** is a full-stack inventory management application built with **Blazor WebAssembly** for the front-end and **.NET Minimal API** for the back-end.

This project allows users to view product details including nested category data, demonstrating seamless integration between client and server using modern web development practices.

---

## 🚀 Features

- 📦 Product list with name, price, stock, and category
- 🔄 Real-time API integration using `HttpClient`
- 🧩 Nested JSON structure with `Category` object
- 🔐 CORS-enabled communication between front-end and back-end
- ⚙ Performance optimizations and caching

---

## 🛠️ Technologies Used

- Blazor WebAssembly (.NET 8+)
- .NET Minimal API (Web API)
- System.Text.Json for serialization
- CORS middleware
- Git + GitHub

---

## 📂 Project Structure

FullStackApp/
├── ClientApp/ # Blazor front-end
├── ServerApp/ # .NET Minimal API back-end
├── FullStackSolution.sln
├── README.md
└── REFLECTION.md

---

## 🧪 Getting Started

### ✅ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or Visual Studio
- Postman (for testing API - optional)

### 🧱 Setup Instructions

```bash
# Clone the project
git clone https://github.com/yourusername/inventoryhub.git
cd inventoryhub/FullStackApp

# Run Server
cd ServerApp
dotnet run

# Run Client (in a separate terminal)
cd ../ClientApp
dotnet run

```

🌐 Navigate to:
ClientApp: https://localhost:PORT/fetchproducts

ServerApp API: https://localhost:PORT/api/productlist

Replace PORT with the values shown in your terminal

## 🔍 API Endpoint

**GET** `/api/productlist`

Returns:

```json
[
  {
    "id": 1,
    "name": "Product A",
    "price": 19.99,
    "stock": 100,
    "category": {
      "id": 1,
      "name": "Category X"
    }
  }
]

👨‍💻 Author
Ahmed Adam
GitHub: @MrADAM02

```

## 📄 License

This project is for educational use only. Feel free to fork and modify as needed.
