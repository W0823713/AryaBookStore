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

# Assignment 2 -  Book Store Part-II
*Author: Arya Patel*
*Student ID: 0823713*
*Start Date: 31st October 2023

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
- 05:57 PM: Added a new folder named it repository, added a new iteam of type interface to the folder and named it IRepository.cs, Implemented 
  the class that implemented the repository. 

- 06:00 PM: Implemented the class that implements the repository. Included using statements and viewed potential fixes.

- 06:10 PM: Created individual repos for cateogry Category.cs and ICategory.cs, Later modified them.

- 06:30 PM: Built the application and as there were no errors i pushed it directly to github.

- 06:40 PM: Added a new interface in the irepository folder named it ISP_Call.cs, then installed the NuGet Package for dapper and implemented it with the ew class in the repository folder.

- 06:50 PM: Added a new class SP_Call.csin the repository folder selected the appropriate using statement and implemented the ISP_Call interface.

- 06:55 PM: Added a connection to the database and updated the implementation of ISP_Call interface, Then added wrapper for Unit of work.

- 07:00 PM: Added anew interface IUnitOfWork toIRepository and updated the code, Then implemeted this inside the IUnitOfWork by adding a class.
To make it accessible by the project i registered it in Startup.cs 

- 07:30 PM: Built the project there were no errors and then pushed to github.

- 07:32 PM: First of all closed all the tabs there were open and there were a lot of them and then added a new mvc controller named it ategoryController.cs, Then modified the code to use the IUnitOfWork from .DataAccess project and the IRepository folder.

- 07:45 PM: Added a new folder in the Views with the same name as controller, Added a new index view to the folder and modified with generic html code from the provided files.

- 07:55 PM: Moded the category link to the content Management dropdown then ran the application to view the changes, Then pushed to github.

- 08:00 PM: Then added icons in the category section and conformed it. Added the @section call to category.js script and ran the project

- 08:15 PM: Added the IAction result to the controller and added a view both named Upsert 

- 08:20 PM: Created a partial view for EDIT | BACK, In views added a partial view for _CreateAndBackToListButton.cshtml _EditAndBackToListButton and code addition of the @model rezor statement.

- 08:25 PM: Added the asp-actionto the Index.cshtml and ran the application. Created a new category, modified Upsert.cshtml and the title uses the @title variable, added @section to validate input on the client side of the test

- 08:25 PM: Created an upsert post action method in the CategoryController.cs, Removed the db.SaveChanges() method in the CategoryRepository.cs and move the unitOfWork.Save() method with the return Redirect Toaction method. Checked for errdrs and tested whether the application can update and create  category.


- 08:27 PM: Added the delete funcnality in category.js with including the onclick event to the delete function, Added the delete(url), Completed the steps ran the application everything is running as i wanted to i pushed it on git hub.


- Start Date: 6th November 2023
- 04:00 PM: Came back to check whether everything is good and i couldn't see the application running and i was freacked out after figuring it out for more than 1 hour i found that i just need to update the database. Thought this was an important thing to n ote t=for the future.

***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************

ASSIGNMENT-2 Part-III

***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************
# Assignment 2 -  Book Store Part-III
*Author: Arya Patel*
*Student ID: 0823713*
*Start Date: 14th November 2023

- 04:00 PM: Started to work on Cover Type Crud, Where i creader cover type with the same method i used in Category. Added CoverType.cs in models. Added CoverType to the repository where i added class, interface and in unitofwork and Iunitofwork.

- 04:07 PM: Pushed CoverType to database. Created Migration and updated it.


               --add-migration AddDefaultIdentityMigration1

- 04:25 PM: Performed CRUD operations on CoverType, Added CoverType to navbar, Then added CoverTypeController to Controller, Added a view named index to use DataTables and upsert that can be used for creating and updating covertype.

- 04:55 PM: Started on product CRUD, added a new class named Product in .Models project, Added the code to build the blueprint of this class.

- 05:00 PM: Added reference to the new Products piece to the database in ApplicationDbContext.cs  

- 05:02 PM: 

              --add-migration AddProductToDbMigration

- 05:04 PM: In the SOE updated the Product class so Title, ISBN and Author are also required 

- 05:05 PM: Created a new migration and updated the database

              --add-migration AddValidationToProduct


                               *(took a bit of a break)*

- 05:55 PM: Added Product.cs to Repository, then added IProductRepository interface to IRepository folder. Added Product to UnitOfWork and IUnitOfWork

- 06:15 PM: Checked everything and ready to push to github



                                 DONE FOR THE DAY



- Start Date: 14th November 2023
- 03:00 PM: Added Product controller in the Controller folder to perform the CRUD operations.

- 03:05 PM: Added IWebHostEnviorment and its Using statements

                            using Microsoft.AspNetCore.Hosting;
                            using Microsoft.AspNetCore.Mvc;
                            using Microsoft.AspNetCore.Mvc.Rendering;

- 03:05 PM: Created ProductVM.cs in ViewModel folder, then selected list for Category and CoverType.

- 03:15 PM: Modified the ProductVM class so it can be public and installed the microsoft features package. Modified the Product controller, then included the using statements to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering
                           
                           --using Microsoft.AspNetCore.Mvc.Rendering;

- 03:15 PM: Commented the Upsert post method as it was instructed and modified the API call to include Category and CoverType properties
                            
                            (includeProperties: "Category,CoverType");

- 03:20 PM: Added an Index view, then copied the index.cshtml code from categories and edited it so it was functional for product, then added new properties for Title/ ISBN/ Price/ Author/ Category and then referenced it to product.js file 

- 03:30 PM: Created the product.js copied the code from category.js and edited it for product, then in _Layout.cshtml linked the product to dropdown menu. Ran the application and everythig was working great without exceptions but can't create and update because there was no Upsert for now.

- 03:45 PM: Created the Upsert for product copied the code from the assignment files. logged in the tiny.cloud by creating account and figuring it out on how to use it, once it was done copied the API key that was provided and added a function to validate the function and if it was left empty a sweet alert was displayed.

- 04:07 PM:
                       My API key: 93bt2v7qg4mgqqdsohnxmxalm89mphzgrfwq3rmxezx7brja

- 04:15 PM: Ran the application and when i selected the new product there was an exception which came becauce there was an error in Upsert.cshtml and when i went through the whole code it was Category and not covertype when i fixed it it allowed me to create a new product and everything looked good

- 04:45 PM: Added a new folder images in wwwroots, in the ProductController configured the product Upsert Post action method and uncommented the HTTP post method.

                                *(took a bit of a break)*

- 05:40 PM: Checked for errors, then ran the application and tested the application everythin is done and now it is time to pust it to github  