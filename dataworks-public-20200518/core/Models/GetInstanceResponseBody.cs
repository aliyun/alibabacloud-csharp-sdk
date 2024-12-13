// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The time when the instance started to run.</para>
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
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public long? BusinessId { get; set; }

            /// <summary>
            /// <para>The connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps_first</para>
            /// </summary>
            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }

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
            /// <para>The creator of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The scheduling time of the instance.</para>
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
            /// <para>338450167</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>The type of the workflow. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY: The workflow is used to run auto triggered nodes.</description></item>
            /// <item><description>MANUAL: The workflow is used to run manually triggered nodes.</description></item>
            /// <item><description>SMOKE_TEST: The workflow is used to perform smoke testing.</description></item>
            /// <item><description>SUPPLY_DATA: The workflow is used to backfill data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("DagType")]
            [Validation(Required=false)]
            public string DagType { get; set; }

            /// <summary>
            /// <para>The table and partition filter expression in Data Quality that are associated with the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;ztjy_dim&quot;,&quot;tableName&quot;:&quot;dim_user_agent_manage_area_a&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyy-mm-dd-1]&quot;}]</para>
            /// </summary>
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }

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
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }

            /// <summary>
            /// <para>The time when the running of the instance was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590416703313</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11713307578</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
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
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The parameters related to the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bizdate=$bizdate tbods=$tbods tbdw=$tbdw tbpmic=$tbpmic tbpidx=$tbpidx tbptcif=$tbptcif</para>
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodNumber")]
            [Validation(Required=false)]
            public int? PeriodNumber { get; set; }

            /// <summary>
            /// <para>The priority of the instance. Valid values: 1, 3, 5, 7, and 8. A greater value indicates a higher priority. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the workflow to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }

            /// <summary>
            /// <para>The interval at which the node is rerun after the node fails to run. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60000</para>
            /// </summary>
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }

            /// <summary>
            /// <para>Indicates whether the node that generates the instance can be rerun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public bool? Repeatability { get; set; }

            /// <summary>
            /// <para>The status of the node that generates the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: The node is not run.</description></item>
            /// <item><description>WAIT_TIME: The node is waiting for its scheduling time to arrive.</description></item>
            /// <item><description>WAIT_RESOURCE: The node is waiting for resources.</description></item>
            /// <item><description>RUNNING: The node is running.</description></item>
            /// <item><description>CHECKING: Data quality is being checked for the node.</description></item>
            /// <item><description>CHECKING_CONDITION: Branch conditions are being checked for the node.</description></item>
            /// <item><description>FAILURE: The node fails to run.</description></item>
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
            /// <para>The number of times the node can be rerun. The value of this parameter can be empty or an integer that is greater than or equal to 0.</para>
            /// <list type="bullet">
            /// <item><description>If the value of this parameter is empty, the number of times that the node can be rerun is not specified.</description></item>
            /// <item><description>If the value of this parameter is 0, the node cannot be rerun.</description></item>
            /// <item><description>If the value of this parameter is a positive integer such as n, the node can still be rerun n times. For example, if the value of this parameter is 1, the node can still be rerun once. If the value of this parameter is 2, the node can still be rerun twice.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TaskRerunTime")]
            [Validation(Required=false)]
            public int? TaskRerunTime { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node that generates the instance. Valid values:</para>
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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the instance fails to be scheduled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
