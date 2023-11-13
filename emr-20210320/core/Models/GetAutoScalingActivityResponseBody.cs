// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingActivityResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingActivity")]
        [Validation(Required=false)]
        public GetAutoScalingActivityResponseBodyScalingActivity ScalingActivity { get; set; }
        public class GetAutoScalingActivityResponseBodyScalingActivity : TeaModel {
            /// <summary>
            /// The ID of the scaling activity.
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// The instances corresponding to this scaling activity.
            /// </summary>
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public List<ScalingActivityResult> ActivityResults { get; set; }

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
            /// The type of the scaling activity. Valid value:
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
            /// The time when scaling ended.
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
            /// The description of the scaling rule.
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public ScalingRule RuleDetail { get; set; }

            /// <summary>
            /// The name of the scaling rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The time when scaling started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
