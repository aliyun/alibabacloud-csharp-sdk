// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageCapacityUnitsRequest : TeaModel {
        /// <summary>
        /// The allocation type. Valid values:
        /// 
        /// *   Normal: queries SCUs that belong to the current Alibaba Cloud account.
        /// *   Shared: queries SCUs shared between the Alibaba Cloud account and RAM users.
        /// 
        /// Default value: Normal.
        /// </summary>
        [NameInMap("AllocationType")]
        [Validation(Required=false)]
        public string AllocationType { get; set; }

        /// <summary>
        /// The capacity of the SCU. Unit: GiB. Valid values: 20, 40, 100, 200, 500, 1024, 2048, 5120, 10240, 20480, and 51200.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The name of the SCU. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the SCU. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The state of SCUs. You can specify 1 to 4 types of state. Valid values:
        /// 
        /// *   Creating: The SCUs are being created.
        /// *   Active: The SCUs are in effect.
        /// *   Expired: The SCUs have expired.
        /// *   Pending: The SCUs have not taken effect.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// One or multiple SCU IDs. You can specify 1 to 100 SCU IDs.
        /// </summary>
        [NameInMap("StorageCapacityUnitId")]
        [Validation(Required=false)]
        public List<string> StorageCapacityUnitId { get; set; }

        /// <summary>
        /// The tags of the SCUs.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeStorageCapacityUnitsRequestTag> Tag { get; set; }
        public class DescribeStorageCapacityUnitsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the SCU. N is the identifier for the tag, which you can use to set and query the tag. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the SCU. N is the identifier for the tag, which you can use to set and query the tag. The value of N must coincide with `Tag.N.Key`. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
