// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceSceneRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceSceneRuleResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceSceneRuleResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceSceneRuleResponseBodyDataRuleList> RuleList { get; set; }
            public class QueryEdgeInstanceSceneRuleResponseBodyDataRuleList : TeaModel {
                public long? GmtCreate { get; set; }
                public int? IsExisted { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public int? Status { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
