// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The server checks whether a request that uses the same client token has been received. If a request that uses the same client token has been received, the server returns the same request result as the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JASIOFKVNVIXXXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The logistics address of this order. This parameter is generally valid for physical orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cityCode&quot;:&quot;330100&quot;,&quot;cityName&quot;:&quot;Hangzhou&quot;,&quot;contactName&quot;:&quot;Test&quot;,&quot;countryCode&quot;:&quot;&quot;,&quot;districtName&quot;:&quot;Puyan Street&quot;,&quot;email&quot;:&quot;\<em>\</em>@example.com&quot;,&quot;mobilePhone&quot;:&quot;153564848844&quot;,&quot;phone&quot;:&quot;1234567&quot;,&quot;provCode&quot;:&quot;330000&quot;,&quot;provName&quot;:&quot;Zhejiang&quot;,&quot;streetCode&quot;:&quot;33010610&quot;,&quot;streetName&quot;:&quot;Zhuantang&quot;,&quot;zipCode&quot;:&quot;0000&quot;}</para>
        /// </summary>
        [NameInMap("Logistics")]
        [Validation(Required=false)]
        public string Logistics { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The details of the modules.</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestParameter> Parameter { get; set; }
        public class CreateInstanceRequestParameter : TeaModel {
            /// <summary>
            /// <para>The code property of the Nth module. Value of N: 1 to 100. If multiple module property parameters are involved, concatenate multiple parameters based on the value of N in sequence.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceType</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The value property of the Nth module. Value of N: 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration. Unit: month. The value must be an integral multiple of 12.</para>
        /// <remarks>
        /// <para> This parameter is required if you create a subscription instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public long? PricingCycle { get; set; }

        /// <summary>
        /// <para>The code of the service to which the instance belongs. You can query the service code by calling the <b>QueryProductList</b> operation or viewing <b>Codes of Alibaba Cloud Services</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Unit: month.</para>
        /// <remarks>
        /// <para> This parameter is required if the <b>RenewalStatus</b> parameter is set to <b>AutoRenewal</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RenewPeriod")]
        [Validation(Required=false)]
        public int? RenewPeriod { get; set; }

        /// <summary>
        /// <para>The renewal method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: The instance is automatically renewed.</description></item>
        /// <item><description>ManualRenewal: The instance is manually renewed.</description></item>
        /// </list>
        /// <para>Default value: ManualRenewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManualRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: the subscription billing method.</description></item>
        /// <item><description>PayAsYouGo: the pay-as-you-go billing method.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
