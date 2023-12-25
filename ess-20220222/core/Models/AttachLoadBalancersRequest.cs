// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachLoadBalancersRequest : TeaModel {
        /// <summary>
        /// Specifies whether to attach the CLB instance to the scaling group in an asynchronous manner. If you attach the CLB instance from the scaling group in an asynchronous manner, the call is successful only after all operations are successful. If a specific operation fails, the call fails. We recommend that you set this parameter to true. Valid values:
        /// 
        /// *   true: attaches the CLB instance to the scaling group in an asynchronous manner. In this case, the ID of the scaling activity is returned.
        /// *   false: does not attach the CLB instance to the scaling group in an asynchronous manner.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to add all instances in the scaling group to the vServer groups of the CLB instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        /// <summary>
        /// 负载均衡配置列表。
        /// </summary>
        [NameInMap("LoadBalancerConfigs")]
        [Validation(Required=false)]
        public List<AttachLoadBalancersRequestLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
        public class AttachLoadBalancersRequestLoadBalancerConfigs : TeaModel {
            /// <summary>
            /// 负载均衡CLB（原SLB）实例的ID。
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// 弹性伸缩将ECS实例添加到SLB服务器组后，ECS实例作为后端服务器的权重。权重越高，ECS实例将被分配到越多的访问请求。如果权重为0，则ECS实例不会收到访问请求。取值范围：0~100。
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The IDs of the CLB instances.
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<string> LoadBalancers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
