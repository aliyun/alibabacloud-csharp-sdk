// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListJobExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobExecutionsResponseBodyData Data { get; set; }
        public class ListJobExecutionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>A list of job instances.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListJobExecutionsResponseBodyDataRecords> Records { get; set; }
            public class ListJobExecutionsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The attempt number for this execution. <c>1</c> indicates the initial run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempt")]
                [Validation(Required=false)]
                public int? Attempt { get; set; }

                /// <summary>
                /// <para>The data timestamp for the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The duration of the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The time when the job execution ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1827811800526000</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The job execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1310630367761285120</para>
                /// </summary>
                [NameInMap("JobExecutionId")]
                [Validation(Required=false)]
                public string JobExecutionId { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>74</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <para>The name of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-job</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The type of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxljob</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The parameters of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name=zhangsan</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The execution result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The strategy for routing the job to a worker. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: Round-robin</para>
                /// </description></item>
                /// <item><description><para>2: Random</para>
                /// </description></item>
                /// <item><description><para>3: First</para>
                /// </description></item>
                /// <item><description><para>4: Last</para>
                /// </description></item>
                /// <item><description><para>5: Least Frequently Used</para>
                /// </description></item>
                /// <item><description><para>6: Least Recently Used</para>
                /// </description></item>
                /// <item><description><para>7: Consistent Hashing</para>
                /// </description></item>
                /// <item><description><para>8: Sharded Broadcasting</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteStrategy")]
                [Validation(Required=false)]
                public int? RouteStrategy { get; set; }

                /// <summary>
                /// <para>The time when the job was scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The IP address of the scheduler node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28.0.168.46</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>The job execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNKNOWN</para>
                /// </description></item>
                /// <item><description><para>1: WAITING</para>
                /// </description></item>
                /// <item><description><para>2: READY</para>
                /// </description></item>
                /// <item><description><para>3: RUNNING</para>
                /// </description></item>
                /// <item><description><para>4: SUCCESS</para>
                /// </description></item>
                /// <item><description><para>5: FAILED</para>
                /// </description></item>
                /// <item><description><para>6: PAUSED</para>
                /// </description></item>
                /// <item><description><para>7: SUBMITTED</para>
                /// </description></item>
                /// <item><description><para>8: REJECTED</para>
                /// </description></item>
                /// <item><description><para>9: ACCEPTED</para>
                /// </description></item>
                /// <item><description><para>10: PARTIAL_FAILED</para>
                /// </description></item>
                /// <item><description><para>11: SKIPPED</para>
                /// </description></item>
                /// <item><description><para>12: REMOVED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>-1: none<br></para>
                /// </description></item>
                /// <item><description><para>1: cron<br></para>
                /// </description></item>
                /// <item><description><para>3: fix_rate<br></para>
                /// </description></item>
                /// <item><description><para>5: one_time<br></para>
                /// </description></item>
                /// <item><description><para>100: api</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <para>The total number of tokens consumed by the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

                /// <summary>
                /// <para>The method that triggered the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: unknown</para>
                /// </description></item>
                /// <item><description><para>1: schedule</para>
                /// </description></item>
                /// <item><description><para>2: rerun</para>
                /// </description></item>
                /// <item><description><para>3: api</para>
                /// </description></item>
                /// <item><description><para>4: user_retry</para>
                /// </description></item>
                /// <item><description><para>5: system_retry</para>
                /// </description></item>
                /// <item><description><para>6: manual</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

                /// <summary>
                /// <para>The address of the worker that executed the job instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.1.9:9999/">http://192.168.1.9:9999/</a></para>
                /// </summary>
                [NameInMap("WorkAddr")]
                [Validation(Required=false)]
                public string WorkAddr { get; set; }

                /// <summary>
                /// <para>The ID of the parent workflow instance, if applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("WorkflowExecutionId")]
                [Validation(Required=false)]
                public string WorkflowExecutionId { get; set; }

                /// <summary>
                /// <para>The ID of the parent workflow, if applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

                /// <summary>
                /// <para>The name of the parent workflow, if applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myWorkflow</para>
                /// </summary>
                [NameInMap("WorkflowName")]
                [Validation(Required=false)]
                public string WorkflowName { get; set; }

                /// <summary>
                /// <para>The extended attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;sessionId&quot;:&quot;ac21f9f6-5a88-4f97-abd1-b51989166035&quot;}</para>
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries found.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request. Alibaba Cloud generates this ID to help troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BCE89B3-E882-511D-9A75-D452A56EC4B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
