# TodoNote: Todo List & Notepad

A modern, responsive **Todo List and Notepad web application** built with **ASP.NET MVC**.  
Easily manage your tasks and notes with a clean interface and persistent data storage.

---

## 🚀 Features

- **Task Management:**  
  Create, edit, complete, and delete your todos. Mark tasks as done and see them move to the bottom of the list with a satisfying animation.

- **Notepad:**  
  Capture, edit, and delete notes with rich formatting.

- **Responsive Design:**  
  Works beautifully on desktop.

- **Modern UI:**  
  Built with Bootstrap 5, custom CSS, and interactive JavaScript.

---

## 🛠️ Built With

- **ASP.NET MVC** (Model, View, Controller)
- **HTML5 / CSS3**
- **JavaScript**
- **Bootstrap 5**
- **Font Awesome / Bootstrap Icons**

---

## 🗄️ Database

- **Backend:** MySQL (via XAMPP)
- **Database Name:** `todonotedb`

### **Schema**

```sql
CREATE TABLE Todos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    IsCompleted TINYINT(1) DEFAULT 0,
    CreatedDate DATETIME NOT NULL
);

CREATE TABLE Notes (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Content TEXT NOT NULL,
    CreatedDate DATETIME NOT NULL
);
```

## ⚡ Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server Express 2019 LocalDB

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Leap0920/TodoNote.git
   ```

2. **Set up the Database**
   - Ensure SQL Server Express 2019 LocalDB is installed

3. **Configure Connection String**
   - Update `appsettings.json` with your LocalDB connection:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": ""Server=(localdb)\\mssqllocaldb;Database=TodoNoteDb;Trusted_Connection=True;MultipleActiveResultSets=true""
   }
   ```

4. **Update the Database**
   - Open the Package Manager Console in Visual Studio
   - Run: `Update-Database`

5. **Run the Application**
   - Press F5 or click Run in Visual Studio

---

## 📸 Screenshots

![image](https://github.com/user-attachments/assets/612a95e5-f2d2-457a-b675-638389543277)

---

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

**Happy organizing!**  
_Your productivity, beautifully managed._
