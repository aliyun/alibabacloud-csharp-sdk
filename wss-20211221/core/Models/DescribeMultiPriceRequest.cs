// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeMultiPriceRequest : TeaModel {
        /// <summary>
        /// <para>The order items.</para>
        /// </summary>
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<DescribeMultiPriceRequestOrderItems> OrderItems { get; set; }
        public class DescribeMultiPriceRequestOrderItems : TeaModel {
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
            /// <para>A list of components.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeMultiPriceRequestOrderItemsComponents> Components { get; set; }
            public class DescribeMultiPriceRequestOrderItemsComponents : TeaModel {
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
                /// <para>The following are the keys and their sample or enumerated values for a monthly duration package of the enterprise edition:</para>
                /// <list type="bullet">
                /// <item><description><para><c>RegionId</c>: cn-shanghai</para>
                /// </description></item>
                /// <item><description><para><c>InstanceType</c>: eds.enterprise_office.4c8g</para>
                /// </description></item>
                /// <item><description><para><c>DurationType</c> (in hours): [enum]</para>
                /// <list type="bullet">
                /// <item><description><para>120</para>
                /// </description></item>
                /// <item><description><para>250</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><c>OsType</c>: [enum]</para>
                /// <list type="bullet">
                /// <item><description><para>Windows</para>
                /// </description></item>
                /// <item><description><para>Linux</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><c>RootDiskSize</c> (in GiB): 80</para>
                /// </description></item>
                /// <item><description><para><c>RootDiskCategory</c>: [enum]</para>
                /// <list type="bullet">
                /// <item><description><para><c>cloud_efficiency</c> (Ultra Cloud Disk)</para>
                /// </description></item>
                /// <item><description><para><c>cloud_auto</c> (AutoPL Cloud Disk)</para>
                /// </description></item>
                /// <item><description><para><c>cloud_essd</c> (Enhanced SSD (ESSD), available only for specific instance types)</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><c>RootPerformanceLevel</c>: [enum]</para>
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
                /// <item><description><para><c>DataDiskSize</c> (in GiB): Same as <c>RootDiskSize</c>.</para>
                /// </description></item>
                /// <item><description><para><c>DataDiskCategory</c>: Same as <c>RootDiskCategory</c>.</para>
                /// </description></item>
                /// <item><description><para><c>DataPerformanceLevel</c>: Same as <c>RootPerformanceLevel</c>.</para>
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

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>A list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The subscription period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>PeriodUnit</c> is <c>Year</c>, the valid values are 1, 2, and 3.</para>
            /// </description></item>
            /// <item><description><para>If <c>PeriodUnit</c> is <c>Month</c>, the valid values are 1, 2, 3, and 6.</para>
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
            /// <para>The unit of the subscription period.</para>
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
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <remarks>
            /// <para>The value is case-sensitive.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DurationPackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SavingPlanPeriod")]
            [Validation(Required=false)]
            public string SavingPlanPeriod { get; set; }

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
        /// <para>The package code. This parameter is not required for non-package types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pacakge</para>
        /// </summary>
        [NameInMap("PackageCode")]
        [Validation(Required=false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// <para>The ID of the user who owns the resource in the reseller model. This parameter is not required in non-reseller mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182864463481****</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
