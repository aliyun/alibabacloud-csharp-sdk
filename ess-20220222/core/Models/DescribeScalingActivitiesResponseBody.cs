// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC107349-57B7-4405-B1BF-9BF5AF7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of scaling activity information.</para>
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
            /// <para>The total number of manually added instances in the scaling group after the scaling activity is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachedCapacity")]
            [Validation(Required=false)]
            public string AttachedCapacity { get; set; }

            /// <summary>
            /// <para>The total number of instances in the scaling group that are generated through automatic creation after you execute the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AutoCreatedCapacity")]
            [Validation(Required=false)]
            public string AutoCreatedCapacity { get; set; }

            /// <summary>
            /// <para>The cause that triggered the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A user requests to execute scaling rule \&quot;asr-bp12tcnol686y1ik****\&quot;, changing the Total Capacity from \&quot;1\&quot; to \&quot;2\&quot;.</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The number of instances created during the current scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public int? CreatedCapacity { get; set; }

            /// <summary>
            /// <para>The list of instances created during the current scaling activity.</para>
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
            /// <para>The number of instances released during the current scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DestroyedCapacity")]
            [Validation(Required=false)]
            public int? DestroyedCapacity { get; set; }

            /// <summary>
            /// <para>The list of instances released during the current scaling activity.</para>
            /// </summary>
            [NameInMap("DestroyedInstances")]
            [Validation(Required=false)]
            public List<string> DestroyedInstances { get; set; }

            /// <summary>
            /// <para>The details of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;new ECS instances &quot;i-j6c8ilerw, i-j6c8iler4mx&quot; are created.&quot;</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the scaling activity. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-10T09:54Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The error code returned when the scaling activity fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationDenied.NoStock</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the scaling activity fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified ECS resource is out of stock in this region. Please try again later.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The error messages returned when the scaling activity fails or is partially successful.</para>
            /// </summary>
            [NameInMap("ErrorMessages")]
            [Validation(Required=false)]
            public List<DescribeScalingActivitiesResponseBodyScalingActivitiesErrorMessages> ErrorMessages { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesErrorMessages : TeaModel {
                /// <summary>
                /// <para>The error code returned when the scaling activity fails or is partially successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OperationDenied.NoStock</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The exception description of the scaling activity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Fail to create instances into scaling group.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of failed instance ID.</para>
                /// </summary>
                [NameInMap("FailedInstanceIds")]
                [Validation(Required=false)]
                public List<string> FailedInstanceIds { get; set; }

                /// <summary>
                /// <para>The error messages returned when the scaling activity fails or is partially successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource is out of stock in the specified zone. Please try other types, or choose other regions and zones.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance refresh task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ir-asdf12adsxg*****</para>
            /// </summary>
            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            /// <summary>
            /// <para>The context information of the lifecycle hook.</para>
            /// </summary>
            [NameInMap("LifecycleHookContext")]
            [Validation(Required=false)]
            public DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext LifecycleHookContext { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext : TeaModel {
                /// <summary>
                /// <para>Specifies whether all lifecycle hooks are disabled for the scaling activity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Disabled.</description></item>
                /// <item><description>false: Not disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DisableLifecycleHook")]
                [Validation(Required=false)]
                public bool? DisableLifecycleHook { get; set; }

                /// <summary>
                /// <para>The list of IDs of the lifecycle hooks disabled for the scaling activity.</para>
                /// </summary>
                [NameInMap("IgnoredLifecycleHookIds")]
                [Validation(Required=false)]
                public List<string> IgnoredLifecycleHookIds { get; set; }

            }

            /// <summary>
            /// <para>The progress of the scaling activity.</para>
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
            /// <item><description><para>If the scaling activity is a scale-out activity, this parameter indicates the number of instances that are created or started from the stopped and reclaimed state during the scaling activity.</para>
            /// </description></item>
            /// <item><description><para>If the scaling activity is a scale-in activity, this parameter indicates the number of instances that are deleted or enter the stopped and reclaimed state during the scaling activity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScalingInstanceNumber")]
            [Validation(Required=false)]
            public int? ScalingInstanceNumber { get; set; }

            /// <summary>
            /// <para>The start time of the scaling activity. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-10T09:54Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The number of instances started from the economical mode during the current scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StartedCapacity")]
            [Validation(Required=false)]
            public int? StartedCapacity { get; set; }

            /// <summary>
            /// <para>The list of instances started from the economical mode during the current scaling activity.</para>
            /// </summary>
            [NameInMap("StartedInstances")]
            [Validation(Required=false)]
            public List<string> StartedInstances { get; set; }

            /// <summary>
            /// <para>The status of the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Successful: The scaling activity is successful. </description></item>
            /// <item><description>Warning: The scaling activity is partially successful. </description></item>
            /// <item><description>Failed: The scaling activity failed. </description></item>
            /// <item><description>InProgress: The scaling activity is in progress. </description></item>
            /// <item><description>Rejected: The request to execute the scaling activity is rejected.</description></item>
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
            /// <para>The number of instances that entered the economical mode during the current scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// <para>The list of instances that entered the economical mode during the current scaling activity.</para>
            /// </summary>
            [NameInMap("StoppedInstances")]
            [Validation(Required=false)]
            public List<string> StoppedInstances { get; set; }

            /// <summary>
            /// <para>The total number of instances in the scaling group after the scaling activity is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public string TotalCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the trigger source for the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Cms trigger source ID: displayed as the event-triggered task ID.</description></item>
            /// <item><description>Api trigger source ID: displayed as the Alibaba Cloud account ID or RAM user ID.</description></item>
            /// <item><description>Ess trigger source ID: displayed as empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2346366580*****</para>
            /// </summary>
            [NameInMap("TriggerSourceId")]
            [Validation(Required=false)]
            public string TriggerSourceId { get; set; }

            /// <summary>
            /// <para>The type of the trigger source for the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Cms: The scaling activity is triggered by an event-triggered task.</description></item>
            /// <item><description>Api: The scaling activity is triggered by a user through an API call.</description></item>
            /// <item><description>Ess: The scaling activity is triggered by a system task.</description></item>
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
        /// <para>The total number of scaling activity records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
