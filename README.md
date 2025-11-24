# CodeQuest -- Wizard Adventure

## 📖 Project Description

**CodeQuest** is a C# console-based adventure game where you step into
the role of an apprentice wizard striving to grow in power. Through a
menu-driven interface filled with interactive mini-games, you will:

-   Train your wizard over several days.
-   Battle monsters and level up by rolling ASCII dice.
-   Explore a hidden mine to collect coins.
-   Manage an inventory and purchase magical items.
-   Unlock attack abilities based on your level.
-   Decode ancient magical scrolls using logic and string processing.

Each gameplay system is self-contained and demonstrates core programming
concepts such as loops, arrays, matrices, jagged arrays, randomness,
exception handling, and user input validation.

## 🧙 Core Game Features

### 1. Train Your Wizard

-   Enter your wizard's name.
-   Simulate 5 training days where hours and power grow randomly.
-   Earn a magical title based on your total accumulated power.

### 2. Increase Your Level

-   Fight a random monster chosen from an array.
-   Roll ASCII dice to deal damage.
-   Level up until reaching the maximum level (5).

### 3. Loot the Mine

-   Explore a 5×5 matrix of hidden squares.
-   Find randomly placed coins.
-   Earn bits (currency) while managing limited attempts.

### 4. Inventory System

-   See your collected items.
-   Buy items from a shop (with price and name arrays).
-   Bits are deducted based on item cost.

### 5. Attack List by Level

-   Unlock new magical attacks at each level.
-   Uses jagged arrays of spells.

### 6. Decode Ancient Scrolls

-   Remove spaces from spells.
-   Count magical rune vowels.
-   Extract numeric codes from a mystical text.

## 🛠️ Requirements

To build and run this project, you need:

-   **.NET SDK 6.0 or higher**\
    (Recommended: .NET 8 or .NET 9)

Check your installed version:

``` bash
dotnet --version
```

## ▶️ How to Compile and Run

### 1. Clone or Download the Project

Place `Program.cs` into a folder, e.g.:

    CodeQuest/
     └── Program.cs

### 2. Create a New Console Project

``` bash
dotnet new console -n CodeQuest
```

Replace the generated `Program.cs` with the provided one.

### 3. Build the Project

``` bash
dotnet build
```

### 4. Run the Game

``` bash
dotnet run
```

## 📂 Project Structure Explained

    CodeQuest
    │
    └── Program.cs   ← Contains all game logic and menus

### Inside `Program.cs`, the main systems include:

-   **Main Menu System** --- input validation and navigation
-   **Wizard Training Module** --- random stats, ranking
-   **Leveling System** --- dice battles, monster arrays
-   **Mine System** --- 5×5 matrices, coin rewards
-   **Inventory & Shop** --- dynamic arrays, item purchases
-   **Attack System** --- jagged arrays of spells
-   **Scroll Decoding System** --- string parsing tasks

## 📜 License

This project is provided for educational purposes. Feel free to modify
or expand it.
