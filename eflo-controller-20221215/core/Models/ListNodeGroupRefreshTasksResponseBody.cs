// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNodeGroupRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. An empty value indicates that no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of node group refresh tasks.</para>
        /// </summary>
        [NameInMap("NodeGroupRefreshTasks")]
        [Validation(Required=false)]
        public List<ListNodeGroupRefreshTasksResponseBodyNodeGroupRefreshTasks> NodeGroupRefreshTasks { get; set; }
        public class ListNodeGroupRefreshTasksResponseBodyNodeGroupRefreshTasks : TeaModel {
            /// <summary>
            /// <para>The end time of the refresh task in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20T10:30:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of failed nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The number of finished nodes, including succeeded, failed, and skipped nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("FinishedCount")]
            [Validation(Required=false)]
            public long? FinishedCount { get; set; }

            /// <summary>
            /// <para>The maximum disruptive action level allowed for the refresh operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Refresh</para>
            /// </summary>
            [NameInMap("MaxDisruptiveAction")]
            [Validation(Required=false)]
            public string MaxDisruptiveAction { get; set; }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-3525</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-159136551662516768776</para>
            /// </summary>
            [NameInMap("NodeGroupRefreshTaskId")]
            [Validation(Required=false)]
            public string NodeGroupRefreshTaskId { get; set; }

            /// <summary>
            /// <para>The start time of the refresh task in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20T10:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The refresh task is created and waiting to be executed.</description></item>
            /// <item><description>InProgress: The refresh task is being processed.</description></item>
            /// <item><description>Success: The refresh task is executed.</description></item>
            /// <item><description>Failed: The refresh task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of nodes to refresh in this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalNodeCount")]
            [Validation(Required=false)]
            public long? TotalNodeCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>03668372-18FF-5959-98D9-6B36A4643C7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
