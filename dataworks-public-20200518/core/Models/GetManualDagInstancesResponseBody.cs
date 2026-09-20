// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of internal instances of the manual workflow.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetManualDagInstancesResponseBodyInstances> Instances { get; set; }
        public class GetManualDagInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance node started to run.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginRunningTime")]
            [Validation(Required=false)]
            public long? BeginRunningTime { get; set; }

            /// <summary>
            /// <para>The time when the instance node started to wait for resources.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginWaitResTime")]
            [Validation(Required=false)]
            public long? BeginWaitResTime { get; set; }

            /// <summary>
            /// <para>The time when the instance node started to wait for scheduling.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BeginWaitTimeTime")]
            [Validation(Required=false)]
            public long? BeginWaitTimeTime { get; set; }

            /// <summary>
            /// <para>The business date. This is typically the day before the node runs.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// <para>The time when the instance node was created.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The scheduled time of the instance node.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("CycTime")]
            [Validation(Required=false)]
            public long? CycTime { get; set; }

            /// <summary>
            /// <para>The DAG ID of the manual workflow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>350850491</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>The type of the manual workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// <para>The time when the instance node finished running.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The internal instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11726873619</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The most recent modification time of the instance node.</para>
            /// <para>The value is a 13-digit number, for example, <c>1605178414676</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605178414676</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The internal node ID of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37851</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The parameter information of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// <para>The status of the instance node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: The instance is not run.</description></item>
            /// <item><description>WAIT_TIME: The instance is waiting for the scheduled dueTime or cycleTime.</description></item>
            /// <item><description>WAIT_RESOURCE: The instance is waiting for resources.</description></item>
            /// <item><description>RUNNING: The instance is running.</description></item>
            /// <item><description>CHECKING: The instance is submitted to Data Quality for data verification.</description></item>
            /// <item><description>CHECKING_CONDITION: The instance is performing branch condition verification.</description></item>
            /// <item><description>FAILURE: The instance failed to run.</description></item>
            /// <item><description>SUCCESS: The instance is run successfully.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_TIME</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The scheduling type of the instance node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL(0): a normal scheduling node. The node is scheduled on a daily basis.</description></item>
            /// <item><description>MANUAL(1): a manual node. The node is not scheduled on a daily basis.</description></item>
            /// <item><description>PAUSE(2): a paused node. The node is scheduled on a daily basis, but is set to failed when scheduling starts.</description></item>
            /// <item><description>SKIP(3): a dry-run node. The node is scheduled on a daily basis, but is set to successful when scheduling starts.</description></item>
            /// <item><description>SKIP_UNCHOOSE(4): a node that is not selected in a temporary workflow. This type of node exists only in temporary workflows and is set to successful when scheduling starts.</description></item>
            /// <item><description>SKIP_CYCLE(5): a weekly or monthly node that has not reached its run cycle. The node is scheduled on a daily basis, but is set to successful when scheduling starts.</description></item>
            /// <item><description>CONDITION_UNCHOOSE(6): a downstream node that is not selected by an upstream branch (IF) node. The node is directly set to dry-run.</description></item>
            /// <item><description>REALTIME_DEPRECATED(7): an expired periodic instance generated in real time. This type of node is directly set to successful.</description></item>
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
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
