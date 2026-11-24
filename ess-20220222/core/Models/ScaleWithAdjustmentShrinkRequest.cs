// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The metadata of the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ActivityMetadata")]
        [Validation(Required=false)]
        public string ActivityMetadata { get; set; }

        /// <summary>
        /// <para>The adjustment method for the scaling activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: Increases or decreases a specified number of ECS instances.</description></item>
        /// <item><description>PercentChangeInCapacity: Increases or decreases a specified percentage of ECS instances.</description></item>
        /// <item><description>TotalCapacity: Adjusts the number of ECS instances in the current scaling group to a specified number.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuantityChangeInCapacity</para>
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// <para>The adjustment value for the scaling activity. In all cases, the number of ECS instances adjusted in a single operation cannot exceed 1,000. Otherwise, the adjustment fails. Valid values vary based on the adjustment method:</para>
        /// <list type="bullet">
        /// <item><description>QuantityChangeInCapacity: -1,000 to 1,000.</description></item>
        /// <item><description>PercentChangeInCapacity: -100 to 10,000.</description></item>
        /// <item><description>TotalCapacity: 0 to 2,000.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: Not specified. Normal scaling is performed.</description></item>
        /// <item><description>PlanOnly: Does not trigger scaling. Only elastic planning is executed. The planning results, including instance types, zone IDs, billing methods, and the number of instances to be created, are returned in PlanResult.</description></item>
        /// </list>
        /// <para>Default value: None.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlanOnly</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The context information of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public string LifecycleHookContextShrink { get; set; }

        /// <summary>
        /// <para>The minimum number of instances to be adjusted in the scaling activity. This parameter takes effect only when <c>AdjustmentType</c> is set to <c>PercentChangeInCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// <para>The override parameters specified for scaling out an Elastic Container Instance (ECI) scaling group.</para>
        /// </summary>
        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public string OverridesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current scaling task supports concurrent execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ParallelTask")]
        [Validation(Required=false)]
        public bool? ParallelTask { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-j6c1o397427hyjdc****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously execute the scaling activity. This parameter is valid only for scaling groups that have the expected number of instances configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Synchronous process. When the scaling rule is executed, the scale-out or scale-in activity of the scaling group is directly triggered.</description></item>
        /// <item><description>false: Asynchronous process. When the expected number of instances in the scaling group is modified, the actual scale-out or scale-in activity of the scaling group is not immediately triggered. The system automatically detects the difference between the expected number of instances and the current number of instances in the scaling group, and then triggers the scale-out or scale-in activity.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the expected number of instances, see <a href="https://help.aliyun.com/document_detail/146231.html">Expected number of instances</a>.</para>
        /// </remarks>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncActivity")]
        [Validation(Required=false)]
        public bool? SyncActivity { get; set; }

    }

}
