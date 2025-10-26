# Challenge

# 📝 Leonel Notes - ASP.NET Web Forms App

Simple note-taking web app built with **ASP.NET Web Forms (VB.NET + C# mix)**, **SQL Server**, and **Bootstrap**.

---

## 🚀 Features

- User login (basic validation)
- Create, list, and filter notes by tags
- Notes stored in SQL Server
- Bootstrap 5 interface with responsive design

---

## 🧰 Requirements

| Tool | Version | Purpose |
|------|----------|----------|
| [.NET SDK](https://dotnet.microsoft.com/download) | 8.0 or later | Build & run the ASP.NET app |
| [Docker](https://www.docker.com/) | Latest stable | Run SQL Server container |
| Bash or Zsh | Any | To execute the setup script |

> ✅ Works on Linux and macOS (tested on Ubuntu 24.04 and macOS Sonoma).

---

## 🗂️ Project Structure
┣ 📂 dominio # Entity classes (Note, User, Tag)
┣ 📂 negocio # Business logic (NoteNegocio, UserNegocio)
┣ 📂 conexionBD # Database access helpers
┣ 📂 WebFormsApp # ASP.NET UI pages
┣ 🧱 run.sh # Bash script to auto setup DB and run app
┗ 📘 README.md

---

## ⚙️ Quick Start

### 1️⃣ Clone the repo
```bash
git clone https://github.com/hirelens-challenges/Marquez-891a0d.git

2️⃣ Run the setup script
chmod +x run.sh
./run.sh

🧩 Database Info

Default SQL connection:

Server=localhost,1433;
Database=NOTAS_APP;
Trusted_Connection=False;
Encrypt=False;

****************
***TEST USER:***
****************

Email: test@mail.com
Password: pass1234

🧱 Technologies Used

ASP.NET Web Forms (.NET 8 SDK)

VB.NET + C#

ADO.NET / SQL Server

Bootstrap 5.3

Docker (SQL Server 2022)

🧑‍💻 Authors

Developed by Leonel Márquez

🪶 License

This project is open-source and free to use.