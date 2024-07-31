// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInnerNodesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListInnerNodesResponseBodyPaging Paging { get; set; }
        public class ListInnerNodesResponseBodyPaging : TeaModel {
            /// <summary>
            /// The list of inner nodes.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListInnerNodesResponseBodyPagingNodes> Nodes { get; set; }
            public class ListInnerNodesResponseBodyPagingNodes : TeaModel {
                /// <summary>
                /// The baseline ID.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The workflow ID.
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// The connection string.
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// The CRON expression.
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// The description of the inner node.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The table and partition filter expression in Data Quality that are associated with the inner node.
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// Indicates whether the inner node is associated with a monitoring rule in Data Quality. Valid values: 0 and 1. The value 0 indicates that the inner node is associated with a monitoring rule in Data Quality. The value 1 indicates that the inner node is not associated with a monitoring rule in Data Quality.
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public string DqcType { get; set; }

                /// <summary>
                /// The inner node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the inner node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The owner ID.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The additional parameters.
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// The priority of the inner node. Valid values: 1, 3, 5, 7, and 8.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The type of the inner node.
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public string ProgramType { get; set; }

                /// <summary>
                /// The workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The interval at which the inner node is rerun after the inner node fails to run.
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

                /// <summary>
                /// Indicates whether the inner node can be rerun.
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("ResGroupName")]
                [Validation(Required=false)]
                public string ResGroupName { get; set; }

                /// <summary>
                /// The scheduling type of the inner node. Valid values:
                /// 
                /// *   NORMAL: The inner node is an auto triggered node.
                /// *   MANUAL: The inner node is a manually triggered node. The scheduling system does not run the node on a regular basis.
                /// *   PAUSE: The inner node is a paused node.
                /// *   SKIP: The inner node is a dry-run node. Dry-run nodes are started as scheduled, but the scheduling system sets the status of the nodes to successful when it starts to run them.
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of inner nodes returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
