# <h1 align = "center"> Local Business Finder (Miyazaki Edition)

<!-- <img align = "center">

![Preview](./Factory/wwwroot/) -->

##### <h4 align = "center">  Building an API, Indepedent Project for Epicodus, 08.21.2020

#### <h4 align = "center"> By _**Christine Augustine**_

## Description

This project will create an API for a local business lookup. The API will list different businesses available. 

## Setup/Installation Requirements 

### 1. Install .NET Core 

Download .NET Core SDK from Microsoft Corp  (**[macOS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) | [Windows OS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)**)

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal 

### 2. Install MySQL and MySQL Workbench

Start by downloading the MySQL Community Server .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the *No thanks, just start my download link*.
2. Follow along with the Install, once on the configuation make sure you:
- Use Legacy Password Encryption.
- Set a unique password
3. Once finished, open your terminal and enter the command echo `export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in .bash_profile, which is where our terminal is configured.
4. Next, download the MySQL Workbench .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484391). Again, use the *No thanks, just start my download link*.
5.Install MySQL Workbench to Applications folder.

*more instructions coming soon*


### 3. Clone this [repository](https://github.com/christinereina/LocalBusiness.Solution) from GitHub
```
cd desktop
git clone https://github.com/christinereina/LocalBusiness.Solution
cd Wonka.Solution
```
### 4. Install the necessary dependencies to build the project, run the following commands in your Terminal:
```
dotnet restore
dotnet build
dotnet run
```
### 4. Create the database and project tables
```
dotnet ef database update
```
### 6. Starting the Server

Initialize a local server to run the project in your browser
```
dotnet watch run
```

If you are running the script locally, it will open the project in your browser window and shift the focus from the terminal to the browser. If not, you can copy and paste this address to view:

```
http://127.0.0.1:5000
```


## Known Bugs

Swagger is not yet correctly implemented (8.21.2020)

## Support and contact details

Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns.


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* EF Core
* ASP.NET Core Identity
* Razor 2.2.0
* Visual Studio Code
* Git Version Control 
* GitHub
* [Swagger](https://swagger.io/)


### License

[MIT](https://mit-license.org/)

Copyright (c) 2020 **Christine Augustine**