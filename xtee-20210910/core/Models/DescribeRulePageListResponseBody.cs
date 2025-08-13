// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRulePageListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeRulePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeRulePageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Service authorization type</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Audit object</para>
            /// </summary>
            [NameInMap("consoleAudit")]
            [Validation(Required=false)]
            public DescribeRulePageListResponseBodyResultObjectConsoleAudit ConsoleAudit { get; set; }
            public class DescribeRulePageListResponseBodyResultObjectConsoleAudit : TeaModel {
                /// <summary>
                /// <para>UID of the user who passed the audit</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户uid</para>
                /// </summary>
                [NameInMap("applyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                /// <summary>
                /// <para>Name of the user who passed the audit</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("applyUserName")]
                [Validation(Required=false)]
                public string ApplyUserName { get; set; }

                /// <summary>
                /// <para>Approval comments</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("auditMsg")]
                [Validation(Required=false)]
                public string AuditMsg { get; set; }

                /// <summary>
                /// <para>UID of the final auditor</para>
                /// 
                /// <b>Example:</b>
                /// <para>1728</para>
                /// </summary>
                [NameInMap("auditRealUserId")]
                [Validation(Required=false)]
                public string AuditRealUserId { get; set; }

                /// <summary>
                /// <para>Name of the final auditor</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("auditRealUserName")]
                [Validation(Required=false)]
                public string AuditRealUserName { get; set; }

                /// <summary>
                /// <para>Remarks by the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>备注</para>
                /// </summary>
                [NameInMap("auditRemark")]
                [Validation(Required=false)]
                public string AuditRemark { get; set; }

                /// <summary>
                /// <para>Application audit status</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGREE</para>
                /// </summary>
                [NameInMap("auditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                /// <summary>
                /// <para>Approval time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545726028000</para>
                /// </summary>
                [NameInMap("auditTime")]
                [Validation(Required=false)]
                public long? AuditTime { get; set; }

                /// <summary>
                /// <para>UID of the auditor</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234xxxx</para>
                /// </summary>
                [NameInMap("auditUserId")]
                [Validation(Required=false)]
                public string AuditUserId { get; set; }

                /// <summary>
                /// <para>Name of the auditor</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("auditUserName")]
                [Validation(Required=false)]
                public string AuditUserName { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545726028000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Primary key ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1728</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Information of other related parties (in JSON format)</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("relationExt")]
                [Validation(Required=false)]
                public string RelationExt { get; set; }

                /// <summary>
                /// <para>ID of the related transaction for the approval</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

                /// <summary>
                /// <para>Name of the related transaction for the approval (can be null)</para>
                /// 
                /// <b>Example:</b>
                /// <para>策略1</para>
                /// </summary>
                [NameInMap("relationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                /// <summary>
                /// <para>Type of the approval (e.g., <c>rule</c> represents the approval of a rule)</para>
                /// 
                /// <b>Example:</b>
                /// <para>RULE</para>
                /// </summary>
                [NameInMap("relationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>Event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_arcehq4370</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>Event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险</para>
            /// </summary>
            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>Event type</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAIN</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>External name of the rule</para>
            /// 
            /// <b>Example:</b>
            /// <para>策略1</para>
            /// </summary>
            [NameInMap("externalRuleName")]
            [Validation(Required=false)]
            public string ExternalRuleName { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Whether there is a new version</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasNewVersion")]
            [Validation(Required=false)]
            public bool? HasNewVersion { get; set; }

            /// <summary>
            /// <para>Primary key ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2793</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Main rule ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4399</para>
            /// </summary>
            [NameInMap("mainRuleId")]
            [Validation(Required=false)]
            public string MainRuleId { get; set; }

            /// <summary>
            /// <para>Policy priority, the higher the number, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>Rule type</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102059</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>Policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述信息</para>
            /// </summary>
            [NameInMap("ruleMemo")]
            [Validation(Required=false)]
            public string RuleMemo { get; set; }

            /// <summary>
            /// <para>Policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>营销风险识别</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Policy status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>Rule type</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>Primary key ID of the rule version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11300</para>
            /// </summary>
            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>register</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>Version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
