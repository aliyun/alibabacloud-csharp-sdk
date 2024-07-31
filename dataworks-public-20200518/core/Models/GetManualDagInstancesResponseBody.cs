// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesResponseBody : TeaModel {
        /// <summary>
        /// The instances in the manually triggered workflow.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetManualDagInstancesResponseBodyInstances> Instances { get; set; }
        public class GetManualDagInstancesResponseBodyInstances : TeaModel {
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
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// The time when the instance was generated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The user who performed the operation.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The time when the instance was scheduled to run.
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// The ID of the DAG for the manually triggered workflow.
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// The type of the manually triggered workflow.
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// The time when the instance finished running.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// The ID of the instance in the manually triggered workflow.
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
            /// The ID of the node in the manually triggered workflow.
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
            /// The parameters related to the instance.
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   NOT_RUN: The instance is not run.
            /// *   WAIT_TIME: The instance is waiting for its scheduling time to arrive.
            /// *   WAIT_RESOURCE: The instance is waiting for resources.
            /// *   RUNNING: The instance is running.
            /// *   CHECKING: Data quality is being checked for the instance.
            /// *   CHECKING_CONDITION: Branch conditions are being checked for the instance.
            /// *   FAILURE: The instance fails to be run.
            /// *   SUCCESS: The instance is successfully run.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The scheduling type of the node that generates the instance. Valid values:
            /// 
            /// *   NORMAL(0): The node is an auto triggered node. The scheduling system regularly runs the node.
            /// *   MANUAL(1): The node is a manually triggered node. The scheduling system does not regularly run the node.
            /// *   PAUSE(2): The node is a paused node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.
            /// *   SKIP(3): The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.
            /// *   SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the status of the node to successful when the scheduling system starts to run the node.
            /// *   SKIP_CYCLE(5): The node is a node that is scheduled by week or month and is waiting for the scheduling time to arrive. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.
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

    }

}
