// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttachmentAttributesRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The ID of the private pool. Set the value to the ID of the elasticity assurance or capacity reservation that generates the private pool.
            /// 
            /// *   This parameter is required when `PrivatePoolOptions.MatchCriteria` is set to `Target`.
            /// *   This parameter must be empty when `PrivatePoolOptions.MatchCriteria` is set to `Open` or `None`.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The match mode of the private pool. Valid values:
            /// 
            /// *   Open: open private pool. The system matches the instance with open private pools.
            /// *   Target: specified private pool. You must use `PrivatePoolOptions.Id` to specify the ID of a private pool.
            /// *   None: no private pool. The instance starts normally without using private pools.
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        /// <summary>
        /// The ID of the instance for which you want to modify the attributes of the private pool.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the private pool. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
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
