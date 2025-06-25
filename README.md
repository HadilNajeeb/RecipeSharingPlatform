---

## 📌 Features

### 👤 User Management
- Register, Login, Logout
- User Profiles
- Authentication via ASP.NET Identity

### 🍲 Recipe Management
- Create, Read, Update, Delete (CRUD)
- Categorization
- Search and filter functionality
- Rating system

### 🛠 Admin Features
- View and manage users
- Delete inappropriate recipes

---

## 🔧 Technologies Used

- **ASP.NET Core 8.0**
- **Entity Framework Core**
- **ASP.NET Identity**
- **Razor Pages**
- **Bootstrap (for UI)**
- **JavaScript / jQuery (for API interaction)**

---

## 🗂 Database Design (ERD Overview)

- **Users** ←→ **Recipes** (One-to-Many)
- **Users** ←→ **Ratings** (One-to-Many)
- **Recipes** ←→ **Ratings** (One-to-Many)
- **Recipes** ←→ **Categories** (Many-to-One)

---

## 🔌 API Endpoints

| Endpoint                          | Method | Description                   |
|----------------------------------|--------|-------------------------------|
| `/api/recipes`                   | GET    | Get all recipes               |
| `/api/recipes/{id}`              | GET    | Get specific recipe           |
| `/api/recipes/search?term=`      | GET    | Search recipes by term        |
| `/api/recipes`                   | POST   | Create new recipe             |
| `/api/recipes/{id}`              | PUT    | Update recipe                 |
| `/api/recipes/{id}`              | DELETE | Delete recipe                 |
| `/api/recipes/{id}/rate`         | POST   | Submit a rating               |
| `/api/auth/register`            | POST   | Register a new user           |
| `/api/auth/login`               | POST   | Login user and return token   |

---

## 🖥 Frontend Highlights

- Razor views with layout and partials
- Client-side + server-side form validation
- Protected views for authenticated users
- Admin dashboard and moderation tools
- AJAX API consumption for dynamic recipe listing

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server or LocalDB
- Visual Studio 2022+

### Run the App
1. Clone the repository
2. Set `RecipePlatform.MVC` as startup project
3. Apply EF Core Migrations:
   ```bash
   dotnet ef database update
