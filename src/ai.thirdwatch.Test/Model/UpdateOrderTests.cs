/* 
 * Thirdwatch API
 *
 * The first version of the Thirdwatch API is an exciting step forward towards making it easier for developers to pass data to Thirdwatch.  Once you've [registered your website/app](https://thirdwatch.ai) it's easy to start sending data to Thirdwatch.  All endpoints are only accessible via https and are located at `api.thirdwatch.ai`. For instance: you can send event at the moment by ```HTTP POST``` Request to the following URL with your API key in ```Header``` and ```JSON``` data in request body. ```   https://api.thirdwatch.ai/event/v1 ``` Every API request must contain ```API Key``` in header value ```X-THIRDWATCH-API-KEY```  Every event must contain your ```_userId``` (if this is not available, you can alternatively provide a ```_sessionId``` value also in ```_userId```).  JavaScript Fingerprinting module for capturing unique devices and tracking user interaction.  This script will identify unique devices with respect to the browser. For e.g., if chrome is opened in normal mode a unique device id is generated and this will be same if chrome is opened in incognito mode or reinstalled.  Paste the below script onto your webpage, just after the opening `<body>` tag. This script should be added to the page which is accessed externally by the user of your website. For e.g., If you want to track three different webpages then paste the below script onto each webpage, just after the opening `<body>` tag. This script should not be added onto internal tools or admin panels. ```   &lt;script id=\"thirdwatch\"     data-session-cookie-name=\"&lt;cookie_name&gt;\"     data-session-id-value=\"&lt;session_id&gt;\"     data-user-id=\"&lt;user_id&gt;\"     data-app-secret=\"&lt;app_secret&gt;\"     data-is-track-pageview=\"true\"&gt; (function() {         var loadDeviceJs = function() {         var element = document.createElement(\"script\");         element.async = 1;         element.src = \"https://cdn.thirdwatch.ai/tw.min.js\";         document.body.appendChild(element);         };         if (window.addEventListener) {              window.addEventListener(\"load\", loadDeviceJs, false);         } else if (window.attachEvent) {         window.attachEvent(\"onload\", loadDeviceJs);         }     })();   &lt;/script&gt; ``` * `data-session-cookie-name` - - The cookie name where you are saving the unique session id. We will pick the session id by reading its value from the cookie name. (Optional) * `data-session-id-value` - - In case you are not passing `data-session-cookie-name` than you can put session id directly in this parameter. In absence of both `data-session-cookie-name` and `data-session-id-value`, our system will generate a session Id. (Optional) * `data-user-id` - - Unique user id at your end. This can be email id or primary key in the database. In case of guest user, you can insert session Id here. * `data-app-secret` - - Unique App secret generated for you by Thirdwatch. * `data-is-track-pageview` - - If this is set to true, then the url on which this script is running will be sent to Thirdwatch, else the url will not be captured.   The Score API is use to get an up to date cutomer trust score after you have sent transaction event and order successful. This API will provide the riskiness score of the order with reasons. Some examples of when you may want to check the score are before:    - Before Shippement of a package   - Finalizing a money transfer   - Giving access to a prearranged vacation rental   - Sending voucher on mail  ```   https://api.thirdwatch.ai/neo/v1/score?api_key=<your api key>&order_id=<Order id> ```  According to Score you can decide to take action Approve or Reject. Orders with score more than 70 will consider as Riskey orders. We'll provide some reasons also in rules section.   ``` {   \"order_id\": \"OCT45671\",   \"user_id\": \"ajay_245\",   \"order_timestamp\": \"2017-05-09T09:40:45.717Z\",   \"score\": 82,   \"flag\": \"red\",     -\"reasons\": [     {         \"name\": \"_numOfFailedTransactions\",         \"display_name\": \"Number of failed transactions\",         \"flag\": \"green\",         \"value\": \"0\",         \"is_display\": true       },       {         \"name\": \"_accountAge\",         \"display_name\": \"Account age\",         \"flag\": \"red\",         \"value\": \"0\",         \"is_display\": true       },       {         \"name\": \"_numOfOrderSameIp\",         \"display_name\": \"Number of orders from same IP\",         \"flag\": \"red\",         \"value\": \"11\",         \"is_display\": true       }     ] } ``` 
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ai.thirdwatch.Api;
using ai.thirdwatch.Model;
using ai.thirdwatch.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ai.thirdwatch.Test
{
    /// <summary>
    ///  Class for testing UpdateOrder
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateOrderTests
    {
        // TODO uncomment below to declare an instance variable for UpdateOrder
        //private UpdateOrder instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateOrder
            //instance = new UpdateOrder();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateOrder
        /// </summary>
        [Test]
        public void UpdateOrderInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateOrder
            //Assert.IsInstanceOfType<UpdateOrder> (instance, "variable 'instance' is a UpdateOrder");
        }


        /// <summary>
        /// Test the property 'userId'
        /// </summary>
        [Test]
        public void userIdTest()
        {
            // TODO unit test for the property 'userId'
        }
        /// <summary>
        /// Test the property 'sessionId'
        /// </summary>
        [Test]
        public void sessionIdTest()
        {
            // TODO unit test for the property 'sessionId'
        }
        /// <summary>
        /// Test the property 'orderId'
        /// </summary>
        [Test]
        public void orderIdTest()
        {
            // TODO unit test for the property 'orderId'
        }
        /// <summary>
        /// Test the property 'deviceIp'
        /// </summary>
        [Test]
        public void deviceIpTest()
        {
            // TODO unit test for the property 'deviceIp'
        }
        /// <summary>
        /// Test the property 'originTimestamp'
        /// </summary>
        [Test]
        public void originTimestampTest()
        {
            // TODO unit test for the property 'originTimestamp'
        }
        /// <summary>
        /// Test the property 'userEmail'
        /// </summary>
        [Test]
        public void userEmailTest()
        {
            // TODO unit test for the property 'userEmail'
        }
        /// <summary>
        /// Test the property 'amount'
        /// </summary>
        [Test]
        public void amountTest()
        {
            // TODO unit test for the property 'amount'
        }
        /// <summary>
        /// Test the property 'currencyCode'
        /// </summary>
        [Test]
        public void currencyCodeTest()
        {
            // TODO unit test for the property 'currencyCode'
        }
        /// <summary>
        /// Test the property 'hasExpeditedShipping'
        /// </summary>
        [Test]
        public void hasExpeditedShippingTest()
        {
            // TODO unit test for the property 'hasExpeditedShipping'
        }
        /// <summary>
        /// Test the property 'shippingMethod'
        /// </summary>
        [Test]
        public void shippingMethodTest()
        {
            // TODO unit test for the property 'shippingMethod'
        }
        /// <summary>
        /// Test the property 'orderReferrer'
        /// </summary>
        [Test]
        public void orderReferrerTest()
        {
            // TODO unit test for the property 'orderReferrer'
        }
        /// <summary>
        /// Test the property 'isPrePaid'
        /// </summary>
        [Test]
        public void isPrePaidTest()
        {
            // TODO unit test for the property 'isPrePaid'
        }
        /// <summary>
        /// Test the property 'isGift'
        /// </summary>
        [Test]
        public void isGiftTest()
        {
            // TODO unit test for the property 'isGift'
        }
        /// <summary>
        /// Test the property 'isReturn'
        /// </summary>
        [Test]
        public void isReturnTest()
        {
            // TODO unit test for the property 'isReturn'
        }
        /// <summary>
        /// Test the property 'isFirstTimeBuyer'
        /// </summary>
        [Test]
        public void isFirstTimeBuyerTest()
        {
            // TODO unit test for the property 'isFirstTimeBuyer'
        }
        /// <summary>
        /// Test the property 'billingAddress'
        /// </summary>
        [Test]
        public void billingAddressTest()
        {
            // TODO unit test for the property 'billingAddress'
        }
        /// <summary>
        /// Test the property 'shippingAddress'
        /// </summary>
        [Test]
        public void shippingAddressTest()
        {
            // TODO unit test for the property 'shippingAddress'
        }
        /// <summary>
        /// Test the property 'paymentMethods'
        /// </summary>
        [Test]
        public void paymentMethodsTest()
        {
            // TODO unit test for the property 'paymentMethods'
        }
        /// <summary>
        /// Test the property 'promotions'
        /// </summary>
        [Test]
        public void promotionsTest()
        {
            // TODO unit test for the property 'promotions'
        }
        /// <summary>
        /// Test the property 'items'
        /// </summary>
        [Test]
        public void itemsTest()
        {
            // TODO unit test for the property 'items'
        }
        /// <summary>
        /// Test the property 'customInfo'
        /// </summary>
        [Test]
        public void customInfoTest()
        {
            // TODO unit test for the property 'customInfo'
        }

    }

}
