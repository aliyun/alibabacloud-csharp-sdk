// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateProductOrdersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic payment is applied to all products specified in the Products parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: automatic payment</description></item>
        /// <item><description>false: no automatic payment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The list of products to purchase, separated by commas.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<CreateProductOrdersRequestProducts> Products { get; set; }
        public class CreateProductOrdersRequestProducts : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Auto-renewal is enabled.</description></item>
            /// <item><description>false: Auto-renewal is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing method. Currently, only POSTPAY is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The purchase duration. This parameter is used together with PricingCycle. Currently, only 1 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The list of instance property information.</para>
            /// <list type="bullet">
            /// <item><description>DataWorks_share:
            /// [ {
            /// &quot;Code&quot;: &quot;region&quot;,
            /// &quot;Value&quot;: &quot;cn-shanghai&quot;
            /// }
            /// ]</description></item>
            /// <item><description>OSS_share:
            /// [ {
            /// &quot;Code&quot;: &quot;commodity_type&quot;,
            /// &quot;Value&quot;: &quot;oss&quot;,
            /// &quot;Name&quot;: &quot;Object Storage Service (OSS)&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;ord_time&quot;,
            /// &quot;Value&quot;: &quot;1:Hour&quot;,
            /// &quot;Name&quot;: &quot;1 hour&quot;
            /// }
            /// ]</description></item>
            /// <item><description>PAI_share: None</description></item>
            /// <item><description>MaxCompute_share for the Chinese site:
            /// [
            /// {
            /// &quot;Code&quot;: &quot;region&quot;,
            /// &quot;Value&quot;: &quot;cn-hangzhou&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;odps_specification_type&quot;,
            /// &quot;Value&quot;: &quot;OdpsStandard&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;ord_time&quot;,
            /// &quot;Value&quot;: &quot;1:Hour&quot;
            /// }
            /// ]</description></item>
            /// <item><description>MaxCompute_share for the international site:
            /// [
            /// {
            /// &quot;Code&quot;: &quot;region&quot;,
            /// &quot;Value&quot;: &quot;cn-hangzhou&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;ord_time&quot;,
            /// &quot;Value&quot;: &quot;1:Hour&quot;
            /// }
            /// ]</description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceProperties")]
            [Validation(Required=false)]
            public List<CreateProductOrdersRequestProductsInstanceProperties> InstanceProperties { get; set; }
            public class CreateProductOrdersRequestProductsInstanceProperties : TeaModel {
                /// <summary>
                /// <para>The code of the instance property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>commodity_type</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The name of the instance property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Object Storage Service (OSS)</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the instance property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The order type. Currently, only BUY is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The pricing unit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Month: Monthly pricing. Only DataWorks_share supports this value.</description></item>
            /// <item><description>Hour: Hourly pricing. Only OSS_share and MaxCompute_share support this value.</description></item>
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
            /// <item><description>DataWorks_share: Pay-as-you-go DataWorks.</description></item>
            /// <item><description>MaxCompute_share: Pay-as-you-go MaxCompute.</description></item>
            /// <item><description>PAI_share: Pay-as-you-go PAI.</description></item>
            /// <item><description>OSS_share: Pay-as-you-go OSS.</description></item>
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
