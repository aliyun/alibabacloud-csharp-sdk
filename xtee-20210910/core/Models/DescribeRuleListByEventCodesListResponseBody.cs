// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleListByEventCodesListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeRuleListByEventCodesListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeRuleListByEventCodesListResponseBodyResultObject : TeaModel {
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
