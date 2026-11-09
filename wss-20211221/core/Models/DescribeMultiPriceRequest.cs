// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeMultiPriceRequest : TeaModel {
        /// <summary>
        /// <para>The product information.</para>
        /// </summary>
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<DescribeMultiPriceRequestOrderItems> OrderItems { get; set; }
        public class DescribeMultiPriceRequestOrderItems : TeaModel {
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
            /// <para>The list of product modules.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeMultiPriceRequestOrderItemsComponents> Components { get; set; }
            public class DescribeMultiPriceRequestOrderItemsComponents : TeaModel {
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
                /// <para>The following section describes the sample values and valid values of each key for the Enterprise Edition monthly package:</para>
                /// <list type="bullet">
                /// <item><description>RegionId: cn-shanghai</description></item>
                /// <item><description>InstanceType: eds.enterprise_office.4c8g</description></item>
                /// <item><description>DurationType (hours): Valid values: <list type="bullet">
                /// <item><description>120</description></item>
                /// <item><description>250</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>OsType: Valid values: <list type="bullet">
                /// <item><description>Windows</description></item>
                /// <item><description>Linux</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootDiskSize (GiB): 80</description></item>
                /// <item><description>RootDiskCategory: Valid values: <list type="bullet">
                /// <item><description>cloud_efficiency (ultra cloud disk)</description></item>
                /// <item><description>cloud_auto (ESSD AutoPL cloud disk)</description></item>
                /// <item><description>cloud_essd (enhanced standard SSD, supported only by specific instance types)</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootPerformanceLevel: Valid values: <list type="bullet">
                /// <item><description>PL0</description></item>
                /// <item><description>PL1</description></item>
                /// <item><description>PL2</description></item>
                /// <item><description>PL3</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>DataDiskSize (GiB): Same as RootDiskSize.</description></item>
                /// <item><description>DataDiskCategory: Same as RootDiskCategory.</description></item>
                /// <item><description>DataPerformanceLevel: Same as RootPerformanceLevel.</description></item>
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
            /// <para>The extended data of the order item, which is passed as a JSON string. The structure varies based on the order scenario. For the billing method change scenario, you can pass the instance and the list of target billing methods. If no extended data is required, you can leave this parameter empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;resourceType&quot;:&quot;Desktop&quot;,&quot;chargeType&quot;:&quot;POSTPAY&quot;,&quot;instanceId&quot;:&quot;ecd-6wye9optu0kag****&quot;}]</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The subscription period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>When <c>PeriodUnit</c> is set to <c>Year</c>: 1, 2, and 3.</para>
            /// </description></item>
            /// <item><description><para>When <c>PeriodUnit</c> is set to <c>Month</c>: 1, 2, 3, and 6.</para>
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
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <remarks>
            /// <para>This parameter is case-sensitive. Make sure that the spelling is correct.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DurationPackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The subscription period of the savings plan. For example, 1Year indicates one year.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1Year</para>
            /// </summary>
            [NameInMap("SavingPlanPeriod")]
            [Validation(Required=false)]
            public string SavingPlanPeriod { get; set; }

            /// <summary>
            /// <para>The unified expiration date, which can be a day from the 1st to the 28th of a month. If you do not specify this parameter, the instance is renewed in the standard way.</para>
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
        /// <para>The package code. You do not need to specify this parameter for non-package types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pacakge</para>
        /// </summary>
        [NameInMap("PackageCode")]
        [Validation(Required=false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// <para>The user ID for resource ownership in the reseller pattern. You do not need to specify this parameter for non-reseller patterns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182864463481****</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
