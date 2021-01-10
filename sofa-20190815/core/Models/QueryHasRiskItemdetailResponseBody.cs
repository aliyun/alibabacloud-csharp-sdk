// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasRiskItemdetailResponseBody : TeaModel {
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
        public QueryHasRiskItemdetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasRiskItemdetailResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryHasRiskItemdetailResponseBodyResultContentData Data { get; set; }
            public class QueryHasRiskItemdetailResponseBodyResultContentData : TeaModel {
                [NameInMap("AdditionalInfo")]
                [Validation(Required=false)]
                public string AdditionalInfo { get; set; }

                [NameInMap("AggregationRiskItemId")]
                [Validation(Required=false)]
                public string AggregationRiskItemId { get; set; }

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

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Resolver")]
                [Validation(Required=false)]
                public string Resolver { get; set; }

                [NameInMap("RiskEvent")]
                [Validation(Required=false)]
                public string RiskEvent { get; set; }

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

                [NameInMap("RiskTime")]
                [Validation(Required=false)]
                public string RiskTime { get; set; }

                [NameInMap("ActionLogs")]
                [Validation(Required=false)]
                public List<QueryHasRiskItemdetailResponseBodyResultContentDataActionLogs> ActionLogs { get; set; }
                public class QueryHasRiskItemdetailResponseBodyResultContentDataActionLogs : TeaModel {
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
                public List<QueryHasRiskItemdetailResponseBodyResultContentDataRiskOrders> RiskOrders { get; set; }
                public class QueryHasRiskItemdetailResponseBodyResultContentDataRiskOrders : TeaModel {
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

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public QueryHasRiskItemdetailResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasRiskItemdetailResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasRiskItemdetailResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasRiskItemdetailResponseBodyResultContentTopErrorCode : TeaModel {
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
        };

    }

}
