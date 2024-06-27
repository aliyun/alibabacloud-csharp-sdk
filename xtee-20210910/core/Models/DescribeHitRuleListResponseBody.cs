// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeHitRuleListResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeHitRuleListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeHitRuleListResponseBodyResultObject : TeaModel {
            [NameInMap("hitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
