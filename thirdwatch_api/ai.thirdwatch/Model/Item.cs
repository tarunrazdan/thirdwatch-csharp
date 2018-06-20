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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ai.thirdwatch.Client.SwaggerDateConverter;

namespace ai.thirdwatch.Model
{
    /// <summary>
    /// The Item field type represents a product or service for sale in your business. The value must be a nested object with the appropriate item subfields. Generally used in the add_to_cart and remove_from_cart events. 
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="itemId">The item&#39;s unique identifier according to your systems. Use the same ID that you would use to look up items on your website&#39;s database..</param>
        /// <param name="productTitle">The item&#39;s name, e.g., \&quot;WD 2 TB External Hard Drive\&quot;..</param>
        /// <param name="price">The item unit price in numbers, in the base unit of the currency_code.e.g. \&quot;2500\&quot;.</param>
        /// <param name="currencyCode">The [ISO-4217](http://en.wikipedia.org/wiki/ISO_4217) currency code for the amount. e.g., USD, INR alternative currencies, like bitcoin or points systems..</param>
        /// <param name="upc">If the item has a Universal Product Code (UPC), provide it here..</param>
        /// <param name="sku">If the item has a Stock-keeping Unit ID (SKU), provide it here..</param>
        /// <param name="isbn">If the item is a book with an International Standard Book Number (ISBN), provide it here..</param>
        /// <param name="brand">The brand name of the item..</param>
        /// <param name="manufacturer">Name of the item&#39;s manufacturer..</param>
        /// <param name="category">The category this item is listed under in your business. e.g., \&quot;travel\&quot;, \&quot;man &gt; bags\&quot;..</param>
        /// <param name="tags">The tags used to describe this item in your business. e.g., \&quot;man\&quot;, \&quot;summer\&quot;..</param>
        /// <param name="color">The color of the item..</param>
        /// <param name="quantity">The quantity of the item..</param>
        /// <param name="isOnSale">Is item on sale or running offers on this item ..</param>
        /// <param name="maxQuantity">The max quantity per user for this item..</param>
        /// <param name="discountPrice">Price of the product after discount..</param>
        /// <param name="productWeight">Weight of the product in Kilo Gram, e.g. \&quot;3\&quot; , \&quot;0.5\&quot;.</param>
        /// <param name="country">The [ISO-3166](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the item, e.g., \&quot;IN\&quot; in case of India..</param>
        /// <param name="descriptionShort">Short description of the item..</param>
        /// <param name="description">Detail description of the item..</param>
        /// <param name="seller">seller.</param>
        public Item(string itemId = default(string), string productTitle = default(string), string price = default(string), string currencyCode = default(string), string upc = default(string), string sku = default(string), string isbn = default(string), string brand = default(string), string manufacturer = default(string), string category = default(string), string tags = default(string), string color = default(string), long? quantity = default(long?), bool? isOnSale = default(bool?), long? maxQuantity = default(long?), string discountPrice = default(string), string productWeight = default(string), string country = default(string), string descriptionShort = default(string), string description = default(string), Seller seller = default(Seller))
        {
            this.itemId = itemId;
            this.productTitle = productTitle;
            this.price = price;
            this.currencyCode = currencyCode;
            this.upc = upc;
            this.sku = sku;
            this.isbn = isbn;
            this.brand = brand;
            this.manufacturer = manufacturer;
            this.category = category;
            this.tags = tags;
            this.color = color;
            this.quantity = quantity;
            this.isOnSale = isOnSale;
            this.maxQuantity = maxQuantity;
            this.discountPrice = discountPrice;
            this.productWeight = productWeight;
            this.country = country;
            this.descriptionShort = descriptionShort;
            this.description = description;
            this.seller = seller;
        }
        
        /// <summary>
        /// The item&#39;s unique identifier according to your systems. Use the same ID that you would use to look up items on your website&#39;s database.
        /// </summary>
        /// <value>The item&#39;s unique identifier according to your systems. Use the same ID that you would use to look up items on your website&#39;s database.</value>
        [DataMember(Name="_itemId", EmitDefaultValue=false)]
        public string itemId { get; set; }

