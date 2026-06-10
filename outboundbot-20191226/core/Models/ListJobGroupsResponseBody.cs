// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task. You can use this ID to query the status of the task.</para>
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
            /// <para>The list of job groups.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobGroupsResponseBodyJobGroupsList> List { get; set; }
            public class ListJobGroupsResponseBodyJobGroupsList : TeaModel {
                /// <summary>
                /// <para>The time when the job group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074361</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// <para>The progress of the export task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ExportProgress")]
                [Validation(Required=false)]
                public ListJobGroupsResponseBodyJobGroupsListExportProgress ExportProgress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListExportProgress : TeaModel {
                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.xxx.com/xxx">http://www.xxx.com/xxx</a></para>
                    /// </summary>
                    [NameInMap("FileHttpUrl")]
                    [Validation(Required=false)]
                    public string FileHttpUrl { get; set; }

                    /// <summary>
                    /// <para>The progress of the export task.</para>
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
                    /// <item><description><para><b>PENDING</b>: The task is pending.</para>
                    /// </description></item>
                    /// <item><description><para><b>IN_PROGRESS</b>: The task is in progress.</para>
                    /// </description></item>
                    /// <item><description><para><b>FINISHED</b>: The task is finished.</para>
                    /// </description></item>
                    /// <item><description><para><b>FAILED</b>: The task failed.</para>
                    /// </description></item>
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
                /// <para>The ID of the task that parses the job data file. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobDataParsingTaskId")]
                [Validation(Required=false)]
                public string JobDataParsingTaskId { get; set; }

                /// <summary>
                /// <para>The description of the job group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收的作业组</para>
                /// </summary>
                [NameInMap("JobGroupDescription")]
                [Validation(Required=false)]
                public string JobGroupDescription { get; set; }

                /// <summary>
                /// <para>The ID of the job group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>The name of the job group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收作业组</para>
                /// </summary>
                [NameInMap("JobGroupName")]
                [Validation(Required=false)]
                public string JobGroupName { get; set; }

                /// <summary>
                /// <para>The minimum number of concurrent calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinConcurrency")]
                [Validation(Required=false)]
                public int? MinConcurrency { get; set; }

                /// <summary>
                /// <para>The time when the job group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074361</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The progress of the job group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public ListJobGroupsResponseBodyJobGroupsListProgress Progress { get; set; }
                public class ListJobGroupsResponseBodyJobGroupsListProgress : TeaModel {
                    /// <summary>
                    /// <para>The number of canceled jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("CancelledNum")]
                    [Validation(Required=false)]
                    public int? CancelledNum { get; set; }

                    /// <summary>
                    /// <para>The total runtime. This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1578550074361</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>The number of running jobs.</para>
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
                    /// <para>The number of jobs that are being scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scheduling")]
                    [Validation(Required=false)]
                    public int? Scheduling { get; set; }

                    /// <summary>
                    /// <para>The start time. This parameter is deprecated.</para>
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
                    /// <para>The status of the job. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Draft</b>: The job is a draft.</para>
                    /// </description></item>
                    /// <item><description><para><b>Scheduling</b>: The job is being scheduled.</para>
                    /// </description></item>
                    /// <item><description><para><b>Executing</b>: The job is running.</para>
                    /// </description></item>
                    /// <item><description><para><b>Completed</b>: The job is completed.</para>
                    /// </description></item>
                    /// <item><description><para><b>Paused</b>: The job is paused.</para>
                    /// </description></item>
                    /// <item><description><para><b>Failed</b>: The job failed.</para>
                    /// </description></item>
                    /// <item><description><para><b>Cancelled</b>: The job is canceled.</para>
                    /// </description></item>
                    /// <item><description><para><b>Initializing</b>: The job is being initialized.</para>
                    /// </description></item>
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
                    /// <para>This parameter is deprecated.</para>
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
                /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The name of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>话术名称</para>
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
                /// <para>The status of the job group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Draft</b>: The job group is a draft.</para>
                /// </description></item>
                /// <item><description><para><b>Scheduling</b>: The job group is being scheduled.</para>
                /// </description></item>
                /// <item><description><para><b>Executing</b>: The job group is running.</para>
                /// </description></item>
                /// <item><description><para><b>Completed</b>: The job group is completed.</para>
                /// </description></item>
                /// <item><description><para><b>Paused</b>: The job group is paused.</para>
                /// </description></item>
                /// <item><description><para><b>Failed</b>: The job group failed.</para>
                /// </description></item>
                /// <item><description><para><b>Cancelled</b>: The job group is canceled.</para>
                /// </description></item>
                /// <item><description><para><b>Initializing</b>: The job group is being initialized.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The calling strategy. This parameter is deprecated.</para>
                /// <remarks>
                /// <para>To view the strategy for a job group, call the <c>DescribeJobGroup</c> operation.</para>
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
                    /// <para>The end time of the calling window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2209702074000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the calling window.</para>
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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: <c>true</c> and <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
