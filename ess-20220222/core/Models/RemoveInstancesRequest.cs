// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to adjust the expected number of ECS instances in the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: After ECS instances are removed from the scaling group, the expected number of ECS instances in the scaling group decreases.</description></item>
        /// <item><description>false: After ECS instances are removed from the scaling group, the expected number of ECS instances in the scaling group remains unchanged.</description></item>
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
        /// <para>Specifies whether to ignore invalid instances when you remove a batch of instances from the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: ignores invalid instances. If invalid instances exist and valid instances are deleted, the corresponding scaling activity enters the Warning state. You can check the scaling activity details to view the invalid instances that are ignored.</description></item>
        /// <item><description>false: does not ignore invalid instances. If invalid instances exist in the batch of instances that you want to remove from the scaling group, an error is reported.</description></item>
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
        /// <para>The IDs of the ECS instances that you want to remove from the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The context of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public RemoveInstancesRequestLifecycleHookContext LifecycleHookContext { get; set; }
        public class RemoveInstancesRequestLifecycleHookContext : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable the lifecycle hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisableLifecycleHook")]
            [Validation(Required=false)]
            public bool? DisableLifecycleHook { get; set; }

            /// <summary>
            /// <para>The IDs of the lifecycle hooks that you want to disable.</para>
            /// </summary>
            [NameInMap("IgnoredLifecycleHookIds")]
            [Validation(Required=false)]
            public List<string> IgnoredLifecycleHookIds { get; set; }

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
        /// <para>The action subsequent to the removal of the Elastic Compute Service (ECS) instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>recycle: The ECS instances enter the Economical Mode.</para>
        /// <para>**</para>
        /// <para><b>Note</b> This setting is applicable only if you set <c>ScalingPolicy</c> to <c>recycle</c>.</para>
        /// </description></item>
        /// <item><description><para>release: The ECS instances are released.</para>
        /// </description></item>
        /// </list>
        /// <para>ScalingPolicy of the CreateScalingGroup operation specifies the reclaim mode of the scaling group while RemovePolicy of the RemoveInstances operation specifies the subsequent action when an ECS instance is removed from the scaling group. Examples:</para>
        /// <list type="bullet">
        /// <item><description>If you set ScalingPolicy and RemovePolicy to recycle, the ECS instances enter the Economical Mode when they are removed.</description></item>
        /// <item><description>If you set ScalingPolicy to recycle and RemovePolicy to release, the ECS instances are released when they are removed.</description></item>
        /// <item><description>If you set ScalingPolicy to release and RemovePolicy to recycle, the ECS instances are released when they are removed.</description></item>
        /// <item><description>If you set ScalingPolicy and RemovePolicy to release, the ECS instances are released when they are removed.</description></item>
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
        /// <para>The period of time required by the ECS instance to enter the Stopped state. Unit: seconds. Valid values: 30 to 240.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>By default, this parameter inherits the value of StopInstanceTimeout specified in the CreateScalingGroup or ModifyScalingGroup operation. You can also specify a different value for this parameter in the RemoveInstances operation.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only if you set RemovePolicy to release.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the system waits for the ECS instance to enter the Stopped state only for up to the specified period of time before continuing with the scale-in operation, regardless of the status of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the system continues with the scale-in operation until the ECS instance enters the Stopped state. If the ECS instance is not successfully stopped, the scale-in process is rolled back and considered failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StopInstanceTimeout")]
        [Validation(Required=false)]
        public int? StopInstanceTimeout { get; set; }

    }

}
