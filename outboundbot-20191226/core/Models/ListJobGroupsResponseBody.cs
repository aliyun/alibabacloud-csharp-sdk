// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous query. If the query is asynchronous, you can use this ID to obtain the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6243d904-939d-42ce-a8e4-886a139e77a3</para>
        /// </summary>
        [NameInMap("AsyncTaskId")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
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
        public ListJobGroupsResponseBodyJobGroups JobGroups { get; set; }
        public class ListJobGroupsResponseBodyJobGroups : TeaModel {
            /// <summary>
            /// <para>The array.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobGroupsResponseBodyJobGroupsList> List { get; set; }
            public class ListJobGroupsResponseBodyJobGroupsList : TeaModel {
                /// <summary>
                /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074361</para>
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
                public ListJobGroupsResponseBodyJobGroupsListExportProgress ExportProgress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListExportProgress : TeaModel {
                    /// <summary>
                    /// <para><b>[Deprecated]</b></para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The status of the export task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>PENDING</b>: Pending.</description></item>
                    /// <item><description><b>IN_PROGRESS</b>: In progress.</description></item>
                    /// <item><description><b>FINISHED</b>: Finished.</description></item>
                    /// <item><description><b>FAILED</b>: Failed.</description></item>
                    /// </list>
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
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobDataParsingTaskId")]
                [Validation(Required=false)]
                public string JobDataParsingTaskId { get; set; }

                /// <summary>
                /// <para>The job group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection job group</para>
                /// </summary>
                [NameInMap("JobGroupDescription")]
                [Validation(Required=false)]
                public string JobGroupDescription { get; set; }

                /// <summary>
                /// <para>The job group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>The job group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection job group</para>
                /// </summary>
                [NameInMap("JobGroupName")]
                [Validation(Required=false)]
                public string JobGroupName { get; set; }

                /// <summary>
                /// <para>The number of valid tasks with a minimum concurrency guarantee.</para>
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
                /// <para>1578550074361</para>
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
                public ListJobGroupsResponseBodyJobGroupsListProgress Progress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListProgress : TeaModel {
                    /// <summary>
                    /// <para>The number of cancelled jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("CancelledNum")]
                    [Validation(Required=false)]
                    public int? CancelledNum { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The total execution duration up to the current time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1578550074361</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The number of executing jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("ExecutingNum")]
                    [Validation(Required=false)]
                    public int? ExecutingNum { get; set; }

                    /// <summary>
                    /// <para>The number of failed jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("FailedNum")]
                    [Validation(Required=false)]
                    public int? FailedNum { get; set; }

                    /// <summary>
                    /// <para>The number of paused jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PausedNum")]
                    [Validation(Required=false)]
                    public int? PausedNum { get; set; }

                    /// <summary>
                    /// <para>The number of jobs being scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scheduling")]
                    [Validation(Required=false)]
                    public int? Scheduling { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The start time. This value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1578550074361</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para>This parameter is no longer returned.</para>
                    /// </remarks>
                    /// <para>The execution status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Draft</b>: Draft.</description></item>
                    /// <item><description><b>Scheduling</b>: Scheduling.</description></item>
                    /// <item><description><b>Executing</b>: Executing.</description></item>
                    /// <item><description><b>Completed</b>: Completed.</description></item>
                    /// <item><description><b>Paused</b>: Paused.</description></item>
                    /// <item><description><b>Failed</b>: Failed.</description></item>
                    /// <item><description><b>Cancelled</b>: Cancelled.</description></item>
                    /// <item><description><b>Initializing</b>: Initializing.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scheduling</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The number of completed jobs up to the current time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalCompleted")]
                    [Validation(Required=false)]
                    public int? TotalCompleted { get; set; }

                    /// <summary>
                    /// <para>The total number of jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("TotalJobs")]
                    [Validation(Required=false)]
                    public int? TotalJobs { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalNotAnswered")]
                    [Validation(Required=false)]
                    public int? TotalNotAnswered { get; set; }

                }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The script name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Script name</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The script version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d9e828ac-744b-4dd3-848a-17a3da9167b8</para>
                /// </summary>
                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

                /// <summary>
                /// <para>The execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Draft</b>: Draft.</description></item>
                /// <item><description><b>Scheduling</b>: Scheduling.</description></item>
                /// <item><description><b>Executing</b>: Executing.</description></item>
                /// <item><description><b>Completed</b>: Completed.</description></item>
                /// <item><description><b>Paused</b>: Paused.</description></item>
                /// <item><description><b>Failed</b>: Failed.</description></item>
                /// <item><description><b>Cancelled</b>: Cancelled.</description></item>
                /// <item><description><b>Initializing</b>: Initializing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The strategy.</para>
                /// <remarks>
                /// <para>To view the job strategy information, call the DescribeJobGroup operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public ListJobGroupsResponseBodyJobGroupsListStrategy Strategy { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListStrategy : TeaModel {
                    /// <summary>
                    /// <para>The end time of the strategy. This value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2209702074000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the strategy. This value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1578550074000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>The total number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCallNum")]
                [Validation(Required=false)]
                public int? TotalCallNum { get; set; }

            }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
