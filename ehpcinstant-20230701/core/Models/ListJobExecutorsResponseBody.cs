// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobExecutorsResponseBody : TeaModel {
        /// <summary>
        /// <para>Statistics about executor statuses.</para>
        /// </summary>
        [NameInMap("ExecutorStatus")]
        [Validation(Required=false)]
        public ListJobExecutorsResponseBodyExecutorStatus ExecutorStatus { get; set; }
        public class ListJobExecutorsResponseBodyExecutorStatus : TeaModel {
            /// <summary>
            /// <para>The number of executors in the Deleted state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            /// <summary>
            /// <para>The number of executors in the Exception state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public int? Exception { get; set; }

            /// <summary>
            /// <para>The number of executors in the Failed state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            /// <summary>
            /// <para>The number of executors in the Initing state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Initing")]
            [Validation(Required=false)]
            public int? Initing { get; set; }

            /// <summary>
            /// <para>The number of executors in the Pending state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pending")]
            [Validation(Required=false)]
            public int? Pending { get; set; }

            /// <summary>
            /// <para>The number of executors in the Restarting state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Restarting")]
            [Validation(Required=false)]
            public int? Restarting { get; set; }

            /// <summary>
            /// <para>The number of executors in the Running state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Running")]
            [Validation(Required=false)]
            public int? Running { get; set; }

            /// <summary>
            /// <para>The number of executors in the Succeeded state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

            /// <summary>
            /// <para>The number of executors in the Suspended state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Suspended")]
            [Validation(Required=false)]
            public int? Suspended { get; set; }

        }

        /// <summary>
        /// <para>A list of executors.</para>
        /// </summary>
        [NameInMap("Executors")]
        [Validation(Required=false)]
        public List<ListJobExecutorsResponseBodyExecutors> Executors { get; set; }
        public class ListJobExecutorsResponseBodyExecutors : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// <list type="bullet">
            /// <item><description><para>Standard: Standard.</para>
            /// </description></item>
            /// <item><description><para>Dedicated: Dedicated. To use this resource type, you must be added to the whitelist.</para>
            /// </description></item>
            /// <item><description><para>Economic: Economy. To use this resource type, you must be added to the whitelist.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            /// <summary>
            /// <para>The index of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ArrayIndex")]
            [Validation(Required=false)]
            public int? ArrayIndex { get; set; }

            /// <summary>
            /// <para>The retention period of the compute resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BlockDuration")]
            [Validation(Required=false)]
            public int? BlockDuration { get; set; }

            /// <summary>
            /// <para>The time when the executor was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the executor ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:18</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the executor. The format is \<c>JobId-TaskName-ArrayIndex\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx-Task0-1</para>
            /// </summary>
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>A list of public IP addresses of the nodes.</para>
            /// </summary>
            [NameInMap("ExternalIpAddress")]
            [Validation(Required=false)]
            public List<string> ExternalIpAddress { get; set; }

            /// <summary>
            /// <para>An array of node hostnames.</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public List<string> HostName { get; set; }

            /// <summary>
            /// <para>A list of node IP addresses.</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            [NameInMap("Preemptible")]
            [Validation(Required=false)]
            public bool? Preemptible { get; set; }

            /// <summary>
            /// <para>The time when the executor started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:13</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the executor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: In queue</para>
            /// </description></item>
            /// <item><description><para>Initing: Initializing</para>
            /// </description></item>
            /// <item><description><para>Succeed: Succeeded</para>
            /// </description></item>
            /// <item><description><para>Failed: Failed</para>
            /// </description></item>
            /// <item><description><para>Running: Running</para>
            /// </description></item>
            /// <item><description><para>Exception: Abnormal scheduling</para>
            /// </description></item>
            /// <item><description><para>Retrying: Retrying</para>
            /// </description></item>
            /// <item><description><para>Expired: Timed out</para>
            /// </description></item>
            /// <item><description><para>Suspended: Job hibernating</para>
            /// </description></item>
            /// <item><description><para>Restarting: Job restarting</para>
            /// </description></item>
            /// <item><description><para>Deleted: Deleted</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExecutorReady</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>A list of executor tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListJobExecutorsResponseBodyExecutorsTags> Tags { get; set; }
            public class ListJobExecutorsResponseBodyExecutorsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-xxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        /// <para>The number of entries on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task0</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
