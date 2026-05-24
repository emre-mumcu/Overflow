dotnet run --project Overflow.AppHost

# Overflow Readme

[https://aspire.dev/docs/](Aspire)

## Prerequisites

dotnet --info
docker --version
dotnet new list
dotnet new install Aspire.ProjectTemplates
dotnet new list

dotnet dev-certs https --check
dotnet dev-certs https --clean
dotnet dev-certs https --trust
dotnet dev-certs https --check --verbose

## Create Owerflow Project

dotnet new sln -n Overflow
dotnet new sln -n Overflow --format sln
cd Overflow
dotnet new aspire-apphost -n Overflow.AppHost
dotnet new aspire-servicedefaults -n Overflow.ServiceDefaults
dotnet sln add Overflow.AppHost/Overflow.AppHost.csproj
dotnet sln add Overflow.ServiceDefaults/Overflow.ServiceDefaults.csproj

F1
Developer: Reload Window

dotnet run --project Overflow.AppHost

## Keycloak Setup

[https://aspire.dev/integrations/security/keycloak/](Keycloak)

Add the following package to the Overflow.AppHost project:

Hosting integration:
dotnet add package Aspire.Hosting.Keycloak --prerelease

### Keycloak Configuration

1. Create a permanent admin user: kc-admin and set its password and add admin realm role.
2. Create a new realm: overflow and add a new user to this realm.
3. Create a new Client for overflow realm with direct access grants Authentication flow.
4. Edit the Postman client Client Scope. Edit the postman-dedicated assigned client scope. Turn off Full scope allowed. Then, configure a new mapper, by configuration. Select Audiance.
5. Configure roles. Create a new group called member. Add the user to this group. Add another group, called admin. Add a new admin user and add this user to the admin group.
6. Using Realm Settings, User registration, Default groups, Click Add Group button and select member group. This makes any newly registered user to have member group.
7. Edit the Postman client Client Scope. Edit the postman-dedicated assigned client scope. Turn off Full scope allowed. Then, configure a new mapper, by configuration. Select Grou pMembership.

[https://www.jwt.io/](JWT)

### Github Repository

```bash

dotnet new gitignore

# Create git repo and first commit:
git init
git add .
git commit -m "First commit"
git branch -M main
git remote add origin https://github.com/emre-mumcu/Overflow.git
git push -u origin main

# Subsequent commits:
git remote add origin https://github.com/emre-mumcu/Overflow.git
git branch -M main
git push -u origin main
https://github.com/emre-mumcu/Overflow.git
```

### Question Service

Overflow\services> dotnet new webapi -n QuestionService --use-controllers --no-https
Overflow> dotnet sln add .\services\QuestionService\QuestionService.csproj
Overflow> dotnet add Overflow.AppHost reference .\services\QuestionService\QuestionService.csproj  
Overflow> dotnet add .\services\QuestionService\ reference .\Overflow.ServiceDefaults\Overflow.ServiceDefaults.csproj

Add the following package to the QuestionService project:

Client integration:
dotnet add package Aspire.Keycloak.Authentication --prerelease

### User Secrets







dotnet run --project Overflow.AppHost
