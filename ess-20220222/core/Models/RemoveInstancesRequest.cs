// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the expected number of instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: After the ECS instances are removed from the scaling group, the expected number of instances is decreased by the number of removed instances.</description></item>
        /// <item><description>false: After the ECS instances are removed from the scaling group, the expected number of instances remains unchanged.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DecreaseDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DecreaseDesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore invalid instances when removing a batch of instances from the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Invalid instances are ignored when removing a batch of instances from the scaling group. If invalid instances exist and valid instances are successfully removed, the execution status of the scaling activity is displayed as Warning. You can view the invalid instances in the scaling activity details.</description></item>
        /// <item><description>false: Invalid instances are not ignored when removing a batch of instances from the scaling group. If invalid instances exist in the batch, an error is reported.</description></item>
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
        /// <para>The IDs of the ECS instances to be removed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The context information of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public RemoveInstancesRequestLifecycleHookContext LifecycleHookContext { get; set; }
        public class RemoveInstancesRequestLifecycleHookContext : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable all lifecycle hooks for the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Disables all lifecycle hooks.</description></item>
            /// <item><description>false: Does not disable lifecycle hooks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableLifecycleHook")]
            [Validation(Required=false)]
            public bool? DisableLifecycleHook { get; set; }

            /// <summary>
            /// <para>The IDs of the lifecycle hooks disabled for the scaling activity.</para>
            /// </summary>
            [NameInMap("IgnoredLifecycleHookIds")]
            [Validation(Required=false)]
            public List<string> IgnoredLifecycleHookIds { get; set; }

            /// <summary>
            /// <para>The default execution result of the lifecycle hook in this scaling activity. After this parameter is set, it overwrites the original default execution result of the hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("LifecycleHookResult")]
            [Validation(Required=false)]
            public string LifecycleHookResult { get; set; }

        }

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

        /// <summary>
        /// <para>Specifies the action for the removed ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>recycle: The ECS instances are stopped in economical mode.</para>
        /// <remarks>
        /// <para>This value takes effect only when <c>ScalingPolicy</c> is set to <c>recycle</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>release: The ECS instances are released.</para>
        /// </description></item>
        /// </list>
        /// <para>The ScalingPolicy parameter of CreateScalingGroup specifies the reclaim mode of the scaling group, but the specific action when an instance is removed is determined by the RemovePolicy parameter of RemoveInstances. Examples:</para>
        /// <list type="bullet">
        /// <item><description>If ScalingPolicy is set to recycle and RemovePolicy is set to recycle, the ECS instances are stopped in economical mode.</description></item>
        /// <item><description>If ScalingPolicy is set to recycle and RemovePolicy is set to release, the ECS instances are released.</description></item>
        /// <item><description>If ScalingPolicy is set to release and RemovePolicy is set to recycle, the ECS instances are released.</description></item>
        /// <item><description>If ScalingPolicy is set to release and RemovePolicy is set to release, the ECS instances are released.</description></item>
        /// </list>
        /// <para>Default value: release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release</para>
        /// </summary>
        [NameInMap("RemovePolicy")]
        [Validation(Required=false)]
        public string RemovePolicy { get; set; }

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

        /// <summary>
        /// <para>The timeout period for waiting for the ECS instances to be successfully stopped during the scale-in process. Unit: seconds.
        /// Valid values: 30 to 240.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, this parameter inherits the value from the scaling group. You can also reset it when calling RemoveInstances.</description></item>
        /// <item><description>This parameter takes effect only in the scale-in process when RemovePolicy is set to release.  </description></item>
        /// <item><description>If this parameter is set, the system waits for a maximum of the StopInstanceTimeout period for the instances to be successfully stopped. After the timeout period, the scale-in process continues regardless of whether the instances are successfully stopped.  </description></item>
        /// <item><description>If this parameter is not set, the system waits for a long time for the instances to be successfully stopped. The scale-in process continues only after the instances are successfully stopped. If the instances fail to be stopped, the scale-in process is rolled back and the scale-in fails.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StopInstanceTimeout")]
        [Validation(Required=false)]
        public int? StopInstanceTimeout { get; set; }

    }

}
