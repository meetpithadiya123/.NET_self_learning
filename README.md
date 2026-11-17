# 🎓 Student Course Registration System

<div align="center">

### ASP.NET Core MVC | C# | Razor Views

A simple web-based Student Course Registration System developed using **ASP.NET Core MVC** as part of the .NET Technologies self-learning activity.

<br>

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

</div>

---

## 📌 About The Project

The **Student Course Registration System** is a web application developed using ASP.NET Core MVC and C#.

The application allows users to register students by entering their personal and academic details. It also provides functionality to view all registered students and display the complete details of an individual student.

This project demonstrates the practical implementation of the **Model-View-Controller (MVC) architecture**, Razor Views, routing, model binding and server-side form validation using Data Annotations.

It uses an in-memory list to store student records without requiring a database.

## ✨ Features

- 🏠 **Home Page** – Simple homepage with application navigation.
- 📝 **Student Registration** – Register students with name, email, course and semester.
- 📋 **Student List** – Display all registered students in a table.
- 👤 **Student Details** – View complete information of an individual student.
- ✅ **Form Validation** – Validate user input using Data Annotations.
- 🔗 **MVC Routing** – Navigate between controllers and views.
- ⚡ **Model Binding** – Automatically bind form values to C# model properties.
- 🔍 **Validation Handling** – Check submitted data using `ModelState.IsValid`.

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Programming language |
| ASP.NET Core MVC | Web application framework |
| .NET 10 | Development platform |
| Razor Views | Dynamic user interface |
| HTML | Web page structure |
| CSS | Styling and design |
| Visual Studio | Development environment |
| Git & GitHub | Version control and source code hosting |

## 🏗️ Project Structure

```text
self_learning/
│
├── Controllers/
│   ├── HomeController.cs
│   └── StudentController.cs
│
├── Models/
│   └── Student.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   │
│   ├── Student/
│   │   ├── Create.cshtml
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   │
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   │
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── wwwroot/
│
├── Properties/
│
├── appsettings.json
├── Program.cs
├── self_learning.csproj
└── README.md
```

## 📚 MVC Architecture

This application follows the Model-View-Controller architecture.

### 1. Model

The `Student.cs` model represents student information and defines validation rules.

**Properties:**
- Id
- Name
- Email
- Course
- Semester

### 2. View

Razor Views provide the user interface.

| View | Description |
|---|---|
| Home/Index.cshtml | Home Page |
| Student/Create.cshtml | Student Registration Form |
| Student/Index.cshtml | Student List |
| Student/Details.cshtml | Student Details |

### 3. Controller

The `StudentController.cs` handles student-related operations.

| Action Method | Description |
|---|---|
| Index() | Displays all registered students |
| Create() GET | Displays the registration form |
| Create() POST | Validates and registers a student |
| Details(int id) | Displays selected student details |

## ✅ Validation Rules

The application uses C# Data Annotations for server-side validation.

| Data Annotation | Purpose |
|---|---|
| `[Required]` | Makes a field mandatory |
| `[StringLength]` | Restricts the length of text |
| `[EmailAddress]` | Validates email format |
| `[Range(1, 8)]` | Restricts semester between 1 and 8 |

The `ModelState.IsValid` property checks whether the submitted student information satisfies the validation rules.

## 🔄 Application Workflow

```text
          🏠 Home Page
                |
                ▼
      Student Registration
                |
                ▼
       Enter Student Details
                |
                ▼
         Submit the Form
                |
                ▼
        Model Validation
                |
          ┌─────┴─────┐
          ▼           ▼
       Invalid      Valid
          |           |
          ▼           ▼
     Show Errors   Save Student
          |           |
          ▼           ▼
    Registration   Student List
        Form           |
                       ▼
                View Student Details
```

## 🚀 Getting Started

Follow these steps to run the project on your local machine.

### Prerequisites

Make sure you have installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) with ASP.NET and web development workload
- Git

### Installation

**Step 1: Clone the repository**

```bash
git clone https://github.com/meetpithadiya123/.NET_self_learning.git
```

**Step 2: Navigate to the project directory**

```bash
cd .NET_self_learning
```

**Step 3: Locate the project file**

Navigate to the folder containing `self_learning.csproj`.

**Step 4: Restore dependencies**

```bash
dotnet restore
```

**Step 5: Run the application**

```bash
dotnet run
```

**Step 6: Open the application**

Open the localhost HTTPS URL displayed in your terminal.

You can also open the project in Visual Studio and press `F5` to run it.

## 🌐 Application Routes

| Page | Route |
|---|---|
| Home | `/` |
| Student Registration | `/Student/Create` |
| Student List | `/Student/Index` |
| Student Details | `/Student/Details/1` |

## 📸 Application Screenshots

Add screenshots of your working application below to demonstrate its functionality.

### 🏠 Home Page

<!-- Add your Home Page screenshot here -->

![Home Page](Screenshots/home.png)

### 📝 Student Registration Form

<!-- Add your Registration Form screenshot here -->

![Student Registration](Screenshots/registration.png)

### ⚠️ Form Validation

<!-- Add your Validation screenshot here -->

![Form Validation](Screenshots/validation.png)

### 📋 Student List

<!-- Add your Student List screenshot here -->

![Student List](Screenshots/student-list.png)

### 👤 Student Details

<!-- Add your Student Details screenshot here -->

![Student Details](Screenshots/student-details.png)

## ⚠️ Important Note

This project uses a static in-memory `List<Student>` to store student records.

- No database is required.
- Student records are available while the application is running.
- All records are lost when the application stops or restarts.

This approach is used because the self-learning activity does not require database integration.

## 🎯 Learning Outcomes

Through this project, I learned:

- Fundamentals of ASP.NET Core MVC.
- MVC architecture and project structure.
- Creating Models, Controllers and Razor Views.
- Routing and action methods.
- Razor syntax and Tag Helpers.
- Model binding and form handling.
- Data Annotations and form validation.
- Using `ModelState.IsValid` in controller actions.
- Managing source code using Git and GitHub.

## 🔮 Future Enhancements

The application can be improved in the future by adding:

- Database integration using SQL Server and Entity Framework Core.
- Student update and delete functionality.
- Search and filter functionality.
- User authentication and authorization.
- Improved responsive user interface.

## 👨‍💻 Author

**Meet Pithadiya**

B.Tech Computer Engineering  
Marwadi University

📌 Subject: .NET Technologies (01CE1523)  
📚 Semester: 5

🔗 **GitHub Repository:**  
[.NET Self Learning – Student Course Registration System](https://github.com/meetpithadiya123/.NET_self_learning)

---

<div align="center">

### ⭐ Thank You for Visiting!

**Built with ❤️ using ASP.NET Core MVC and C#**

</div>
