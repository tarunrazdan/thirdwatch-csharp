# ai.thirdwatch.Api.SubmitReviewApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitReview**](SubmitReviewApi.md#submitreview) | **POST** /v1/submit_review | Use submit_review when a user-submitted review of a product or seller.


<a name="submitreview"></a>
# **SubmitReview**
> EventResponse SubmitReview (SubmitReview JSON)

Use submit_review when a user-submitted review of a product or seller.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class SubmitReviewExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new SubmitReviewApi();
            var JSON = new SubmitReview(); // SubmitReview | Pass review to thirdwatch. Only `_userID` is required field. But this should contain review info.

            try
            {
                // Use submit_review when a user-submitted review of a product or seller.
                EventResponse result = apiInstance.SubmitReview(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmitReviewApi.SubmitReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**SubmitReview**](SubmitReview.md)| Pass review to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain review info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

