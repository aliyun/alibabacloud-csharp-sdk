// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class QueryAuthRuleDetailByRuleIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public QueryAuthRuleDetailByRuleIdResponseBodyResultObject ResultObject { get; set; }
        public class QueryAuthRuleDetailByRuleIdResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Audit ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>225</para>
            /// </summary>
            [NameInMap("auditId")]
            [Validation(Required=false)]
            public long? AuditId { get; set; }

            /// <summary>
            /// <para>Authorization type</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Authorized user UID</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("authUsers")]
            [Validation(Required=false)]
            public string AuthUsers { get; set; }

            /// <summary>
            /// <para>Primary key ID of the strategy</para>
            /// 
            /// <b>Example:</b>
            /// <para>6843</para>
            /// </summary>
            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            /// <summary>
            /// <para>Event code</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
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
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Execution logic</para>
            /// 
            /// <b>Example:</b>
            /// <para>1&amp;2</para>
            /// </summary>
            [NameInMap("logicExpression")]
            [Validation(Required=false)]
            public string LogicExpression { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <para>Rule priority, the higher the number, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>Returned rule action structure.</para>
            /// </summary>
            [NameInMap("ruleActionMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> RuleActionMap { get; set; }

            /// <summary>
            /// <para>Output actions</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;inputs\&quot;:[\&quot;unusualBrand\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;}]</para>
            /// </summary>
            [NameInMap("ruleActions")]
            [Validation(Required=false)]
            public string RuleActions { get; set; }

            /// <summary>
            /// <para>Rule authorization type</para>
            /// 
            /// <b>Example:</b>
            /// <para>WHITE_BOX</para>
            /// </summary>
            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

            /// <summary>
            /// <para>Rule expressions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;expressionName\&quot;:\&quot;同一设备同一IP上的注册用户数\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;dK7EXHr490f\&quot;},\&quot;operatorCode\&quot;:\&quot;gte\&quot;,\&quot;operatorName\&quot;:\&quot;大于等于\&quot;,\&quot;right\&quot;:{\&quot;fieldValue\&quot;:\&quot;2\&quot;}}]</para>
            /// </summary>
            [NameInMap("ruleExpressions")]
            [Validation(Required=false)]
            public string RuleExpressions { get; set; }

            /// <summary>
            /// <para>Strategy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>102224</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>Strategy name</para>
            /// 
            /// <b>Example:</b>
            /// <para>营销风险识别</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Strategy status</para>
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
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>Primary key ID of the strategy version</para>
            /// 
            /// <b>Example:</b>
            /// <para>11519</para>
            /// </summary>
            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

            /// <summary>
            /// <para>Template type</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUB_SERVICE</para>
            /// </summary>
            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>Version number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
