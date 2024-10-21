// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC107349-57B7-4405-B1BF-9BF5AF7F2A46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scaling activities.</para>
        /// </summary>
        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public List<DescribeScalingActivitiesResponseBodyScalingActivities> ScalingActivities { get; set; }
        public class DescribeScalingActivitiesResponseBodyScalingActivities : TeaModel {
            /// <summary>
            /// <para>The metadata of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;goatscaler.io/managed\&quot;:\&quot;true\&quot;}</para>
            /// </summary>
            [NameInMap("ActivityMetadata")]
            [Validation(Required=false)]
            public string ActivityMetadata { get; set; }

            /// <summary>
            /// <para>The total number of instances that are manually added to the scaling group after the scaling activity is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachedCapacity")]
            [Validation(Required=false)]
            public string AttachedCapacity { get; set; }

            /// <summary>
            /// <para>The total number of instances that are created by Auto Scaling after the scaling activity was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AutoCreatedCapacity")]
            [Validation(Required=false)]
            public string AutoCreatedCapacity { get; set; }

            /// <summary>
            /// <para>The reason why the scaling activity was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A user requests to execute scaling rule \&quot;asr-bp12tcnol686y1ik****\&quot;, changing the Total Capacity from \&quot;1\&quot; to \&quot;2\&quot;.</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The number of instances that are created during the scale-out event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public int? CreatedCapacity { get; set; }

            /// <summary>
            /// <para>The instances that are created during the scale-out event.</para>
            /// </summary>
            [NameInMap("CreatedInstances")]
            [Validation(Required=false)]
            public List<string> CreatedInstances { get; set; }

            /// <summary>
            /// <para>The description of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Add \&quot;1\&quot; ECS instance</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of instances that are released during the scale-in event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DestroyedCapacity")]
            [Validation(Required=false)]
            public int? DestroyedCapacity { get; set; }

            /// <summary>
            /// <para>The instances that are released during the scale-in event.</para>
            /// </summary>
            [NameInMap("DestroyedInstances")]
            [Validation(Required=false)]
            public List<string> DestroyedInstances { get; set; }

            /// <summary>
            /// <para>Details of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;new ECS instances &quot;i-j6c8ilerw, i-j6c8iler4mx&quot; are created.&quot;</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The time when the scaling activity was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-10T09:54Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The error code that is returned when the scaling activity failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationDenied.NoStock</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message that is returned when the scaling activity failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified ECS resource is out of stock in this region. Please try again later.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ir-asdf12adsxg*****</para>
            /// </summary>
            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            /// <summary>
            /// <para>The context of the lifecycle hook.</para>
            /// </summary>
            [NameInMap("LifecycleHookContext")]
            [Validation(Required=false)]
            public DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext LifecycleHookContext { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext : TeaModel {
                /// <summary>
                /// <para>Indicates whether all lifecycle hooks are disabled when the scaling activity is triggered. Valid values:</para>
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
                /// <para>The IDs of the lifecycle hooks that are disabled.</para>
                /// </summary>
                [NameInMap("IgnoredLifecycleHookIds")]
                [Validation(Required=false)]
                public List<string> IgnoredLifecycleHookIds { get; set; }

            }

            /// <summary>
            /// <para>The execution progress of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The ID of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asa-bp161xudmuxdzofe****</para>
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp18p2yfxow2dloq****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If you query a scale-out activity, the value of this parameter indicates the number of instances that are created or the number of instances that are started from Economical Mode.</description></item>
            /// <item><description>If you query a scale-in activity, the value of this parameter indicates the number of instances that are deleted or the number of instances that are stopped in Economical Mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScalingInstanceNumber")]
            [Validation(Required=false)]
            public int? ScalingInstanceNumber { get; set; }

            /// <summary>
            /// <para>The time when the scaling activity was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-10T09:54Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The number of instances that are started from the Economical Mode during the scale-out event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StartedCapacity")]
            [Validation(Required=false)]
            public int? StartedCapacity { get; set; }

            /// <summary>
            /// <para>The instances that are started from the Economical Mode during the scale-out event.</para>
            /// </summary>
            [NameInMap("StartedInstances")]
            [Validation(Required=false)]
            public List<string> StartedInstances { get; set; }

            /// <summary>
            /// <para>The status of the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Successful: The scaling activity is successful.</description></item>
            /// <item><description>Warning: The scaling activity is partially successful.</description></item>
            /// <item><description>Failed: The scaling activity failed.</description></item>
            /// <item><description>InProgress: The scaling activity is in progress.</description></item>
            /// <item><description>Rejected: The request to trigger the scaling activity is rejected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The status message of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;1\&quot; ECS instances are added</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The number of instances that are stopped in the Economical Mode during the scale-in event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// <para>The instances that are stopped in the Economical Mode during the scale-in event.</para>
            /// </summary>
            [NameInMap("StoppedInstances")]
            [Validation(Required=false)]
            public List<string> StoppedInstances { get; set; }

            /// <summary>
            /// <para>The total number of instances in the scaling group after the scaling activity was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public string TotalCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the trigger source of the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the scaling activity is triggered by an event-triggered task, the ID of the trigger source is the ID of the event-triggered task.</description></item>
            /// <item><description>If the scaling activity is triggered by calling an API operation, the ID of the trigger source is the ID of the Alibaba Cloud account or Resource Access Management (RAM) user that you use to call the API operation.</description></item>
            /// <item><description>If the scaling activity is triggered by Auto Scaling, the ID of the trigger source is null.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2346366580*****</para>
            /// </summary>
            [NameInMap("TriggerSourceId")]
            [Validation(Required=false)]
            public string TriggerSourceId { get; set; }

            /// <summary>
            /// <para>The type of the trigger source of the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Cms: The scaling activity is triggered by an event-triggered task.</description></item>
            /// <item><description>APIs: The scaling activity is triggered by calling an API operation.</description></item>
            /// <item><description>Ess: The scaling activity is triggered by Auto Scaling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Api</para>
            /// </summary>
            [NameInMap("TriggerSourceType")]
            [Validation(Required=false)]
            public string TriggerSourceType { get; set; }

        }

        /// <summary>
        /// <para>The total number of scaling activities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
