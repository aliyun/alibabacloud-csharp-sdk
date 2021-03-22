// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DescribeAclRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAclRulesResponseBodyResult Result { get; set; }
        public class DescribeAclRulesResponseBodyResult : TeaModel {
            [NameInMap("AclRules")]
            [Validation(Required=false)]
            public DescribeAclRulesResponseBodyResultAclRules AclRules { get; set; }
            public class DescribeAclRulesResponseBodyResultAclRules : TeaModel {
                [NameInMap("AclRule")]
                [Validation(Required=false)]
                public List<DescribeAclRulesResponseBodyResultAclRulesAclRule> AclRule { get; set; }
                public class DescribeAclRulesResponseBodyResultAclRulesAclRule : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public int? Action { get; set; }

                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public int? IsDefault { get; set; }

                    [NameInMap("ContinueWaf")]
                    [Validation(Required=false)]
                    public int? ContinueWaf { get; set; }

                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public int? Order { get; set; }

                    [NameInMap("Conditions")]
                    [Validation(Required=false)]
                    public DescribeAclRulesResponseBodyResultAclRulesAclRuleConditions Conditions { get; set; }
                    public class DescribeAclRulesResponseBodyResultAclRulesAclRuleConditions : TeaModel {
                        [NameInMap("condition")]
                        [Validation(Required=false)]
                        public List<DescribeAclRulesResponseBodyResultAclRulesAclRuleConditionsCondition> Condition { get; set; }
                        public class DescribeAclRulesResponseBodyResultAclRulesAclRuleConditionsCondition : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                            public string Contain { get; set; }
                        }
                    };

                    [NameInMap("ContinueDataRiskControl")]
                    [Validation(Required=false)]
                    public int? ContinueDataRiskControl { get; set; }

                    [NameInMap("ContinueSdk")]
                    [Validation(Required=false)]
                    public int? ContinueSdk { get; set; }

                    [NameInMap("ContinueCc")]
                    [Validation(Required=false)]
                    public int? ContinueCc { get; set; }

                    [NameInMap("ContinueSA")]
                    [Validation(Required=false)]
                    public int? ContinueSA { get; set; }

                    [NameInMap("ContinueBlockGeo")]
                    [Validation(Required=false)]
                    public int? ContinueBlockGeo { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

    }

}
