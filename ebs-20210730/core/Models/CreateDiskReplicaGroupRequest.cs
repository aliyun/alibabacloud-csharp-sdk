// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiskReplicaGroupRequest : TeaModel {
        /// <summary>
        /// The bandwidth value. Unit: Mbit/s.
        /// 
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the replication pair-consistent group. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The region ID of the secondary site.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// The zone ID of the secondary site.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// The name of the replication pair-consistent group. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The RPO of the replication pair-consistent group. Unit: seconds. Valid value: 900.
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// The ID of the region in which to create the replication pair-consistent group. The primary site is deployed in the specified region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the replication pair-consistent group belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The zone ID of the primary site.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceZoneId")]
        [Validation(Required=false)]
        public string SourceZoneId { get; set; }

        /// <summary>
        /// The tags. Up to 20 tags are supported.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskReplicaGroupRequestTag> Tag { get; set; }
        public class CreateDiskReplicaGroupRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the replication pair-consistent group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the replication pair-consistent group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
