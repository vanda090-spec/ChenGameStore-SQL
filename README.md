# ChenGameStore SQL Project

A C# console application for managing a SQL Server database for a game store.

## Project Overview

This project was created as a final SQL assignment.  
The application connects to a local SQL Server database and allows the user to create, manage, display, update and analyze data related to a game store.

## Technologies Used

- C#
- SQL Server
- ADO.NET
- SqlConnection
- SqlCommand
- SqlDataReader
- Console Application

## Database

Database name:

```text
ChenGameStore
```

## Tables

The project includes three main tables:

### Games
Stores information about games:
- GameID
- GameName
- GamePrice
- GameCategory
- GameDateAdded

### Workers
Stores information about store workers:
- WorkerID
- WorkerName
- WorkerRole
- WorkerSalary

### Orders
Stores game order information:
- OrderID
- GameID
- OrderCount
- OrderDate
- WorkerID

The `Orders` table includes foreign keys connected to:
- `Games(GameID)`
- `Workers(WorkerID)`

## Features

- Create database
- Drop database
- Create tables
- Drop tables
- Insert sample data
- Display table data
- Delete records by ID
- Update records by ID
- Display orders by date
- Join tables
- Show order details with worker and game names
- Calculate total orders per game
- Show maximum order count per game
- Show minimum order count per game
- Calculate total sales per worker

## Main Menu

```text
1. Create ChenGameStore DB
2. Drop ChenGameStore DB
3. Create Table
4. Drop Table
5. Delete Table content by ID
6. Show Tables
7. Insert Table options
8. Update Table options
10. Join Tables
11. Count Orders
12. Exit
```

## SQL Queries Included

The project includes SQL operations such as:

- `CREATE DATABASE`
- `DROP DATABASE`
- `CREATE TABLE`
- `DROP TABLE`
- `INSERT INTO`
- `DELETE`
- `UPDATE`
- `SELECT`
- `INNER JOIN`
- `GROUP BY`
- `SUM`
- `MAX`
- `MIN`
- `ORDER BY`

## Connection

The project uses a local SQL Server Express connection:

```csharp
server=localhost\\SQLEXPRESS;
Integrated Security=SSPI;
```

## How To Run

1. Open the project in Visual Studio.
2. Make sure SQL Server Express is installed and running.
3. Run the console application.
4. Use the menu to create the database, create tables and insert data.
5. Continue using the menu to display, update, delete and analyze the data.

## Project Purpose

This project was created to practice:

- SQL database creation
- Table relationships
- Primary keys and foreign keys
- CRUD operations
- SQL joins
- Aggregate queries
- C# database connection using ADO.NET
- Console menu-based application development

## Author

Chen Vanda
