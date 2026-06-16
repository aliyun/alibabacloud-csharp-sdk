// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleVersionListResponseBody : TeaModel {
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
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeRuleVersionListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeRuleVersionListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The approval object.</para>
            /// </summary>
            [NameInMap("consoleAudit")]
            [Validation(Required=false)]
            public DescribeRuleVersionListResponseBodyResultObjectConsoleAudit ConsoleAudit { get; set; }
            public class DescribeRuleVersionListResponseBodyResultObjectConsoleAudit : TeaModel {
                /// <summary>
                /// <para>The UID of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1519714049632764</para>
                /// </summary>
                [NameInMap("applyUserId")]
                [Validation(Required=false)]
                public string ApplyUserId { get; set; }

                /// <summary>
                /// <para>The name of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
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
                /// <para>The UID of the final approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1519714049632764</para>
                /// </summary>
                [NameInMap("auditRealUserId")]
                [Validation(Required=false)]
                public string AuditRealUserId { get; set; }

                /// <summary>
                /// <para>The name of the final approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("auditRealUserName")]
                [Validation(Required=false)]
                public string AuditRealUserName { get; set; }

                /// <summary>
                /// <para>The remark of the approver.</para>
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
                /// <para>The UID of the designated approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1519714049632764</para>
                /// </summary>
                [NameInMap("auditUserId")]
                [Validation(Required=false)]
                public string AuditUserId { get; set; }

                /// <summary>
                /// <para>The name of the designated approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("auditUserName")]
                [Validation(Required=false)]
                public string AuditUserName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
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
                /// <para>The information about other related persons in JSON format.</para>
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
                /// <para>The name associated with the approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>营销风险识别</para>
                /// </summary>
                [NameInMap("relationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                /// <summary>
                /// <para>The type of the approval. For example, rule indicates a policy approval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RULE</para>
                /// </summary>
                [NameInMap("relationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>The console rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6715</para>
            /// </summary>
            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            /// <summary>
            /// <para>The remark of the associated policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("consoleRuleMemo")]
            [Validation(Required=false)]
            public string ConsoleRuleMemo { get; set; }

            /// <summary>
            /// <para>The Policy Name of the associated policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>营销风险识别</para>
            /// </summary>
            [NameInMap("consoleRuleName")]
            [Validation(Required=false)]
            public string ConsoleRuleName { get; set; }

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
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAIN</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

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
            /// <para>376773</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The user who last performed an operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1519714049632764</para>
            /// </summary>
            [NameInMap("lastOperator")]
            [Validation(Required=false)]
            public string LastOperator { get; set; }

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
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102224</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

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
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

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
        /// <para>7</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
