# ai.thirdwatch.Api.AddPromotionApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPromotion**](AddPromotionApi.md#addpromotion) | **POST** /v1/add_promotion | Use add_promotion to record when a user adds one or more promotions to their account.


<a name="addpromotion"></a>
# **AddPromotion**
> EventResponse AddPromotion (AddPromotion JSON)

Use add_promotion to record when a user adds one or more promotions to their account.

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class AddPromotionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new AddPromotionApi();
            var JSON = new AddPromotion(); // AddPromotion | Pass added promotion info to thirdwatch. Only `_userID` is required field. But this should contain promotion info.

            try
            {
                // Use add_promotion to record when a user adds one or more promotions to their account.
                EventResponse result = apiInstance.AddPromotion(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddPromotionApi.AddPromotion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**AddPromotion**](AddPromotion.md)| Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

