// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySceneRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySceneRuleResponseBodyData Data { get; set; }
        public class QuerySceneRuleResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<QuerySceneRuleResponseBodyDataRuleList> RuleList { get; set; }
            public class QuerySceneRuleResponseBodyDataRuleList : TeaModel {
                public string RuleId { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string RuleName { get; set; }
                public string RuleDescription { get; set; }
                public int? RuleStatus { get; set; }
            }
        };

    }

}
