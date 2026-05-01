# GitHub Secrets Setup for NuGet Publishing

## Requirements

1. Create a NuGet account at [nuget.org](https://nuget.org)
2. Generate an API key from your NuGet account settings
3. Add the API key as a GitHub repository secret

## Steps to Add NuGet API Key

1. Go to your GitHub repository
2. Click on **Settings** > **Secrets and variables** > **Actions**
3. Under **Repository secrets**, click **New repository secret**
4. Name the secret: `NUGET_API_KEY`
5. Paste your NuGet API key as the secret value
6. Click **Add secret**

## Workflow Behavior

The CI/CD workflow will:
- Build and test on every push to main branch and on every pull request
- Only publish to NuGet when pushing directly to the main branch
- Package the project with version 0.1.0
- Upload the package to NuGet.org using the API key

## Manual Publishing

To manually publish the package:
```bash
dotnet pack WpfPrinter/WpfPrinter.csproj --configuration Release
dotnet nuget push *.nupkg --api-key YOUR_NUGET_API_KEY --source https://api.nuget.org/v3/index.json
```