// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
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

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public string CriticalThreshold { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public int? EntityId { get; set; }

                [NameInMap("ExpectValue")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                [NameInMap("FixCheck")]
                [Validation(Required=false)]
                public bool? FixCheck { get; set; }

                [NameInMap("HistoryCriticalThreshold")]
                [Validation(Required=false)]
                public string HistoryCriticalThreshold { get; set; }

                [NameInMap("HistoryWarningThreshold")]
                [Validation(Required=false)]
                public string HistoryWarningThreshold { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("MatchExpression")]
                [Validation(Required=false)]
                public string MatchExpression { get; set; }

                [NameInMap("MethodId")]
                [Validation(Required=false)]
                public int? MethodId { get; set; }

                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                [NameInMap("OnDuty")]
                [Validation(Required=false)]
                public string OnDuty { get; set; }

                [NameInMap("OnDutyAccountName")]
                [Validation(Required=false)]
                public string OnDutyAccountName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("Property")]
                [Validation(Required=false)]
                public string Property { get; set; }

                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                [NameInMap("RuleCheckerRelationId")]
                [Validation(Required=false)]
                public int? RuleCheckerRelationId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("Trend")]
                [Validation(Required=false)]
                public string Trend { get; set; }

                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public string WarningThreshold { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
