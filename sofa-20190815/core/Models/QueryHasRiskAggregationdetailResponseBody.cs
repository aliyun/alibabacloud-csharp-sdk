// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasRiskAggregationdetailResponseBody : TeaModel {
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
        public QueryHasRiskAggregationdetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasRiskAggregationdetailResponseBodyResultContent : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryHasRiskAggregationdetailResponseBodyResultContentData Data { get; set; }
            public class QueryHasRiskAggregationdetailResponseBodyResultContentData : TeaModel {
                [NameInMap("Cell")]
                [Validation(Required=false)]
                public string Cell { get; set; }

                [NameInMap("CellId")]
                [Validation(Required=false)]
                public string CellId { get; set; }

                [NameInMap("CloseComment")]
                [Validation(Required=false)]
                public string CloseComment { get; set; }

                [NameInMap("Deadline")]
                [Validation(Required=false)]
                public string Deadline { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FirstRiskTime")]
                [Validation(Required=false)]
                public string FirstRiskTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("InspectPluginId")]
                [Validation(Required=false)]
                public string InspectPluginId { get; set; }

                [NameInMap("InspectPluginName")]
                [Validation(Required=false)]
                public string InspectPluginName { get; set; }

                [NameInMap("InspectPluginType")]
                [Validation(Required=false)]
                public string InspectPluginType { get; set; }

                [NameInMap("LatestRiskTime")]
                [Validation(Required=false)]
                public string LatestRiskTime { get; set; }

                [NameInMap("Resolver")]
                [Validation(Required=false)]
                public string Resolver { get; set; }

                [NameInMap("RiskFrequency")]
                [Validation(Required=false)]
                public long? RiskFrequency { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

                [NameInMap("RiskSource")]
                [Validation(Required=false)]
                public string RiskSource { get; set; }

                [NameInMap("RiskStatus")]
                [Validation(Required=false)]
                public string RiskStatus { get; set; }

                [NameInMap("RiskTarget")]
                [Validation(Required=false)]
                public string RiskTarget { get; set; }

                [NameInMap("RiskTargetName")]
                [Validation(Required=false)]
                public string RiskTargetName { get; set; }

                [NameInMap("RiskTargetType")]
                [Validation(Required=false)]
                public string RiskTargetType { get; set; }

                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

                [NameInMap("WorkspaceGroup")]
                [Validation(Required=false)]
                public string WorkspaceGroup { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                [NameInMap("ActionLogs")]
                [Validation(Required=false)]
                public List<QueryHasRiskAggregationdetailResponseBodyResultContentDataActionLogs> ActionLogs { get; set; }
                public class QueryHasRiskAggregationdetailResponseBodyResultContentDataActionLogs : TeaModel {
                    [NameInMap("RiskItemId")]
                    [Validation(Required=false)]
                    public string RiskItemId { get; set; }

                    [NameInMap("ActionTime")]
                    [Validation(Required=false)]
                    public string ActionTime { get; set; }

                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                }

                [NameInMap("RiskOrders")]
                [Validation(Required=false)]
                public List<QueryHasRiskAggregationdetailResponseBodyResultContentDataRiskOrders> RiskOrders { get; set; }
                public class QueryHasRiskAggregationdetailResponseBodyResultContentDataRiskOrders : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("AggregateStatus")]
                    [Validation(Required=false)]
                    public string AggregateStatus { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    [NameInMap("NotExist")]
                    [Validation(Required=false)]
                    public bool? NotExist { get; set; }

                }

                [NameInMap("AdditionalInfo")]
                [Validation(Required=false)]
                public QueryHasRiskAggregationdetailResponseBodyResultContentDataAdditionalInfo AdditionalInfo { get; set; }
                public class QueryHasRiskAggregationdetailResponseBodyResultContentDataAdditionalInfo : TeaModel {
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
                };

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasRiskAggregationdetailResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasRiskAggregationdetailResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasRiskAggregationdetailResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasRiskAggregationdetailResponseBodyResultContentTopErrorReason : TeaModel {
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
