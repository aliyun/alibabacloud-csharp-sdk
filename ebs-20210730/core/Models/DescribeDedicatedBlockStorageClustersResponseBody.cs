// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the dedicated block storage clusters.</para>
        /// </summary>
        [NameInMap("DedicatedBlockStorageClusters")]
        [Validation(Required=false)]
        public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters> DedicatedBlockStorageClusters { get; set; }
        public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345601234560***</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The category of disks that can be created in the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the dedicated block storage cluster was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657113211</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Details about the storage capacity of the dedicated block storage cluster.</para>
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterCapacity")]
            [Validation(Required=false)]
            public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity : TeaModel {
                /// <summary>
                /// <para>The available capacity of the dedicated block storage cluster. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("AvailableCapacity")]
                [Validation(Required=false)]
                public long? AvailableCapacity { get; set; }

                /// <summary>
                /// <para>The total capacity of the dedicated block storage cluster that was delivered in disk creation orders. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("AvailableDeviceCapacity")]
                [Validation(Required=false)]
                public long? AvailableDeviceCapacity { get; set; }

                /// <summary>
                /// <para>This parameter is displayed only if Thin Provision is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40000.3</para>
                /// </summary>
                [NameInMap("AvailableSpaceCapacity")]
                [Validation(Required=false)]
                public double? AvailableSpaceCapacity { get; set; }

                /// <summary>
                /// <para>The capacity of the dedicated block storage cluster that was delivered in orders. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("ClusterAvailableCapacity")]
                [Validation(Required=false)]
                public long? ClusterAvailableCapacity { get; set; }

                /// <summary>
                /// <para>The capacity of the dedicated block storage cluster that is to be delivered in orders. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ClusterDeliveryCapacity")]
                [Validation(Required=false)]
                public long? ClusterDeliveryCapacity { get; set; }

                /// <summary>
                /// <para>The capacity to be delivered for the dedicated block storage cluster. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeliveryCapacity")]
                [Validation(Required=false)]
                public long? DeliveryCapacity { get; set; }

                /// <summary>
                /// <para>The total capacity of the dedicated block storage cluster. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public long? TotalCapacity { get; set; }

                /// <summary>
                /// <para>The total capacity of the dedicated block storage cluster that is to be delivered in disk creation orders. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("TotalDeviceCapacity")]
                [Validation(Required=false)]
                public long? TotalDeviceCapacity { get; set; }

                /// <summary>
                /// <para>This parameter is displayed only if Thin Provision is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73728</para>
                /// </summary>
                [NameInMap("TotalSpaceCapacity")]
                [Validation(Required=false)]
                public long? TotalSpaceCapacity { get; set; }

                /// <summary>
                /// <para>The used capacity of the dedicated block storage cluster. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1440</para>
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public long? UsedCapacity { get; set; }

                /// <summary>
                /// <para>The capacity of the dedicated block storage cluster that was used to create disks. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32000</para>
                /// </summary>
                [NameInMap("UsedDeviceCapacity")]
                [Validation(Required=false)]
                public long? UsedDeviceCapacity { get; set; }

                /// <summary>
                /// <para>This parameter is displayed only if Thin Provision is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33727.7</para>
                /// </summary>
                [NameInMap("UsedSpaceCapacity")]
                [Validation(Required=false)]
                public double? UsedSpaceCapacity { get; set; }

            }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-f8z4d3k4nsgg9okb****</para>
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterId")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterId { get; set; }

            /// <summary>
            /// <para>The name of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDBSCCluster</para>
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterName")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterName { get; set; }

            /// <summary>
            /// <para>The description of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether Thin Provision is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableThinProvision")]
            [Validation(Required=false)]
            public bool? EnableThinProvision { get; set; }

            /// <summary>
            /// <para>The time when the dedicated block storage cluster expires. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673020800</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The performance level of disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0</description></item>
            /// <item><description>PL1</description></item>
            /// <item><description>PL2</description></item>
            /// <item><description>PL3</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is valid only when the SupportedCategory value is cloud_essd.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The region ID of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the dedicated block storage cluster belongs. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to obtain the ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzsoux****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The capacity oversold ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("SizeOverSoldRatio")]
            [Validation(Required=false)]
            public double? SizeOverSoldRatio { get; set; }

            /// <summary>
            /// <para>The state of the dedicated block storage cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Preparing</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>Offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>StorageDomain</para>
            /// 
            /// <b>Example:</b>
            /// <para>StorageDomain</para>
            /// </summary>
            [NameInMap("StorageDomain")]
            [Validation(Required=false)]
            public string StorageDomain { get; set; }

            /// <summary>
            /// <para>This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SupportedCategory")]
            [Validation(Required=false)]
            public string SupportedCategory { get; set; }

            /// <summary>
            /// <para>The tags of the dedicated block storage cluster.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags> Tags { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the dedicated block storage cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the dedicated block storage cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The type of the dedicated block storage cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: basic dedicated block storage cluster. ESSDs at performance level 0 (PL0 ESSDs) can be created in basic dedicated block storage clusters.</description></item>
            /// <item><description>Premium: performance dedicated block storage cluster. ESSDs at performance level 1 (PL1 ESSDs) can be created in performance dedicated block storage clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The zone ID of the dedicated block storage cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11B55F58-D3A4-4A9B-9596-342420D0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
