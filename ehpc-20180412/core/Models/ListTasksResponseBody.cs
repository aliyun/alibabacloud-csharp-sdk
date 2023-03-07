// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListTasksResponseBody : TeaModel {
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
        /// The list of task information.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The current step of the task.
            /// </summary>
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public int? CurrentStep { get; set; }

            /// <summary>
            /// The list of error messages returned for the task.
            /// 
            /// For information about error messages and their solutions, visit the [API Error Center](https://error-center.alibabacloud.com/status/product/EHPC).
            /// </summary>
            [NameInMap("Errors")]
            [Validation(Required=false)]
            public string Errors { get; set; }

            /// <summary>
            /// The request parameters of the task. The value is a JSON string.
            /// </summary>
            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            /// <summary>
            /// The result of the task. Valid values:
            /// 
            /// *   If TaskType is set to CreateCluster and AddComputes, the value is in the `{\"Instances\":[]}` format, which indicates the information of the nodes added to the cluster.
            /// *   If TaskType is set to a value other than CreateCluster and AddComputes, the value is in the `{}` format.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   Processing: The task is running.
            /// *   Success: The task is completed.
            /// *   Fail: The task failed.
            /// *   PartialFail: The task partially failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   CreateCluster: creates a cluster by calling the [CreateCluster](~~87100~~) operation.
            /// *   StartCluster: starts a cluster by calling the [StartCluster](~~200345~~) operation.
            /// *   StopCluster: stops a cluster by calling the [StopCluster](~~200346~~) operation.
            /// *   DeleteCluster: releases a cluster by calling the [DeleteCluster](~~87110~~) operation.
            /// *   AddComputes: adds nodes to a cluster by calling the [AddNodes](~~87147~~) operation.
            /// *   StartComputes: starts nodes by calling the [StartNodes](~~87159~~) operation.
            /// *   ResetCompute: resets nodes by calling the [ResetNodes](~~87158~~) operation.
            /// *   StopComputes: stops nodes by calling the [StopNodes](~~87160~~) operation.
            /// *   DeleteComputes: deletes nodes by calling the [DeleteNodes](~~87155~~) operation.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The total number of steps of the task.
            /// </summary>
            [NameInMap("TotalSteps")]
            [Validation(Required=false)]
            public int? TotalSteps { get; set; }

        }

        /// <summary>
        /// The total number of entries of the task.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
