# ai.thirdwatch.Api.LoginApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](LoginApi.md#login) | **POST** /v1/login | Use login to record when a user attempts to log in.


<a name="login"></a>
# **Login**
> EventResponse Login (Login JSON)

Use login to record when a user attempts to log in.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new LoginApi();
            var JSON = new Login(); // Login | Pass login status to thirdwatch. Only `_userID` is required field. But this should contain login info.

            try
            {
                // Use login to record when a user attempts to log in.
                EventResponse result = apiInstance.Login(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**Login**](Login.md)| Pass login status to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain login info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

