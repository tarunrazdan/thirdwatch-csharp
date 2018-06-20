# ai.thirdwatch.Api.CreateOrderApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrder**](CreateOrderApi.md#createorder) | **POST** /v1/createOrder | Submit a new or existing order to Thirdwatch for review. This API should contain order item info, the payment info, and user identity info.


<a name="createorder"></a>
# **CreateOrder**
> EventResponse CreateOrder (CreateOrder body)

Submit a new or existing order to Thirdwatch for review. This API should contain order item info, the payment info, and user identity info.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new CreateOrderApi();
            var body = new CreateOrder(); // CreateOrder | An order to submit for review. Only `_userID` is required field. But this should contain order info.

            try
            {
                // Submit a new or existing order to Thirdwatch for review. This API should contain order item info, the payment info, and user identity info.
                EventResponse result = apiInstance.CreateOrder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateOrderApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateOrder**](CreateOrder.md)| An order to submit for review. Only &#x60;_userID&#x60; is required field. But this should contain order info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

