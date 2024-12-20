# dam - the C# library for the Dam Service

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Generator version: 7.9.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using dam.Api;
using dam.Client;
using dam.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out dam.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamBatchUploadAssetsRequest(); // DamBatchUploadAssetsRequest | 

            try
            {
                // Batch Upload Assets
                DamBatchUploadAssetsResponse result = apiInstance.BatchUploadAssets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.BatchUploadAssets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dam.api.gogemini.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BasicOperationsApi* | [**BatchUploadAssets**](docs/BasicOperationsApi.md#batchuploadassets) | **POST** /dam.Dam/BatchUploadAssets | Batch Upload Assets
*BasicOperationsApi* | [**BatchUploadAssets_0**](docs/BasicOperationsApi.md#batchuploadassets_0) | **POST** /dam/batch_upload_assets | Batch Upload Assets
*BasicOperationsApi* | [**CreateAsset**](docs/BasicOperationsApi.md#createasset) | **POST** /dam.Dam/CreateAsset | Create Asset
*BasicOperationsApi* | [**CreateAsset_0**](docs/BasicOperationsApi.md#createasset_0) | **POST** /dam/create_asset | Create Asset
*BasicOperationsApi* | [**GetAssetByCode**](docs/BasicOperationsApi.md#getassetbycode) | **POST** /dam.Dam/GetAssetByCode | Get Asset By Code
*BasicOperationsApi* | [**GetAssetByCode_0**](docs/BasicOperationsApi.md#getassetbycode_0) | **POST** /dam/get_asset_by_code | Get Asset By Code
*BasicOperationsApi* | [**ListAssets**](docs/BasicOperationsApi.md#listassets) | **POST** /dam.Dam/ListAssets | List Assets
*BasicOperationsApi* | [**ListAssetsByCodes**](docs/BasicOperationsApi.md#listassetsbycodes) | **POST** /dam.Dam/ListAssetsByCodes | List Assets By Codes
*BasicOperationsApi* | [**ListAssetsByCodes_0**](docs/BasicOperationsApi.md#listassetsbycodes_0) | **POST** /dam/list_assets_by_codes | List Assets By Codes
*BasicOperationsApi* | [**ListAssetsByIds**](docs/BasicOperationsApi.md#listassetsbyids) | **POST** /dam.Dam/ListAssetsByIds | List Assets By Ids
*BasicOperationsApi* | [**ListAssetsByIds_0**](docs/BasicOperationsApi.md#listassetsbyids_0) | **POST** /dam/list_assets_by_ids | List Assets By Ids
*BasicOperationsApi* | [**ListAssets_0**](docs/BasicOperationsApi.md#listassets_0) | **POST** /dam/list_assets | List Assets
*BasicOperationsApi* | [**UpdateAsset**](docs/BasicOperationsApi.md#updateasset) | **POST** /dam.Dam/UpdateAsset | Update Asset
*BasicOperationsApi* | [**UpdateAsset_0**](docs/BasicOperationsApi.md#updateasset_0) | **POST** /dam/update_asset | Update Asset


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AssetMetadata](docs/AssetMetadata.md)
 - [Model.AssetOriginTypes](docs/AssetOriginTypes.md)
 - [Model.BatchUploadAssetsRequestFiles](docs/BatchUploadAssetsRequestFiles.md)
 - [Model.DamAsset](docs/DamAsset.md)
 - [Model.DamAssetOrigin](docs/DamAssetOrigin.md)
 - [Model.DamAssetType](docs/DamAssetType.md)
 - [Model.DamBatchUploadAssetsRequest](docs/DamBatchUploadAssetsRequest.md)
 - [Model.DamBatchUploadAssetsResponse](docs/DamBatchUploadAssetsResponse.md)
 - [Model.DamCreateAssetRequest](docs/DamCreateAssetRequest.md)
 - [Model.DamGetAssetByCodeRequest](docs/DamGetAssetByCodeRequest.md)
 - [Model.DamListAssetsByCodesRequest](docs/DamListAssetsByCodesRequest.md)
 - [Model.DamListAssetsByCodesResponse](docs/DamListAssetsByCodesResponse.md)
 - [Model.DamListAssetsByIdsRequest](docs/DamListAssetsByIdsRequest.md)
 - [Model.DamListAssetsByIdsResponse](docs/DamListAssetsByIdsResponse.md)
 - [Model.DamListAssetsRequest](docs/DamListAssetsRequest.md)
 - [Model.DamListAssetsResponse](docs/DamListAssetsResponse.md)
 - [Model.DamUpdateAssetRequest](docs/DamUpdateAssetRequest.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.RpcStatus](docs/RpcStatus.md)
 - [Model.UpdateAssetRequestPayload](docs/UpdateAssetRequestPayload.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

