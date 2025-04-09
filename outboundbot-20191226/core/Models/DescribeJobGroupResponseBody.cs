// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("JobGroup")]
        [Validation(Required=false)]
        public DescribeJobGroupResponseBodyJobGroup JobGroup { get; set; }
        public class DescribeJobGroupResponseBodyJobGroup : TeaModel {
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://oss-cn-shanghai.aliyuncs.com/xx.zip">https://oss-cn-shanghai.aliyuncs.com/xx.zip</a></para>
                /// </summary>
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("FlashSmsExtras")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupFlashSmsExtras FlashSmsExtras { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupFlashSmsExtras : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>da37319b-6c83-4268-9f19-814aed62e401/a5a9a310-b902-4674-a6e1-29975cbaa312_100.xlsx</para>
            /// </summary>
            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>46a9ad0c-3e11-44da-a9a7-2c21bf5ce185</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578881227404</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupProgress Progress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupProgress : TeaModel {
                [NameInMap("Briefs")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressBriefs> Briefs { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressBriefs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cancelled")]
                [Validation(Required=false)]
                public int? Cancelled { get; set; }

                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Executing")]
                [Validation(Required=false)]
                public int? Executing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public int? Paused { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            [NameInMap("RecallCallingNumbers")]
            [Validation(Required=false)]
            public List<string> RecallCallingNumbers { get; set; }

            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupResult Result { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClientHangupNum")]
                [Validation(Required=false)]
                public int? ClientHangupNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoInteractNum")]
                [Validation(Required=false)]
                public int? NoInteractNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutHangupNum")]
                [Validation(Required=false)]
                public int? TimeoutHangupNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnrecognizedNum")]
                [Validation(Required=false)]
                public int? UnrecognizedNum { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49f00b0d-78ac-4d51-91de-a9e8e92b8470</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1579881227404</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                [NameInMap("Repeatable")]
                [Validation(Required=false)]
                public bool? Repeatable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LocalFirst</para>
                /// </summary>
                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578881227404</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a2bff22c-2604-4df2-83d6-5952e2438c5a</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Repeatable</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>09:00:00</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
