// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneRulePageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneRulePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneRulePageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The service authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The audit object.</para>
            /// </summary>
            [NameInMap("consoleAudit")]
            [Validation(Required=false)]
            public DescribeSceneRulePageListResponseBodyResultObjectConsoleAudit ConsoleAudit { get; set; }
            public class DescribeSceneRulePageListResponseBodyResultObjectConsoleAudit : TeaModel {
                /// <summary>
                /// <para>The account ID of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890999</para>
                /// </summary>
                [NameInMap("applyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                /// <summary>
                /// <para>The account name of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("applyUserName")]
                [Validation(Required=false)]
                public string ApplyUserName { get; set; }

                /// <summary>
                /// <para>The approval comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("auditMsg")]
                [Validation(Required=false)]
                public string AuditMsg { get; set; }

                /// <summary>
                /// <para>The ID of the final approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("auditRealUserId")]
                [Validation(Required=false)]
                public string AuditRealUserId { get; set; }

                /// <summary>
                /// <para>The account name of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>王五</para>
                /// </summary>
                [NameInMap("auditRealUserName")]
                [Validation(Required=false)]
                public string AuditRealUserName { get; set; }

                /// <summary>
                /// <para>The remark for the approval request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>备注</para>
                /// </summary>
                [NameInMap("auditRemark")]
                [Validation(Required=false)]
                public string AuditRemark { get; set; }

                /// <summary>
                /// <para>The approval status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGREE</para>
                /// </summary>
                [NameInMap("auditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                /// <summary>
                /// <para>The approval time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545726028000</para>
                /// </summary>
                [NameInMap("auditTime")]
                [Validation(Required=false)]
                public long? AuditTime { get; set; }

                /// <summary>
                /// <para>The account IDs of the designated reviewers. Multiple IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("auditUserId")]
                [Validation(Required=false)]
                public string AuditUserId { get; set; }

                /// <summary>
                /// <para>The account names of the designated reviewers. Multiple names are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("auditUserName")]
                [Validation(Required=false)]
                public string AuditUserName { get; set; }

                /// <summary>
                /// <para>The creation time in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545726028000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1728</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The information about other associated persons in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("relationExt")]
                [Validation(Required=false)]
                public string RelationExt { get; set; }

                /// <summary>
                /// <para>The transaction ID associated with the approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("relationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

                /// <summary>
                /// <para>The transaction name associated with the approval. This parameter can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t</para>
                /// </summary>
                [NameInMap("relationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                /// <summary>
                /// <para>The approval type. For example, rule indicates a policy approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RULE</para>
                /// </summary>
                [NameInMap("relationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>The event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险</para>
            /// </summary>
            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BYPASS: bypass event.</description></item>
            /// <item><description>SHUNT: shunt event.</description></item>
            /// <item><description>MAIN: main event.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MAIN</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The customer-facing policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>策略1</para>
            /// </summary>
            [NameInMap("externalRuleName")]
            [Validation(Required=false)]
            public string ExternalRuleName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The main policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4399</para>
            /// </summary>
            [NameInMap("mainRuleId")]
            [Validation(Required=false)]
            public string MainRuleId { get; set; }

            /// <summary>
            /// <para>The policy priority. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTMER</para>
            /// </summary>
            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4730</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述信息</para>
            /// </summary>
            [NameInMap("ruleMemo")]
            [Validation(Required=false)]
            public string RuleMemo { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>营销风险识别</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The policy status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>The rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DSL</para>
            /// </summary>
            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The primary key ID of the policy version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3823</para>
            /// </summary>
            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
