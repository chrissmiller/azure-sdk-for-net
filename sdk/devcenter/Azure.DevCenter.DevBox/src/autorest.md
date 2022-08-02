# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- C:\Users\chrismiller\source\repos\azure-rest-api-specs-pr/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2022-03-01-preview/devbox.json
namespace: Azure.DevCenter.DevBox
security: AADToken
security-scopes: https://devcenter.azure.com/.default
 
```

