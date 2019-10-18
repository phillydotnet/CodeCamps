# Azure DevOps Hands On : Rich Ross
Rich Ross works for Microsoft
Chris Gomez is a Microsoft MVP (does NOT work for Microsoft)

*This document does not reflect opinions or guidance directly from Microsoft, but hopefully will allow attendees to reflect upon the collaborative conversation. -- Chris Gomez*

## Presentations

## Conversations

### Feature Flags

**Azure DevOps Case Studies and Best Practices** - In the Azure DevOps docs, there is a short collection of articles on practices that the team themselves enabled through DevOps.

[Feature Flags](https://docs.microsoft.com/en-us/azure/devops/migrate/phase-features-with-feature-flags?view=azure-devops) - Azure DevOps team promoted feature flags as a best practice in their own documentation on case studies.

[LaunchDarkly](https://launchdarkly.com/) - Well known product that enables and manages continuous delivery of features behind feature flags (this was not discussed in the presentation but suggested as an example tool).

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
- Each project (one or more in an organization)
    - Contain zero or one TFVC (similar to a collection in TFS/Azure DevOps Server)
    - Contain zero or more Git repositories
    - Not mutally exclusive, can live side-by-side
    - [What is source control?](https://docs.microsoft.com/en-us/azure/devops/user-guide/source-control?view=azure-devops)

## Azure Pipelines
- [Deploy to AWS](https://azure.microsoft.com/en-us/blog/azure-pipelines-is-the-ci-cd-solution-for-any-language-any-platform-any-cloud/)
