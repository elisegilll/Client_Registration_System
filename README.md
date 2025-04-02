# Client_Registration_System

# Client Registration System (CRS)

A secure and user-friendly desktop application developed in C# for managing client information through a structured registration, storage, and admin review system. Built using Windows Forms and connected to a SQL Server database, this system supports user authentication, admin controls, and data export functionality.

---

## 📌 Project Overview

The Client Registration System (CRS) enables:
- Secure client account creation and login
- Admin-only access to search, delete, and print user details
- Saving client information to a file from the admin portal
- Real-time client database interaction with SQL Server

---

## 🎯 Features

- **User Functionality**
  - Client registration and login
  - Technology selection on sign-up
  - Secure access control using ClientID and Password

- **Admin Functionality**
  - View all client records
  - Add, delete, search, and sort clients
  - Print and save client details to file

- **OOP Implementation**
  - Inheritance via partial class forms
  - Encapsulation using private fields and methods
  - Structured with modular methods for maintainability

---

## 🛠 Technologies Used

- **Programming Language:** C#
- **Platform:** Windows Forms (.NET)
- **Database:** SQL Server Express
- **Tools:** Visual Studio, SQL Server Management Studio

---

## 🚀 How to Run

1. Clone the repository
2. Open the solution in **Visual Studio**
3. Ensure SQL Server is running and the database is configured
4. Run the solution and use the following credentials:
   - **Client Login:** ClientID + Password
   - **Admin Login:** Username: `1`, Password: `Admin`

> Note: Ensure connection strings are correctly set in your project to match your local SQL Server setup.

---

## 🧪 Testing Highlights

Testing was performed on:
- Login verification
- Admin actions (deleting users, saving/printing data)
- Form usability and field validation
- Functional coverage of all core user/admin features

Tools used:
- Visual Studio Debugger
- SQL Server logs for back-end validation

---

## 📈 Reflection

> "Overall, this system is effective, usable, and serves as a robust platform for client management. I implemented core OOP principles such as encapsulation and inheritance, though future improvements would involve adding property accessors and detailed user testing guides."

– Elise Gill

---

## 📂 Folder Structure

