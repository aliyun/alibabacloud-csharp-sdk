// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteScalingGroupRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcefully delete the VPC. Valid values:
        /// 
        /// - **true**: yes
        /// - **false** (default): no
        /// 
        /// You can forcefully delete a VPC in the following scenarios:
        /// 
        /// - Only an IPv4 gateway and routes that point to the IPv4 gateway exist in the VPC.
        /// - Only an IPv6 gateway and routes that point to the IPv6 gateway exist in the VPC.
        /// </summary>
        [NameInMap("ForceDelete")]
        [Validation(Required=false)]
        public bool? ForceDelete { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
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
