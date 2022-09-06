// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("ExportProgress")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupExportProgress ExportProgress { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupExportProgress : TeaModel {
                [NameInMap("FileHttpUrl")]
                [Validation(Required=false)]
                public string FileHttpUrl { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("JobDataParsingTaskId")]
            [Validation(Required=false)]
            public string JobDataParsingTaskId { get; set; }

            [NameInMap("JobFilePath")]
            [Validation(Required=false)]
            public string JobFilePath { get; set; }

            [NameInMap("JobGroupDescription")]
            [Validation(Required=false)]
            public string JobGroupDescription { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            [NameInMap("MinConcurrency")]
            [Validation(Required=false)]
            public long? MinConcurrency { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

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
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Cancelled")]
                [Validation(Required=false)]
                public int? Cancelled { get; set; }

                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupProgressCategories> Categories { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupProgressCategories : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("Executing")]
                [Validation(Required=false)]
                public int? Executing { get; set; }

                [NameInMap("Failed")]
                [Validation(Required=false)]
                public int? Failed { get; set; }

                [NameInMap("Paused")]
                [Validation(Required=false)]
                public int? Paused { get; set; }

                [NameInMap("Scheduling")]
                [Validation(Required=false)]
                public int? Scheduling { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCompleted")]
                [Validation(Required=false)]
                public int? TotalCompleted { get; set; }

                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                [NameInMap("TotalNotAnswered")]
                [Validation(Required=false)]
                public int? TotalNotAnswered { get; set; }

            }

            [NameInMap("RecallStrategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupRecallStrategy RecallStrategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupRecallStrategy : TeaModel {
                [NameInMap("EmptyNumberIgnore")]
                [Validation(Required=false)]
                public bool? EmptyNumberIgnore { get; set; }

                [NameInMap("InArrearsIgnore")]
                [Validation(Required=false)]
                public bool? InArrearsIgnore { get; set; }

                [NameInMap("OutOfServiceIgnore")]
                [Validation(Required=false)]
                public bool? OutOfServiceIgnore { get; set; }

            }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupResult Result { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupResult : TeaModel {
                [NameInMap("ClientHangupNum")]
                [Validation(Required=false)]
                public int? ClientHangupNum { get; set; }

                [NameInMap("FinishedNum")]
                [Validation(Required=false)]
                public int? FinishedNum { get; set; }

                [NameInMap("NoInteractNum")]
                [Validation(Required=false)]
                public int? NoInteractNum { get; set; }

                [NameInMap("TimeoutHangupNum")]
                [Validation(Required=false)]
                public int? TimeoutHangupNum { get; set; }

                [NameInMap("UnrecognizedNum")]
                [Validation(Required=false)]
                public int? UnrecognizedNum { get; set; }

            }

            [NameInMap("RingingDuration")]
            [Validation(Required=false)]
            public long? RingingDuration { get; set; }

            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public DescribeJobGroupResponseBodyJobGroupStrategy Strategy { get; set; }
            public class DescribeJobGroupResponseBodyJobGroupStrategy : TeaModel {
                [NameInMap("Customized")]
                [Validation(Required=false)]
                public string Customized { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("FollowUpStrategy")]
                [Validation(Required=false)]
                public string FollowUpStrategy { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("MaxAttemptsPerDay")]
                [Validation(Required=false)]
                public int? MaxAttemptsPerDay { get; set; }

                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                [NameInMap("RepeatBy")]
                [Validation(Required=false)]
                public string RepeatBy { get; set; }

                [NameInMap("RepeatDays")]
                [Validation(Required=false)]
                public List<string> RepeatDays { get; set; }

                [NameInMap("RoutingStrategy")]
                [Validation(Required=false)]
                public string RoutingStrategy { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("StrategyDescription")]
                [Validation(Required=false)]
                public string StrategyDescription { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkingTime")]
                [Validation(Required=false)]
                public List<DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime> WorkingTime { get; set; }
                public class DescribeJobGroupResponseBodyJobGroupStrategyWorkingTime : TeaModel {
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public string BeginTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
