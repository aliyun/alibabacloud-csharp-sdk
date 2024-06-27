// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleVersionListResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeRuleVersionListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeRuleVersionListResponseBodyResultObject : TeaModel {
            [NameInMap("consoleAudit")]
            [Validation(Required=false)]
            public DescribeRuleVersionListResponseBodyResultObjectConsoleAudit ConsoleAudit { get; set; }
            public class DescribeRuleVersionListResponseBodyResultObjectConsoleAudit : TeaModel {
                [NameInMap("applyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                [NameInMap("applyUserName")]
                [Validation(Required=false)]
                public string ApplyUserName { get; set; }

                [NameInMap("auditMsg")]
                [Validation(Required=false)]
                public string AuditMsg { get; set; }

                [NameInMap("auditRealUserId")]
                [Validation(Required=false)]
                public string AuditRealUserId { get; set; }

                [NameInMap("auditRealUserName")]
                [Validation(Required=false)]
                public string AuditRealUserName { get; set; }

                [NameInMap("auditRemark")]
                [Validation(Required=false)]
                public string AuditRemark { get; set; }

                [NameInMap("auditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                [NameInMap("auditTime")]
                [Validation(Required=false)]
                public long? AuditTime { get; set; }

                [NameInMap("auditUserId")]
                [Validation(Required=false)]
                public string AuditUserId { get; set; }

                [NameInMap("auditUserName")]
                [Validation(Required=false)]
                public string AuditUserName { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("relationExt")]
                [Validation(Required=false)]
                public string RelationExt { get; set; }

                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

                [NameInMap("relationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                [NameInMap("relationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            [NameInMap("consoleRuleMemo")]
            [Validation(Required=false)]
            public string ConsoleRuleMemo { get; set; }

            [NameInMap("consoleRuleName")]
            [Validation(Required=false)]
            public string ConsoleRuleName { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("lastOperator")]
            [Validation(Required=false)]
            public string LastOperator { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
