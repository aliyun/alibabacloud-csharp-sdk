// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
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
        /// <para>The job group information.</para>
        /// </summary>
        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public DescribeJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class DescribeJobGroupResponseBodyJobGroup : TeaModel {
            /// <summary>
            /// <para>The list of calling numbers.</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The export progress.</para>
            /// <remarks>
            /// <para>This information is obtained from the ListJobGroups operation.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The file URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss-cn-shanghai.aliyuncs.com/xx.zip">https://oss-cn-shanghai.aliyuncs.com/xx.zip</a></para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The export progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The export status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The configuration parameters for flash SMS push in JSON format, including the configuration information of third-party flash SMS.</para>
            /// </summary>
            [NameInMap("FlashSmsExtras")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupFlashSmsExtras FlashSmsExtras { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupFlashSmsExtras : TeaModel {
                /// <summary>
                /// <para>The ID of the flash SMS configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bebe23e6e2604f50bbeb12900c07703d</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <para>The ID of the flash SMS template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e080d737-5c0b-4350-b7d4-1162530579e7</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> The ID of the job list parsing operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The OSS file key of the uploaded job list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            /// <summary>
            /// <para>The description of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection job group</para>
            /// </summary>
            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <para>The ID of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46a9ad0c-3e11-44da-a9a7-2c21bf5ce185</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The name of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection job group</para>
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
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The job progress.</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupProgress Progress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupProgress : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The business result information.</para>
                /// </summary>
                [NameInMap("Briefs")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressBriefs> Briefs { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressBriefs : TeaModel {
                    /// <summary>
                    /// <para>The name of the business result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the business result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The number of canceled jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cancelled")]
                [Validation(Required=false)]
                public int? Cancelled { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The statistics information in key-value format.</para>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
                    /// <summary>
                    /// <para>The name of the custom statistics information field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The custom statistics information value (IV).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para><b>[Deprecated]</b> The execution duration of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The number of executing jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Executing")]
                [Validation(Required=false)]
                public int? Executing { get; set; }

                /// <summary>
                /// <para>The number of failed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <para>The number of paused jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public int? Paused { get; set; }

                /// <summary>
                /// <para>The number of jobs being scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The start time of the execution. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The overall execution status of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total number of completed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                /// <summary>
                /// <para>The total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The total number of unanswered jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            /// <summary>
            /// <para>The list of calling numbers used for recall calls when the initial call fails. If not specified, it defaults to the primary calling number list.</para>
            /// </summary>
            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            /// <summary>
            /// <para>The redial strategy.</para>
            /// </summary>
            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to stop calling nonexistent numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <para>Specifies whether to stop calling numbers with overdue payments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <para>Specifies whether to stop calling out-of-service numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> The statistics information. This is a legacy parameter and is no longer provided.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupResult Result { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupResult : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The number of hang-ups by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClientHangupNum")]
                [Validation(Required=false)]
                public int? ClientHangupNum { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The number of completed jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The number of jobs without interaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoInteractNum")]
                [Validation(Required=false)]
                public int? NoInteractNum { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The number of hang-ups due to timeout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutHangupNum")]
                [Validation(Required=false)]
                public int? TimeoutHangupNum { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The number of unrecognized utterances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnrecognizedNum")]
                [Validation(Required=false)]
                public int? UnrecognizedNum { get; set; }

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
            /// <para>The scenario ID. This is a legacy canvas parameter. For the new canvas, the scenario ID is the same as the ScriptId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>The ID of the script scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The name of the script scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collection script</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The natural language understanding (NLU) engine used by the script.</para>
            /// </summary>
            [NameInMap("ScriptNluEngine")]
            [Validation(Required=false)]
            public string ScriptNluEngine { get; set; }

            /// <summary>
            /// <para>The version number of the script scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <para>The job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The execution strategy of the job.</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <para>The custom data of the strategy. This is a legacy parameter and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <para>The overall end time of the scheduling strategy. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579881227404</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The processing method after the execution cycle ends. This is a legacy parameter and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <para>Indicates whether the strategy is a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <para>The maximum number of calls per day when the call is not answered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <para>The interval for redialing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The repetition method of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                /// <summary>
                /// <para>The days for repeated execution. This parameter is used in combination with RepeatBy.</para>
                /// <list type="bullet">
                /// <item><description>If the repetition cycle is weekly, 0 indicates Sunday, and 1 to 6 indicate Monday to Saturday.  </description></item>
                /// <item><description>If the repetition cycle is monthly, 1 to 31 indicate the 1st to the 31st day of the month. The job is not executed in months that do not have the specified day. For example, if the 30th day is selected, the job is not executed in February.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                /// <summary>
                /// <para>Indicates whether the job is a recurring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Repeatable")]
                [Validation(Required=false)]
                public bool? Repeatable { get; set; }

                /// <summary>
                /// <para>The number routing strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <para>The overall start time of the strategy. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The description of the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection strategy</para>
                /// </summary>
                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <para>The ID of the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a2bff22c-2604-4df2-83d6-5952e2438c5a</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The name of the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection strategy name</para>
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
                /// <para>The working hours.</para>
                /// </summary>
                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <para>The start time. The format is HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
                    /// <para>The end time. The format is HH:mm:ss.</para>
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
        /// <para>The API message.</para>
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
