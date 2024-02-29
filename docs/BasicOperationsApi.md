# dam.Api.BasicOperationsApi

All URIs are relative to *https://dam.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchUploadAssets**](BasicOperationsApi.md#batchuploadassets) | **POST** /dam.Dam/BatchUploadAssets | Batch Upload Assets |
| [**BatchUploadAssets_0**](BasicOperationsApi.md#batchuploadassets_0) | **POST** /dam/batch_upload_assets | Batch Upload Assets |
| [**CreateAsset**](BasicOperationsApi.md#createasset) | **POST** /dam.Dam/CreateAsset | Create Asset |
| [**CreateAsset_0**](BasicOperationsApi.md#createasset_0) | **POST** /dam/create_asset | Create Asset |
| [**GetAssetByCode**](BasicOperationsApi.md#getassetbycode) | **POST** /dam.Dam/GetAssetByCode | Get Asset By Code |
| [**GetAssetByCode_0**](BasicOperationsApi.md#getassetbycode_0) | **POST** /dam/get_asset_by_code | Get Asset By Code |
| [**ListAssets**](BasicOperationsApi.md#listassets) | **POST** /dam.Dam/ListAssets | List Assets |
| [**ListAssetsByCodes**](BasicOperationsApi.md#listassetsbycodes) | **POST** /dam.Dam/ListAssetsByCodes | List Assets By Codes |
| [**ListAssetsByCodes_0**](BasicOperationsApi.md#listassetsbycodes_0) | **POST** /dam/list_assets_by_codes | List Assets By Codes |
| [**ListAssetsByIds**](BasicOperationsApi.md#listassetsbyids) | **POST** /dam.Dam/ListAssetsByIds | List Assets By Ids |
| [**ListAssetsByIds_0**](BasicOperationsApi.md#listassetsbyids_0) | **POST** /dam/list_assets_by_ids | List Assets By Ids |
| [**ListAssets_0**](BasicOperationsApi.md#listassets_0) | **POST** /dam/list_assets | List Assets |
| [**UpdateAsset**](BasicOperationsApi.md#updateasset) | **POST** /dam.Dam/UpdateAsset | Update Asset |
| [**UpdateAsset_0**](BasicOperationsApi.md#updateasset_0) | **POST** /dam/update_asset | Update Asset |

<a id="batchuploadassets"></a>
# **BatchUploadAssets**
> DamBatchUploadAssetsResponse BatchUploadAssets (DamBatchUploadAssetsRequest body)

Batch Upload Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class BatchUploadAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamBatchUploadAssetsRequest(); // DamBatchUploadAssetsRequest | 

            try
            {
                // Batch Upload Assets
                DamBatchUploadAssetsResponse result = apiInstance.BatchUploadAssets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.BatchUploadAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUploadAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch Upload Assets
    ApiResponse<DamBatchUploadAssetsResponse> response = apiInstance.BatchUploadAssetsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.BatchUploadAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamBatchUploadAssetsRequest**](DamBatchUploadAssetsRequest.md) |  |  |

### Return type

[**DamBatchUploadAssetsResponse**](DamBatchUploadAssetsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="batchuploadassets_0"></a>
# **BatchUploadAssets_0**
> DamBatchUploadAssetsResponse BatchUploadAssets_0 (DamBatchUploadAssetsRequest body)

Batch Upload Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class BatchUploadAssets_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamBatchUploadAssetsRequest(); // DamBatchUploadAssetsRequest | 

            try
            {
                // Batch Upload Assets
                DamBatchUploadAssetsResponse result = apiInstance.BatchUploadAssets_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.BatchUploadAssets_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUploadAssets_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch Upload Assets
    ApiResponse<DamBatchUploadAssetsResponse> response = apiInstance.BatchUploadAssets_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.BatchUploadAssets_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamBatchUploadAssetsRequest**](DamBatchUploadAssetsRequest.md) |  |  |

### Return type

[**DamBatchUploadAssetsResponse**](DamBatchUploadAssetsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createasset"></a>
# **CreateAsset**
> DamAsset CreateAsset (DamCreateAssetRequest body)

Create Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class CreateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamCreateAssetRequest(); // DamCreateAssetRequest | 

            try
            {
                // Create Asset
                DamAsset result = apiInstance.CreateAsset(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.CreateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Asset
    ApiResponse<DamAsset> response = apiInstance.CreateAssetWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.CreateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamCreateAssetRequest**](DamCreateAssetRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createasset_0"></a>
# **CreateAsset_0**
> DamAsset CreateAsset_0 (DamCreateAssetRequest body)

Create Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class CreateAsset_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamCreateAssetRequest(); // DamCreateAssetRequest | 

            try
            {
                // Create Asset
                DamAsset result = apiInstance.CreateAsset_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.CreateAsset_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAsset_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Asset
    ApiResponse<DamAsset> response = apiInstance.CreateAsset_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.CreateAsset_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamCreateAssetRequest**](DamCreateAssetRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getassetbycode"></a>
# **GetAssetByCode**
> DamAsset GetAssetByCode (DamGetAssetByCodeRequest body)

Get Asset By Code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class GetAssetByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamGetAssetByCodeRequest(); // DamGetAssetByCodeRequest | 

            try
            {
                // Get Asset By Code
                DamAsset result = apiInstance.GetAssetByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.GetAssetByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset By Code
    ApiResponse<DamAsset> response = apiInstance.GetAssetByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.GetAssetByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamGetAssetByCodeRequest**](DamGetAssetByCodeRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getassetbycode_0"></a>
# **GetAssetByCode_0**
> DamAsset GetAssetByCode_0 (DamGetAssetByCodeRequest body)

Get Asset By Code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class GetAssetByCode_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamGetAssetByCodeRequest(); // DamGetAssetByCodeRequest | 

            try
            {
                // Get Asset By Code
                DamAsset result = apiInstance.GetAssetByCode_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.GetAssetByCode_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetByCode_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset By Code
    ApiResponse<DamAsset> response = apiInstance.GetAssetByCode_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.GetAssetByCode_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamGetAssetByCodeRequest**](DamGetAssetByCodeRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassets"></a>
# **ListAssets**
> DamListAssetsResponse ListAssets (DamListAssetsRequest body)

List Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsRequest(); // DamListAssetsRequest | 

            try
            {
                // List Assets
                DamListAssetsResponse result = apiInstance.ListAssets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets
    ApiResponse<DamListAssetsResponse> response = apiInstance.ListAssetsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsRequest**](DamListAssetsRequest.md) |  |  |

### Return type

[**DamListAssetsResponse**](DamListAssetsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassetsbycodes"></a>
# **ListAssetsByCodes**
> DamListAssetsByCodesResponse ListAssetsByCodes (DamListAssetsByCodesRequest body)

List Assets By Codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssetsByCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsByCodesRequest(); // DamListAssetsByCodesRequest | 

            try
            {
                // List Assets By Codes
                DamListAssetsByCodesResponse result = apiInstance.ListAssetsByCodes(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsByCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets By Codes
    ApiResponse<DamListAssetsByCodesResponse> response = apiInstance.ListAssetsByCodesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsByCodesRequest**](DamListAssetsByCodesRequest.md) |  |  |

### Return type

[**DamListAssetsByCodesResponse**](DamListAssetsByCodesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassetsbycodes_0"></a>
# **ListAssetsByCodes_0**
> DamListAssetsByCodesResponse ListAssetsByCodes_0 (DamListAssetsByCodesRequest body)

List Assets By Codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssetsByCodes_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsByCodesRequest(); // DamListAssetsByCodesRequest | 

            try
            {
                // List Assets By Codes
                DamListAssetsByCodesResponse result = apiInstance.ListAssetsByCodes_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByCodes_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsByCodes_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets By Codes
    ApiResponse<DamListAssetsByCodesResponse> response = apiInstance.ListAssetsByCodes_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByCodes_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsByCodesRequest**](DamListAssetsByCodesRequest.md) |  |  |

### Return type

[**DamListAssetsByCodesResponse**](DamListAssetsByCodesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassetsbyids"></a>
# **ListAssetsByIds**
> DamListAssetsByIdsResponse ListAssetsByIds (DamListAssetsByIdsRequest body)

List Assets By Ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssetsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsByIdsRequest(); // DamListAssetsByIdsRequest | 

            try
            {
                // List Assets By Ids
                DamListAssetsByIdsResponse result = apiInstance.ListAssetsByIds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets By Ids
    ApiResponse<DamListAssetsByIdsResponse> response = apiInstance.ListAssetsByIdsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsByIdsRequest**](DamListAssetsByIdsRequest.md) |  |  |

### Return type

[**DamListAssetsByIdsResponse**](DamListAssetsByIdsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassetsbyids_0"></a>
# **ListAssetsByIds_0**
> DamListAssetsByIdsResponse ListAssetsByIds_0 (DamListAssetsByIdsRequest body)

List Assets By Ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssetsByIds_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsByIdsRequest(); // DamListAssetsByIdsRequest | 

            try
            {
                // List Assets By Ids
                DamListAssetsByIdsResponse result = apiInstance.ListAssetsByIds_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByIds_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsByIds_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets By Ids
    ApiResponse<DamListAssetsByIdsResponse> response = apiInstance.ListAssetsByIds_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssetsByIds_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsByIdsRequest**](DamListAssetsByIdsRequest.md) |  |  |

### Return type

[**DamListAssetsByIdsResponse**](DamListAssetsByIdsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listassets_0"></a>
# **ListAssets_0**
> DamListAssetsResponse ListAssets_0 (DamListAssetsRequest body)

List Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class ListAssets_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamListAssetsRequest(); // DamListAssetsRequest | 

            try
            {
                // List Assets
                DamListAssetsResponse result = apiInstance.ListAssets_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListAssets_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssets_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Assets
    ApiResponse<DamListAssetsResponse> response = apiInstance.ListAssets_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListAssets_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamListAssetsRequest**](DamListAssetsRequest.md) |  |  |

### Return type

[**DamListAssetsResponse**](DamListAssetsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateasset"></a>
# **UpdateAsset**
> DamAsset UpdateAsset (DamUpdateAssetRequest body)

Update Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamUpdateAssetRequest(); // DamUpdateAssetRequest | 

            try
            {
                // Update Asset
                DamAsset result = apiInstance.UpdateAsset(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UpdateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Asset
    ApiResponse<DamAsset> response = apiInstance.UpdateAssetWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UpdateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamUpdateAssetRequest**](DamUpdateAssetRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateasset_0"></a>
# **UpdateAsset_0**
> DamAsset UpdateAsset_0 (DamUpdateAssetRequest body)

Update Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dam.Api;
using dam.Client;
using dam.Model;

namespace Example
{
    public class UpdateAsset_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dam.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new DamUpdateAssetRequest(); // DamUpdateAssetRequest | 

            try
            {
                // Update Asset
                DamAsset result = apiInstance.UpdateAsset_0(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UpdateAsset_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAsset_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Asset
    ApiResponse<DamAsset> response = apiInstance.UpdateAsset_0WithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UpdateAsset_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DamUpdateAssetRequest**](DamUpdateAssetRequest.md) |  |  |

### Return type

[**DamAsset**](DamAsset.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When an endpoint receives a request with an invalid or unauthorized JWT token, a 401 error (Unauthorized) is thrown. This error indicates that the client is not authenticated or lacks the necessary permissions to access the requested resource. The server responds with the 401 error to enforce security measures and restrict unauthorized access. Clients should handle this error by taking appropriate actions, such as re-authenticating or obtaining a valid token, to gain authorized access. |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

