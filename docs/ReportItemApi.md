# ai.thirdwatch.Api.ReportItemApi

All URIs are relative to *https://localhost/event*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportItem**](ReportItemApi.md#reportitem) | **POST** /v1/report_item | Use report_item to let us know when another user reports that this item may violate your company’s policies.


<a name="reportitem"></a>
# **ReportItem**
> EventResponse ReportItem (ReportItem JSON)

Use report_item to let us know when another user reports that this item may violate your company’s policies.

If you have a feature like \"Report Item\" or \"Flag this Item\", send that event to us using this. 

### Example
```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class ReportItemExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-THIRDWATCH-API-KEY", "Bearer");

            var apiInstance = new ReportItemApi();
            var JSON = new ReportItem(); // ReportItem | Pass report item info to thirdwatch. Only `_userID` is required field. But this should contain item id.

            try
            {
                // Use report_item to let us know when another user reports that this item may violate your company’s policies.
                EventResponse result = apiInstance.ReportItem(JSON);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportItemApi.ReportItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **JSON** | [**ReportItem**](ReportItem.md)| Pass report item info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain item id. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

