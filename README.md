# thirdwatch_api
ThirdwatchApi - the C# library for the Thirdwatch API

The first version of the Thirdwatch API is an exciting step forward towards making it easier for developers to pass data to Thirdwatch.

# Introduction 

Once you've [registered your website/app](https://dashboardstaging.thirdwatch.co/login) it's easy to start sending data to Thirdwatch.  All endpoints are only accessible via https and are located at `staging.thirdwatch.co`. 
For instance: you can send event at the moment by ```HTTPS POST``` request to the following URL with your API key in ```Header``` and ```JSON``` data in request body. 

```   https://staging.thirdwatch.co/event/v1 ``` 

Every API request must contain ```API Key``` in header value ```X-THIRDWATCH-API-KEY```. Every event must contain your ```_userId``` (if this is not available, you can alternatively provide a ```_sessionId``` value also in ```_userId```). 

- API version: 0.0.1
- SDK version: 0.0.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ai.thirdwatch.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using ai.thirdwatch.Api;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-THIRDWATCH-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-THIRDWATCH-API-KEY", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.thirdwatch.ai/event*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddPromotionApi* | [**AddPromotion**](docs/AddPromotionApi.md#addpromotion) | **POST** /v1/add_promotion | Use add_promotion to record when a user adds one or more promotions to their account.
*AddToCartApi* | [**AddToCart**](docs/AddToCartApi.md#addtocart) | **POST** /v1/add_to_cart | Use add_to_cart when a user adds an item to their shopping cart or list.
*ChargebackApi* | [**Chargeback**](docs/ChargebackApi.md#chargeback) | **POST** /v1/chargeback | Use chargeback to capture a chargeback reported on a transaction. This event can be called multiple times to record changes to the chargeback state.
*CreateAccountApi* | [**CreateAccount**](docs/CreateAccountApi.md#createaccount) | **POST** /v1/create_account | Use create_account to pass user details at user registration.
*CreateOrderApi* | [**CreateOrder**](docs/CreateOrderApi.md#createorder) | **POST** /v1/createOrder | Submit a new or existing order to Thirdwatch for review. This API should contain order item info, the payment info, and user identity info.
*CustomEventApi* | [**CustomEvent**](docs/CustomEventApi.md#customevent) | **POST** /v1/custom_event | Use order_status to track the order processing workflow of a previously submitted order.
*ItemStatusApi* | [**ItemStatus**](docs/ItemStatusApi.md#itemstatus) | **POST** /v1/item_status | Use item_status to update the status of item that you’ve already pass to Thirdwatch.
*LinkSessionToUserApi* | [**LinkSessionToUser**](docs/LinkSessionToUserApi.md#linksessiontouser) | **POST** /v1/link_session_to_user | Use link_session_to_user to associate specific session to a user. Generally used only in anonymous checkout workflows.
*LoginApi* | [**Login**](docs/LoginApi.md#login) | **POST** /v1/login | Use login to record when a user attempts to log in.
*LogoutApi* | [**Logout**](docs/LogoutApi.md#logout) | **POST** /v1/logout | Use logout to record when a user logs out.
*OrderStatusApi* | [**OrderStatus**](docs/OrderStatusApi.md#orderstatus) | **POST** /v1/order_status | Use order_status to track the order processing workflow of a previously submitted order.
*RemoveFromCartApi* | [**RemoveFromCart**](docs/RemoveFromCartApi.md#removefromcart) | **POST** /v1/remove_from_cart | Use remove_from_cart when a user removes an item from their shopping cart or list.
*ReportItemApi* | [**ReportItem**](docs/ReportItemApi.md#reportitem) | **POST** /v1/report_item | Use report_item to let us know when another user reports that this item may violate your company’s policies.
*SendMessageApi* | [**SendMessage**](docs/SendMessageApi.md#sendmessage) | **POST** /v1/send_message | Use send_message to record when a user sends a message to other i.e. seller, support.
*SubmitReviewApi* | [**SubmitReview**](docs/SubmitReviewApi.md#submitreview) | **POST** /v1/submit_review | Use submit_review when a user-submitted review of a product or seller.
*TagAPIApi* | [**TagUser**](docs/TagAPIApi.md#taguser) | **POST** /v1/tag | The Tag API enables you to tell Thirdwatch which of your users are bad and which are good.
*TransactionApi* | [**Transaction**](docs/TransactionApi.md#transaction) | **POST** /v1/transaction | Use transaction to record attempts results to Pay, Transfer money, Refund or other transactions.
*UntagAPIApi* | [**UnTagUser**](docs/UntagAPIApi.md#untaguser) | **POST** /v1/untag | If you are unsure whether a user is bad or good, you can always remove tag and leave the user in a neutral state.
*UpdateAccountApi* | [**UpdateAccount**](docs/UpdateAccountApi.md#updateaccount) | **POST** /v1/update_account | Use update_account to record changes to the user's account information.
*UpdateOrderApi* | [**UpdateOrder**](docs/UpdateOrderApi.md#updateorder) | **POST** /v1/update_order | Update details of an existing order.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddPromotion](docs/AddPromotion.md)
 - [Model.AddToCart](docs/AddToCart.md)
 - [Model.BillingAddress](docs/BillingAddress.md)
 - [Model.Chargeback](docs/Chargeback.md)
 - [Model.CreateAccount](docs/CreateAccount.md)
 - [Model.CreateOrder](docs/CreateOrder.md)
 - [Model.Custom](docs/Custom.md)
 - [Model.CustomInfo](docs/CustomInfo.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.Item](docs/Item.md)
 - [Model.ItemStatus](docs/ItemStatus.md)
 - [Model.LinkSessionToUser](docs/LinkSessionToUser.md)
 - [Model.Login](docs/Login.md)
 - [Model.Logout](docs/Logout.md)
 - [Model.OrderStatus](docs/OrderStatus.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.Promotion](docs/Promotion.md)
 - [Model.RemoveFromCart](docs/RemoveFromCart.md)
 - [Model.ReportItem](docs/ReportItem.md)
 - [Model.Seller](docs/Seller.md)
 - [Model.SendMessage](docs/SendMessage.md)
 - [Model.ShippingAddress](docs/ShippingAddress.md)
 - [Model.SubmitReview](docs/SubmitReview.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.UnTag](docs/UnTag.md)
 - [Model.UpdateAccount](docs/UpdateAccount.md)
 - [Model.UpdateOrder](docs/UpdateOrder.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: X-THIRDWATCH-API-KEY
- **Location**: HTTP header

