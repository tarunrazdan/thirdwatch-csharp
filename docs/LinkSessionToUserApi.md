# ai.thirdwatch.Api.LinkSessionToUserApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LinkSessionToUser**](LinkSessionToUserApi.md#linksessiontouser) | **POST** /v1/link_session_to_user | Use link_session_to_user to associate specific session to a user. Generally used only in anonymous checkout workflows.


<a name="linksessiontouser"></a>
# **LinkSessionToUser**
> EventResponse LinkSessionToUser (LinkSessionToUser JSON)

Use link_session_to_user to associate specific session to a user. Generally used only in anonymous checkout workflows.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class LinkSessionToUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new LinkSessionToUserApi();
            var JSON = new LinkSessionToUser(); // LinkSessionToUser | Pass session and user to thirdwatch for link. Only `_userID` is required field. But this should contain session and user info.

            try
            {
                // Use link_session_to_user to associate specific session to a user. Generally used only in anonymous checkout workflows.
                EventResponse result = apiInstance.LinkSessionToUser(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkSessionToUserApi.LinkSessionToUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**LinkSessionToUser**](LinkSessionToUser.md)| Pass session and user to thirdwatch for link. Only &#x60;_userID&#x60; is required field. But this should contain session and user info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

