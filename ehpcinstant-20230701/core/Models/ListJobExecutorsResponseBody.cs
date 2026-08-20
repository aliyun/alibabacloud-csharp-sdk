// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobExecutorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The executor status statistics.</para>
        /// </summary>
        [NameInMap("ExecutorStatus")]
        [Validation(Required=false)]
        public ListJobExecutorsResponseBodyExecutorStatus ExecutorStatus { get; set; }
        public class ListJobExecutorsResponseBodyExecutorStatus : TeaModel {
            /// <summary>
            /// <para>The number of executors in the deleted state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            /// <summary>
            /// <para>The number of executors in the exception state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public int? Exception { get; set; }

            /// <summary>
            /// <para>The number of executors in the failed state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            /// <summary>
            /// <para>The number of executors in the initializing state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Initing")]
            [Validation(Required=false)]
            public int? Initing { get; set; }

            /// <summary>
            /// <para>The number of executors in the queued state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pending")]
            [Validation(Required=false)]
            public int? Pending { get; set; }

            /// <summary>
            /// <para>The number of executors in the restarting state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Restarting")]
            [Validation(Required=false)]
            public int? Restarting { get; set; }

            /// <summary>
            /// <para>The number of executors in the running state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Running")]
            [Validation(Required=false)]
            public int? Running { get; set; }

            /// <summary>
            /// <para>The number of executors in the succeeded state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

            /// <summary>
            /// <para>The number of executors in the hibernation state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Suspended")]
            [Validation(Required=false)]
            public int? Suspended { get; set; }

        }

        /// <summary>
        /// <para>The list of executors.</para>
        /// </summary>
        [NameInMap("Executors")]
        [Validation(Required=false)]
        public List<ListJobExecutorsResponseBodyExecutors> Executors { get; set; }
        public class ListJobExecutorsResponseBodyExecutors : TeaModel {
            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard.</description></item>
            /// <item><description>Dedicated: dedicated. You must be added to the whitelist to use this type.</description></item>
            /// <item><description>Economic: economy. You must be added to the whitelist to use this type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            /// <summary>
            /// <para>The array index of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ArrayIndex")]
            [Validation(Required=false)]
            public int? ArrayIndex { get; set; }

            /// <summary>
            /// <para>The retention duration of compute resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BlockDuration")]
            [Validation(Required=false)]
            public int? BlockDuration { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:18</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The executor ID. The format is JobId-TaskName-ArrayIndex.</para>
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
            /// <para>The list of node public IP addresses.</para>
            /// </summary>
            [NameInMap("ExternalIpAddress")]
            [Validation(Required=false)]
            public List<string> ExternalIpAddress { get; set; }

            /// <summary>
            /// <para>The array of node hostnames.</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public List<string> HostName { get; set; }

            /// <summary>
            /// <para>The list of node IP addresses.</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            [NameInMap("Preemptible")]
            [Validation(Required=false)]
            public bool? Preemptible { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:13</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The executor status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: queued.</description></item>
            /// <item><description>Initing: initializing.</description></item>
            /// <item><description>Succeed: succeeded.</description></item>
            /// <item><description>Failed: failed.</description></item>
            /// <item><description>Running: running.</description></item>
            /// <item><description>Exception: scheduling exception.</description></item>
            /// <item><description>Retrying: retrying.</description></item>
            /// <item><description>Expired: timed out.</description></item>
            /// <item><description>Suspended: in hibernation.</description></item>
            /// <item><description>Restarting: restarting.</description></item>
            /// <item><description>Deleted: deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the status reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExecutorReady</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The list of executor tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListJobExecutorsResponseBodyExecutorsTags> Tags { get; set; }
            public class ListJobExecutorsResponseBodyExecutorsTags : TeaModel {
                /// <summary>
                /// <para>The executor tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The executor tag value.</para>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
