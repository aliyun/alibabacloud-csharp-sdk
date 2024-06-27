// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneRulePageListResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneRulePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneRulePageListResponseBodyResultObject : TeaModel {
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("consoleAudit")]
            [Validation(Required=false)]
            public DescribeSceneRulePageListResponseBodyResultObjectConsoleAudit ConsoleAudit { get; set; }
            public class DescribeSceneRulePageListResponseBodyResultObjectConsoleAudit : TeaModel {
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

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("externalRuleName")]
            [Validation(Required=false)]
            public string ExternalRuleName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("mainRuleId")]
            [Validation(Required=false)]
            public string MainRuleId { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("ruleMemo")]
            [Validation(Required=false)]
            public string RuleMemo { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
