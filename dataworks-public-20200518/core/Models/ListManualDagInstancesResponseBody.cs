// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListManualDagInstancesResponseBody : TeaModel {
        /// <summary>
        /// The instances in the manually triggered workflow.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListManualDagInstancesResponseBodyInstances> Instances { get; set; }
        public class ListManualDagInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The time when the node started to run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// The time when the node started to wait for resources. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// The time when the node started to wait to be scheduled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// The data timestamp of the instance. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. In most cases, the value indicates one day before the time when the node was run.
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// The time when the node was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The name of the account used to run the instance. For example, if an account named Test was used to run the instance to backfill data, the value of this parameter is Test.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The time when the node was scheduled to run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            /// The identifier of the manually triggered workflow.
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// The time when the node stopped running. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            /// The time when the node was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
            /// The status of the node. Valid values:
            /// 
            /// *   NOT_RUN: The node is not run.
            /// *   WAIT_TIME: The node is waiting for its scheduled time to arrive.
            /// *   WAIT_RESOURCE: The node is waiting for resources.
            /// *   RUNNING: The node is running.
            /// *   CHECKING: Data quality is being checked for the node.
            /// *   CHECKING_CONDITION: Branch conditions are being checked for the node.
            /// *   FAILURE: The node fails to run.
            /// *   SUCCESS: The node is run as expected.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The scheduling type of the node. Valid values:
            /// 
            /// *   NORMAL(0): The node is an auto triggered node. It is run on a regular basis.
            /// *   MANUAL(1): The node is a manually triggered node. It is not run on a regular basis.
            /// *   PAUSE(2): The node is a frozen node. The scheduling system still runs the node on a regular basis but sets it to Failed when the scheduling system starts to run the node.
            /// *   SKIP(3): The node is a dry-run node. The scheduling system still runs the node on a regular basis but sets it to Succeeded when the scheduling system starts to run the node.
            /// *   SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the node to Succeeded when the scheduling system starts to run the node.
            /// *   SKIP_CYCLE(5): The node is a node that is scheduled by week or month and is waiting for its scheduled time. The scheduling system still runs the node on a regular basis but sets it to Succeeded when the scheduling system starts to run the node.
            /// *   CONDITION_UNCHOOSE(6): The node is not selected by its ancestor branch node and is run as a dry-run node.
            /// *   REALTIME_DEPRECATED(7): The node has instances generated in real time but deprecated. The scheduling system directly sets the node to Succeeded.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to search for logs and troubleshoot issues based on the logs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
