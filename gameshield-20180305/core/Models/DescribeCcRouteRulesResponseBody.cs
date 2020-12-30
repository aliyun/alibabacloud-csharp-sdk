// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcRouteRulesResponseBody : TeaModel {
        [NameInMap("RuleQueryResult")]
        [Validation(Required=false)]
        public DescribeCcRouteRulesResponseBodyRuleQueryResult RuleQueryResult { get; set; }
        public class DescribeCcRouteRulesResponseBodyRuleQueryResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RouteRules")]
            [Validation(Required=false)]
            public List<DescribeCcRouteRulesResponseBodyRuleQueryResultRouteRules> RouteRules { get; set; }
            public class DescribeCcRouteRulesResponseBodyRuleQueryResultRouteRules : TeaModel {
                public string Comment { get; set; }
                public List<string> Rservers { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
