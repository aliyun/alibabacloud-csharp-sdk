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
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The data disk configurations.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribeInstanceModificationPriceRequestDataDisk> DataDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The category of data disk N, where N is an integer from 1 to 16. Use this parameter to query the price of adding a new data disk to the instance. Valid values:\
            /// \
            /// \- <c>cloud_efficiency</c>: Ultra Disk\
            /// \
            /// \- <c>cloud_ssd</c>: Standard SSD\
            /// \
            /// \- <c>cloud_essd</c>: ESSD\
            /// \
            /// \- <c>cloud</c>: Basic Disk\
            /// \
            /// Default value: None.\
            /// \
            /// \
            /// \
            /// \
            /// \
            /// \
            /// \
            /// \
            /// \</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d-bf4rupt9****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. This parameter is valid only when DataDisk.N.Category is set to cloud_essd. The value of N must match the N in DataDisk.N.Category. Valid values:
            /// \- PL0: up to 10,000 random read/write IOPS per disk.
            /// \- PL1: up to 50,000 random read/write IOPS per disk.
            /// \- PL2: up to 100,000 random read/write IOPS per disk.
            /// \- PL3: up to 1,000,000 random read/write IOPS per disk.
            /// Default value: PL1.
            /// For more information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of data disk N in GiB, where N is an integer from 1 to 16. The value range varies based on the disk category:
            /// \- <c>cloud_efficiency</c> (Ultra Disk): 20 to 32768.
            /// \- <c>cloud_ssd</c> (Standard SSD): 20 to 32768.
            /// \- <c>cloud_essd</c>: The value range varies based on the value of <c>DataDisk.N.PerformanceLevel</c>.
            /// \- PL0: 1 to 32768.
            /// \- PL1: 20 to 32768.
            /// \- PL2: 461 to 32768.
            /// \- PL3: 1261 to 32768.
            /// \- <c>cloud</c> (Basic Disk): 5 to 2000.
            /// Default value: The minimum size supported by the specified data disk category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-06T22Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which to query the modification price.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1f2o4ldh8l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target instance type for the instance upgrade. Call the <a href="https://help.aliyun.com/document_detail/66187.html">DescribeResourcesModification</a> operation to query the instance types available for upgrade in the specified availability zone.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>InstanceType</c> and <c>DataDisk.N.*</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6e.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to get the latest list of Alibaba Cloud regions.</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-05T22:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
