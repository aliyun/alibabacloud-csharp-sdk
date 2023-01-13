// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySceneRuleResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySceneRuleResponseData Data { get; set; }
        public class QuerySceneRuleResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=true)]
            public List<QuerySceneRuleResponseDataRuleList> RuleList { get; set; }
            public class QuerySceneRuleResponseDataRuleList : TeaModel {
                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=true)]
                public long? GmtModified { get; set; }

                [NameInMap("RuleDescription")]
                [Validation(Required=true)]
                public string RuleDescription { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=true)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=true)]
                public string RuleName { get; set; }

                [NameInMap("RuleStatus")]
                [Validation(Required=true)]
                public int? RuleStatus { get; set; }

            }

        }

    }

}
