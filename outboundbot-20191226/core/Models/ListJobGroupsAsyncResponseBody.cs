// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The list of job groups.</para>
        /// </summary>
        [NameInMap("JobGroups")]
        [Validation(Required=false)]
        public List<ListJobGroupsAsyncResponseBodyJobGroups> JobGroups { get; set; }
        public class ListJobGroupsAsyncResponseBodyJobGroups : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640316786259</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The export progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsExportProgress ExportProgress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsExportProgress : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.xxx.com/xxx">http://www.xxx.com/xxx</a></para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para>The progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> The ID of the jobFile parsing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para>The description of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>The ID of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The name of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>The minimum concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public int? MinConcurrency { get; set; }

            /// <summary>
            /// <para>The modification time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640316786259</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The node statistics information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsProgress Progress { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsProgress : TeaModel {
                /// <summary>
                /// <para>The number of canceled jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The total execution duration up to the current time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The number of jobs being executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                /// <summary>
                /// <para>The number of failed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <para>The number of paused jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                /// <summary>
                /// <para>The number of jobs being scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Draft: The job group is a draft.</description></item>
                /// <item><description>Scheduling: The job group is being scheduled.</description></item>
                /// <item><description>Executing: The job group is being executed.</description></item>
                /// <item><description>Completed: The job group is completed.</description></item>
                /// <item><description>Paused: The job group is paused.</description></item>
                /// <item><description>Failed: The job group failed.</description></item>
                /// <item><description>Cancelled: The job group is canceled.</description></item>
                /// <item><description>Initializing: The job group is being initialized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduling</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of completed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                /// <summary>
                /// <para>The total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The number of unanswered jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The version of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>The status of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The strategy.</para>
            /// <remarks>
            /// <para>To view the strategy information of the job group, call the DescribeJobGroup operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public ListJobGroupsAsyncResponseBodyJobGroupsStrategy Strategy { get; set; }
            public class ListJobGroupsAsyncResponseBodyJobGroupsStrategy : TeaModel {
                /// <summary>
                /// <para>The end time of the strategy. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the strategy. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640316786259</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCallNum")]
            [Validation(Required=false)]
            public int? TotalCallNum { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
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

        /// <summary>
        /// <para>Indicates whether the request timed out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public bool? Timeout { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Vaild")]
        [Validation(Required=false)]
        public bool? Vaild { get; set; }

    }

}
