// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateProductOrdersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically pay for all products listed in the Products parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables automatic payment.</para>
        /// </description></item>
        /// <item><description><para>false: Disables automatic payment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The list of products to purchase.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<CreateProductOrdersRequestProducts> Products { get; set; }
        public class CreateProductOrdersRequestProducts : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enables auto-renewal.</para>
            /// </description></item>
            /// <item><description><para>false: Disables auto-renewal.</para>
            /// </description></item>
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
            /// <para>The subscription duration. This parameter is used with PricingCycle. Currently, only a value of 1 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The list of instance properties.</para>
            /// <list type="bullet">
            /// <item><description><para>DataWorks_share:
            /// [ {
            /// &quot;Code&quot;: &quot;region&quot;,
            /// &quot;Value&quot;: &quot;cn-shanghai&quot;
            /// }
            /// ]</para>
            /// </description></item>
            /// <item><description><para>OSS_share:
            /// [ {
            /// &quot;Code&quot;: &quot;commodity_type&quot;,
            /// &quot;Value&quot;: &quot;oss&quot;,
            /// &quot;Name&quot;: &quot;Object Storage Service&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;ord_time&quot;,
            /// &quot;Value&quot;: &quot;1:Hour&quot;,
            /// &quot;Name&quot;: &quot;1 Hour&quot;
            /// }
            /// ]</para>
            /// </description></item>
            /// <item><description><para>PAI_share: None</para>
            /// </description></item>
            /// <item><description><para>MaxCompute_share for accounts in mainland China:
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
            /// ]</para>
            /// </description></item>
            /// <item><description><para>MaxCompute_share for accounts outside mainland China:
            /// [
            /// {
            /// &quot;Code&quot;: &quot;region&quot;,
            /// &quot;Value&quot;: &quot;cn-hangzhou&quot;
            /// },
            /// {
            /// &quot;Code&quot;: &quot;ord_time&quot;,
            /// &quot;Value&quot;: &quot;1:Hour&quot;
            /// }
            /// ]</para>
            /// </description></item>
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
                /// <para>Object Storage Service</para>
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
            /// <para>The billing cycle. The following values are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Month: Monthly billing. Only DataWorks_share supports this value.</para>
            /// </description></item>
            /// <item><description><para>Hour: Hourly billing. Only OSS_share and MaxCompute_share support this value.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            /// <summary>
            /// <para>The product code. The following codes are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>DataWorks_share: The pay-as-you-go DataWorks product.</para>
            /// </description></item>
            /// <item><description><para>MaxCompute_share: The pay-as-you-go MaxCompute product.</para>
            /// </description></item>
            /// <item><description><para>PAI_share: The pay-as-you-go PAI product.</para>
            /// </description></item>
            /// <item><description><para>OSS_share: The pay-as-you-go OSS product.</para>
            /// </description></item>
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
