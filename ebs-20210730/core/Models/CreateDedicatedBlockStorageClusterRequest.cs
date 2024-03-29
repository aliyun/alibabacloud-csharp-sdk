// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDedicatedBlockStorageClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the zone in which to create the dedicated block storage cluster. You can call the [DescribeZones](~~25610~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("Azone")]
        [Validation(Required=false)]
        public string Azone { get; set; }

        /// <summary>
        /// The capacity of the dedicated block storage cluster. Valid values: 61440 to 2334720. Unit: GiB. 2,334,720 GiB is equal to 2,280 TiB. The capacity increases in a minimum increment of 12,288 GB.
        /// 
        /// >  If the capacity of a dedicated block storage cluster is less than 576 TiB, the maximum throughput supported per TiB does not exceed 52 MB/s. If the capacity of a dedicated block storage cluster is greater than 576 TiB, the maximum throughput supported per TiB does not exceed 26 MB/s.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DbscId { get; set; }

        /// <summary>
        /// The name of the dedicated block storage cluster.
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// The specific number of PeriodUnit.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration for the dedicated block storage cluster,
        /// Valid values:
        /// 
        /// *   **Month**
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the region in which to create the dedicated block storage cluster. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The resource tags. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDedicatedBlockStorageClusterRequestTag> Tag { get; set; }
        public class CreateDedicatedBlockStorageClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N used for exact search of EBS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.
            /// 
            /// The `Tag.N` parameter pair (Tag.N.Key and Tag.N.Value) is used for exact search of EBS resources that have specified tags added. Each tag is a key-value pair.
            /// 
            /// *   If you specify only `Tag.N.Key`, all EBS resources whose tags contain the specified tag key are returned.
            /// *   If you specify only `Tag.N.Value`, the `InvalidParameter.TagValue` error is returned.
            /// *   If you specify multiple tag key-value pairs at the same time, only EBS resources that match all tag key-value pairs are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with `acs:` or contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the dedicated block storage cluster. Valid values:
        /// 
        /// *   Standard: basic type. When you set Type to Standard, enhanced SSDs (ESSDs) at performance level 0 (PL0 ESSDs) can be created in the dedicated block storage cluster.
        /// *   Premium: performance type. When you set Type to Premium, ESSDs at performance level 1 (PL1 ESSDs) can be created in the dedicated block storage cluster.
        /// 
        /// Default value: Premium.
        /// 
        /// For more information about ESSDs, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
