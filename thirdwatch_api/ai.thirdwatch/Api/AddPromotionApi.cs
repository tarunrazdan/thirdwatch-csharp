/* 
 * Thirdwatch API
 *
 * The first version of the Thirdwatch API is an exciting step forward towards making it easier for developers to pass data to Thirdwatch.  Once you've [registered your website/app](https://thirdwatch.ai) it's easy to start sending data to Thirdwatch.  All endpoints are only accessible via https and are located at `api.thirdwatch.ai`. For instance: you can send event at the moment by ```HTTP POST``` Request to the following URL with your API key in ```Header``` and ```JSON``` data in request body. ```   https://api.thirdwatch.ai/event/v1 ``` Every API request must contain ```API Key``` in header value ```X-THIRDWATCH-API-KEY```  Every event must contain your ```_userId``` (if this is not available, you can alternatively provide a ```_sessionId``` value also in ```_userId```).  JavaScript Fingerprinting module for capturing unique devices and tracking user interaction.  This script will identify unique devices with respect to the browser. For e.g., if chrome is opened in normal mode a unique device id is generated and this will be same if chrome is opened in incognito mode or reinstalled.  Paste the below script onto your webpage, just after the opening `<body>` tag. This script should be added to the page which is accessed externally by the user of your website. For e.g., If you want to track three different webpages then paste the below script onto each webpage, just after the opening `<body>` tag. This script should not be added onto internal tools or admin panels. ```   &lt;script id=\"thirdwatch\"     data-session-cookie-name=\"&lt;cookie_name&gt;\"     data-session-id-value=\"&lt;session_id&gt;\"     data-user-id=\"&lt;user_id&gt;\"     data-app-secret=\"&lt;app_secret&gt;\"     data-is-track-pageview=\"true\"&gt; (function() {         var loadDeviceJs = function() {         var element = document.createElement(\"script\");         element.async = 1;         element.src = \"https://cdn.thirdwatch.ai/tw.min.js\";         document.body.appendChild(element);         };         if (window.addEventListener) {              window.addEventListener(\"load\", loadDeviceJs, false);         } else if (window.attachEvent) {         window.attachEvent(\"onload\", loadDeviceJs);         }     })();   &lt;/script&gt; ``` * `data-session-cookie-name` - - The cookie name where you are saving the unique session id. We will pick the session id by reading its value from the cookie name. (Optional) * `data-session-id-value` - - In case you are not passing `data-session-cookie-name` than you can put session id directly in this parameter. In absence of both `data-session-cookie-name` and `data-session-id-value`, our system will generate a session Id. (Optional) * `data-user-id` - - Unique user id at your end. This can be email id or primary key in the database. In case of guest user, you can insert session Id here. * `data-app-secret` - - Unique App secret generated for you by Thirdwatch. * `data-is-track-pageview` - - If this is set to true, then the url on which this script is running will be sent to Thirdwatch, else the url will not be captured.   The Score API is use to get an up to date cutomer trust score after you have sent transaction event and order successful. This API will provide the riskiness score of the order with reasons. Some examples of when you may want to check the score are before:    - Before Shippement of a package   - Finalizing a money transfer   - Giving access to a prearranged vacation rental   - Sending voucher on mail  ```   https://api.thirdwatch.ai/neo/v1/score?api_key=<your api key>&order_id=<Order id> ```  According to Score you can decide to take action Approve or Reject. Orders with score more than 70 will consider as Riskey orders. We'll provide some reasons also in rules section.   ``` {   \"order_id\": \"OCT45671\",   \"user_id\": \"ajay_245\",   \"order_timestamp\": \"2017-05-09T09:40:45.717Z\",   \"score\": 82,   \"flag\": \"red\",     -\"reasons\": [     {         \"name\": \"_numOfFailedTransactions\",         \"display_name\": \"Number of failed transactions\",         \"flag\": \"green\",         \"value\": \"0\",         \"is_display\": true       },       {         \"name\": \"_accountAge\",         \"display_name\": \"Account age\",         \"flag\": \"red\",         \"value\": \"0\",         \"is_display\": true       },       {         \"name\": \"_numOfOrderSameIp\",         \"display_name\": \"Number of orders from same IP\",         \"flag\": \"red\",         \"value\": \"11\",         \"is_display\": true       }     ] } ``` 
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ai.thirdwatch.Client;
using ai.thirdwatch.Model;

namespace ai.thirdwatch.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddPromotionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>EventResponse</returns>
        EventResponse AddPromotion (AddPromotion JSON);

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>ApiResponse of EventResponse</returns>
        ApiResponse<EventResponse> AddPromotionWithHttpInfo (AddPromotion JSON);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>Task of EventResponse</returns>
        System.Threading.Tasks.Task<EventResponse> AddPromotionAsync (AddPromotion JSON);

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>Task of ApiResponse (EventResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventResponse>> AddPromotionAsyncWithHttpInfo (AddPromotion JSON);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddPromotionApi : IAddPromotionApi
    {
        private ai.thirdwatch.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPromotionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddPromotionApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = ai.thirdwatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPromotionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddPromotionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ai.thirdwatch.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ai.thirdwatch.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account. 
        /// </summary>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>EventResponse</returns>
        public EventResponse AddPromotion (AddPromotion JSON)
        {
             ApiResponse<EventResponse> localVarResponse = AddPromotionWithHttpInfo(JSON);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account. 
        /// </summary>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>ApiResponse of EventResponse</returns>
        public ApiResponse< EventResponse > AddPromotionWithHttpInfo (AddPromotion JSON)
        {
            // verify the required parameter 'JSON' is set
            if (JSON == null)
                throw new ApiException(400, "Missing required parameter 'JSON' when calling AddPromotionApi->AddPromotion");

            var localVarPath = "/v1/add_promotion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (JSON != null && JSON.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(JSON); // http body (model) parameter
            }
            else
            {
                localVarPostBody = JSON; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-THIRDWATCH-API-KEY")))
            {
                localVarHeaderParams["X-THIRDWATCH-API-KEY"] = Configuration.GetApiKeyWithPrefix("X-THIRDWATCH-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPromotion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventResponse)));
        }

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account. 
        /// </summary>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>Task of EventResponse</returns>
        public async System.Threading.Tasks.Task<EventResponse> AddPromotionAsync (AddPromotion JSON)
        {
             ApiResponse<EventResponse> localVarResponse = await AddPromotionAsyncWithHttpInfo(JSON);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Use add_promotion to record when a user adds one or more promotions to their account. 
        /// </summary>
        /// <exception cref="ai.thirdwatch.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="JSON">Pass added promotion info to thirdwatch. Only &#x60;_userID&#x60; is required field. But this should contain promotion info.</param>
        /// <returns>Task of ApiResponse (EventResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventResponse>> AddPromotionAsyncWithHttpInfo (AddPromotion JSON)
        {
            // verify the required parameter 'JSON' is set
            if (JSON == null)
                throw new ApiException(400, "Missing required parameter 'JSON' when calling AddPromotionApi->AddPromotion");

            var localVarPath = "/v1/add_promotion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (JSON != null && JSON.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(JSON); // http body (model) parameter
            }
            else
            {
                localVarPostBody = JSON; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-THIRDWATCH-API-KEY")))
            {
                localVarHeaderParams["X-THIRDWATCH-API-KEY"] = Configuration.GetApiKeyWithPrefix("X-THIRDWATCH-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPromotion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventResponse)));
        }

    }
}
