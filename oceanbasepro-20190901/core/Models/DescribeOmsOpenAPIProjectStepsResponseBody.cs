// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOmsOpenAPIProjectStepsResponseBody : TeaModel {
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOmsOpenAPIProjectStepsResponseBodyData> Data { get; set; }
        public class DescribeOmsOpenAPIProjectStepsResponseBodyData : TeaModel {
            [NameInMap("EstimatedRemainingSeconds")]
            [Validation(Required=false)]
            public long? EstimatedRemainingSeconds { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfo : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfoErrorDetails> ErrorDetails { get; set; }
                public class DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfoErrorDetails : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("ErrorParam")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorParam { get; set; }

                [NameInMap("FailedTime")]
                [Validation(Required=false)]
                public string FailedTime { get; set; }

            }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Interactive")]
            [Validation(Required=false)]
            public bool? Interactive { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StepDescription")]
            [Validation(Required=false)]
            public string StepDescription { get; set; }

            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfo StepInfo { get; set; }
            public class DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfo : TeaModel {
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                [NameInMap("ConnectorFullProgressOverview")]
                [Validation(Required=false)]
                public DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfoConnectorFullProgressOverview ConnectorFullProgressOverview { get; set; }
                public class DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfoConnectorFullProgressOverview : TeaModel {
                    [NameInMap("EstimatedRemainingTimeOfSec")]
                    [Validation(Required=false)]
                    public long? EstimatedRemainingTimeOfSec { get; set; }

                    [NameInMap("EstimatedTotalCount")]
                    [Validation(Required=false)]
                    public long? EstimatedTotalCount { get; set; }

                    [NameInMap("FinishedCount")]
                    [Validation(Required=false)]
                    public long? FinishedCount { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                }

                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public string DeployId { get; set; }

                [NameInMap("DstIops")]
                [Validation(Required=false)]
                public long? DstIops { get; set; }

                [NameInMap("DstRps")]
                [Validation(Required=false)]
                public long? DstRps { get; set; }

                [NameInMap("DstRpsRef")]
                [Validation(Required=false)]
                public long? DstRpsRef { get; set; }

                [NameInMap("DstRt")]
                [Validation(Required=false)]
                public long? DstRt { get; set; }

                [NameInMap("DstRtRef")]
                [Validation(Required=false)]
                public long? DstRtRef { get; set; }

                [NameInMap("Gmt")]
                [Validation(Required=false)]
                public long? Gmt { get; set; }

                [NameInMap("Inconsistencies")]
                [Validation(Required=false)]
                public long? Inconsistencies { get; set; }

                [NameInMap("IncrTimestampCheckpoint")]
                [Validation(Required=false)]
                public long? IncrTimestampCheckpoint { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("ProcessedRecords")]
                [Validation(Required=false)]
                public long? ProcessedRecords { get; set; }

                [NameInMap("Skipped")]
                [Validation(Required=false)]
                public bool? Skipped { get; set; }

                [NameInMap("SrcIops")]
                [Validation(Required=false)]
                public long? SrcIops { get; set; }

                [NameInMap("SrcIopsRef")]
                [Validation(Required=false)]
                public long? SrcIopsRef { get; set; }

                [NameInMap("SrcRps")]
                [Validation(Required=false)]
                public long? SrcRps { get; set; }

                [NameInMap("SrcRpsRef")]
                [Validation(Required=false)]
                public long? SrcRpsRef { get; set; }

                [NameInMap("SrcRt")]
                [Validation(Required=false)]
                public long? SrcRt { get; set; }

                [NameInMap("SrcRtRef")]
                [Validation(Required=false)]
                public long? SrcRtRef { get; set; }

                [NameInMap("Validated")]
                [Validation(Required=false)]
                public bool? Validated { get; set; }

            }

            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public int? StepProgress { get; set; }

            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeOmsOpenAPIProjectStepsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeOmsOpenAPIProjectStepsResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
