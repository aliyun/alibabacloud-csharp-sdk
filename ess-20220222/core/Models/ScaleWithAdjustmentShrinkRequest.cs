// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The metadata for the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ActivityMetadata")]
        [Validation(Required=false)]
        public string ActivityMetadata { get; set; }

        /// <summary>
        /// <para>The method used to adjust the number of instances in a scaling activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>QuantityChangeInCapacity</c>: Adds or removes a specified number of ECS instances.</para>
        /// </description></item>
        /// <item><description><para><c>PercentChangeInCapacity</c>: Adds or removes a specified percentage of ECS instances.</para>
        /// </description></item>
        /// <item><description><para><c>TotalCapacity</c>: Adjusts the number of ECS instances in the scaling group to a specified number.</para>
        /// </description></item>
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
        /// <para>The adjustment value for the scaling activity. A single adjustment cannot add or remove more than 1,000 ECS instances. The valid range depends on <c>AdjustmentType</c>:</para>
        /// <list type="bullet">
        /// <item><description><para><c>QuantityChangeInCapacity</c>: -1000 to 1000.</para>
        /// </description></item>
        /// <item><description><para><c>PercentChangeInCapacity</c>: -100 to 10000.</para>
        /// </description></item>
        /// <item><description><para><c>TotalCapacity</c>: 0 to 2000.</para>
        /// </description></item>
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
        /// <para>A client-generated token to ensure the idempotence of the request. This token must be a unique string of up to 64 ASCII characters.</para>
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
        /// <item><description><para><c>None</c>: Executes a standard scaling activity.</para>
        /// </description></item>
        /// <item><description><para><c>PlanOnly</c>: Only performs elastic planning and returns the results in <c>PlanResult</c> without triggering the scaling activity. The results include details such as instance types, availability zones, billing methods, and the number of new instances.</para>
        /// </description></item>
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
        /// <para>The lifecycle hook context.</para>
        /// </summary>
        [NameInMap("LifecycleHookContext")]
        [Validation(Required=false)]
        public string LifecycleHookContextShrink { get; set; }

        /// <summary>
        /// <para>The minimum number of instances to adjust in a scaling activity. This parameter takes effect only when <c>AdjustmentType</c> is set to <c>PercentChangeInCapacity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// <para>The parameters to override when scaling out an ECI scaling group.</para>
        /// </summary>
        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public string OverridesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current scaling activity supports concurrency.</para>
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
        /// <para>Specifies whether to execute the scaling activity synchronously. This parameter applies only to scaling groups that are configured with an expected number of instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Synchronous execution. The scaling activity is triggered immediately.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Asynchronous execution. The call updates the expected number of instances without immediately triggering the scaling activity. The activity occurs when the system detects a discrepancy between the new expected number and the current number of instances.</para>
        /// </description></item>
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
