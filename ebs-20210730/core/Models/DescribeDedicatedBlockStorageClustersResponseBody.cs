// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClustersResponseBody : TeaModel {
        /// <summary>
        /// The queried dedicated block storage clusters.
        /// </summary>
        [NameInMap("DedicatedBlockStorageClusters")]
        [Validation(Required=false)]
        public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters> DedicatedBlockStorageClusters { get; set; }
        public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// The category of disks that can be created in the dedicated block storage cluster.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The time when the dedicated block storage cluster was created. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The storage capacity of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterCapacity")]
            [Validation(Required=false)]
            public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity : TeaModel {
                /// <summary>
                /// The available capacity of the dedicated block storage cluster. Unit: GiB.
                /// </summary>
                [NameInMap("AvailableCapacity")]
                [Validation(Required=false)]
                public long? AvailableCapacity { get; set; }

                /// <summary>
                /// The total capacity of the dedicated block storage cluster that was delivered in disk creation orders. Unit: GB.
                /// </summary>
                [NameInMap("AvailableDeviceCapacity")]
                [Validation(Required=false)]
                public long? AvailableDeviceCapacity { get; set; }

                /// <summary>
                /// This parameter is displayed only if Thin Provision is enabled.
                /// </summary>
                [NameInMap("AvailableSpaceCapacity")]
                [Validation(Required=false)]
                public double? AvailableSpaceCapacity { get; set; }

                /// <summary>
                /// The capacity of the dedicated block storage cluster that was delivered in orders. Unit: GB.
                /// </summary>
                [NameInMap("ClusterAvailableCapacity")]
                [Validation(Required=false)]
                public long? ClusterAvailableCapacity { get; set; }

                /// <summary>
                /// The capacity of the dedicated block storage cluster that is to be delivered in orders. Unit: GB.
                /// </summary>
                [NameInMap("ClusterDeliveryCapacity")]
                [Validation(Required=false)]
                public long? ClusterDeliveryCapacity { get; set; }

                /// <summary>
                /// The to-be-delivered capacity of the dedicated block storage cluster. Unit: GB.
                /// </summary>
                [NameInMap("DeliveryCapacity")]
                [Validation(Required=false)]
                public long? DeliveryCapacity { get; set; }

                /// <summary>
                /// The total capacity of the dedicated block storage cluster. Unit: GiB.
                /// </summary>
                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public long? TotalCapacity { get; set; }

                /// <summary>
                /// The total capacity of the dedicated block storage cluster that is to be delivered in disk creation orders. Unit: GB.
                /// </summary>
                [NameInMap("TotalDeviceCapacity")]
                [Validation(Required=false)]
                public long? TotalDeviceCapacity { get; set; }

                /// <summary>
                /// This parameter is displayed only if Thin Provision is enabled.
                /// </summary>
                [NameInMap("TotalSpaceCapacity")]
                [Validation(Required=false)]
                public long? TotalSpaceCapacity { get; set; }

                /// <summary>
                /// The used capacity of the dedicated block storage cluster. Unit: GB.
                /// </summary>
                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public long? UsedCapacity { get; set; }

                /// <summary>
                /// The capacity of the dedicated block storage cluster that was used to create disks. Unit: GB.
                /// </summary>
                [NameInMap("UsedDeviceCapacity")]
                [Validation(Required=false)]
                public long? UsedDeviceCapacity { get; set; }

                /// <summary>
                /// This parameter is displayed only if Thin Provision is enabled.
                /// </summary>
                [NameInMap("UsedSpaceCapacity")]
                [Validation(Required=false)]
                public double? UsedSpaceCapacity { get; set; }

            }

            /// <summary>
            /// The ID of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterId")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterId { get; set; }

            /// <summary>
            /// The name of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("DedicatedBlockStorageClusterName")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterName { get; set; }

            /// <summary>
            /// The description of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableThinProvision")]
            [Validation(Required=false)]
            public bool? EnableThinProvision { get; set; }

            /// <summary>
            /// The time when the dedicated block storage cluster expires. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The performance level of disks. Valid values:
            /// 
            /// *   PL0
            /// *   PL1
            /// *   PL2
            /// *   PL3
            /// 
            /// >  This parameter takes effect only if Category is set to cloud_essd.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The region ID of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the dedicated block storage cluster belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SizeOverSoldRatio")]
            [Validation(Required=false)]
            public double? SizeOverSoldRatio { get; set; }

            /// <summary>
            /// The state of the dedicated block storage cluster. Valid values:
            /// 
            /// *   Preparing
            /// *   Running
            /// *   Expired
            /// *   Offline
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageDomain")]
            [Validation(Required=false)]
            public string StorageDomain { get; set; }

            /// <summary>
            /// This parameter is not supported.
            /// </summary>
            [NameInMap("SupportedCategory")]
            [Validation(Required=false)]
            public string SupportedCategory { get; set; }

            /// <summary>
            /// The tags of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags> Tags { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags : TeaModel {
                /// <summary>
                /// The tag key of the dedicated block storage cluster.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the dedicated block storage cluster.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The type of the dedicated block storage cluster. Valid values:
            /// 
            /// *   Standard: basic dedicated block storage cluster. ESSDs at performance level 0 (PL0 ESSDs) can be created in basic dedicated block storage clusters.
            /// *   Premium: performance dedicated block storage cluster. ESSDs at performance level 1 (PL1 ESSDs) can be created in performance dedicated block storage clusters.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The zone ID of the dedicated block storage cluster.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
