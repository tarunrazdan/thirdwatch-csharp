# ai.thirdwatch.Api.AddToCartApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToCart**](AddToCartApi.md#addtocart) | **POST** /v1/add_to_cart | Use add_to_cart when a user adds an item to their shopping cart or list.


<a name="addtocart"></a>
# **AddToCart**
> EventResponse AddToCart (AddToCart JSON)

Use add_to_cart when a user adds an item to their shopping cart or list.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class AddToCartExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new AddToCartApi();
            var JSON = new AddToCart(); // AddToCart | Pass added item info to thirdwatch. Only `_userID` is required field. But this should contain item info.

            try
            {
                // Use add_to_cart when a user adds an item to their shopping cart or list.
                EventResponse result = apiInstance.AddToCart(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddToCartApi.AddToCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**AddToCart**](AddToCart.md)| Pass added item info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain item info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

