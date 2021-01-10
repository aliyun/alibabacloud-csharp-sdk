// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasRiskItemResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryHasRiskItemResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasRiskItemResponseBodyResultContent : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryHasRiskItemResponseBodyResultContentData> Data { get; set; }
            public class QueryHasRiskItemResponseBodyResultContentData : TeaModel {
                public string AggregationRiskItemId { get; set; }
                public string CellId { get; set; }
                public string CloseComment { get; set; }
                public string Deadline { get; set; }
                public string Description { get; set; }
                public string Resolver { get; set; }
                public string RiskEvent { get; set; }
                public string RiskLevel { get; set; }
                public string RiskName { get; set; }
                public string RiskSource { get; set; }
                public string RiskStatus { get; set; }
                public string RiskTarget { get; set; }
                public string RiskTargetName { get; set; }
                public string RiskTargetType { get; set; }
                public string RiskTime { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string TenantId { get; set; }
                public QueryHasRiskItemResponseBodyResultContentDataAdditionalInfo AdditionalInfo { get; set; }
                public class QueryHasRiskItemResponseBodyResultContentDataAdditionalInfo : TeaModel {
                    [NameInMap("ExecutionId")]
                    [Validation(Required=false)]
                    public string ExecutionId { get; set; }

                    [NameInMap("InspectRiskId")]
                    [Validation(Required=false)]
                    public string InspectRiskId { get; set; }

                    [NameInMap("PluginType")]
                    [Validation(Required=false)]
                    public string PluginType { get; set; }

                    [NameInMap("RiskInfo")]
                    [Validation(Required=false)]
                    public string RiskInfo { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasRiskItemResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasRiskItemResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public QueryHasRiskItemResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasRiskItemResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
