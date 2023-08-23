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
        /// Details of the scaling activities.
        /// </summary>
        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public List<DescribeScalingActivitiesResponseBodyScalingActivities> ScalingActivities { get; set; }
        public class DescribeScalingActivitiesResponseBodyScalingActivities : TeaModel {
            /// <summary>
            /// The total number of instances that were manually added to the scaling group after the scaling activity was complete.
            /// </summary>
            [NameInMap("AttachedCapacity")]
            [Validation(Required=false)]
            public string AttachedCapacity { get; set; }

            /// <summary>
            /// The total number of instances that were created by Auto Scaling after the scaling activity was complete.
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
            /// The number of instances that were created during the scaling activity.
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public int? CreatedCapacity { get; set; }

            /// <summary>
            /// The instances that were created during the scaling activity.
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
            /// The number of instances that were released during the scaling activity.
            /// </summary>
            [NameInMap("DestroyedCapacity")]
            [Validation(Required=false)]
            public int? DestroyedCapacity { get; set; }

            /// <summary>
            /// The instances that were released during the scaling activity.
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
            /// If the scaling activity is a scale-out activity, the value of this parameter indicates the number of instances that were created during the scaling activity or the number of instances that were started from Economical Mode.
            /// 
            /// If the scaling activity is a scale-in activity, the value of this parameter indicates the number of instances that were deleted during the scaling activity or the number of instances that were stopped in Economical Mode.
            /// </summary>
            [NameInMap("ScalingInstanceNumber")]
            [Validation(Required=false)]
            public int? ScalingInstanceNumber { get; set; }

            /// <summary>
            /// The time when the scaling activity started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The number of instances that were started from Economical Mode during the scaling activity.
            /// </summary>
            [NameInMap("StartedCapacity")]
            [Validation(Required=false)]
            public int? StartedCapacity { get; set; }

            /// <summary>
            /// The instances that were started from Economical Mode during the scaling activity.
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
            /// The number of instances that were stopped in Economical Mode during the scaling activity.
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// The instances that were stopped in Economical Mode during the scaling activity.
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

        }

        /// <summary>
        /// The total number of scaling activities.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
