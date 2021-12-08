[![Live Demo](https://img.shields.io/badge/live-demo-brightgreen.svg)](https://acsblazor.azurewebsites.net/)

# ACS Blazor

A demonstration of Azure Communication Services capabilities in a Blazor app.

## Prerequisites

- An Azure account with an active subscription. [Create an account for free](https://azure.microsoft.com/free/?WT.mc_id=A261C142F).
- An active Azure Communication Services resource. [Create a Communication Services resource](https://docs.microsoft.com/azure/communication-services/quickstarts/create-communication-resource).
- .NET 6 SDK [Download](https://dotnet.microsoft.com/download/dotnet/6.0)


## Running the app locally

- Add configuration (either in appsettings.json or [user secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows))
```json
{
  "CommunicationConfiguration": {
    "Endpoint": "https://<your_communication_resource>.communication.azure.com/",
    "AccessKey": "<your_access_key>"
  }
}
```
- `dotnet run`
- Open the app in multiple incognito windows to test sending and receiving chat messages