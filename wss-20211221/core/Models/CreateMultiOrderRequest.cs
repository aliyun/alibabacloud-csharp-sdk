// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class CreateMultiOrderRequest : TeaModel {
        /// <summary>
        /// <para>The cookie information used for channel attribution. Specify this parameter if channel attribution information exists. Otherwise, you can leave it empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel=example</para>
        /// </summary>
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The product information.</para>
        /// </summary>
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<CreateMultiOrderRequestOrderItems> OrderItems { get; set; }
        public class CreateMultiOrderRequestOrderItems : TeaModel {
            /// <summary>
            /// <para>The purchase quantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic payment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>Specifies whether to modify the configuration of the monthly duration package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BuyChange")]
            [Validation(Required=false)]
            public bool? BuyChange { get; set; }

            /// <summary>
            /// <para>The product modules.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<CreateMultiOrderRequestOrderItemsComponents> Components { get; set; }
            public class CreateMultiOrderRequestOrderItemsComponents : TeaModel {
                /// <summary>
                /// <para>The key of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the module.</para>
                /// <para>The sample values and valid values for each key of the monthly duration package for Enterprise Edition are as follows:</para>
                /// <list type="bullet">
                /// <item><description>RegionId: cn-shanghai</description></item>
                /// <item><description>InstanceType: eds.enterprise_office.4c8g</description></item>
                /// <item><description>DurationType (hours): [Enum] <list type="bullet">
                /// <item><description>120</description></item>
                /// <item><description>250</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>OsType: [Enum] <list type="bullet">
                /// <item><description>Windows</description></item>
                /// <item><description>Linux</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootDiskSize (GiB): 80</description></item>
                /// <item><description>RootDiskCategory: [Enum] <list type="bullet">
                /// <item><description>cloud_efficiency (ultra cloud disk)</description></item>
                /// <item><description>cloud_auto (ESSD AutoPL cloud disk)</description></item>
                /// <item><description>cloud_essd (enhanced standard SSD, supported only by specific instance types)</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootPerformanceLevel: [Enum] <list type="bullet">
                /// <item><description>PL0</description></item>
                /// <item><description>PL1</description></item>
                /// <item><description>PL2</description></item>
                /// <item><description>PL3</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>DataDiskSize (GiB): Valid values are the same as those of RootDiskSize.</description></item>
                /// <item><description>DataDiskCategory: Valid values are the same as those of RootDiskCategory.</description></item>
                /// <item><description>DataPerformanceLevel: Valid values are the same as those of RootPerformanceLevel.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The callback URL after the order is paid. Specify the URL to receive the payment result based on your business requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/order/paid">https://example.com/order/paid</a></para>
            /// </summary>
            [NameInMap("PaidCallBackUrl")]
            [Validation(Required=false)]
            public string PaidCallBackUrl { get; set; }

            /// <summary>
            /// <para>The subscription period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 2, 3, and 5.</para>
            /// </description></item>
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are 1, 2, 3, and 6.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period for the subscription instance.</para>
            /// <remarks>
            /// <para>This parameter is required only when the billing method of the instance is subscription. This parameter is case-sensitive. Make sure that the spelling is correct.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The ID of the promotion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>youhuiquan_promotion_option_id_for_blank</para>
            /// </summary>
            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public string PromotionId { get; set; }

            /// <summary>
            /// <para>The list of resource IDs.</para>
            /// <remarks>
            /// <para>For the monthly duration package, this parameter corresponds to the cloud desktop ID. This parameter is required when OrderType is not set to <c>create</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <remarks>
            /// <para>This parameter is case-sensitive. Make sure that the spelling is correct.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DurationPackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The unified expiration date, which can be a day from the 1st to the 28th of a month. If this parameter is not specified, the standard renewal process is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("UnifiedExpireDay")]
            [Validation(Required=false)]
            public int? UnifiedExpireDay { get; set; }

        }

        /// <summary>
        /// <para>The order type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The extended properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// <para>The ID of the actual end user. This parameter is required when a reseller partner places an order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000001</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
