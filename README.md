# Pulumi AzureCaf Resource Provider

This provider implements a set of methodologies for naming convention implementation including the default Microsoft Cloud Adoption Framework for Azure recommendations as per https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/naming-and-tagging.

This Provider is a Bridged Terraform Provider for [AzureCaf](https://github.com/aztfmod/terraform-provider-azurecaf)

## Installing

### Provider Binary

Download the Provider Binary
```bash
wget 
https://github.com/BinaryBrilliance/pulumi-azurecaf/releases/download/v0.0.0/pulumi-resource-azurecaf-v0.0.0-linux-amd64.tar.gz
tar xfv pulumi-resource-azurecaf-v0.0.0-linux-amd64.tar.gz
# Add the Provider Binary to your path
export PATH=$PATH:$(pwd)
```

### .NET

Add the Nuget Package Source
```bash
dotnet nuget add source \
--name binarybrilliance \
--username {your-username} \
--password {github-pat} --store-password-in-clear-text \
https://nuget.pkg.github.com/BinaryBrilliance/index.json
```
To use from .NET, install using `dotnet add package`:

```bash
dotnet add package BinaryBrilliance.AzureCaf
```

## Reference

For detailed reference documentation, please visit [AzureCaf](https://github.com/aztfmod/terraform-provider-azurecaf).
