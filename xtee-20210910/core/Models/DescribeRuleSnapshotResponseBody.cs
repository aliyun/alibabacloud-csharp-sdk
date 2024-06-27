// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleSnapshotResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRuleSnapshotResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRuleSnapshotResponseBodyResultObject : TeaModel {
            [NameInMap("bizVersion")]
            [Validation(Required=false)]
            public string BizVersion { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("logicExpression")]
            [Validation(Required=false)]
            public string LogicExpression { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("ruleActions")]
            [Validation(Required=false)]
            public string RuleActions { get; set; }

            [NameInMap("ruleExpressions")]
            [Validation(Required=false)]
            public string RuleExpressions { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

        }

    }

}
