// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class CreateMultiOrderShrinkRequest : TeaModel {
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The product information.</para>
        /// </summary>
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<CreateMultiOrderShrinkRequestOrderItems> OrderItems { get; set; }
        public class CreateMultiOrderShrinkRequestOrderItems : TeaModel {
            /// <summary>
            /// <para>The quantity to purchase.</para>
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

            [NameInMap("BuyChange")]
            [Validation(Required=false)]
            public bool? BuyChange { get; set; }

            /// <summary>
            /// <para>The product modules.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<CreateMultiOrderShrinkRequestOrderItemsComponents> Components { get; set; }
            public class CreateMultiOrderShrinkRequestOrderItemsComponents : TeaModel {
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
                /// <para>The following example values or valid values are available for each key of the Enterprise Edition monthly duration package:</para>
                /// <list type="bullet">
                /// <item><description>RegionId: cn-shanghai</description></item>
                /// <item><description>InstanceType: eds.enterprise_office.4c8g</description></item>
                /// <item><description>DurationType (hours): [Valid values] <list type="bullet">
                /// <item><description>120</description></item>
                /// <item><description>250</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>OsType: [Valid values] <list type="bullet">
                /// <item><description>Windows</description></item>
                /// <item><description>Linux</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootDiskSize (GiB): 80</description></item>
                /// <item><description>RootDiskCategory: [Valid values] <list type="bullet">
                /// <item><description>cloud_efficiency (ultra cloud disk)</description></item>
                /// <item><description>cloud_auto (ultra-fast cloud disk)</description></item>
                /// <item><description>cloud_essd (enhanced standard SSD. Only specific instance types support this value.)</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootPerformanceLevel: [Valid values] <list type="bullet">
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

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            [NameInMap("PaidCallBackUrl")]
            [Validation(Required=false)]
            public string PaidCallBackUrl { get; set; }

            /// <summary>
            /// <para>The subscription duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>: 1, 2, 3, or 5.</para>
            /// </description></item>
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>: 1, 2, 3, or 6.</para>
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
            /// <para>The unit of the billing cycle for the subscription instance.</para>
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
            /// <para>The promotion ID.</para>
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
            /// <para>For monthly duration packages, this parameter corresponds to the cloud desktop ID. This parameter is required when OrderType is not <c>create</c>.</para>
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
        public string PropertiesShrink { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
