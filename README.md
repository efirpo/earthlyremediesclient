
<div style="text-align:center"><img src="https://i.ibb.co/M1QL2Pm/earthly-remedies.png"/></div>

### _Created by Mr.Bates & Mr.Firpo_

## _Description_

Earthly Remedies is an application allowing the access to a hosted API consisting of user submitted naturopathic remedies. Upon registration the user will have access to the remedy details as well as the ability to edit, delete, and rate them. The hosted database features Swagger for up to date documentation of all api calls made via the application.


## _Setup/Installation Requirements_ 

### To Access the client side:
1. Clone this projects repository into your local directory following [these](https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/) instructions.

2. Open the now local project folder with [VSC](https://code.visualstudio.com/Download) or an equivalent

3. Download [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows) then enter the following command in the terminal to confirm installation (2.2 or higher)
```sh
dotnet -- version
``` 
4. Still in the command line, enter
```sh
dotnet tool install -g 
dotnet-script
```
5. Download [ASP.NET Core](https://dotnet.microsoft.com/download) to enable live viewing on a local server

6. Open the repository, navigate to the containing folder of the project & Enter the following command to confirm build stability 

```sh
dotnet run build 
```

7. Within that same containing folder enter the following to open a live server w/auto updated viewing
```sh
dotnet watch run
``` 
8. Go to your browser and enter the following url:

```sh
http://localhost:5000
```
### To Access the API server with Swagger UI:
1. Clone [this](url goes here) project repository into your local directory
2. Repeat steps 2-6 of the _Client Side_ instructions.
3. Follow the steps below to set up MySQL Workbench.
4. If you haven't already, initiate a data migration by entering the following into your terminal:
```
dotnet ef migrations addDATABASE
```
5. Once this successfully employs, enter the following to update the data tables to correlate with the project models:
```
dotnet ef database update
```
6. Next, enter the following to open a live server w/auto updated viewing
```sh
dotnet watch run
``` 
7. Go to your browser and enter the following url:

```sh
http://localhost:5003
```
**Keep this server running** while navigating through the client side of the application to achieve full functionality of the project.

### MySQL Installation & Configuration:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.
6. Within the project directory, create a file called "appsettings.json" and fill it with the following code:
```sh
"AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=root;pwd=[YOUR PASSWORD GOES HERE];"
  }
```
7. Next, initiate a data migration by entering the following into your terminal:
```
dotnet ef migrations addDATABASE
```
8. Once this successfully employs, enter the following to update the data tables to correlate with the project models:
```
dotnet ef database update
```
9. Continue to the rest of the _Client Side_ setup instructions.

## _Technology Used_

## <a href="https://en.wikipedia.org/wiki/C_Sharp_%28programming_language%29">C#</a>
## <a href="https://en.wikipedia.org/wiki/.NET_Core">.NET Core</a>
## <a href="https://www.postman.com/">Postman</a>
## <a href="https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/entity-sql-language">Entity</a>
## <a href="https://github.com/swagger-api">Swagger</a>
## <a href="https://www.mysql.com/products/workbench/">MySQL Workbench</a>

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|User is greeted and given option to register as new user or login as existing user|"home"|"localhost.5003/"|
|User can search existing remedies by name|"fungus foiler"|"5003/?name=fungusfoiler"|
|User can search existing remedies by category|"Skin"|"5003/?category=skin"|
|User can search existing remedies by rating|"5"|"5003/?rating=5"|
|User can add remedy via form submission |"Add New Remedy"|"5003/remedies/{remedyId}"|
|User can edit extising remedy information|"Edit Remedy"|"5003/edit/{remedyId}"|
|User can delete existing remedy|"Delete Remedy"|"5003/remedies/{remedyId}/delete"|


## _Legal_

#### MIT License

### Copyright (c) 2020 Mr.Bates & Mr.Firpo @ Epicodus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.