// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSqlTemplateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetSqlTemplateListResponseBodyResults> Results { get; set; }
        public class GetSqlTemplateListResponseBodyResults : TeaModel {
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("LastCaptureTime")]
            [Validation(Required=false)]
            public string LastCaptureTime { get; set; }

            [NameInMap("CaptureCount")]
            [Validation(Required=false)]
            public long? CaptureCount { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public int? SqlType { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<GetSqlTemplateListResponseBodyResultsRuleList> RuleList { get; set; }
            public class GetSqlTemplateListResponseBodyResultsRuleList : TeaModel {
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                [NameInMap("RuleState")]
                [Validation(Required=false)]
                public int? RuleState { get; set; }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

        }

    }

}
