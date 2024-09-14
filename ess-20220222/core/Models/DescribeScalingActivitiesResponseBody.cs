// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivitiesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the scaling activities.
        /// </summary>
        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public List<DescribeScalingActivitiesResponseBodyScalingActivities> ScalingActivities { get; set; }
        public class DescribeScalingActivitiesResponseBodyScalingActivities : TeaModel {
            /// <summary>
            /// The metadata of the scaling activity.
            /// </summary>
            [NameInMap("ActivityMetadata")]
            [Validation(Required=false)]
            public string ActivityMetadata { get; set; }

            /// <summary>
            /// The total number of instances that are manually added to the scaling group after the scaling activity was complete.
            /// </summary>
            [NameInMap("AttachedCapacity")]
            [Validation(Required=false)]
            public string AttachedCapacity { get; set; }

            /// <summary>
            /// The total number of instances that are created by Auto Scaling after the scaling activity was complete.
            /// </summary>
            [NameInMap("AutoCreatedCapacity")]
            [Validation(Required=false)]
            public string AutoCreatedCapacity { get; set; }

            /// <summary>
            /// The reason why the scaling activity was triggered.
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// The number of instances that are created during the scale-out event.
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public int? CreatedCapacity { get; set; }

            /// <summary>
            /// The instances that are created during the scale-out event.
            /// </summary>
            [NameInMap("CreatedInstances")]
            [Validation(Required=false)]
            public List<string> CreatedInstances { get; set; }

            /// <summary>
            /// The description of the scaling activity.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The number of instances that are released during the scale-in event.
            /// </summary>
            [NameInMap("DestroyedCapacity")]
            [Validation(Required=false)]
            public int? DestroyedCapacity { get; set; }

            /// <summary>
            /// The instances that are released during the scale-in event.
            /// </summary>
            [NameInMap("DestroyedInstances")]
            [Validation(Required=false)]
            public List<string> DestroyedInstances { get; set; }

            /// <summary>
            /// Details of the scaling activity.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The time when the scaling activity was complete.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The error code that is returned when the scaling activity failed.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message that is returned when the scaling activity failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            /// <summary>
            /// The context of the lifecycle hook.
            /// </summary>
            [NameInMap("LifecycleHookContext")]
            [Validation(Required=false)]
            public DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext LifecycleHookContext { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext : TeaModel {
                /// <summary>
                /// Indicates whether all lifecycle hooks are disabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("DisableLifecycleHook")]
                [Validation(Required=false)]
                public bool? DisableLifecycleHook { get; set; }

                /// <summary>
                /// The IDs of the lifecycle hooks that are disabled.
                /// </summary>
                [NameInMap("IgnoredLifecycleHookIds")]
                [Validation(Required=false)]
                public List<string> IgnoredLifecycleHookIds { get; set; }

            }

            /// <summary>
            /// The execution progress of the scaling activity.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The ID of the scaling activity.
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// If you query a scale-out activity, the value of this parameter indicates the number of instances that are created or the number of instances that are started from the Economical Mode during the scale-out event.
            /// 
            /// If you query a scale-in activity, the value of this parameter indicates the number of instances that are deleted or the number of instances that are stopped in the Economical Mode during the scale-in event.
            /// </summary>
            [NameInMap("ScalingInstanceNumber")]
            [Validation(Required=false)]
            public int? ScalingInstanceNumber { get; set; }

            /// <summary>
            /// The time when the scaling activity was started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The number of instances that are started from the Economical Mode during the scale-out event.
            /// </summary>
            [NameInMap("StartedCapacity")]
            [Validation(Required=false)]
            public int? StartedCapacity { get; set; }

            /// <summary>
            /// The instances that are started from the Economical Mode during the scale-out event.
            /// </summary>
            [NameInMap("StartedInstances")]
            [Validation(Required=false)]
            public List<string> StartedInstances { get; set; }

            /// <summary>
            /// The status of the scaling activity. Valid values:
            /// 
            /// *   Successful: The scaling activity is successful.
            /// *   Warning: The scaling activity is partially successful.
            /// *   Failed: The scaling activity failed.
            /// *   InProgress: The scaling activity is in progress.
            /// *   Rejected: The request to trigger the scaling activity is rejected.
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// The status message of the scaling activity.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The number of instances that are stopped in the Economical Mode during the scale-in event.
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// The instances that are stopped in the Economical Mode during the scale-in event.
            /// </summary>
            [NameInMap("StoppedInstances")]
            [Validation(Required=false)]
            public List<string> StoppedInstances { get; set; }

            /// <summary>
            /// The total number of instances in the scaling group after the scaling activity was complete.
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public string TotalCapacity { get; set; }

            /// <summary>
            /// The ID of the trigger source of the scaling activity.
            /// 
            /// *   If TriggerSourceType is set to Cms, the ID of the trigger source is the ID of an event-triggered task.
            /// *   If TriggerSourceType is set to Api, the ID of the trigger source is the ID of an Alibaba Cloud account or a RAM user.
            /// *   If TriggerSourceType is set to Api, the ID of the trigger source is null.
            /// </summary>
            [NameInMap("TriggerSourceId")]
            [Validation(Required=false)]
            public string TriggerSourceId { get; set; }

            /// <summary>
            /// The type of the trigger source of the scaling activity.
            /// 
            /// *   Cms: triggered by an event-triggered task
            /// *   APIs: triggered by API calling
            /// *   Ess: triggered by a system task
            /// </summary>
            [NameInMap("TriggerSourceType")]
            [Validation(Required=false)]
            public string TriggerSourceType { get; set; }

        }

        /// <summary>
        /// The total number of scaling activities.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
