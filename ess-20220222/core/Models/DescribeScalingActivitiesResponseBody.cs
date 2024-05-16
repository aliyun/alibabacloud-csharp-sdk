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
            [NameInMap("ActivityMetadata")]
            [Validation(Required=false)]
            public string ActivityMetadata { get; set; }

            /// <summary>
            /// The total number of instances that are manually added to the scaling group after the scaling activity is complete.
            /// </summary>
            [NameInMap("AttachedCapacity")]
            [Validation(Required=false)]
            public string AttachedCapacity { get; set; }

            /// <summary>
            /// The total number of instances that are created by Auto Scaling after the scaling activity is complete.
            /// </summary>
            [NameInMap("AutoCreatedCapacity")]
            [Validation(Required=false)]
            public string AutoCreatedCapacity { get; set; }

            /// <summary>
            /// The reason why the scaling activity is triggered.
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// The number of instances that are created during the scale-out.
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public int? CreatedCapacity { get; set; }

            /// <summary>
            /// The instances that are created during the scale-out.
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
            /// The number of instances that are released during the scale-in.
            /// </summary>
            [NameInMap("DestroyedCapacity")]
            [Validation(Required=false)]
            public int? DestroyedCapacity { get; set; }

            /// <summary>
            /// The instances that are released during the scale-in.
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
            /// The time when the scaling activity is complete.
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

            [NameInMap("LifecycleHookContext")]
            [Validation(Required=false)]
            public DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext LifecycleHookContext { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesLifecycleHookContext : TeaModel {
                [NameInMap("DisableLifecycleHook")]
                [Validation(Required=false)]
                public bool? DisableLifecycleHook { get; set; }

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
            /// If you query a scale-out, the value of this parameter indicates the number of instances that are created or the number of instances that are started from the Economical Mode during the scale-out.
            /// 
            /// If you query a scale-in, the value of this parameter indicates the number of instances that are deleted or the number of instances that are stopped in the Economical Mode during the scale-in.
            /// </summary>
            [NameInMap("ScalingInstanceNumber")]
            [Validation(Required=false)]
            public int? ScalingInstanceNumber { get; set; }

            /// <summary>
            /// The time when the scaling activity is started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The number of instances that are started from the Economical Mode during the scale-out.
            /// </summary>
            [NameInMap("StartedCapacity")]
            [Validation(Required=false)]
            public int? StartedCapacity { get; set; }

            /// <summary>
            /// The instances that are started from the Economical Mode during the scale-out.
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
            /// The number of instances that are stopped in the Economical Mode during the scale-in.
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// The instances that are stopped in the Economical Mode during the scale-in.
            /// </summary>
            [NameInMap("StoppedInstances")]
            [Validation(Required=false)]
            public List<string> StoppedInstances { get; set; }

            /// <summary>
            /// The total number of instances in the scaling group after the scaling activity is complete.
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public string TotalCapacity { get; set; }

            [NameInMap("TriggerSourceId")]
            [Validation(Required=false)]
            public string TriggerSourceId { get; set; }

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
