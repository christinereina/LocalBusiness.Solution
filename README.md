# <h1 align = "center"> Local Business Finder (Miyazaki Edition)

<p align="center">

![Preview](miyazaki_preview.png)

##### <h4 align = "center">  Building an API, Indepedent Project for Epicodus, 08.21.2020

#### <h4 align = "center"> By _**Christine Augustine**_
</p>

## Description

This project will create an API for a fictional local business lookup within the Studio Ghibili universe. The API will list different businesses available.  

## Setup/Installation Requirements 

### Install .NET Core 

Download .NET Core SDK from Microsoft Corp  (**[macOS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) | [Windows OS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)**)

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal 

### Install MySQL and MySQL Workbench

Start by downloading the MySQL Community Server .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the *No thanks, just start my download link*.
2. Follow along with the Install, once on the configuation make sure you:
- Use Legacy Password Encryption.
- Set a unique password
3. Once finished, open your terminal and enter the command echo `export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in .bash_profile, which is where our terminal is configured.
4. Next, download the MySQL Workbench .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484391). Again, use the *No thanks, just start my download link*.
5.Install MySQL Workbench to Applications folder.

#### [Download and install Postman](https://www.postman.com/downloads/)  (Optional) 

### Clone this [repository](https://github.com/christinereina/LocalBusiness.Solution) from GitHub
```
cd desktop
git clone https://github.com/christinereina/LocalBusiness.Solution
cd Wonka.Solution
```

### AppSettings

 Create a new file named `appsettings.json` in the LocalBusiness.Solution/LocalBusiness directory. Add the following code:
  
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=local_business;uid=root;pwd=YOUR_PASSWORD_HERE;"
  }
}
  ```
Change the server, port, and userid as needed. Replace YOUR_PASSWORD_HERE with the password used for MySQL.

### Create the database and project tables

Navigate to LocalBusiness.Solution/LocalBusiness. Run the following command in the terminal:

```
dotnet ef database update
```
### Launch the API

Initialize a local server to access the API in your browser or in Postman. Run the following command in the terminal:

```
dotnet watch run
```

If you are running the script locally, it will open the project in your browser window and shift the focus from the terminal to the browser. If not, you can copy and paste this address to view:

```
http://127.0.0.1:5000
```

## API Documentation

See the API endpoints in Postman or a browser.

### Using [Swagger](https://swagger.io/) Documentation
To explore the LocalBusiness API, launch the project using `dotnet run` with the Terminal and copy and paste the following URL in your preferred browser

```
`http://localhost:5000/swagger`
```

## Endpoints

```
GET /api/Businesses
POST /api/Businesses
GET /api/Businesses/{id}
PUT /api/Businesses/{id}
DELETE /api/Businesses/{id}
```

## Further Exploration 

Here are some features I would like to incorporate into my API in the future:

* Token-Based Authentication and Authorization
* API Versioning
* Pagination
* Enable CORS

## Known Bugs

n/a

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


## Support and contact details

<p>
    <br>
    <a href="https://github.com/christinereina">
        <img src="https://avatars3.githubusercontent.com/u/59573479?s=60&v=4">
    </a>
    </p>
    <p>
        <a href="https://github.com/christinereina">
            <strong>christinereina</strong>
        </a>
</p>

### License

[MIT](https://mit-license.org/)

Copyright (c) 2020 **Christine Augustine**