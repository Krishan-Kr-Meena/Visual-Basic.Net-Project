# Visual Basic .NET Project  
*A collection of simple desktop applications built with VB.NET — including a Sign In & Register System, Notepad, Calculator, and Student Marks Calculator.*

## 📘 Overview  
This project is developed in **Visual Basic .NET** using **Windows Forms**. It demonstrates how to create a user-friendly desktop application with multiple integrated modules in a single project.  

It includes:
- A **Sign In and Register System** for user authentication.  
- A **Notepad** application for writing, editing, and saving text files.  
- A **Calculator** for performing basic arithmetic operations.  
- A **Student Marks Calculator** to compute total marks, percentage, and grade.  

Each module features a clean graphical interface designed for ease of use and learning.

---

## 🧩 Features  

### 🔐 Sign In & Register System  
- **Sign Up Panel** for new users to register by providing username, email, and password.  
- **Sign In Panel** for existing users to log in securely.  
- User data stored in a **SQL database** for validation and future access.  
- Basic input checks such as matching passwords and mandatory fields.  
- Acts as a gateway to access the other modules (Notepad, Calculator, Marks Calculator).  
- Demonstrates database connectivity and CRUD operations in VB.NET.

### 📝 Notepad  
- Create, open, edit, and save text files (`.txt`).  
- Supports copy, cut, paste, undo, and redo operations.  
- Menu options for **File**, **Edit**, and **Help**.  
- Demonstrates the use of file handling (`StreamReader`, `StreamWriter`) in VB.NET.  

### 🧮 Calculator  
- Performs addition, subtraction, multiplication, and division.  
- Includes clear and backspace options for editing input.  
- Displays results instantly through event-driven logic.  
- Demonstrates button click events and text manipulation.  

### 🎓 Student Marks Calculator  
- Allows users to input marks for multiple subjects.  
- Calculates **Total**, **Average**, and **Percentage** automatically.  
- Displays **Result** (Pass/Fail) and **Grade** based on percentage.  
- Demonstrates loops, conditions, and arithmetic operations in VB.NET.  

---

## 🛠️ Technologies Used  
- **Language:** Visual Basic .NET  
- **Framework:** .NET Framework  
- **IDE:** Microsoft Visual Studio  
- **UI:** Windows Forms Application  
- **Database:** Microsoft SQL Server (for Sign In & Register module)  

---

## 📂 Project Structure  

Visual-Basic.Net-Project/
│
├── VB projects.sln # Solution file
├── VB projects/ # Source code folder
│ ├── LoginForm.vb # Sign In form
│ ├── RegisterForm.vb # Sign Up form
│ ├── Notepad.vb # Notepad module
│ ├── Calculator.vb # Calculator module
│ ├── StudentMarksCalculator.vb # Student Marks Calculator module
│ └── DatabaseConnection.vb # SQL connection logic
└── README.md
