// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasLocaloverviewTodayrisklistResponseBody : TeaModel {
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
        public QueryHasLocaloverviewTodayrisklistResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContent : TeaModel {
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
            public List<QueryHasLocaloverviewTodayrisklistResponseBodyResultContentData> Data { get; set; }
            public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContentData : TeaModel {
                public string AdditionalInfo { get; set; }
                public string AggregationRiskItemId { get; set; }
                public string CellId { get; set; }
                public string CloseComment { get; set; }
                public string Deadline { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
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
                public List<QueryHasLocaloverviewTodayrisklistResponseBodyResultContentDataActionLogs> ActionLogs { get; set; }
                public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContentDataActionLogs : TeaModel {
                    public string RiskItemId { get; set; }
                    public string ActionTime { get; set; }
                    public string Action { get; set; }
                    public string Operator { get; set; }
                }
                public List<QueryHasLocaloverviewTodayrisklistResponseBodyResultContentDataRiskOrders> RiskOrders { get; set; }
                public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContentDataRiskOrders : TeaModel {
                    public string Name { get; set; }
                    public string TenantId { get; set; }
                    public string Creator { get; set; }
                    public string Operator { get; set; }
                    public string Description { get; set; }
                    public string Status { get; set; }
                    public string AggregateStatus { get; set; }
                    public string StartTime { get; set; }
                    public string EndTime { get; set; }
                    public string CreateTime { get; set; }
                    public string Id { get; set; }
                    public string OrderId { get; set; }
                    public string OrderType { get; set; }
                    public bool? NotExist { get; set; }
                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasLocaloverviewTodayrisklistResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasLocaloverviewTodayrisklistResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasLocaloverviewTodayrisklistResponseBodyResultContentTopErrorReason : TeaModel {
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
