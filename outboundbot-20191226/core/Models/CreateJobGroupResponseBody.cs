// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Job information.</para>
        /// </summary>
        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public CreateJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class CreateJobGroupResponseBodyJobGroup : TeaModel {
            /// <summary>
            /// <para>List of calling numbers.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578550074361</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>Export progress.  </para>
            /// <remarks>
            /// <para>This field is deprecated in the current parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class CreateJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <para>File URL. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://***.oss-cn-shanghai.aliyuncs.com/sample</para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para>Progress. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>Job export status. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the asynchronous parsing operation in the backend corresponding to the uploaded job file.  </para>
            /// <remarks>
            /// <para>If empty, it is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>744ff448-2b4c-40d4-94ca-51f246905b0f</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para>OSS path of the job file.  </para>
            /// <remarks>
            /// <para>If empty, it is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED/JOB/b3865dc3-40fa-4afd-9fe4-dc7cda305a24/229eac13-379d-4abe-96e0-8cf026b56c0b_template (1).xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>Task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第一个的作业组</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c62e6789-28a8-41db-941e-171a01d3b3b9</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>Task Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第一个作业组</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>Concurrent guarantee value.<br>When the job starts, it guarantees a minimum of N concurrent instances.<br>The sum of concurrent guarantee values for jobs with the same priority must not exceed the instance concurrency limit.<br>If the concurrent guarantee value is set to 0, the system intelligently assigns available idle concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <para>Updated At.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Job group priority. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>Urgent</b>: Urgent job.  </description></item>
            /// <item><description><b>Daily</b>: Daily job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>List of recall calling numbers</para>
            /// </summary>
            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            /// <summary>
            /// <para>Redial policy.</para>
            /// </summary>
            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Do not make outbound calls to nonexistent numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <para>Do not make outbound calls to numbers with overdue payment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <para>Do not make outbound calls to numbers that are out of service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <para>Ringing duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            /// <summary>
            /// <para>Scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>Scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>话术</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>Script scenario version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628425608429</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>Task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Job scheduling policy.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public CreateJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class CreateJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <para>Custom policy data</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>End Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2209702074000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Post-execution handling method after the epoch ends (this field is deprecated).</para>
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
                /// <para>The maximum number of attempts per day when a call in the job fails to connect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>Calling interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>Repetition mode: &quot;once&quot; for no repetition, &quot;day&quot; for daily repetition, &quot;week&quot; for weekly repetition, and &quot;month&quot; for monthly repetition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>Days on which execution repeats.</para>
                /// <list type="bullet">
                /// <item><description>If the recurrence <b>RepeatBy</b> is set to <b>Week</b>, 0 represents Sunday, and 1–6 represent Monday through Saturday, respectively.</description></item>
                /// <item><description>If the recurrence <b>RepeatBy</b> is set to <b>Month</b>, values 1–31 represent the 1st through the 31st day of the month. Months that do not contain the specified date will not execute the task. For example, if the 30th is selected, the task will not run in February.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>Number routing policy.</para>
                /// <list type="bullet">
                /// <item><description>None: No special rule.</description></item>
                /// <item><description>LocalFirst: Local city numbers are prioritized.</description></item>
                /// <item><description>LocalProvinceFirst: Numbers from the same province are prioritized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>Start Time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578550074000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Policy Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收策略</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>Policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc9a436e-03b0-4ada-8364-77ec2290aa39</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>Policy Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收策略</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <para>Policy Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Time window for policy execution.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<CreateJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class CreateJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>End Time of the window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>Start Time of the window.</para>
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
        /// <para>Message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
