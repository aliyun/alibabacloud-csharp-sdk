// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceSceneRuleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceSceneRuleResponseData Data { get; set; }
        public class QueryEdgeInstanceSceneRuleResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=true)]
            public List<QueryEdgeInstanceSceneRuleResponseDataRuleList> RuleList { get; set; }
            public class QueryEdgeInstanceSceneRuleResponseDataRuleList : TeaModel {
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public long? GmtCreate { get; set; }
                public int? Status { get; set; }
                public int? IsExisted { get; set; }
            }
        };

    }

}
