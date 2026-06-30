// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class CreateMultiOrderRequest : TeaModel {
        [NameInMap("ChannelCookie")]
        [Validation(Required=false)]
        public string ChannelCookie { get; set; }

        /// <summary>
        /// <para>The items in the order.</para>
        /// </summary>
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<CreateMultiOrderRequestOrderItems> OrderItems { get; set; }
        public class CreateMultiOrderRequestOrderItems : TeaModel {
            /// <summary>
            /// <para>The number of resources to purchase.</para>
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
            /// <para>The components that define the resource.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<CreateMultiOrderRequestOrderItemsComponents> Components { get; set; }
            public class CreateMultiOrderRequestOrderItemsComponents : TeaModel {
                /// <summary>
                /// <para>The key of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the component.</para>
                /// <para>Example and valid values for the keys of a monthly duration package (Enterprise Edition):</para>
                /// <list type="bullet">
                /// <item><description><para>RegionId: cn-shanghai</para>
                /// </description></item>
                /// <item><description><para>InstanceType: eds.enterprise_office.4c8g</para>
                /// </description></item>
                /// <item><description><para>DurationType (in hours): Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>120</para>
                /// </description></item>
                /// <item><description><para>250</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>OsType: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Windows</para>
                /// </description></item>
                /// <item><description><para>Linux</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>RootDiskSize (in GiB): 80</para>
                /// </description></item>
                /// <item><description><para>RootDiskCategory: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_efficiency (Ultra Disk)</para>
                /// </description></item>
                /// <item><description><para>cloud_auto (ESSD AutoPL Disk)</para>
                /// </description></item>
                /// <item><description><para><c>cloud_essd</c> (Enhanced SSD). This value is supported only by specific instance types.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>RootPerformanceLevel: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PL0</para>
                /// </description></item>
                /// <item><description><para>PL1</para>
                /// </description></item>
                /// <item><description><para>PL2</para>
                /// </description></item>
                /// <item><description><para>PL3</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>DataDiskSize (in GiB): Same as <c>RootDiskSize</c>.</para>
                /// </description></item>
                /// <item><description><para>DataDiskCategory: Same as <c>RootDiskCategory</c>.</para>
                /// </description></item>
                /// <item><description><para>DataPerformanceLevel: Same as <c>RootPerformanceLevel</c>.</para>
                /// </description></item>
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

            /// <summary>
            /// <para>The subscription period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, the valid values are 1, 2, 3, and 5.</para>
            /// </description></item>
            /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, the valid values are 1, 2, 3, and 6.</para>
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
            /// <para>The time unit of the subscription duration.</para>
            /// <remarks>
            /// <para>This parameter is required for prepaid instances and is case-sensitive.</para>
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
            /// <para>A list of resource IDs.</para>
            /// <remarks>
            /// <para>For a monthly duration package, this parameter specifies the IDs of the cloud desktops. This parameter is required unless the <c>OrderType</c> is <c>create</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// <remarks>
            /// <para>This parameter is case-sensitive.</para>
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
        public Dictionary<string, string> Properties { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
