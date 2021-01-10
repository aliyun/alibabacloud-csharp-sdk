// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsSgAuthRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AuthRule")]
        [Validation(Required=false)]
        public AddMsSgAuthRulesResponseBodyAuthRule AuthRule { get; set; }
        public class AddMsSgAuthRulesResponseBodyAuthRule : TeaModel {
            [NameInMap("AuthRuleGroupId")]
            [Validation(Required=false)]
            public long? AuthRuleGroupId { get; set; }
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RuleItems")]
            [Validation(Required=false)]
            public List<AddMsSgAuthRulesResponseBodyAuthRuleRuleItems> RuleItems { get; set; }
            public class AddMsSgAuthRulesResponseBodyAuthRuleRuleItems : TeaModel {
                public string Type { get; set; }
                public string Operation { get; set; }
                public string Value { get; set; }
                public long? AuthRuleId { get; set; }
                public string Field { get; set; }
            }
        };

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
