// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the system disk. You must specify this parameter only when you upgrade a non-I/O optimized instance of a retired instance type to an I/O optimized instance of an available instance type. For more information about instance types, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> and <a href="https://help.aliyun.com/document_detail/55263.html">Retired instance types</a>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// </list>
            /// <para>This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        /// <summary>
        /// <para>The information about data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribeInstanceModificationPriceRequestDataDisk> DataDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The category of data disk N. You can specify this parameter if you want to query the pricing information about newly attached subscription data disks. Valid values of N: 1 to 16. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: utra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// </list>
            /// <para>This parameter is empty by default.</para>
            /// <remarks>
            /// <para> When you call the DescribeInstanceModificationPrice operation, you must specify at least one of the following parameters: <c>InstanceType</c> and <c>DataDisk.N.*</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of data disk N that is an enhanced SSD (ESSD). The value of N must be the same as that in <c>DataDisk.N.Category</c> when DataDisk.N.Category is set to cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>Default value: PL1.</para>
            /// <para>For more information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The capacity of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud_essd: vary based on the <c>DataDisk.N.PerformanceLevel</c> value.</para>
            /// <list type="bullet">
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL0: 1 to 32768.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.</description></item>
            /// <item><description>Valid values when DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when DataDisk.N.Category is set to cloud: 5 to 2000.</para>
            /// </description></item>
            /// </list>
            /// <para>The default value is the minimum capacity allowed for the specified data disk category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance for which you want to query pricing information for a configuration upgrade.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1f2o4ldh8l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new instance type. We recommend that you call the <a href="https://help.aliyun.com/document_detail/66187.html">DescribeResourcesModification</a> operation to query the instance types available for configuration upgrades in a specified zone.</para>
        /// <remarks>
        /// <para>When you call the DescribeInstanceModificationPrice operation, you must specify at least one of the following parameters: <c>InstanceType</c> and <c>DataDisk.N.*</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6e.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
