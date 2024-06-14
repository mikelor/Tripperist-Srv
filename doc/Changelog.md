# Changelog
Newest changes listed first. 
The goal of this is to capture the changes needed to get a workable solution up and running. 
This will help me remember what changes to make in future backend projects. For now it will be extremely verbose.

## 2024.06.14.02 - Attempted Option B But Unsuccessful
I attempted to follow instructions for Linux and WSL, however I was unable to get to work. For now we are going forward with Option A. Filing an Issue in this GitHub repository.

## 2024.06.14.01 - Implemented Option A
Allow Unsecured Transport via Settings File
**ASPIRE_ALLOW_UNSECURED_TRANSPORT** environment variable in the AppHost  */properties/launchSettings.json* file to **"true"**

## 2024.06.14.01 - Add solution to github
1. Create tripperist-srv on github
2. git clohne https://github.com/mikelor/tripperist-srv
3. dotnet new aspire-starter -n Tripperist
4. git add .
5. git commit -m "Initial Project Version
6. dotnet build
7. dotnet run

```
warn: Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServer[8]
      The ASP.NET Core developer certificate is not trusted. For information about trusting the ASP.NET Core developer certificate, see https://aka.ms/aspnet/https-trust-dev-cert.
```
[Cause and Fix Described Here](https://learn.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-8.0&tabs=visual-studio%2Clinux-ubuntu#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos)

### Option A - Allow Unsecured Transport via Settings File
**ASPIRE_ALLOW_UNSECURED_TRANSPORT** environment variable in the AppHost  */properties/launchSettings.json* file to **"true"**
```
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "http://localhost:15234",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "DOTNET_ENVIRONMENT": "Development",
        "DOTNET_DASHBOARD_OTLP_ENDPOINT_URL": "http://localhost:19172",
        "DOTNET_RESOURCE_SERVICE_ENDPOINT_URL": "http://localhost:20185",
        "ASPIRE_ALLOW_UNSECURED_TRANSPORT": "true"
      }
```

### Option B - Trust Dev Cert
```
dotnet dev-certs https --trust
```
If running on Linux, follow [these instructions](https://learn.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-8.0&tabs=visual-studio%2Clinux-ubuntu#ssl-linux).