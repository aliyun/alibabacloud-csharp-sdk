// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances in the manually triggered workflow.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetManualDagInstancesResponseBodyInstances> Instances { get; set; }
        public class GetManualDagInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance started to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started to wait for resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started to wait to be scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// <para>The data timestamp of the instance. In most cases, the value is one day before the time when the instance was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// <para>The time when the instance was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The user who performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The time when the instance was scheduled to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// <para>The ID of the DAG for the manually triggered workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>350850491</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>The type of the manually triggered workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// <para>The time when the instance finished running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance in the manually triggered workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11726873619</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the node in the manually triggered workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37851</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The parameters related to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: The instance is not run.</description></item>
            /// <item><description>WAIT_TIME: The instance is waiting for its scheduling time to arrive.</description></item>
            /// <item><description>WAIT_RESOURCE: The instance is waiting for resources.</description></item>
            /// <item><description>RUNNING: The instance is running.</description></item>
            /// <item><description>CHECKING: Data quality is being checked for the instance.</description></item>
            /// <item><description>CHECKING_CONDITION: Branch conditions are being checked for the instance.</description></item>
            /// <item><description>FAILURE: The instance fails to be run.</description></item>
            /// <item><description>SUCCESS: The instance is successfully run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_TIME</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node that generates the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL(0): The node is an auto triggered node. The scheduling system regularly runs the node.</description></item>
            /// <item><description>MANUAL(1): The node is a manually triggered node. The scheduling system does not regularly run the node.</description></item>
            /// <item><description>PAUSE(2): The node is a paused node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP(3): The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP_CYCLE(5): The node is a node that is scheduled by week or month and is waiting for the scheduling time to arrive. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
            /// <item><description>CONDITION_UNCHOOSE(6): The node is not selected by its ancestor branch node and is run as a dry-run node.</description></item>
            /// <item><description>REALTIME_DEPRECATED(7): The node has instances that are generated in real time but deprecated. The scheduling system sets the status of the node to successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL(0)</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