        /// <summary>
        /// The item&#39;s name, e.g., \&quot;WD 2 TB External Hard Drive\&quot;.
        /// </summary>
        /// <value>The item&#39;s name, e.g., \&quot;WD 2 TB External Hard Drive\&quot;.</value>
        [DataMember(Name="_productTitle", EmitDefaultValue=false)]
        public string productTitle { get; set; }

        /// <summary>
        /// The item unit price in numbers, in the base unit of the currency_code.e.g. \&quot;2500\&quot;
        /// </summary>
        /// <value>The item unit price in numbers, in the base unit of the currency_code.e.g. \&quot;2500\&quot;</value>
        [DataMember(Name="_price", EmitDefaultValue=false)]
        public string price { get; set; }

        /// <summary>
        /// The [ISO-4217](http://en.wikipedia.org/wiki/ISO_4217) currency code for the amount. e.g., USD, INR alternative currencies, like bitcoin or points systems.
        /// </summary>
        /// <value>The [ISO-4217](http://en.wikipedia.org/wiki/ISO_4217) currency code for the amount. e.g., USD, INR alternative currencies, like bitcoin or points systems.</value>
        [DataMember(Name="_currencyCode", EmitDefaultValue=false)]
        public string currencyCode { get; set; }

        /// <summary>
        /// If the item has a Universal Product Code (UPC), provide it here.
        /// </summary>
        /// <value>If the item has a Universal Product Code (UPC), provide it here.</value>
        [DataMember(Name="_upc", EmitDefaultValue=false)]
        public string upc { get; set; }

        /// <summary>
        /// If the item has a Stock-keeping Unit ID (SKU), provide it here.
        /// </summary>
        /// <value>If the item has a Stock-keeping Unit ID (SKU), provide it here.</value>
        [DataMember(Name="_sku", EmitDefaultValue=false)]
        public string sku { get; set; }

        /// <summary>
        /// If the item is a book with an International Standard Book Number (ISBN), provide it here.
        /// </summary>
        /// <value>If the item is a book with an International Standard Book Number (ISBN), provide it here.</value>
        [DataMember(Name="_isbn", EmitDefaultValue=false)]
        public string isbn { get; set; }

        /// <summary>
        /// The brand name of the item.
        /// </summary>
        /// <value>The brand name of the item.</value>
        [DataMember(Name="_brand", EmitDefaultValue=false)]
        public string brand { get; set; }

        /// <summary>
        /// Name of the item&#39;s manufacturer.
        /// </summary>
        /// <value>Name of the item&#39;s manufacturer.</value>
        [DataMember(Name="_manufacturer", EmitDefaultValue=false)]
        public string manufacturer { get; set; }

        /// <summary>
        /// The category this item is listed under in your business. e.g., \&quot;travel\&quot;, \&quot;man &gt; bags\&quot;.
        /// </summary>
        /// <value>The category this item is listed under in your business. e.g., \&quot;travel\&quot;, \&quot;man &gt; bags\&quot;.</value>
        [DataMember(Name="_category", EmitDefaultValue=false)]
        public string category { get; set; }

        /// <summary>
        /// The tags used to describe this item in your business. e.g., \&quot;man\&quot;, \&quot;summer\&quot;.
        /// </summary>
        /// <value>The tags used to describe this item in your business. e.g., \&quot;man\&quot;, \&quot;summer\&quot;.</value>
        [DataMember(Name="_tags", EmitDefaultValue=false)]
        public string tags { get; set; }

