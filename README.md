# Dotnet Core API Application with autodeployment
![bagde](https://img.shields.io/github/languages/top/ErenoGit/Dotnet-Core-API-with-autodeploy) ![bagde2](https://img.shields.io/badge/.NET%20Core-6.0-blue)
Version with working GitLab CI/CD for autodeployment: https://gitlab.com/ErenoGit/dotnet-api-test (requires GitLab Runner configured for schell on your Linux machine). Autodeployment version will automatically upon detecting changes to the main branch pull latest changes to your machine, build a docker image and start the application listening on port 5000.

Application written in .NET Core exposing a simple API for writing and reading a to-do list.

API query list:
GET /api/Todo/GetAll - retrieves a list of all to-do tasks
GET /api/Todo/GetById/<id> - retrieves one specific to-do task
POST /api/Todo/Add - adds a to-do task, required body in format: 
> {
> 'name': "test task",
> "isComplete": false
> }```

The application does not use any database to store saved tasks, so any restart of the application causes the task list to be reset as well.