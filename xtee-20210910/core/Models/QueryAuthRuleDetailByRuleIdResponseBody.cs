// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class QueryAuthRuleDetailByRuleIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public QueryAuthRuleDetailByRuleIdResponseBodyResultObject ResultObject { get; set; }
        public class QueryAuthRuleDetailByRuleIdResponseBodyResultObject : TeaModel {
            [NameInMap("auditId")]
            [Validation(Required=false)]
            public long? AuditId { get; set; }

            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("authUsers")]
            [Validation(Required=false)]
            public string AuthUsers { get; set; }

            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

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

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("ruleActionMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> RuleActionMap { get; set; }

            [NameInMap("ruleActions")]
            [Validation(Required=false)]
            public string RuleActions { get; set; }

            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

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

            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
