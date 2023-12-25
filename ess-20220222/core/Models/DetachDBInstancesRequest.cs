// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachDBInstancesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IDs of the ApsaraDB RDS instances. You can specify up to five ApsaraDB RDS instances.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<string> DBInstances { get; set; }

        /// <summary>
        /// Specifies whether to remove the private IP addresses of instances in the scaling group from the whitelist that manages access to the ApsaraDB RDS instance with which the scaling group is associated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceDetach")]
        [Validation(Required=false)]
        public bool? ForceDetach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
