// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request.</para>
        /// <para>You can generate a parameter value from your client to ensure that the value is unique among different requests. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to entrust the lifecycle of an existing instance to the scaling group when the instance is manually added to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Entrusted. The lifecycle of the instance is managed by Auto Scaling, which is the same as that of instances automatically created by the scaling group. The instance is automatically released when it is removed from the scaling group (excluding instances removed when you invoke the DetachInstances operation).</description></item>
        /// <item><description>false: Not entrusted. The instance is not released when it is removed from the scaling group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not supported for subscription instances, managed instances, and instances in the Economical Mode in the scaling group.</para>
        /// </remarks>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Entrusted")]
        [Validation(Required=false)]
        public bool? Entrusted { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore invalid instances when a batch of instances is added to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Invalid instances are ignored when a batch of instances is added to the scaling group. If invalid instances exist and valid instances are successfully added, the execution status of the scaling activity is displayed as Warning. You can view the invalid instances in the scaling activity details.</para>
        /// </description></item>
        /// <item><description><para>false: Invalid instances are not ignored when a batch of instances is added to the scaling group. If invalid instances exist in the batch, an error is reported.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreInvalidInstance")]
        [Validation(Required=false)]
        public bool? IgnoreInvalidInstance { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances, ECI instances, managed instances, or instances in the Economical Mode in the scaling group to be added.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger the scale-out lifecycle hook when instances are added to the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Triggered.</description></item>
        /// <item><description>false: Not triggered.<remarks>
        /// <para>This parameter is not supported for managed instances and instances in the Economical Mode in the scaling group.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LifecycleHook")]
        [Validation(Required=false)]
        public bool? LifecycleHook { get; set; }

        /// <summary>
        /// <para>The weight of the ECS instance or ECI instance as a backend server of the load balancing instance.</para>
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
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