        /// <summary>
        /// The color of the item.
        /// </summary>
        /// <value>The color of the item.</value>
        [DataMember(Name="_color", EmitDefaultValue=false)]
        public string color { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        /// <value>The quantity of the item.</value>
        [DataMember(Name="_quantity", EmitDefaultValue=false)]
        public long? quantity { get; set; }

        /// <summary>
        /// Is item on sale or running offers on this item .
        /// </summary>
        /// <value>Is item on sale or running offers on this item .</value>
        [DataMember(Name="_isOnSale", EmitDefaultValue=false)]
        public bool? isOnSale { get; set; }

        /// <summary>
        /// The max quantity per user for this item.
        /// </summary>
        /// <value>The max quantity per user for this item.</value>
        [DataMember(Name="_maxQuantity", EmitDefaultValue=false)]
        public long? maxQuantity { get; set; }

        /// <summary>
        /// Price of the product after discount.
        /// </summary>
        /// <value>Price of the product after discount.</value>
        [DataMember(Name="_discountPrice", EmitDefaultValue=false)]
        public string discountPrice { get; set; }

        /// <summary>
        /// Weight of the product in Kilo Gram, e.g. \&quot;3\&quot; , \&quot;0.5\&quot;
        /// </summary>
        /// <value>Weight of the product in Kilo Gram, e.g. \&quot;3\&quot; , \&quot;0.5\&quot;</value>
        [DataMember(Name="_productWeight", EmitDefaultValue=false)]
        public string productWeight { get; set; }

        /// <summary>
        /// The [ISO-3166](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the item, e.g., \&quot;IN\&quot; in case of India.
        /// </summary>
        /// <value>The [ISO-3166](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the item, e.g., \&quot;IN\&quot; in case of India.</value>
        [DataMember(Name="_country", EmitDefaultValue=false)]
        public string country { get; set; }

        /// <summary>
        /// Short description of the item.
        /// </summary>
        /// <value>Short description of the item.</value>
        [DataMember(Name="_descriptionShort", EmitDefaultValue=false)]
        public string descriptionShort { get; set; }

        /// <summary>
        /// Detail description of the item.
        /// </summary>
        /// <value>Detail description of the item.</value>
        [DataMember(Name="_description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Gets or Sets seller
        /// </summary>
        [DataMember(Name="_seller", EmitDefaultValue=false)]
        public Seller seller { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  itemId: ").Append(itemId).Append("\n");
            sb.Append("  productTitle: ").Append(productTitle).Append("\n");
            sb.Append("  price: ").Append(price).Append("\n");
            sb.Append("  currencyCode: ").Append(currencyCode).Append("\n");
            sb.Append("  upc: ").Append(upc).Append("\n");
            sb.Append("  sku: ").Append(sku).Append("\n");
            sb.Append("  isbn: ").Append(isbn).Append("\n");
            sb.Append("  brand: ").Append(brand).Append("\n");
            sb.Append("  manufacturer: ").Append(manufacturer).Append("\n");
            sb.Append("  category: ").Append(category).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
            sb.Append("  color: ").Append(color).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  isOnSale: ").Append(isOnSale).Append("\n");
            sb.Append("  maxQuantity: ").Append(maxQuantity).Append("\n");
            sb.Append("  discountPrice: ").Append(discountPrice).Append("\n");
            sb.Append("  productWeight: ").Append(productWeight).Append("\n");
            sb.Append("  country: ").Append(country).Append("\n");
            sb.Append("  descriptionShort: ").Append(descriptionShort).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  seller: ").Append(seller).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.itemId == input.itemId ||
                    (this.itemId != null &&
                    this.itemId.Equals(input.itemId))
                ) && 
                (
                    this.productTitle == input.productTitle ||
                    (this.productTitle != null &&
                    this.productTitle.Equals(input.productTitle))
                ) && 
                (
                    this.price == input.price ||
                    (this.price != null &&
                    this.price.Equals(input.price))
                ) && 
                (
                    this.currencyCode == input.currencyCode ||
                    (this.currencyCode != null &&
                    this.currencyCode.Equals(input.currencyCode))
                ) && 
                (
                    this.upc == input.upc ||
                    (this.upc != null &&
                    this.upc.Equals(input.upc))
                ) && 
                (
                    this.sku == input.sku ||
                    (this.sku != null &&
                    this.sku.Equals(input.sku))
                ) && 
                (
                    this.isbn == input.isbn ||
                    (this.isbn != null &&
                    this.isbn.Equals(input.isbn))
                ) && 
                (
                    this.brand == input.brand ||
                    (this.brand != null &&
                    this.brand.Equals(input.brand))
                ) && 
                (
                    this.manufacturer == input.manufacturer ||
                    (this.manufacturer != null &&
                    this.manufacturer.Equals(input.manufacturer))
                ) && 
                (
                    this.category == input.category ||
                    (this.category != null &&
                    this.category.Equals(input.category))
                ) && 
                (
                    this.tags == input.tags ||
                    (this.tags != null &&
                    this.tags.Equals(input.tags))
                ) && 
                (
                    this.color == input.color ||
                    (this.color != null &&
                    this.color.Equals(input.color))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.isOnSale == input.isOnSale ||
                    (this.isOnSale != null &&
                    this.isOnSale.Equals(input.isOnSale))
                ) && 
                (
                    this.maxQuantity == input.maxQuantity ||
                    (this.maxQuantity != null &&
                    this.maxQuantity.Equals(input.maxQuantity))
                ) && 
                (
                    this.discountPrice == input.discountPrice ||
                    (this.discountPrice != null &&
                    this.discountPrice.Equals(input.discountPrice))
                ) && 
                (
                    this.productWeight == input.productWeight ||
                    (this.productWeight != null &&
                    this.productWeight.Equals(input.productWeight))
                ) && 
                (
                    this.country == input.country ||
                    (this.country != null &&
                    this.country.Equals(input.country))
                ) && 
                (
                    this.descriptionShort == input.descriptionShort ||
                    (this.descriptionShort != null &&
                    this.descriptionShort.Equals(input.descriptionShort))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.seller == input.seller ||
                    (this.seller != null &&
                    this.seller.Equals(input.seller))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.itemId != null)
                    hashCode = hashCode * 59 + this.itemId.GetHashCode();
                if (this.productTitle != null)
                    hashCode = hashCode * 59 + this.productTitle.GetHashCode();
                if (this.price != null)
                    hashCode = hashCode * 59 + this.price.GetHashCode();
                if (this.currencyCode != null)
                    hashCode = hashCode * 59 + this.currencyCode.GetHashCode();
                if (this.upc != null)
                    hashCode = hashCode * 59 + this.upc.GetHashCode();
                if (this.sku != null)
                    hashCode = hashCode * 59 + this.sku.GetHashCode();
                if (this.isbn != null)
                    hashCode = hashCode * 59 + this.isbn.GetHashCode();
                if (this.brand != null)
                    hashCode = hashCode * 59 + this.brand.GetHashCode();
                if (this.manufacturer != null)
                    hashCode = hashCode * 59 + this.manufacturer.GetHashCode();
                if (this.category != null)
                    hashCode = hashCode * 59 + this.category.GetHashCode();
                if (this.tags != null)
                    hashCode = hashCode * 59 + this.tags.GetHashCode();
                if (this.color != null)
                    hashCode = hashCode * 59 + this.color.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.isOnSale != null)
                    hashCode = hashCode * 59 + this.isOnSale.GetHashCode();
                if (this.maxQuantity != null)
                    hashCode = hashCode * 59 + this.maxQuantity.GetHashCode();
                if (this.discountPrice != null)
                    hashCode = hashCode * 59 + this.discountPrice.GetHashCode();
                if (this.productWeight != null)
                    hashCode = hashCode * 59 + this.productWeight.GetHashCode();
                if (this.country != null)
                    hashCode = hashCode * 59 + this.country.GetHashCode();
                if (this.descriptionShort != null)
                    hashCode = hashCode * 59 + this.descriptionShort.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.seller != null)
                    hashCode = hashCode * 59 + this.seller.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
