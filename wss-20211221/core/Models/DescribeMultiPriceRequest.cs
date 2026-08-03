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
                /// <para>The following example values and valid values are for the Enterprise Edition monthly duration package:</para>
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
                /// <item><description>cloud_efficiency: ultra cloud disk</description></item>
                /// <item><description>cloud_auto: ESSD AutoPL cloud disk</description></item>
                /// <item><description>cloud_essd: enhanced standard SSD. Only specific instance types support this value.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>RootPerformanceLevel: Valid values: <list type="bullet">
                /// <item><description>PL0</description></item>
                /// <item><description>PL1</description></item>
                /// <item><description>PL2</description></item>
                /// <item><description>PL3</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>DataDiskSize (GiB): same as RootDiskSize</description></item>
                /// <item><description>DataDiskCategory: same as RootDiskCategory</description></item>
                /// <item><description>DataPerformanceLevel: same as RootPerformanceLevel</description></item>
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
            /// <para>The list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The subscription duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If PeriodUnit is set to Year: 1, 2, or 3.</para>
            /// </description></item>
            /// <item><description><para>If PeriodUnit is set to Month: 1, 2, 3, or 6.</para>
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
            /// <para>The unit of the subscription duration.</para>
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
            /// </summary>
            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <remarks>
            /// <para>This parameter is case-sensitive. Make sure that the value is spelled correctly.</para>
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
        /// <para>The package code. You do not need to specify this parameter for non-package types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pacakge</para>
        /// </summary>
        [NameInMap("PackageCode")]
        [Validation(Required=false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// <para>The user ID of the resource ownership in reseller pattern. You do not need to specify this parameter in non-reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182864463481****</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

    }

}
