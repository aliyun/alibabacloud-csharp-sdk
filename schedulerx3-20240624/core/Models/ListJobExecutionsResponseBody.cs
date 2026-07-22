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
            /// <para>The list of job instances.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListJobExecutionsResponseBodyDataRecords> Records { get; set; }
            public class ListJobExecutionsResponseBodyDataRecords : TeaModel {
                [NameInMap("AppGroupId")]
                [Validation(Required=false)]
                public long? AppGroupId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The number of failed attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempt")]
                [Validation(Required=false)]
                public int? Attempt { get; set; }

                /// <summary>
                /// <para>The data timestamp of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The total running duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The end time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The executor ID.</para>
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
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-job</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxljob</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>The job parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name=zhangsan</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The returned result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The routing strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: round-robin.</description></item>
                /// <item><description>2: random.</description></item>
                /// <item><description>3: first.</description></item>
                /// <item><description>4: last.</description></item>
                /// <item><description>5: least frequently used.</description></item>
                /// <item><description>6: least recently used.</description></item>
                /// <item><description>7: consistent hashing.</description></item>
                /// <item><description>8: shard broadcast.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteStrategy")]
                [Validation(Required=false)]
                public int? RouteStrategy { get; set; }

                /// <summary>
                /// <para>The scheduling time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The scheduling node.</para>
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
                /// <item><description>0: UNKNOWN.</description></item>
                /// <item><description>1: WAITING.</description></item>
                /// <item><description>2: READY.</description></item>
                /// <item><description>3: RUNNING.</description></item>
                /// <item><description>4: SUCCESS.</description></item>
                /// <item><description>5: FAILED.</description></item>
                /// <item><description>6: PAUSED.</description></item>
                /// <item><description>7: SUBMITTED.</description></item>
                /// <item><description>8: REJECTED.</description></item>
                /// <item><description>9: ACCEPTED.</description></item>
                /// <item><description>10: PARTIAL_FAILED.</description></item>
                /// <item><description>11: SKIPPED.</description></item>
                /// <item><description>12: REMOVED.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>-1: none<br/></description></item>
                /// <item><description>1: cron<br/></description></item>
                /// <item><description>3: fix_rate<br/></description></item>
                /// <item><description>5: one_time<br/></description></item>
                /// <item><description>100: api</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <para>The tokens consumed by the AI job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

                /// <summary>
                /// <para>The job trigger type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: unknown.</description></item>
                /// <item><description>1: schedule.</description></item>
                /// <item><description>2: rerun.</description></item>
                /// <item><description>3: api.</description></item>
                /// <item><description>4: user_retry.</description></item>
                /// <item><description>5: system_retry.</description></item>
                /// <item><description>6: manual.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

                /// <summary>
                /// <para>The machine on which the job instance runs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.1.9:9999/">http://192.168.1.9:9999/</a></para>
                /// </summary>
                [NameInMap("WorkAddr")]
                [Validation(Required=false)]
                public string WorkAddr { get; set; }

                /// <summary>
                /// <para>The workflow instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("WorkflowExecutionId")]
                [Validation(Required=false)]
                public string WorkflowExecutionId { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

                /// <summary>
                /// <para>The workflow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myWorkflow</para>
                /// </summary>
                [NameInMap("WorkflowName")]
                [Validation(Required=false)]
                public string WorkflowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;sessionId&quot;:&quot;ac21f9f6-5a88-4f97-abd1-b51989166035&quot;}</para>
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BCE89B3-E882-511D-9A75-D452A56EC4B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
