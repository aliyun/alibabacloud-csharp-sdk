// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachInstancesRequest : TeaModel {
        /// <summary>
        /// 保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。只支持ASCII字符，且不能超过64个字符。更多信息，请参见[如何保证幂等性](https://help.aliyun.com/document_detail/25965.html)。
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
        /// Specifies whether to remove the instances from the default server group and vServer groups of the Classic Load Balancer (CLB) instance that is associated with the scaling group, and whether to remove the IP addresses of the instances from the whitelist that manages access to the ApsaraDB RDS instance that is associated with the scaling group.
        /// 
        /// If you set this parameter to both, the instances are removed from the default sever group and vServer groups of the associated CLB instance, and the IP addresses of the instances are removed from the whitelist that manages access to the associated ApsaraDB RDS instance.
        /// </summary>
        [NameInMap("DetachOption")]
        [Validation(Required=false)]
        public string DetachOption { get; set; }

        /// <summary>
        /// The IDs of the ECS instances or elastic container instances that you want to remove from the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to trigger a lifecycle hook for a scale-in activity. Valid values:
        /// 
        /// *   true
        /// *   false
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
