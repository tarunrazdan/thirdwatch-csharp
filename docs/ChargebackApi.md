# ai.thirdwatch.Api.ChargebackApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Chargeback**](ChargebackApi.md#chargeback) | **POST** /v1/chargeback | Use chargeback to capture a chargeback reported on a transaction. This event can be called multiple times to record changes to the chargeback state.


<a name="chargeback"></a>
# **Chargeback**
> EventResponse Chargeback (Chargeback JSON)

Use chargeback to capture a chargeback reported on a transaction. This event can be called multiple times to record changes to the chargeback state.

Note - When you send a chargeback event you also need to send a label event if you want to prevent the user from making another purchase. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class ChargebackExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new ChargebackApi();
            var JSON = new Chargeback(); // Chargeback | Pass chargeback to thirdwatch. Only `_userID` is required field. But this should contain chargeback info.

            try
            {
                // Use chargeback to capture a chargeback reported on a transaction. This event can be called multiple times to record changes to the chargeback state.
                EventResponse result = apiInstance.Chargeback(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargebackApi.Chargeback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**Chargeback**](Chargeback.md)| Pass chargeback to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain chargeback info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

