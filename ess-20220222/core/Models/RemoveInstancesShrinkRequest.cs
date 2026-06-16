// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This token must be unique for each request, contain only ASCII characters, and not exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to decrease the desired capacity of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Decreases the desired capacity of the scaling group by the number of removed instances.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The desired capacity of the scaling group remains unchanged.</para>
        /// </description></item>
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
        /// <para>Specifies whether to ignore invalid instances when you remove multiple instances from a scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Invalid instances are ignored. If valid instances are removed while invalid ones are present, the scaling activity status is set to Warning. The invalid instances are listed in the scaling activity details.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request is rejected and an error is returned if it contains any invalid instances.</para>
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
        /// <para>The IDs of the ECS instances to remove.</para>
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
        public string LifecycleHookContextShrink { get; set; }

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
        /// <para>Specifies the action to take on removed ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>recycle: The ECS instances enter the economical mode.</para>
        /// <remarks>
        /// <para>This value takes effect only when the <c>ScalingPolicy</c> parameter of the scaling group is set to <c>recycle</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>release: The ECS instances are released.</para>
        /// </description></item>
        /// </list>
        /// <para>The <c>ScalingPolicy</c> parameter of the <c>CreateScalingGroup</c> operation specifies the reclamation mode of a scaling group. However, the <c>RemovePolicy</c> parameter of the <c>RemoveInstances</c> operation determines the action taken when an instance is removed. For example:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>ScalingPolicy</c> is <c>recycle</c> and <c>RemovePolicy</c> is <c>recycle</c>, the ECS instances enter the economical mode.</para>
        /// </description></item>
        /// <item><description><para>If <c>ScalingPolicy</c> is <c>recycle</c> and <c>RemovePolicy</c> is <c>release</c>, the ECS instances are released.</para>
        /// </description></item>
        /// <item><description><para>If <c>ScalingPolicy</c> is <c>release</c> and <c>RemovePolicy</c> is <c>recycle</c>, the ECS instances are released.</para>
        /// </description></item>
        /// <item><description><para>If <c>ScalingPolicy</c> is <c>release</c> and <c>RemovePolicy</c> is <c>release</c>, the ECS instances are released.</para>
        /// </description></item>
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
        /// <para>The timeout period, in seconds, for an ECS instance to stop during a scale-in. Valid values: 30 to 240.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>By default, this parameter inherits its value from the scaling group, but you can override it when calling the <c>RemoveInstances</c> operation.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only during scale-in events where <c>RemovePolicy</c> is set to <c>release</c>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set, the system waits for the specified duration for the instance to stop. The scale-in process continues after the timeout expires, regardless of the instance\&quot;s state.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not set, the system waits until the instance stops before continuing the scale-in process. If the instance fails to stop, the scale-in operation is rolled back and fails.</para>
        /// </description></item>
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
