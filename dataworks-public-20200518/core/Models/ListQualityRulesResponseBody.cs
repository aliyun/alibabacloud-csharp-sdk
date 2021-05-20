// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityRulesResponseBodyData Data { get; set; }
        public class ListQualityRulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
                public int? BlockType { get; set; }
                public string OnDutyAccountName { get; set; }
                public string Property { get; set; }
                public string WarningThreshold { get; set; }
                public string TableName { get; set; }
                public string OnDuty { get; set; }
                public string Comment { get; set; }
                public int? RuleCheckerRelationId { get; set; }
                public bool? FixCheck { get; set; }
                public int? MethodId { get; set; }
                public string TemplateName { get; set; }
                public string Trend { get; set; }
                public string HistoryWarningThreshold { get; set; }
                public int? RuleType { get; set; }
                public string MatchExpression { get; set; }
                public string ProjectName { get; set; }
                public string PropertyKey { get; set; }
                public string CriticalThreshold { get; set; }
                public string HistoryCriticalThreshold { get; set; }
                public string MethodName { get; set; }
                public int? CheckerId { get; set; }
                public int? EntityId { get; set; }
                public string ExpectValue { get; set; }
                public int? TemplateId { get; set; }
                public int? Id { get; set; }
            }
        };

    }

}
