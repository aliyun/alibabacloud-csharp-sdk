// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryResponseBodyInstances> Instances { get; set; }
        public class ListInstanceHistoryResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance started to be run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started to wait for resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started to wait to be scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// <para>The data timestamp of the instance. In most cases, the value is one day before the time when the instance was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590336000000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The time when the instance was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the node started to be run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590422400000</para>
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33845</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is associated with a monitoring rule in Data Quality. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The instance is associated with a monitoring rule in Data Quality.</description></item>
            /// <item><description>1: The instance is not associated with a monitoring rule in Data Quality.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is deprecated. You can call the GetInstanceLog operation to query the error information related to the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error message</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the running of the node was complete. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The historical record number of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceHistoryId")]
            [Validation(Required=false)]
            public long? InstanceHistoryId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the node was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33115</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kzh</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The status of the node that generates the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: The node is not run.</description></item>
            /// <item><description>WAIT_TIME: The node is waiting for the scheduling time to arrive.</description></item>
            /// <item><description>WAIT_RESOURCE: The node is waiting for resources.</description></item>
            /// <item><description>RUNNING: The node is running.</description></item>
            /// <item><description>CHECKING: Data quality is being checked for the node.</description></item>
            /// <item><description>CHECKING_CONDITION: Branch conditions are being checked for the node.</description></item>
            /// <item><description>FAILURE: The node fails to be run.</description></item>
            /// <item><description>SUCCESS: The node is successfully run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_RUN</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL(0): The node is an auto triggered node. The scheduling system regularly runs the node.</description></item>
            /// <item><description>MANUAL(1): The node is a manually triggered node. The scheduling system does not regularly run the node.</description></item>
            /// <item><description>PAUSE(2): The node is a frozen node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP(3): The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
            /// <item><description>SKIP_CYCLE(5): The node is a node that is scheduled by the week or month and is waiting for the scheduling time to arrive. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
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
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
