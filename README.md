# 🏦 Simple Banking System

This is a **C# console application** that simulates a basic banking system.  
Users can **deposit, withdraw, check balance, and exit** the system.  

## ✨ Features
✔️ Get an **initial balance** from the user.  
✔️ **Deposit money** into the account.  
✔️ **Withdraw money** (with insufficient balance protection).  
✔️ **Check account balance** anytime.  
✔️ **Input validation** (prevents invalid amounts).  
✔️ Uses a **while loop** to keep running until the user exits. 

---

## 🔍 How It Works
1. **User is asked to enter an initial balance**.  
   - If the input is invalid (e.g., negative number or text), the program keeps asking until a valid number is entered.  
2. **User selects an option from the menu**:  
   - `1` → **Deposit money**  
   - `2` → **Withdraw money** (only if the balance is sufficient)  
   - `3` → **Check current balance**  
   - `4` → **Exit the program**  
3. **If the user enters an invalid choice**, they are asked again.  
4. **The loop continues** until the user selects **option 4 (Exit)**.  

---

## 🚀 How to Run the Program
Open the project in Visual Studio or any C# IDE. Compile and run the program.
