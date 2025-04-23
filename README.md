# 🎓 CUET Student Database Management System (C# Console App)

A simple and interactive **C# console application** for managing student records at CUET. This app allows administrators to add, view, search, update, and delete student data, while maintaining batch-wise and department-wise summaries.

---

## 📌 Features

- ➕ Add new students with name, ID, and contact number
- 📄 View student summaries (ID, name, contact)
- 🔍 Search student by ID
- ✏️ Update contact number
- ❌ Delete student by ID
- 📊 View student statistics by **batch** and **department**

---

## 🏷️ ID Format Logic

Student ID is structured to extract:
- **Batch Year:** First 2 digits (e.g., `19` for 2019)
- **Department Code:**
  - `01` – Civil Engineering (CE)
  - `02` – Electrical & Electronic Engineering (EEE)
  - `03` – Mechanical Engineering (ME)
  - `04` – Computer Science & Engineering (CSE)

---

## 🧪 Sample Menu Options

```bash
1. Add student
2. Student Summary
3. Search Student
4. Update Contact no
5. Exit
6. Delete student
7. Student Summary BatchWise

🛠️ Technologies Used
	•	Language: C#
	•	Environment: .NET Console Application
