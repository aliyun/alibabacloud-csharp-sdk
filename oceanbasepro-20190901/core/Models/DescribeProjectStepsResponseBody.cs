// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectStepsResponseBody : TeaModel {
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
        public List<DescribeProjectStepsResponseBodyData> Data { get; set; }
        public class DescribeProjectStepsResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeProjectStepsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeProjectStepsResponseBodyDataExtraInfo : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectStepsResponseBodyDataExtraInfoErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectStepsResponseBodyDataExtraInfoErrorDetails : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

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

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> StepInfo { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeProjectStepsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeProjectStepsResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

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
