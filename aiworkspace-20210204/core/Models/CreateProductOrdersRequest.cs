// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateProductOrdersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically pay for the provided products.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The list of products to be purchased. Separate them with commas (,).</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<CreateProductOrdersRequestProducts> Products { get; set; }
        public class CreateProductOrdersRequestProducts : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically renew the product.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing method. Only POSTPAY is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The purchase duration. You can use this parameter together with pricingCycle. Only 1 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The properties of the instance.</para>
            /// <list type="bullet">
            /// <item><description>DataWorks_share: [ { &quot;Code&quot;: &quot;region&quot;, &quot;Value&quot;: &quot;cn-shanghai&quot; } ]</description></item>
            /// <item><description>OSS_share: [ { &quot;Code&quot;: &quot;commodity_type&quot;, &quot;Value&quot;: &quot;oss&quot;, &quot;Name&quot;: &quot;Object Storage Service&quot; }, { &quot;Code&quot;: &quot;ord_time&quot;, &quot;Value&quot;: &quot;1:Hour&quot;, &quot;Name&quot;: &quot;1 Hour&quot; } ]</description></item>
            /// <item><description>PAI_share: None</description></item>
            /// <item><description>China bid MaxCompute_share: [ { &quot;Code&quot;: &quot;region&quot;, &quot;Value&quot;: &quot;cn-hangzhou&quot; }, { &quot;Code&quot;: &quot;odps_specification_type&quot;, &quot;Value&quot;: &quot;OdpsStandard&quot; }, { &quot;Code&quot;: &quot;ord_time&quot;, &quot;Value&quot;: &quot;1:Hour&quot; } ]</description></item>
            /// <item><description>International bid MaxCompute_share: [ { &quot;Code&quot;: &quot;region&quot;, &quot;Value&quot;: &quot;cn-hangzhou&quot; }, { &quot;Code&quot;: &quot;ord_time&quot;, &quot;Value&quot;: &quot;1:Hour&quot; } ]</description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceProperties")]
            [Validation(Required=false)]
            public List<CreateProductOrdersRequestProductsInstanceProperties> InstanceProperties { get; set; }
            public class CreateProductOrdersRequestProductsInstanceProperties : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>commodity_type。</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss。</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the order. Only BUY is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The billing cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Month: The price is calculated every month. DataWorks_share only supports Month.</description></item>
            /// <item><description>Hour: The price is calculated every hour. OSS_share and MaxCompute_share only support Hour.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            /// <summary>
            /// <para>The product code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataWorks_share: pay-as-you-go DataWorks</description></item>
            /// <item><description>MaxCompute_share: pay-as-you-go MaxCompute</description></item>
            /// <item><description>PAI_share: pay-as-you-go PAI.</description></item>
            /// <item><description>OSS_share: pay-as-you-go OSS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataWorks_share</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

    }

}
