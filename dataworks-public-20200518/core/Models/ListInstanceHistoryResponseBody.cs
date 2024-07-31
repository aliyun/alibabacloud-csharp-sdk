// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceHistoryResponseBody : TeaModel {
        /// <summary>
        /// The instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryResponseBodyInstances> Instances { get; set; }
        public class ListInstanceHistoryResponseBodyInstances : TeaModel {
            /// <summary>
            /// The time when the instance started to be run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
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
            /// The time when the instance was generated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The time when the node started to be run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
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
            /// Indicates whether the instance is associated with a monitoring rule in Data Quality. Valid values:
            /// 
            /// *   0: The instance is associated with a monitoring rule in Data Quality.
            /// *   1: The instance is not associated with a monitoring rule in Data Quality.
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// The error message. This parameter is deprecated. You can call the GetInstanceLog operation to query the error information related to the node.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The time when the running of the node was complete. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// The historical record number of the instance.
            /// </summary>
            [NameInMap("InstanceHistoryId")]
            [Validation(Required=false)]
            public long? InstanceHistoryId { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The time when the node was last modified.
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
            /// The status of the node that generates the instance. Valid values:
            /// 
            /// *   NOT_RUN: The node is not run.
            /// *   WAIT_TIME: The node is waiting for the scheduling time to arrive.
            /// *   WAIT_RESOURCE: The node is waiting for resources.
            /// *   RUNNING: The node is running.
            /// *   CHECKING: Data quality is being checked for the node.
            /// *   CHECKING_CONDITION: Branch conditions are being checked for the node.
            /// *   FAILURE: The node fails to be run.
            /// *   SUCCESS: The node is successfully run.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The scheduling type of the node. Valid values:
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
