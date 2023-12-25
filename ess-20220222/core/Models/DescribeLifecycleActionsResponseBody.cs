// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleActionsResponseBody : TeaModel {
        /// <summary>
        /// The lifecycle actions.
        /// </summary>
        [NameInMap("LifecycleActions")]
        [Validation(Required=false)]
        public List<DescribeLifecycleActionsResponseBodyLifecycleActions> LifecycleActions { get; set; }
        public class DescribeLifecycleActionsResponseBodyLifecycleActions : TeaModel {
            /// <summary>
            /// The IDs of the ECS instances to which the lifecycle hook applies.
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// The action that is performed after the lifecycle action triggered by the lifecycle hook is complete. Valid values:
            /// 
            /// *   CONTINUE: Auto Scaling continues to add ECS instances to the scaling group, or continues to remove ECS instances from the scaling group.
            /// *   ABANDON: Auto Scaling stops adding ECS instances to the scaling group and releases the ECS instances, or continues to respond to scale-in requests and remove ECS instances from the scaling group.
            /// </summary>
            [NameInMap("LifecycleActionResult")]
            [Validation(Required=false)]
            public string LifecycleActionResult { get; set; }

            /// <summary>
            /// The status of the lifecycle action.
            /// </summary>
            [NameInMap("LifecycleActionStatus")]
            [Validation(Required=false)]
            public string LifecycleActionStatus { get; set; }

            /// <summary>
            /// The token of the lifecycle action.
            /// </summary>
            [NameInMap("LifecycleActionToken")]
            [Validation(Required=false)]
            public string LifecycleActionToken { get; set; }

            /// <summary>
            /// The ID of the lifecycle hook.
            /// </summary>
            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the queried lifecycle actions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
