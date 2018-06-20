# ai.thirdwatch.Api.OrderStatusApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderStatus**](OrderStatusApi.md#orderstatus) | **POST** /v1/order_status | Use order_status to track the order processing workflow of a previously submitted order.


<a name="orderstatus"></a>
# **OrderStatus**
> EventResponse OrderStatus (OrderStatus JSON)

Use order_status to track the order processing workflow of a previously submitted order.

For example, order_status can be used to indicate that an order has been held for review, canceled due to suspected fraud, or fulfilled. This event can be called multiple times to record changes an order's status. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class OrderStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new OrderStatusApi();
            var JSON = new OrderStatus(); // OrderStatus | Pass order status to thirdwatch. Only `_userID` is required field. But this should contain order info.

            try
            {
                // Use order_status to track the order processing workflow of a previously submitted order.
                EventResponse result = apiInstance.OrderStatus(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderStatusApi.OrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**OrderStatus**](OrderStatus.md)| Pass order status to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain order info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

