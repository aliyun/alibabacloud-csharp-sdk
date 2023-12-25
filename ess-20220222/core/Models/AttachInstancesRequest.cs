// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// 保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。只支持ASCII字符，且不能超过64个字符。更多信息，请参见[如何保证幂等性](~~25965~~)。
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether the scaling group manages the lifecycles of instances that are manually added to the scaling group. Valid values:
        /// 
        /// *   true: The scaling group manages the lifecycles of instances that are manually added in a similar manner in which the scaling group manages the lifecycles of automatically created instances. After Auto Scaling removes instances from the scaling group, Auto Scaling releases the instances. After you call the DetachInstances operation to remove instances from the scaling group, Auto Scaling does not release the instances.
        /// *   false: The scaling group does not manage the lifecycles of instances that are manually added. After Auto Scaling removes instances from the scaling group, Auto Scaling does not release the instances.
        /// 
        /// > You cannot specify this parameter for subscription instances.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Entrusted")]
        [Validation(Required=false)]
        public bool? Entrusted { get; set; }

        /// <summary>
        /// The IDs of the ECS instances or elastic container instances that you want to add.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to trigger a lifecycle hook for a scale-out activity. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("LifecycleHook")]
        [Validation(Required=false)]
        public bool? LifecycleHook { get; set; }

        /// <summary>
        /// The weights of the ECS instances or elastic container instances as the backend servers of the associated Classic Load Balancer (CLB) instance.
        /// </summary>
        [NameInMap("LoadBalancerWeights")]
        [Validation(Required=false)]
        public List<int?> LoadBalancerWeights { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
