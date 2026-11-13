// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupResponseBody : TeaModel {
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
        /// <para>The job information.</para>
        /// </summary>
        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public CreateJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class CreateJobGroupResponseBodyJobGroup : TeaModel {
            /// <summary>
            /// <para>The list of caller numbers.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578550074361</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The export progress.</para>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class CreateJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://***.oss-cn-shanghai.aliyuncs.com/sample</para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The job export status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the background asynchronous parsing operation corresponding to the uploaded job file.</para>
            /// <remarks>
            /// <para>If no value exists, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>744ff448-2b4c-40d4-94ca-51f246905b0f</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para>The OSS path of the job file.</para>
            /// <remarks>
            /// <para>If no value exists, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED/JOB/b3865dc3-40fa-4afd-9fe4-dc7cda305a24/229eac13-379d-4abe-96e0-8cf026b56c0b_template (1).xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>First job group</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>First job group</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>The guaranteed concurrency value.
            /// When the job starts, a minimum of N concurrent calls are guaranteed.
            /// The sum of guaranteed concurrency values for jobs of the same priority cannot exceed the instance concurrency.
            /// If the guaranteed concurrency value is set to 0, the system intelligently allocates idle concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The job group priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Urgent</b>: urgent job.</description></item>
            /// <item><description><b>Daily</b>: daily job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The list of caller numbers for recall.</para>
            /// </summary>
            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            /// <summary>
            /// <para>The recall strategy.</para>
            /// </summary>
            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to skip nonexistent numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip numbers with overdue payments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip suspended numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <para>The ringing duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Script</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>The job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job scheduling strategy.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <para>The custom strategy data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2209702074000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The follow-up processing method after the execution cycle ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTINUE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <para>Indicates whether it is a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The maximum number of call attempts per day when calls are not connected in the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>The call interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The recurrence type. Valid values: once (no recurrence), day (daily recurrence), week (weekly recurrence), and month (monthly recurrence).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>The execution days for recurrence.</para>
                /// <list type="bullet">
                /// <item><description>If the <b>RepeatBy</b> recurrence type is <b>week</b>, 0 indicates Sunday, and 1 to 6 indicate Monday to Saturday.</description></item>
                /// <item><description>If the <b>RepeatBy</b> recurrence type is <b>month</b>, 1 to 31 indicate the 1st to the 31st day. Months without the specified date are not executed. For example, if the 30th is selected, the job is not executed in February.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>The number routing strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: no special rules.</description></item>
                /// <item><description>LocalFirst: local city numbers first.</description></item>
                /// <item><description>LocalProvinceFirst: local province numbers first.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The strategy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection strategy</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>The strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc9a436e-03b0-4ada-8364-77ec2290aa39</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The strategy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection strategy</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <para>The strategy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The strategy execution time window.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<CreateJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>The start time of the window. Format: HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The end time of the window. Format: HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The message.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
