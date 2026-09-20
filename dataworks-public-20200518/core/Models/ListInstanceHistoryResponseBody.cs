// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryResponseBodyInstances> Instances { get; set; }
        public class ListInstanceHistoryResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance started running, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started waiting for resources.</para>
            /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// <para>The time when the instance started waiting for scheduling.</para>
            /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// <para>The business date on which the scheduled node was run. This value is typically one day before the run time of the node.</para>
            /// <para>The value is a 13-digit number, such as <c>1590336000000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590336000000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The scheduled run time of the node, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590422400000</para>
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// <para>The ID of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33845</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>The Data Quality Check (DQC) type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: associated with DQC.</description></item>
            /// <item><description>1: not associated with DQC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The error message returned when the instance failed to run. This field is deprecated. You can call the GetInstanceLog operation to obtain the error information of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error message</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the scheduled node finished running, in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The history archive ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceHistoryId")]
            [Validation(Required=false)]
            public long? InstanceHistoryId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the scheduled node was last modified.</para>
            /// <para>The value is a 13-digit number, such as <c>1590416703313</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
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
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: The node is not run.</description></item>
            /// <item><description>WAIT_TIME: The node is waiting for the scheduled time (DueTime or CycTime) to arrive.</description></item>
            /// <item><description>WAIT_RESOURCE: The node is waiting for resources.</description></item>
            /// <item><description>RUNNING: The node is running.</description></item>
            /// <item><description>CHECKING: The node is sent to Data Quality for data verification.</description></item>
            /// <item><description>CHECKING_CONDITION: The node is undergoing branch condition verification.</description></item>
            /// <item><description>FAILURE: The node failed to run.</description></item>
            /// <item><description>SUCCESS: The node ran successfully.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_RUN</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL(0): A normal scheduling node. The node is scheduled on a daily basis.</description></item>
            /// <item><description>MANUAL(1): A manual node. The node is not scheduled on a daily basis.</description></item>
            /// <item><description>PAUSE(2): A frozen node. The node is scheduled on a daily basis, but is set to failed when scheduling starts.</description></item>
            /// <item><description>SKIP(3): A dry-run node. The node is scheduled on a daily basis, but is set to successful when scheduling starts.</description></item>
            /// <item><description>SKIP_UNCHOOSE(4): A node that is not selected in a temporary workflow. This type of node exists only in temporary workflows and is set to successful when scheduling starts.</description></item>
            /// <item><description>SKIP_CYCLE(5): A weekly or monthly node that has not reached its run cycle. The node is scheduled on a daily basis, but is set to successful when scheduling starts.</description></item>
            /// <item><description>CONDITION_UNCHOOSE(6): A downstream node that is not selected by an upstream branch (IF) node. The node is directly set to dry-run.</description></item>
            /// <item><description>REALTIME_DEPRECATED(7): An expired periodic instance generated in real time. This type of node is directly set to successful.</description></item>
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
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
