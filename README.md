# Blog Management Console App using Class Library
A simple C# console application for managing blog entries using Entity Framework Core with a SQL Server database.

## Features
* List All Blogs: Display all blog entries from the database
* Search Blog by ID: Find and display a specific blog by its ID
* Simple Menu Interface: Easy-to-use console menu system

## Prerequisites
* .NET 6.0 or later
* SQL Server
* Entity Framework Core tools

## Database Setup
### 1. Database Configuration
The application uses a SQL Server database named TrainingBatch5. Update the connection string in the AppDbContext class if needed:

        csharp
        optionsBuilder.UseSqlServer("Server=.;Database=TrainingBatch5;User Id=sa;Password=23032106;TrustServerCertificate=True;");
### 2. Database Model
The application uses the following table structure:
Table: Tbl_Blog
  * BlogId (int, primary key, auto-increment)
  * BlogTitle (nvarchar(50), not null)
  * BlogAuthor (nvarchar(50), not null)
  * BlogContent (text, not null)
  * DeleteFlag (bit, for soft deletion)

### 3. Entity Framework Configuration
The TblBlog entity is configured as a keyless entity in the DbContext. You may want to add a proper primary key configuration:

        csharp
        modelBuilder.Entity<TblBlog>(entity =>
        {
            entity
                .HasNoKey() // Consider adding a proper key configuration
                .ToTable("Tbl_Blog");
            // ... other configurations
        });

## Installation
1. Clone the repository:

        bash
        git clone <repository-url>
        cd BlogConsoleApp
2. Restore NuGet packages:

        bash
        dotnet restore
3. Update the database connection string in AppDbContext.cs to match your SQL Server instance.

4. Ensure the database exists or create it:

        sql
        CREATE DATABASE TrainingBatch5;
5. Run the application:

        bash
        dotnet run
## Usage
When you run the application, you'll see the main menu:

        text
        Menu : L - List All Blogs, S - Search Blog By Id, E - Exit the Program : 
### Available Options:
* L: List all blogs in the database
* S: Search for a blog by its ID
* E: Exit the application

### Listing Blogs
Selecting 'L' will display all blogs in the following format:

        text
        Id : 1 
                - Title : Sample Blog 
                - Author : John Doe 
                - Content : This is a sample blog content...

### Searching Blogs
Selecting 'S' will prompt you to enter a blog ID. The application will then display the blog details if found, or show a "Blog Not Found" message.

## Project Structure
        text
        BlogConsoleApp/
        ├── Program.cs                 # Main application entry point
        ├── Models/
        │   ├── AppDbContext.cs        # Database context class
        │   └── TblBlog.cs            # Blog entity model
        └── Blogs.Database.Models.csproj # Project file

## Entity Framework Notes
* The application uses Code-First approach with an existing database
* The DbContext is configured to use SQL Server
* The TblBlog entity maps to the Tbl_Blog table in the database
* Consider adding proper primary key configuration for better Entity Framework functionality

License
This project is for educational purposes. Feel free to modify and use as needed.
