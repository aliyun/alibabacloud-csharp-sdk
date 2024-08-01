// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPrefixListRequest : TeaModel {
        /// <summary>
        /// The entries to be added to the prefix list.
        /// </summary>
        [NameInMap("AddEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestAddEntry> AddEntry { get; set; }
        public class ModifyPrefixListRequestAddEntry : TeaModel {
            /// <summary>
            /// The CIDR block in entry N to be added to the prefix list. Valid values of N: 0 to 200.
            /// 
            /// Take note of the following items when you add the entries:
            /// 
            /// *   The total number of entries in the prefix list cannot exceed the maximum number of entries you specified for the prefix list. You can call the [DescribePrefixListAttributes](https://help.aliyun.com/document_detail/205872.html) operation to query the maximum number of entries that the prefix list can contain.
            /// *   You cannot specify duplicate CIDR blocks.
            /// *   The CIDR blocks cannot be the same as the `RemoveEntry.N.Cidr` values.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// The description in entry N. The description must be 2 to 32 characters in length and cannot start with `http://` or `https://`. Valid values of N: 0 to 200.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// The description of the prefix list. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the prefix list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// The name of the prefix list. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://`, `https://`, `com.aliyun`, or `com.alibabacloud`. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// The region ID of the prefix list. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The entries to be deleted from the prefix list.
        /// </summary>
        [NameInMap("RemoveEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestRemoveEntry> RemoveEntry { get; set; }
        public class ModifyPrefixListRequestRemoveEntry : TeaModel {
            /// <summary>
            /// The CIDR block in entry N to be deleted from the prefix list. Valid values of N: 0 to 200.
            /// 
            /// Take note of the following items when you delete the entries:
            /// 
            /// *   You cannot specify duplicate CIDR blocks.
            /// *   The CIDR blocks cannot be the same as the `AddEntry.N.Cidr` values.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
