# Azure DevOps Hands On : Rich Ross

Rich Ross works for Microsoft
Chris Gomez is a Microsoft MVP (does NOT work for Microsoft)

- [@SpaceShot](https://twitter.com/SpaceShot) on Twitter
- [Mixer](https://mixer.com/SpaceShot) - Live Streams
- [YouTube](https://youtube.com)

## Presentations

## Conversations

### Feature Flags

**Azure DevOps Case Studies and Best Practices** - In the Azure DevOps docs, there is a short collection of articles on practices that the team themselves enabled through DevOps.

[Feature Flags](https://docs.microsoft.com/en-us/azure/devops/migrate/phase-features-with-feature-flags?view=azure-devops) - Azure DevOps team promoted feature flags as a best practice in their own documentation on case studies.

[LaunchDarkly](https://launchdarkly.com/) - Well known product that enables and manages continuous delivery of features behind feature flags (this was not discussed in the presentation but suggested as an example tool).

There is an Azure DevOps LaunchDarkly Lab too: [Feature Flag Management with LaunchDarkly and AzureDevOps](https://azuredevopslabs.com/labs/vstsextend/launchdarkly/)

## Azure Boards

### Open Questions

Note that everything in this section came from discussion and/or Chris Gomez as he was typing.  It does not represent anything we know of in the docs or promoted by Microsoft.

Estimation of work items

- Not seeing a default way to add initial estimation to a story/task
- Important in some orgs to report back out
  - Could be useful to determine a team's standard deviation from estimate, which some research suggests can be determined per team over time, similar to velocity
- Chris found: [Estimate](https://marketplace.visualstudio.com/items?itemName=ms-devlabs.estimate)
- [Azure DevOps extension marketplace](https://marketplace.visualstudio.com/azuredevops)

Reporting out of Azure DevOps

- Roll back up to PM
- Trying to keep everything in one place

Integration with JIRA

- https://devblogs.microsoft.com/devops/azure-pipelines-integration-with-jira-software/

Simpler alternatives
Azure Boards seems very powerful and could be used for large enterprise scale projects.  

Could it be simplified? Possibilities (not vetted, just discovered)
    - [Azure Boards with Trello](https://marketplace.visualstudio.com/items?itemName=ms-vsts.services-trello)
    - [Azure Boards with Zapier](https://marketplace.visualstudio.com/items?itemName=ms-vsts.services-zapier)

## Azure Repos

Azure Repos is a product name.  It is a product (in the Azure DevOps family) that hosts repositories. You can later use Azure Pipelines to build/release (CI/CD), but it is NOT REQUIRED to use Azure Repos.  You might enjoy GitHub, or some other product or have a product in-house in the data center.

- Each project (one or more in an organization)

  - Contain zero or one TFVC (similar to a collection in TFS/Azure DevOps Server)
  - Contain zero or more Git repositories
  - Not mutally exclusive, can live side-by-side
  - Use New Repository to add or Import Repository to import
  - [What is source control?](https://docs.microsoft.com/en-us/azure/devops/user-guide/source-control?view=azure-devops)

- Basic Labs
  - [Version Controlling with Git in Visual Studio Code and Azure DevOps](https://www.azuredevopslabs.com/labs/azuredevops/git/) - You should be able to follow this in Visual Studio (in Team Explorer) fairly easily
  - [Working with Pull Requests in Visual Studio Code and Azure DevOps](https://www.azuredevopslabs.com/labs/azuredevops/pullrequests/)

## Azure Pipelines

- [Deploy to AWS](https://azure.microsoft.com/en-us/blog/azure-pipelines-is-the-ci-cd-solution-for-any-language-any-platform-any-cloud/)
- [Self-Hosted Agents](https://docs.microsoft.com/en-us/azure/devops/pipelines/agents/agents?view=azure-devops#install) - If you need to use your own build agent

Question was asked about ServiceNow integration.  Here is a tutorial on integration with Azure Pipelines: [Integrate with ServiceNow change management](https://docs.microsoft.com/en-us/azure/devops/pipelines/release/approvals/servicenow?view=azure-devops)

- [Multi-stage YAML Pipelines](https://devblogs.microsoft.com/devops/whats-new-with-azure-pipelines/)

### How do you manage multiple environments when secrets are different in dev, test, prod, etc.?

### Labs

Rich demoed this lab:
[Enabling Continuous Integration with Azure Pipelines](https://azuredevopslabs.com/labs/azuredevops/continuousintegration/)

[Using secrets from Azure Key Vault in a pipeline](https://azuredevopslabs.com/labs/vstsextend/azurekeyvault/)

## Azure DevOps Labs

Try the basic labs or the advanced labs that run through more integration scenarios:
https://www.azuredevopslabs.com/

Don't be afraid to scroll down to the Deep Dives, which go into detail on focused scenarios, including some integration scenarios with other products.

## Azure DevOps Labs Generator

Wasn't the lab generator cool?  It creates projects that already havae boards, work items, projects, and pipelines co you can explore more easily.

You can create your own templates for the lab generator from a project you have in Azure DevOps.  You can generate projects from your own templates.
See [Building your own template] (https://docs.microsoft.com/en-us/azure/devops/demo-gen/build-your-own-template?toc=%2Fazure%2Fdevops%2Fdemo-gen%2Ftoc.json&bc=%2Fazure%2Fdevops%2Fdemo-gen%2Fbreadcrumb%2Ftoc.json&view=azure-devops)

## ARM Templates (Azure Resource Manager)

Using the protal is fine when exploring or learning, but you can head to scripting your operations if you obtain an ARM Template.

[Quickstart: Create and deploy Azure Resource Manager templates by using the Azure portal](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-quickstart-create-templates-use-the-portal)

[Manage Azure resources by using Azure PowerShell](https://docs.microsoft.com/en-us/azure/azure-resource-manager/manage-resources-powershell) - This article has links to other articles on accomplishing the same with the CLI. Create a PowerShell Script to deploy resources from templates.

## Azure DevOps Projects

Great way to get started with samples that are end-to-end including Application Insights and CI/CD into Azure: https://azure.microsoft.com/en-au/features/devops-projects/

## API Management

Can API Management configuration setting move from environments via Azure DevOps?

## Azure .NET Core Deployment Worldwide (or on your own)

Status: https://aspnetcoreon.azurewebsites.net/
Deploying Self Contained in Azure DevOps: https://twitter.com/bradygaster/status/1179463110928654336
