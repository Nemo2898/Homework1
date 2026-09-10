# Homework_1 — Homework exercise (console application)

Homework repository with a simple console application exercise.

Task:
1. Create an abstract class LibraryItem with the properties Title and Year, and an abstract method string GetInfo().

2. Create the subclasses inheriting LibraryItem:
Book (with additional properties Author and Pages)
Dvd (with an additional property DurationMinutes)
Each subclass must provide its own implementation of GetInfo().

3. Create an interface ILendable with:
bool IsAvailable
void Lend()
void Return()
Implement the interface in both Book and Dvd classes. Attempting to lend an item that has already been lent out must throw an InvalidOperationException.

4. Create a class Library with the following methods:
Add(LibraryItem item)
LibraryItem[] GetAvailableItems()
LibraryItem? FindByTitle(string title)
 
An xUnit test project (`LibraryConsoleApp.Tests/`) is included so you can verify your solution before submitting.

Program.cs also has example code you can run.

## Getting started

### 1. Fork this repository

Fork it to your own account at `https://git.vamk.fi/<your_username>/<your_repo>`.

### 2. Clone your fork

	git clone https://git.vamk.fi/<your_username>/<your_repo>.git
	cd Homework_Demo

### 3. Implement the exercise

Open `Homework_1.slnx` in Visual Studio. `Homework1/LibraryConsoleApp` project
contains `TODO` comments marking the parts you need to implement.

### 4. Run tests

Open Test Explorer in Visual Studio (Ctrl+E, T) and run all tests, or
use the command line:

	dotnet test

### 5. Commit and push

	git add .
	git commit -m "Complete homework"
	git push origin main

## License

This repository is for educational use only.