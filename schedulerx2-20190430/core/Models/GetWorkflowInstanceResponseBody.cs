// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the workflow instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyData Data { get; set; }
        public class GetWorkflowInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The directed acyclic graph (DAG) of the workflow instance, including nodes and dependencies.</para>
            /// </summary>
            [NameInMap("WfInstanceDag")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceDag WfInstanceDag { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceDag : TeaModel {
                /// <summary>
                /// <para>The dependencies between job instances.</para>
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges> Edges { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges : TeaModel {
                    /// <summary>
                    /// <para>The upstream job instance of the current job instance. A value of 0 indicates that the upstream job instance is the root node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24058798</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    /// <summary>
                    /// <para>The downstream job instance of the current job instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24058796</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                /// <summary>
                /// <para>The job instances.</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes> Nodes { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes : TeaModel {
                    /// <summary>
                    /// <para>The number of retries when the job failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Attempt")]
                    [Validation(Required=false)]
                    public int? Attempt { get; set; }

                    /// <summary>
                    /// <para>The data timestamp of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-03 18:00:00</para>
                    /// </summary>
                    [NameInMap("DataTime")]
                    [Validation(Required=false)]
                    public string DataTime { get; set; }

                    /// <summary>
                    /// <para>The time when the job stopped running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-03 18:00:21</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1472</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public long? JobId { get; set; }

                    /// <summary>
                    /// <para>The ID of the job instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24058796</para>
                    /// </summary>
                    [NameInMap("JobInstanceId")]
                    [Validation(Required=false)]
                    public long? JobInstanceId { get; set; }

                    /// <summary>
                    /// <para>The job name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestJob</para>
                    /// </summary>
                    [NameInMap("JobName")]
                    [Validation(Required=false)]
                    public string JobName { get; set; }

                    /// <summary>
                    /// <para>The execution result of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code=200</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>The time when the job was scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-03 18:00:03</para>
                    /// </summary>
                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                    /// <summary>
                    /// <para>The time when the job started to run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-03 18:00:03</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The state of the job instance. Valid values: 1: The job instance is waiting for execution. 3: The job instance is running. 4: The job instance is run. 5: The job instance failed to run. 9: The job instance is rejected. Enumeration class: com.alibaba.schedulerx.common.domain.InstanceStatus.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The worker on which the job instance run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.163.0.101:34027</para>
                    /// </summary>
                    [NameInMap("WorkAddr")]
                    [Validation(Required=false)]
                    public string WorkAddr { get; set; }

                }

            }

            /// <summary>
            /// <para>The details of the workflow instance, including the state of the workflow instance, the time when the workflow instance started to run, the time when the workflow instance stopped running, the state of each job instance, and the dependencies between job instances.</para>
            /// </summary>
            [NameInMap("WfInstanceInfo")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceInfo WfInstanceInfo { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceInfo : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the workflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:00</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance stopped running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:21</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance was scheduled to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:00</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow instance started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-03 18:00:01</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The state of the workflow instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: pending</description></item>
                /// <item><description>2: preparing</description></item>
                /// <item><description>3: running</description></item>
                /// <item><description>4: successful</description></item>
                /// <item><description>5: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workflowId=xxx is not existed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39090022-1F3B-4797-8518-6B61095F1AF0</para>
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
