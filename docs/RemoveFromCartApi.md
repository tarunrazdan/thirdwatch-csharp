# ai.thirdwatch.Api.RemoveFromCartApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RemoveFromCart**](RemoveFromCartApi.md#removefromcart) | **POST** /v1/remove_from_cart | Use remove_from_cart when a user removes an item from their shopping cart or list.


<a name="removefromcart"></a>
# **RemoveFromCart**
> EventResponse RemoveFromCart (RemoveFromCart JSON)

Use remove_from_cart when a user removes an item from their shopping cart or list.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class RemoveFromCartExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new RemoveFromCartApi();
            var JSON = new RemoveFromCart(); // RemoveFromCart | Pass removed item info to thirdwatch. Only `_userID` is required field. But this should contain item info.

            try
            {
                // Use remove_from_cart when a user removes an item from their shopping cart or list.
                EventResponse result = apiInstance.RemoveFromCart(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoveFromCartApi.RemoveFromCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**RemoveFromCart**](RemoveFromCart.md)| Pass removed item info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain item info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

