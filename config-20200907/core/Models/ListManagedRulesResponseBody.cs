// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListManagedRulesResponseBody : TeaModel {
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public ListManagedRulesResponseBodyManagedRules ManagedRules { get; set; }
        public class ListManagedRulesResponseBodyManagedRules : TeaModel {
            [NameInMap("ManagedRuleList")]
            [Validation(Required=false)]
            public List<ListManagedRulesResponseBodyManagedRulesManagedRuleList> ManagedRuleList { get; set; }
            public class ListManagedRulesResponseBodyManagedRulesManagedRuleList : TeaModel {
                public string ConfigRuleName { get; set; }
                public string Description { get; set; }
                public string HelpUrls { get; set; }
                public string Identifier { get; set; }
                public List<string> Labels { get; set; }
                public int? RiskLevel { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
