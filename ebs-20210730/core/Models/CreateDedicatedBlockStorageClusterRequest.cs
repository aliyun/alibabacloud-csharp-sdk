// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDedicatedBlockStorageClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the zone in which to create the dedicated block storage cluster. You can call the [DescribeZones](https://help.aliyun.com/document_detail/25610.html) operation to query the most recent zone list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Azone")]
        [Validation(Required=false)]
        public string Azone { get; set; }

        /// <summary>
        /// The capacity of the dedicated block storage cluster. Valid values: 61440 to 2334720. Unit: GiB. 2,334,720 GiB is equal to 2,280 TiB. The capacity increases in a minimum increment of 12,288 GiB.
        /// 
        /// >  If the capacity of a dedicated block storage cluster is less than 576 TiB, the maximum throughput per TiB cannot exceed 52 MB/s. If the capacity of a dedicated block storage cluster is greater than 576 TiB, the maximum throughput per TiB cannot exceed 26 MB/s.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DbscId { get; set; }

        /// <summary>
        /// The name of the dedicated block storage cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// The subscription duration of the dedicated block storage cluster. Valid values: 6, 7, 8, 9, 10, 11, 12, 24, and 36.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration specified by `Period`. Set the value to Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the region in which to create the dedicated block storage cluster. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the dedicated block storage cluster.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags to add to the dedicated block storage cluster. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDedicatedBlockStorageClusterRequestTag> Tag { get; set; }
        public class CreateDedicatedBlockStorageClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the dedicated block storage cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the dedicated block storage cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the dedicated block storage cluster. Valid values:
        /// 
        /// *   Standard: basic dedicated block storage cluster. Enterprise SSDs (ESSDs) at performance level 0 (PL0 ESSDs) can be created in basic dedicated block storage clusters.
        /// *   Premium: performance dedicated block storage cluster. ESSDs at performance level 1 (PL1 ESSDs) can be created in performance dedicated block storage clusters.
        /// 
        /// Default value: Premium.
        /// 
        /// For more information about ESSDs, see [ESSDs](https://help.aliyun.com/document_detail/122389.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
