// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectFullVerifyResultResponseBody : TeaModel {
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
        public ListProjectFullVerifyResultResponseBodyData Data { get; set; }
        public class ListProjectFullVerifyResultResponseBodyData : TeaModel {
            [NameInMap("DifferentNumber")]
            [Validation(Required=false)]
            public long? DifferentNumber { get; set; }

            [NameInMap("FullVerifyTableStatistics")]
            [Validation(Required=false)]
            public List<ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatistics> FullVerifyTableStatistics { get; set; }
            public class ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatistics : TeaModel {
                [NameInMap("ConsistentCount")]
                [Validation(Required=false)]
                public long? ConsistentCount { get; set; }

                [NameInMap("DestOnlyCount")]
                [Validation(Required=false)]
                public long? DestOnlyCount { get; set; }

                [NameInMap("DestSchemaName")]
                [Validation(Required=false)]
                public string DestSchemaName { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatisticsErrorDetails> ErrorDetails { get; set; }
                public class ListProjectFullVerifyResultResponseBodyDataFullVerifyTableStatisticsErrorDetails : TeaModel {
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

                [NameInMap("MismatchedCount")]
                [Validation(Required=false)]
                public long? MismatchedCount { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("ResultDesc")]
                [Validation(Required=false)]
                public string ResultDesc { get; set; }

                [NameInMap("ResultType")]
                [Validation(Required=false)]
                public string ResultType { get; set; }

                [NameInMap("SourceOnlyCount")]
                [Validation(Required=false)]
                public long? SourceOnlyCount { get; set; }

                [NameInMap("SourceSchemaName")]
                [Validation(Required=false)]
                public string SourceSchemaName { get; set; }

                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListProjectFullVerifyResultResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListProjectFullVerifyResultResponseBodyErrorDetail : TeaModel {
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
