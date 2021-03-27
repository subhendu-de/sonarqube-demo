# Setting up SonarCloud for .net Core

Maintaining technical quality of an application is not an easy task. SonarCloud - a cloud version of the SonarQube helps to measure the technical quality of an application. This article helps you to setup the SonarCloud for a .net Core based application.

## Getting Started

You can easily setup the application by cloning the repo. Please find the list of folders and files

```bash
|_ SampleWebApp (a basic .net core mvc application)
|_ azure-pipelines.yml (yml based build pipeline)
```
### Prerequisites

The demo uses three products
* [GitHub](https://maven.apache.org/) - To host the files and version them
* [Azure Devops](https://dev.azure.com/) - To run the Azure pipeline build
* [SonarCloud](https://sonarcloud.io/) - To analyze the code

### Installing

Take the latest code by cloning the git repo

```bash
git clone https://github.com/subhendu-de/sonarqube-demo.git
```

Open the .net application in visual studio code and run it. The home page is accessible here at https://localhost:5001/Home

```
dotnet build .\SampleWebApp\SampleWebApp.csproj
dotnet run -p .\SampleWebApp\SampleWebApp.csproj
```

Setup a Sonarcloud account and take a note of the token. Connect with Github account and select the sonarqube-demo repo.

Setup a Azure DevOps project and create an Azure pipeline. While setting up the Azure pipeline, point the existing azure-pipeliens.yml file from the repo.

Create a new service connection named svc-sonarcloud and use the same token collected during setting up the SonarCloud account.

Make a code change and raise a pr. Once the pr build is completed, sonar cloud displays the code quality of the new code.

Merge the pr to main branch and sonar cloud displays the code quality of the overall code.
## Contributing

Please feel free to update the repo and send the pr. Please contact me if you need any help.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
