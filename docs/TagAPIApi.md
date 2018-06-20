# ai.thirdwatch.Api.TagAPIApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagUser**](TagAPIApi.md#taguser) | **POST** /v1/tag | The Tag API enables you to tell Thirdwatch which of your users are bad and which are good.


<a name="taguser"></a>
# **TagUser**
> EventResponse TagUser (Tag JSON)

The Tag API enables you to tell Thirdwatch which of your users are bad and which are good.

By telling us who is bad and who is good, we can identify patterns that are unique to your business. Once you give this feedback, the platform instantly analyzes it and learns to identify good and bad behavior of other users more accurately. If you want to change an existing label for a user - for example, from bad to good - all you need to do is send a new label and we'll overwrite the existing value. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class TagUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new TagAPIApi();
            var JSON = new Tag(); // Tag | Pass user and it's info to thirdwatch. Only `_userID` is required field. But this should contain tag info.

            try
            {
                // The Tag API enables you to tell Thirdwatch which of your users are bad and which are good.
                EventResponse result = apiInstance.TagUser(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagAPIApi.TagUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**Tag**](Tag.md)| Pass user and it&#39;s info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain tag info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

