# ai.thirdwatch.Api.SendMessageApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendMessage**](SendMessageApi.md#sendmessage) | **POST** /v1/send_message | Use send_message to record when a user sends a message to other i.e. seller, support.


<a name="sendmessage"></a>
# **SendMessage**
> EventResponse SendMessage (SendMessage JSON)

Use send_message to record when a user sends a message to other i.e. seller, support.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new SendMessageApi();
            var JSON = new SendMessage(); // SendMessage | Pass message to thirdwatch. Only `_userID` is required field. But this should contain message info.

            try
            {
                // Use send_message to record when a user sends a message to other i.e. seller, support.
                EventResponse result = apiInstance.SendMessage(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendMessageApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**SendMessage**](SendMessage.md)| Pass message to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain message info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

