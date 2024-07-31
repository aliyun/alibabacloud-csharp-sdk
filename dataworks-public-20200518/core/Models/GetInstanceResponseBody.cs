// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The baseline ID.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// The time when the instance started to run.
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// The time when the instance started to wait for resources.
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// The time when the instance started to wait to be scheduled.
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// The data timestamp of the instance. In most cases, the value is one day before the time when the instance was run.
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

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
            /// The time when the instance was generated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The creator of the instance.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The scheduling time of the instance.
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// The workflow ID.
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// The type of the workflow. Valid values:
            /// 
            /// *   DAILY: The workflow is used to run auto triggered nodes.
            /// *   MANUAL: The workflow is used to run manually triggered nodes.
            /// *   SMOKE_TEST: The workflow is used to perform smoke testing.
            /// *   SUPPLY_DATA: The workflow is used to backfill data.
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// The table and partition filter expression in Data Quality that are associated with the node.
            /// </summary>
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }

            /// <summary>
            /// Indicates whether the instance is associated with a monitoring rule in Data Quality. Valid values:
            /// 
            /// *   0: The instance is associated with a monitoring rule in Data Quality.
            /// *   1: The instance is not associated with a monitoring rule in Data Quality.
            /// </summary>
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }

            /// <summary>
            /// The time when the running of the instance was complete.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The time when the instance was last modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

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
            /// The parameters related to the node.
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// The priority of the instance. Valid values: 1, 3, 5, 7, and 8. A greater value indicates a higher priority. Default value: 1.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The ID of the workflow to which the node belongs.
            /// </summary>
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }

            /// <summary>
            /// The interval at which the node is rerun after the node fails to run. Unit: milliseconds.
            /// </summary>
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }

            /// <summary>
            /// Indicates whether the node that generates the instance can be rerun.
            /// </summary>
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public bool? Repeatability { get; set; }

            /// <summary>
            /// The status of the node that generates the instance. Valid values:
            /// 
            /// *   NOT_RUN: The node is not run.
            /// *   WAIT_TIME: The node is waiting for its scheduling time to arrive.
            /// *   WAIT_RESOURCE: The node is waiting for resources.
            /// *   RUNNING: The node is running.
            /// *   CHECKING: Data quality is being checked for the node.
            /// *   CHECKING_CONDITION: Branch conditions are being checked for the node.
            /// *   FAILURE: The node fails to run.
            /// *   SUCCESS: The node is successfully run.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The number of times the node can be rerun. The value of this parameter can be empty or an integer that is greater than or equal to 0.
            /// 
            /// *   If the value of this parameter is empty, the number of times that the node can be rerun is not specified.
            /// *   If the value of this parameter is 0, the node cannot be rerun.
            /// *   If the value of this parameter is a positive integer such as n, the node can still be rerun n times. For example, if the value of this parameter is 1, the node can still be rerun once. If the value of this parameter is 2, the node can still be rerun twice.
            /// </summary>
            [NameInMap("TaskRerunTime")]
            [Validation(Required=false)]
            public int? TaskRerunTime { get; set; }

            /// <summary>
            /// The scheduling type of the node that generates the instance. Valid values:
            /// 
            /// *   NORMAL(0): The node is an auto triggered node. The scheduling system regularly runs the node.
            /// *   MANUAL(1): The node is a manually triggered node. The scheduling system does not regularly run the node.
            /// *   PAUSE(2): The node is a frozen node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.
            /// *   SKIP(3): The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.
            /// *   SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the status of the node to successful when the scheduling system starts to run the node.
            /// *   SKIP_CYCLE(5): The node is a node that is scheduled by the week or month and is waiting for the scheduling time to arrive. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.
            /// *   CONDITION_UNCHOOSE(6): The node is not selected by its ancestor branch node and is run as a dry-run node.
            /// *   REALTIME_DEPRECATED(7): The node has instances that are generated in real time but deprecated. The scheduling system sets the status of the node to successful.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned when the instance fails to be scheduled.
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
