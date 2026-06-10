// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
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
        public DescribeJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class DescribeJobGroupResponseBodyJobGroup : TeaModel {
            /// <summary>
            /// <para>Caller number list.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>Export progress. This field is deprecated.</para>
            /// <remarks>
            /// <para>Get this information from the ListJobGroups API instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <para>File URL. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss-cn-shanghai.aliyuncs.com/xx.zip">https://oss-cn-shanghai.aliyuncs.com/xx.zip</a></para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para>Export progress. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>Export status. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Configuration parameters for flash SMS delivery. This is a JSON object that contains third-party flash SMS configuration details.</para>
            /// </summary>
            [NameInMap("FlashSmsExtras")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupFlashSmsExtras FlashSmsExtras { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupFlashSmsExtras : TeaModel {
                /// <summary>
                /// <para>Flash SMS configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bebe23e6e2604f50bbeb12900c07703d</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <para>Flash SMS template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e080d737-5c0b-4350-b7d4-1162530579e7</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

            /// <summary>
            /// <para>Job list parsing task ID. This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para>OSS file key for the uploaded job list. This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>Job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收作业组</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>Job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46a9ad0c-3e11-44da-a9a7-2c21bf5ce185</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>Job group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收作业组</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>Minimum concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>Job progress.</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupProgress Progress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupProgress : TeaModel {
                /// <summary>
                /// <para>Business result information. This field is deprecated.</para>
                /// </summary>
                [NameInMap("Briefs")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressBriefs> Briefs { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressBriefs : TeaModel {
                    /// <summary>
                    /// <para>Business result name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Business result value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Number of cancelled jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cancelled")]
                [Validation(Required=false)]
                public int? Cancelled { get; set; }

                /// <summary>
                /// <para>Statistics in key-value format. This field is deprecated.</para>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
                    /// <summary>
                    /// <para>Custom statistics field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Custom statistics value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Job execution time. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>Number of jobs in execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Executing")]
                [Validation(Required=false)]
                public int? Executing { get; set; }

                /// <summary>
                /// <para>Number of failed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <para>Number of paused jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public int? Paused { get; set; }

                /// <summary>
                /// <para>Number of jobs being scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                /// <summary>
                /// <para>Start time of execution. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Overall job execution status. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Total number of completed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                /// <summary>
                /// <para>Total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <para>This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            /// <summary>
            /// <para>Caller number list for redials. These numbers are used only when the first call fails. If not specified, the system uses the main caller number list.</para>
            /// </summary>
            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            /// <summary>
            /// <para>Redial strategy.</para>
            /// </summary>
            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Do not dial nonexistent numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <para>Do not dial numbers with overdue payments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <para>Do not dial out-of-service numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <para>Statistics. This is a legacy parameter and is no longer provided. This field is deprecated.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupResult Result { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupResult : TeaModel {
                /// <summary>
                /// <para>Number of calls hung up by the customer. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClientHangupNum")]
                [Validation(Required=false)]
                public int? ClientHangupNum { get; set; }

                /// <summary>
                /// <para>Number of completed jobs. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                /// <summary>
                /// <para>Number of calls with no interaction. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoInteractNum")]
                [Validation(Required=false)]
                public int? NoInteractNum { get; set; }

                /// <summary>
                /// <para>Number of calls hung up due to timeout. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutHangupNum")]
                [Validation(Required=false)]
                public int? TimeoutHangupNum { get; set; }

                /// <summary>
                /// <para>Number of unrecognized responses. This field is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnrecognizedNum")]
                [Validation(Required=false)]
                public int? UnrecognizedNum { get; set; }

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
            /// <para>Scenario ID. This is a legacy canvas parameter. For new canvases, this value is the same as ScriptId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>Script scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Script scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>催收话术</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("ScriptNluEngine")]
            [Validation(Required=false)]
            public string ScriptNluEngine { get; set; }

            /// <summary>
            /// <para>Script scenario version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>Job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Job execution strategy.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <para>Custom data for the strategy. This is a legacy parameter and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>End time of the scheduling strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579881227404</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Action to take after the execution period ends. This is a legacy parameter and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>Maximum number of calls per day when the call is not answered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>Minimum interval between retry attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>Job repetition method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>Days on which the job repeats. Use with RepeatBy.</para>
                /// <list type="bullet">
                /// <item><description><para>If the recurrence is weekly, 0 means Sunday, and 1–6 mean Monday through Saturday.</para>
                /// </description></item>
                /// <item><description><para>If the recurrence is monthly, 1–31 mean the 1st through 31st days of the month. Months without the specified day skip the job. For example, if you select the 30th, February skips it.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a recurring job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Repeatable")]
                [Validation(Required=false)]
                public bool? Repeatable { get; set; }

                /// <summary>
                /// <para>Phone number routing policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>Start time of the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Strategy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收策略</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>Strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a2bff22c-2604-4df2-83d6-5952e2438c5a</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>Strategy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>催收策略名字</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <para>Strategy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Working hours.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>End time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>End time.</para>
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
        /// <para>API message.</para>
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
        /// <para>Indicates whether the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
