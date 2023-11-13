// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListAutoScalingActivitiesResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scaling activities.
        /// </summary>
        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public List<ListAutoScalingActivitiesResponseBodyScalingActivities> ScalingActivities { get; set; }
        public class ListAutoScalingActivitiesResponseBodyScalingActivities : TeaModel {
            /// <summary>
            /// The ID of the scaling activity.
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// The status of the scaling activity. Valid values:
            /// 
            /// *   REJECTED
            /// *   SUCCESSFUL
            /// *   FAILED
            /// *   IN_PROGRESS
            /// </summary>
            [NameInMap("ActivityState")]
            [Validation(Required=false)]
            public string ActivityState { get; set; }

            /// <summary>
            /// The type of the scaling activity. Valid values:
            /// 
            /// *   SCALE_OUT
            /// *   SCALE_IN
            /// </summary>
            [NameInMap("ActivityType")]
            [Validation(Required=false)]
            public string ActivityType { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The description of the scaling activity.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The end time of the scaling. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The number of added or removed instances.
            /// </summary>
            [NameInMap("ExpectNum")]
            [Validation(Required=false)]
            public int? ExpectNum { get; set; }

            /// <summary>
            /// The ID of the node group.
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// The name of the node group.
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// The operation ID.
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// The name of the scaling rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The start time of the scaling. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
