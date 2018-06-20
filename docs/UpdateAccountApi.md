# ai.thirdwatch.Api.UpdateAccountApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateAccount**](UpdateAccountApi.md#updateaccount) | **POST** /v1/update_account | Use update_account to record changes to the user&#39;s account information.


<a name="updateaccount"></a>
# **UpdateAccount**
> EventResponse UpdateAccount (UpdateAccount JSON)

Use update_account to record changes to the user's account information.

For user accounts created before integration with Thirdwatch, there's no need to call `create_account` before `update_account`. Simply call `update_account` and we'll infer that account was created before integration. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new UpdateAccountApi();
            var JSON = new UpdateAccount(); // UpdateAccount | Pass user details after update or change in user info. Only `_userID` is required field. But this should contain user info.

            try
            {
                // Use update_account to record changes to the user's account information.
                EventResponse result = apiInstance.UpdateAccount(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdateAccountApi.UpdateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**UpdateAccount**](UpdateAccount.md)| Pass user details after update or change in user info. Only &#x60;_userID&#x60; is required field. But this should contain user info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

