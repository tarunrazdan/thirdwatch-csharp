# ai.thirdwatch.Model.UpdateOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**userId** | **string** | The user&#39;s account ID according to your systems. Note that user IDs are case sensitive. | [optional] 
**sessionId** | **string** | The user&#39;s current session ID, used to tie a user&#39;s action before and after login or account creation. Required if no user_id values is provided. | [optional] 
**orderId** | **string** | The ID for tracking this order in your system. | 
**deviceIp** | **string** | IP address of the request made by the user. Recommended for historical backfills and customers with mobile apps. | [optional] 
**originTimestamp** | **string** | Represents the time the event occured in your system. Send as a UNIX timestamp in milliseconds in string. | [optional] 
**userEmail** | **string** | Email of the user creating this order. Note - If the user&#39;s email is also their account ID in your system, set both the userId and userEmail fields to their email address. | [optional] 
**amount** | **string** | The item unit price in numbers, in the base unit of the currency_code.e.g. \&quot;2500\&quot; | [optional] 
**currencyCode** | **string** | The [ISO-4217](http://en.wikipedia.org/wiki/ISO_4217) currency code for the amount. e.g., USD, INR alternative currencies, like bitcoin or points systems. | [optional] 
**hasExpeditedShipping** | **bool?** | Whether the user requested priority/expedited shipping on their order. | [optional] 
**shippingMethod** | **string** | Indicates the method of delivery to the user. e.g. _electronic, _physical | [optional] 
**orderReferrer** | **string** | Referer website or user name. | [optional] 
**isPrePaid** | **bool?** | is order is prepaid. | [optional] 
**isGift** | **bool?** | Is user chosen gift pack. | [optional] 
**isReturn** | **bool?** | Is this return order. | [optional] 
**isFirstTimeBuyer** | **bool?** | Is user first time buyer. | [optional] 
**billingAddress** | [**BillingAddress**](BillingAddress.md) |  | [optional] 
**shippingAddress** | [**ShippingAddress**](ShippingAddress.md) |  | [optional] 
**paymentMethods** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) | The payment information associated with this order. Represented as an array of nested payment_method objects containing payment type, payment gateway, credit card bin, etc. | [optional] 
**promotions** | [**List&lt;Promotion&gt;**](Promotion.md) | The list of promotions that apply to this order. You can add one or more promotions when creating or updating an order. Represented as a JSON array of promotion objects. You can also separately add promotions to the account via the addPromotion event. | [optional] 
**items** | [**List&lt;Item&gt;**](Item.md) | The list of items ordered. Represented as a JSON array of item | [optional] 
**customInfo** | [**CustomInfo**](CustomInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

