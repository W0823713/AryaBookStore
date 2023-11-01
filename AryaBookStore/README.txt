# Assignment 2 -  Book Store
*Author: Arya Patel*
*Student ID: 0823713*
*Project Start Date: 26th October 2023*﻿

**Create README (Project Initialization)**
- Start Date: 26th October 2023
- 12:00 AM: The project was initiated by creating the README, serving as the project's initial and foundational document.

- 01:00 PM: Setting up the project in which i created a new project in ASP.NET Core Webapp template in visual studio 2019 named it AryaBookStore in ASP.NET Core 5.0 then enabled razor run time compilation

- 02:00 PM: Viewed all files if they were correct and ran the application which it did without any errors. But I had to comment the ssl port as i was doing it in collage computer.

- 02:30 AM: Created a git repositary by logging in github and then created and pushed the project to github.

- 03:00 PM: Started debugging added two break points on IAction Index and Privacy in HomeController.cs then ran the program when clicked to privacy it too kme to the  HomeController.cs privacy part where i added the break points and then bvack to the privacy page.

              *(took a bit of a break)*

- 05:00 PM: I went to bootswatch.com where i selected a theme for my page downloaded the css and replaced it with bootstrap.css in wwwroot folder. Then replaced the site.css with the one provided by the professor, then made the changes in _Layout.cshtml. Ran the project again to see the changes and it was close to perfection.


- 06:00 PM: Added third party tools JQueryUI, DataTables, Sweet Alert, Font awesome, Toastr in the _Layout.cshtml, then added a dropdown navbar which was really tough as i was not able to figure it out but at the end it was success. Then again refreshaed and reviewed the UI. After that changed the dropdown to Content Management.

- 07:30 PM: Added three new projects class library to the application AryaBooks.DataAccess, AryaBooks.Models, AryaBooks.Utility. Then copied the Data folder and pasted to AryaBooks.DataAccess project, and deleted the original one

- 08:30 PM: Saved the whole project uploaded it to onedrive and went home as it wss really late.

- Start Date: 27th October 2023
- 10:00 AM: Sat as the same computer as yesterday so the project was still on the desktop opened the project ran it and it was still running perfectly.

- 10:30 AM: Installed  Microsoft.EntityFrameworkCore. Relational and Core.Sq|Server packages and deleted the migrations folder from the data folder then installed the Install NuGet package: Identity.EntityFrameworkCore then modified the namespace to reflect  the project and deleted the CLass1.cs file from all the three projects. Next was building the project.

- 12:00 AM: Moved Models into AryaBooks.Models, then added references of .Models and .DataAccess to the project, renamed the Models folder to ViewModels, Changed the ErrorViewModels.cs Built the project. 

- 01:00 PM: Modified Startup.cs in the first line where earlier it was AryaBookStore.Startup then changed it usingAryaStore.DataAccess.Data;, Then run the application and reviewed the errors. Corrected any default reference to Models.ViewModels.ErrorViewModels. 

- 02:45 PM: Solved all the errors and run the application and reviewed the presentation in the browser.

- 03:00 PM: Added seed data in utility project calle SD.cs, Modified the properties of the class and then added project reference to the main project.

- 04:00 PM: Added a customers area to Areas Changed the routes in startup.cs same as the one in ScaffoldingReadme.txt, then added HomeController to Customer in Area. Then edited the HomeController.cs to define that the controller is in the customer area Then ran the application and there was an error as sir told that then copied few files from one folder to another edited them to make them work 

- 06:00 PM: Added admin area in areas, added proper view files then deleted Data and Models folder, Deleted the controllers folder updated the repository to github and this brings me to the end of the assignment2. 

***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************

ASSIGNMENT-2 Part-II

***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************


- Start Date: 31st October 2023
- 04:30 PM: Came to the collage and started the second part. Crebated the sapce for coding and every thing is set to go

- 04:56 PM: First i built the application to check wether everything is good and it was successful as no errors were found

- 05:00 PM: Created migrations then modified the database name and saved to move to the next part

                     add-migration AddDefaultIdentityMigration

            Got an error: Your target project 'AryaBookStore' doesn't match your migrations assembly 'AryaBooks.DataAccess'. Either change your target project or change your migrations assembly.
            Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("AryaBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
            Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

             Solved by selecting the correct default project (AryaBooks.DataAccess)

- 05:23 PM: Reviewed the migration file for the sql. 

- 05:25 PM: Updated the data base with the code : update-database
            and the output was successful Build started... Build succeeded.  Done.

- 05:30 PM: Reviewed the updated database in SQL Server Object Operator, checked the errors and ran the application

- 06:00 PM: Added a new table to the database by creating a category model and pushing it to the database

- 06:10 PM: Added the migration via the pmc console:  add-migration AddCategoryToDb

- 06:20 PM: Updated the note using the (using) statement then reran the migration to fina the error : The name 'AddCategoryToDb' is used by an existing migration.
            So added another category migration to solve the duplication:  add-migration AddCategoryToDb-2

            Build started...
            Build succeeded.


- 06:55 PM: Updated the database checked everything and was ready for commit to git


                              DONE FOR THE DAY


- Start Date: 1st November 2023
- 05:57 PM: 









- 04:30 PM
- 04:30 PM
- 04:30 PM
- 04:30 PM


