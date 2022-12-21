# Load Testing Demo

This is a demo repository about Azure Load Testing in CI/CD with Azure DevOps and GitHub.

Check out the [blog post about this repository](https://xpirit.com/adding-load-testing-to-your-workflows).

## GitHub Action Badge
[![Build-Deploy-WebApp](https://github.com/dsanchezcr/LoadTestingDemo/actions/workflows/workflow.yml/badge.svg)](https://github.com/dsanchezcr/LoadTestingDemo/actions/workflows/workflow.yml)

## Want to try it out?

If you would like to try this demo/project. You can fork this repository and we the ARM template you can deploy the following Azure resources:

- Azure Cosmos DB (free tier)
- Azure App Service Plan (Basic B1)
- Azure Web App (Linux - .NET 7)
- Azure Application Insights (With Log Analytics)
- Azure Load Testing

[![Deploy to Azure](img/deploy.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fdsanchezcr%2FLoadTestingDemo%2Fmain%2FARM%2Ftemplate.json)

> Note: Azure Cosmos DB is going to be created using the [free tier](https://learn.microsoft.com/azure/cosmos-db/free-tier), which only allows one per subscription, if you have already another Cosmos DB free tier, you will get a deployment error.

## Setting up the GitHub Action

To run the GitHub Action you will need to create the following two GitHub Secrets:

- AZURE_CREDENTIALS: This is used to give access to the workflow to authenticate with the Azure Load Testing by using a Service Principal, you can [follow the steps in this guide](https://github.com/Azure/load-testing#azure-service-principal-for-rbac) to get the credentials needed.
- AZURE_WEBAPP_SECRET: This is the publishing profile from the Azure Web App that was created before, it is used by the GitHub Action to deploy the web application.