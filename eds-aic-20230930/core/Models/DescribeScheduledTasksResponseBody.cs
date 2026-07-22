// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeScheduledTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token that indicates the position from which to start reading. Leave this parameter empty to read from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A51B1DF-96FF-3BCC-B08C-783161D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scheduled tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeScheduledTasksResponseBodyTasks> Tasks { get; set; }
        public class DescribeScheduledTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 * * *</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-12T10:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The list of associated instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The last execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-12T00:00:00</para>
            /// </summary>
            [NameInMap("LastExecutionAt")]
            [Validation(Required=false)]
            public string LastExecutionAt { get; set; }

            /// <summary>
            /// <para>The next execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-13T00:00:00</para>
            /// </summary>
            [NameInMap("NextExecutionAt")]
            [Validation(Required=false)]
            public string NextExecutionAt { get; set; }

            /// <summary>
            /// <para>The run configuration.</para>
            /// </summary>
            [NameInMap("RunConfig")]
            [Validation(Required=false)]
            public DescribeScheduledTasksResponseBodyTasksRunConfig RunConfig { get; set; }
            public class DescribeScheduledTasksResponseBodyTasksRunConfig : TeaModel {
                /// <summary>
                /// <para>The extra parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;batchSize&quot;:&quot;1000&quot;}</para>
                /// </summary>
                [NameInMap("ExtraParams")]
                [Validation(Required=false)]
                public string ExtraParams { get; set; }

                /// <summary>
                /// <para>The maximum number of steps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxSteps")]
                [Validation(Required=false)]
                public int? MaxSteps { get; set; }

                /// <summary>
                /// <para>The timeout period, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            /// <summary>
            /// <para>The scheduled task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sch-260705-agb*****</para>
            /// </summary>
            [NameInMap("ScheduledId")]
            [Validation(Required=false)]
            public string ScheduledId { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tsk-260615-*****</para>
            /// </summary>
            [NameInMap("TaskConfigId")]
            [Validation(Required=false)]
            public string TaskConfigId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily data synchronization task.</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The total number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalExecutions")]
            [Validation(Required=false)]
            public long? TotalExecutions { get; set; }

            /// <summary>
            /// <para>The total number of failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalFailures")]
            [Validation(Required=false)]
            public long? TotalFailures { get; set; }

            /// <summary>
            /// <para>The user prompt or task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execute daily data synchronization task.</para>
            /// </summary>
            [NameInMap("UserPrompt")]
            [Validation(Required=false)]
            public string UserPrompt { get; set; }

            /// <summary>
            /// <para>The CAS version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
