// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client idempotency token. The server checks whether a request with the same ClientToken has been made. If yes, the server returns the result of the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JASIOFKVNVIXXXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The logistics address for this order. This parameter is typically valid for orders of physical products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cityCode&quot;:&quot;330100&quot;,&quot;cityName&quot;:&quot;Hangzhou&quot;,&quot;contactName&quot;:&quot;Test&quot;,&quot;countryCode&quot;:&quot;&quot;,&quot;districtName&quot;:&quot;Puyan Street&quot;,&quot;email&quot;:&quot;**@example.com&quot;,&quot;mobilePhone&quot;:&quot;153564848844&quot;,&quot;phone&quot;:&quot;1234567&quot;,&quot;provCode&quot;:&quot;330000&quot;,&quot;provName&quot;:&quot;Zhejiang Province&quot;,&quot;streetCode&quot;:&quot;33010610&quot;,&quot;streetName&quot;:&quot;Zhuantang&quot;,&quot;zipCode&quot;:&quot;0000&quot;}</para>
        /// </summary>
        [NameInMap("Logistics")]
        [Validation(Required=false)]
        public string Logistics { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of modules.</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestParameter> Parameter { get; set; }
        public class CreateInstanceRequestParameter : TeaModel {
            /// <summary>
            /// <para>The code of the Nth module property. Valid values of N: 1 to 100. If multiple module properties exist, concatenate them in the format of N=1, 2, 3...N.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceType</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The value of the Nth module property. Valid values of N: 1 to 100.</para>
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
        /// <para>The subscription period. Unit: months. For yearly subscription products, specify a multiple of 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period.</para>
        /// <list type="bullet">
        /// <item><description><para>PricingCycle=1: The unit of the subscription period is year.</para>
        /// </description></item>
        /// <item><description><para>PricingCycle=2: The unit of the subscription period is month.</para>
        /// </description></item>
        /// <item><description><para>PricingCycle=3: The unit of the subscription period is day.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PricingCycle=2.</para>
        /// <para>This parameter is applicable only to specific product types (ProductType is ddos_originpre_public_cn, ddosDip, ddoscoo, ddos_originpre_public_intl, ddosDip_intl, or ddoscoo_intl).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public long? PricingCycle { get; set; }

        /// <summary>
        /// <para>The product code. You can call the <b>QueryProductList</b> operation to query the product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cdn</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cdn</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The auto-renewal epoch. Unit: months.</para>
        /// <remarks>
        /// <para>This parameter is required when you set <b>RenewalStatus</b> to <b>AutoRenewal</b> in Settings.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RenewPeriod")]
        [Validation(Required=false)]
        public int? RenewPeriod { get; set; }

        /// <summary>
        /// <para>The auto-renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: auto-renewal is enabled.</description></item>
        /// <item><description>ManualRenewal: manual renewal.</description></item>
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
        /// <item><description>Subscription: subscription.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
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
