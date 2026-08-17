// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeGroupRefreshTaskResponseBody : TeaModel {
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
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. An empty value of NextToken indicates that no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ed93fda-5e7f-436a-ae5a-bd8e6b04e36b</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3525</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the refresh task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-159136551662516768776</para>
        /// </summary>
        [NameInMap("NodeGroupRefreshTaskId")]
        [Validation(Required=false)]
        public string NodeGroupRefreshTaskId { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeNodeGroupRefreshTaskResponseBodyNodes> Nodes { get; set; }
        public class DescribeNodeGroupRefreshTaskResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The action level actually executed on the node. If multiple properties are refreshed on the node, the highest required action level is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Refresh: in-place refresh.</description></item>
            /// <item><description>Reboot: restart.</description></item>
            /// <item><description>Reimage: reimage.
            /// If the entire node is skipped, this value is empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Refresh</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NodeInMaintenance</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The node has been confirmed for maintenance and there is no need to confirm the maintenance again. sn: 21B917666,status:ClusterNodeRepairing</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-001</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The list of property drifts for the node, including both executed and skipped properties.</para>
            /// </summary>
            [NameInMap("PropertyDrifts")]
            [Validation(Required=false)]
            public List<DescribeNodeGroupRefreshTaskResponseBodyNodesPropertyDrifts> PropertyDrifts { get; set; }
            public class DescribeNodeGroupRefreshTaskResponseBodyNodesPropertyDrifts : TeaModel {
                /// <summary>
                /// <para>The current value of the node property. Complex types are serialized as JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>old-role</para>
                /// </summary>
                [NameInMap("ActualValue")]
                [Validation(Required=false)]
                public string ActualValue { get; set; }

                /// <summary>
                /// <para>The minimum action required to apply the target value: Refresh / Reboot / Reimage. For more information, see the MaxDisruptiveAction parameter description in the RefreshNodeGroupNodes operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Refresh</para>
                /// </summary>
                [NameInMap("MinRequiredAction")]
                [Validation(Required=false)]
                public string MinRequiredAction { get; set; }

                /// <summary>
                /// <para>The property path in dot notation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RamRoleName</para>
                /// </summary>
                [NameInMap("PropertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

                /// <summary>
                /// <para>Indicates whether the property was skipped because it exceeded the MaxDisruptiveAction constraint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Skipped")]
                [Validation(Required=false)]
                public bool? Skipped { get; set; }

                /// <summary>
                /// <para>The target value of the node property. Complex types are serialized as JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-role</para>
                /// </summary>
                [NameInMap("TargetValue")]
                [Validation(Required=false)]
                public string TargetValue { get; set; }

            }

            /// <summary>
            /// <para>The node refresh status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: the node is waiting to be refreshed.</description></item>
            /// <item><description>InProgress: the node is being refreshed.</description></item>
            /// <item><description>Success: the node is refreshed.</description></item>
            /// <item><description>Failed: the node failed to be refreshed.</description></item>
            /// <item><description>Skipped: all properties to be refreshed on the node exceeded the MaxDisruptiveAction constraint and were skipped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <item><description>Pending: the refresh task is created and waiting to be executed.</description></item>
        /// <item><description>InProgress: the refresh task is being processed.</description></item>
        /// <item><description>Success: the refresh task is executed.</description></item>
        /// <item><description>Failed: the refresh task failed to be executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InProgress</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of nodes to be refreshed in the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalNodeCount")]
        [Validation(Required=false)]
        public long? TotalNodeCount { get; set; }

    }

}
