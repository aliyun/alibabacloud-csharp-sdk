// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachInstancesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to adjust the expected number of instances in the scaling group. Valid values:
        /// 
        /// *   true: After a specific number of instances are removed from the scaling group, the expected number of instances in the scaling group decreases.
        /// *   false: After a specific number of instances are removed from the scaling group, the expected number of instances in the scaling group remains unchanged.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("DecreaseDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DecreaseDesiredCapacity { get; set; }

        /// <summary>
        /// Specifies whether to detach the ECS instances or elastic container instances that are marked for removal from the associated load balancers, and whether to remove the private IP addresses of these instances from the IP address whitelists of the associated ApsaraDB RDS instances.
        /// 
        /// Both: detaches the ECS instances or elastic container instances that are marked for removal from the associated load balancers and removes the private IP addresses of these instances from the IP address whitelists of the associated ApsaraDB RDS instances.
        /// 
        /// >  This parameter is not supported if you want to remove Alibaba Cloud-hosted third-party instances from a scaling group.
        /// </summary>
        [NameInMap("DetachOption")]
        [Validation(Required=false)]
        public string DetachOption { get; set; }

        /// <summary>
        /// Specifies whether to ignore invalid instances when you remove a batch of instances from the scaling group. Valid values:
        /// 
        /// *   true: ignores invalid instances. If invalid instances exist and valid instances are removed from the scaling group, the corresponding scaling activity enters the Warning state. You can check the scaling activity details to view the invalid instances that are ignored.
        /// *   false: does not ignore invalid instances. If invalid instances exist in the batch of instances that you want to remove from the scaling group, an error is reported.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IgnoreInvalidInstance")]
        [Validation(Required=false)]
        public bool? IgnoreInvalidInstance { get; set; }

        /// <summary>
        /// The IDs of the ECS instances, elastic container instances, or Aliababa Cloud-managed third-party instances that you want to remove from a scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to trigger a lifecycle hook for scale-in purposes when ECS instances or elastic container instances are removed from the scaling group. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  This parameter is not supported if you want to remove Alibaba Cloud-hosted third-party instances from a scaling group.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("LifecycleHook")]
        [Validation(Required=false)]
        public bool? LifecycleHook { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
