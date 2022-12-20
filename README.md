# Load Testing Demo

This is a demo repository about Azure Load Testing in CI/CD with Azure DevOps and GitHub.

Check out the [blog post about this repository](https://xpirit.com/adding-load-testing-to-your-workflows).

## Want to try it out?

If you would like to try this demo/project. You will need to deploy the following Azure resources:

- Azure Cosmos DB (free tier)
- Azure App Service Plan (Basic B1)
- Azure Web App (Linux - .NET 7)
- Azure Application Insights (With Log Analytics)

You can use the following ARM template to deploy the resources needed:

[![Deploy to Azure](img/deploy.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fdsanchezcr%2FLoadTestingDemo%2Fmain%2FARM%2Ftemplate.json)