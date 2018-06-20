# ai.thirdwatch.Api.UpdateOrderApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateOrder**](UpdateOrderApi.md#updateorder) | **POST** /v1/update_order | Update details of an existing order.


<a name="updateorder"></a>
# **UpdateOrder**
> EventResponse UpdateOrder (UpdateOrder JSON)

Update details of an existing order.

* This event contains the same fields as ```create_order```. * The existing order will be completely replaced by the values sent in `update_order`. Be sure to specify all values for the order, not just those that changed. * If no matching `_orderId` found, a new order will be created. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new UpdateOrderApi();
            var JSON = new UpdateOrder(); // UpdateOrder | Update details of an existing order. Only `_userID` is required field. But this should contain existing order info.

            try
            {
                // Update details of an existing order.
                EventResponse result = apiInstance.UpdateOrder(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdateOrderApi.UpdateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**UpdateOrder**](UpdateOrder.md)| Update details of an existing order. Only &#x60;_userID&#x60; is required field. But this should contain existing order info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

