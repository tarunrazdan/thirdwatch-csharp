# ai.thirdwatch.Api.TransactionApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Transaction**](TransactionApi.md#transaction) | **POST** /v1/transaction | Use transaction to record attempts results to Pay, Transfer money, Refund or other transactions.


<a name="transaction"></a>
# **Transaction**
> EventResponse Transaction (Transaction JSON)

Use transaction to record attempts results to Pay, Transfer money, Refund or other transactions.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class TransactionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new TransactionApi();
            var JSON = new Transaction(); // Transaction | Pass transaction results to thirdwatch. Only `_userID` is required field. But this should contain transaction info.

            try
            {
                // Use transaction to record attempts results to Pay, Transfer money, Refund or other transactions.
                EventResponse result = apiInstance.Transaction(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.Transaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**Transaction**](Transaction.md)| Pass transaction results to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain transaction info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

