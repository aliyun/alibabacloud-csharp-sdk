// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByOutputResponseBody : TeaModel {
        /// <summary>
        /// The nodes returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNodesByOutputResponseBodyData> Data { get; set; }
        public class ListNodesByOutputResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the nodes returned.
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<ListNodesByOutputResponseBodyDataNodeList> NodeList { get; set; }
            public class ListNodesByOutputResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// The baseline ID.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The name of the data source.
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
                /// The description of the node.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The table and partition filter expression in Data Quality that are associated with the node.
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// Indicates whether the node is associated with a monitoring rule in Data Quality. Valid values: 0 and 1. The value 0 indicates that the node is associated with a monitoring rule in Data Quality. The value 1 indicates that the node is not associated with a monitoring rule in Data Quality.
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public int? DqcType { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3)
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the node.
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
                /// The scheduling parameters of the node.
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// The priority of the node. Valid values: 1, 3, 5, 7, and 8. A greater value indicates a higher priority. Default value: 1.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The node type. This parameter is deprecated. For more information about node types, see valid values of the FileType parameter.
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
                /// The ID of the workflow to which the node belongs.
                /// </summary>
                [NameInMap("RelatedFlowId")]
                [Validation(Required=false)]
                public long? RelatedFlowId { get; set; }

                /// <summary>
                /// The interval at which the node is rerun after the node fails to run.
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public int? RepeatInterval { get; set; }

                /// <summary>
                /// Indicates whether the node can be rerun.
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
                /// The scheduling type of the node. Valid values:
                /// 
                /// *   NORMAL: The node is an auto triggered node. The scheduling system regularly runs the node.
                /// *   MANUAL: The node is a manually triggered node. The scheduling system does not regularly run the node.
                /// *   PAUSE: The node is a frozen node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.
                /// *   SKIP: The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

            }

            /// <summary>
            /// The output name of the current node.
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
