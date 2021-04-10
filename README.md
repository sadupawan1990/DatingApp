# DatingApp
# Create gitignore file 
dotnet new gitignore
# To run the app with https, our browser need to Trust the certificate provided by .net SDK
# Run the command "dotnet dev-certs https --trust" in the command window with administrator mode
1. dotnet run
2. dotnet watch run --> for watch mode if any file changed rebuilds and refreshing browser will get the new code
# EF Features:
1. Querying
2. Change Tracking (of the entity objects)
3. Saving to DB using savechanges method (generate Insert update delete commands)
4. Concurrency (protects from the parallel updates into the same entity)
5. Transcations (Provides Automatic transaction management for saving the data)
6. Caching - Provides first level of caching out of the box, repeated querying will fetch data from caching 
7. Built-in-Conventions
8. Migrations - for database generation in code first approach 
# Add the EF:
1. Install the nuget package of entityframework
2. Prior to that install nuget gallery extensu=ion for VS CODE
3. add Microsoft.EntityFrameworkCore.Sqlite package into API.csproj for sql lite provider 
# DB Context Class creation
1. Now create the YourDBContext class which inherits from DBContext class from Entityframework core
2. And pass the DBContextOptions from the ConfigureServices method of Startup.cs file, with AddDBContext or    AddDBContextPool
# Install the dotnet ef tools from nuget.org site, for .NET CORE command line interface, which will be used to generate the migration scripts and generating the database in code first approach
# make sure you are installing the same version as EntityFrameworkCore.SQLLite
1. Run this command from command prompt or terminal "dotnet tool install --global dotnet-ef --version 5.0.5"
2. Entity Framework Core Tools for the .NET Command-Line Interface.
Enables these commonly used dotnet-ef commands:
dotnet ef migrations add
dotnet ef migrations list
dotnet ef migrations script
dotnet ef dbcontext info
dotnet ef dbcontext scaffold
dotnet ef database drop
dotnet ef database update
# now generate the migrations inside data/migrations using below command
1. Run this command under the API start up project path and give the output folder path in -o parameter
 dotnet ef migrations add initialCreate -o data/migrations
2. To generate the migrations in different project use -p 
3. above command will throw exception saying that u need to refre Microsoft.EntityFrameworkCore.Design in the start up project to generate the migration scripts.
4. Go and add this nuget package using nuget gallery
# If you want to delete/remove the migrations run 
dotnet ef migrations remove 
# Now Create the database using the migration scripts run the below command to create/update the DB
1. dotnet ef database update 
2. with this command you should be seeing the datingapp.db file in your application folder
3. it creates the table  - CREATE TABLE "Users" 
4. CREATE TABLE "__EFMigrationsHistory" - to insert the migration history records
5. Inserts a first record into  __EFMigrationsHistory table
3. now to see this DB tables we need to install SQLite extension for VS code and open the SQLite using CTRL + P
