// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CompareRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public CompareRuleResponseBodyResultObject ResultObject { get; set; }
        public class CompareRuleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>New policy object.</para>
            /// </summary>
            [NameInMap("newRule")]
            [Validation(Required=false)]
            public CompareRuleResponseBodyResultObjectNewRule NewRule { get; set; }
            public class CompareRuleResponseBodyResultObjectNewRule : TeaModel {
                /// <summary>
                /// <para>Audit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>258</para>
                /// </summary>
                [NameInMap("auditId")]
                [Validation(Required=false)]
                public long? AuditId { get; set; }

                /// <summary>
                /// <para>Authorization type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("authType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>Primary key ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6760</para>
                /// </summary>
                [NameInMap("consoleRuleId")]
                [Validation(Required=false)]
                public long? ConsoleRuleId { get; set; }

                /// <summary>
                /// <para>Creation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("createType")]
                [Validation(Required=false)]
                public string CreateType { get; set; }

                /// <summary>
                /// <para>Event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de_asssce8122</para>
                /// </summary>
                [NameInMap("eventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>Event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>注册_事件</para>
                /// </summary>
                [NameInMap("eventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760670462000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1761196952000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>Logic of the rule expression execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1&amp;2&amp;3</para>
                /// </summary>
                [NameInMap("logicExpression")]
                [Validation(Required=false)]
                public string LogicExpression { get; set; }

                /// <summary>
                /// <para>Main event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de_asssce8122</para>
                /// </summary>
                [NameInMap("mainEventCode")]
                [Validation(Required=false)]
                public string MainEventCode { get; set; }

                /// <summary>
                /// <para>Memo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>鸿蒙元服务_交费业务</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>Returned rule action structure. Returned when the policy type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;TAG&quot;: &quot;[{\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;inputs\&quot;:[\&quot;test\&quot;],\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;}]&quot;
                /// }</para>
                /// </summary>
                [NameInMap("ruleActionMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> RuleActionMap { get; set; }

                /// <summary>
                /// <para>Output actions of the rule execution. Returned when the rule type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;actionType&quot;: &quot;TAG&quot;,
                ///         &quot;code&quot;: &quot;addDeTags&quot;,
                ///         &quot;description&quot;: &quot;打标签&quot;,
                ///         &quot;displayType&quot;: &quot;ACTION&quot;,
                ///         &quot;fieldType&quot;: &quot;STRING&quot;,
                ///         &quot;inputs&quot;: [
                ///             &quot;test&quot;
                ///         ],
                ///         &quot;name&quot;: &quot;<b>addDeTags</b>&quot;,
                ///         &quot;sourceType&quot;: &quot;SAF&quot;,
                ///         &quot;title&quot;: &quot;打标签&quot;,
                ///         &quot;type&quot;: &quot;ACTION&quot;
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("ruleActions")]
                [Validation(Required=false)]
                public string RuleActions { get; set; }

                /// <summary>
                /// <para>Authorization type of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("ruleAuthType")]
                [Validation(Required=false)]
                public string RuleAuthType { get; set; }

                /// <summary>
                /// <para>DSL logic for rule execution. Returned when the rule type is DSL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;elseStatement&quot;: {</para>
                /// <pre><c>},
                /// &quot;ifStatement&quot;: {
                ///     &quot;condition&quot;: {
                ///         &quot;currentId&quot;: 0,
                ///         &quot;deepCount&quot;: 1,
                ///         &quot;list&quot;: [
                ///             {
                ///                 &quot;sequence&quot;: 1,
                ///                 &quot;left&quot;: {
                ///                     &quot;displayType&quot;: &quot;NATIVE&quot;,
                ///                     &quot;code&quot;: &quot;ip&quot;,
                ///                     &quot;functionCode&quot;: &quot;&quot;,
                ///                     &quot;functionName&quot;: &quot;&quot;,
                ///                     &quot;name&quot;: &quot;ip&quot;,
                ///                     &quot;description&quot;: &quot;IP地址&quot;,
                ///                     &quot;hasRightVariable&quot;: true,
                ///                     &quot;title&quot;: &quot;IP地址&quot;,
                ///                     &quot;type&quot;: &quot;NATIVE&quot;,
                ///                     &quot;fieldType&quot;: &quot;STRING&quot;
                ///                 },
                ///                 &quot;currentId&quot;: 0,
                ///                 &quot;deepCount&quot;: 1,
                ///                 &quot;right&quot;: {
                ///                     &quot;name&quot;: &quot;192.168.1.1&quot;,
                ///                     &quot;rightVariableType&quot;: &quot;constant&quot;
                ///                 },
                ///                 &quot;operatorCode&quot;: &quot;equals&quot;,
                ///                 &quot;operatorName&quot;: &quot;等于&quot;,
                ///                 &quot;parentId&quot;: 0
                ///             }
                ///         ],
                ///         &quot;relationship&quot;: &quot;and&quot;,
                ///         &quot;parentId&quot;: 0
                ///     },
                ///     &quot;then&quot;: [
                ///         {
                ///             &quot;actionType&quot;: &quot;TAG&quot;,
                ///             &quot;displayType&quot;: &quot;ACTION&quot;,
                ///             &quot;code&quot;: &quot;addDeTags&quot;,
                ///             &quot;sourceType&quot;: &quot;SAF&quot;,
                ///             &quot;inputs&quot;: [
                ///                 &quot;10&quot;
                ///             ],
                ///             &quot;name&quot;: &quot;__addDeTags__&quot;,
                ///             &quot;description&quot;: &quot;打标签&quot;,
                ///             &quot;outputType&quot;: &quot;const&quot;,
                ///             &quot;title&quot;: &quot;打标签&quot;,
                ///             &quot;type&quot;: &quot;ACTION&quot;,
                ///             &quot;fieldType&quot;: &quot;STRING&quot;
                ///         }
                ///     ],
                ///     &quot;expressions&quot;: [
                ///         {
                ///             &quot;itemId&quot;: 1,
                ///             &quot;left&quot;: {
                ///                 &quot;displayType&quot;: &quot;NATIVE&quot;,
                ///                 &quot;code&quot;: &quot;ip&quot;,
                ///                 &quot;functionCode&quot;: &quot;&quot;,
                ///                 &quot;functionName&quot;: &quot;&quot;,
                ///                 &quot;name&quot;: &quot;ip&quot;,
                ///                 &quot;description&quot;: &quot;IP地址&quot;,
                ///                 &quot;hasRightVariable&quot;: true,
                ///                 &quot;title&quot;: &quot;IP地址&quot;,
                ///                 &quot;type&quot;: &quot;NATIVE&quot;,
                ///                 &quot;fieldType&quot;: &quot;STRING&quot;
                ///             },
                ///             &quot;expressionName&quot;: &quot;IP地址 等于 192.168.1.1&quot;,
                ///             &quot;rightValue&quot;: &quot;192.168.1.1&quot;,
                ///             &quot;right&quot;: {
                ///                 &quot;name&quot;: &quot;192.168.1.1&quot;,
                ///                 &quot;fieldValue&quot;: &quot;192.168.1.1&quot;
                ///             },
                ///             &quot;operatorCode&quot;: &quot;equals&quot;,
                ///             &quot;operatorName&quot;: &quot;等于&quot;
                ///         }
                ///     ]
                /// },
                /// &quot;elseIfStatement&quot;: [
                /// 
                /// ]
                /// </c></pre>
                /// <para>}</para>
                /// </summary>
                [NameInMap("ruleBody")]
                [Validation(Required=false)]
                public string RuleBody { get; set; }

                /// <summary>
                /// <para>Policy expressions. Returned when the policy type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;expressionName\&quot;:\&quot;设备token不为空\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;deviceToken\&quot;},\&quot;operatorCode\&quot;:\&quot;isNotEmptyWrapper\&quot;,\&quot;operatorName\&quot;:\&quot;不为空\&quot;}]</para>
                /// </summary>
                [NameInMap("ruleExpressions")]
                [Validation(Required=false)]
                public string RuleExpressions { get; set; }

                /// <summary>
                /// <para>Rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101793</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>Rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>返回设备信息</para>
                /// </summary>
                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Policy status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFT</para>
                /// </summary>
                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                /// <summary>
                /// <para>Rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DSL</para>
                /// </summary>
                [NameInMap("ruleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>Primary key ID of the rule version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11519</para>
                /// </summary>
                [NameInMap("ruleVersionId")]
                [Validation(Required=false)]
                public long? RuleVersionId { get; set; }

                /// <summary>
                /// <para>User UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>151222xxxxxxxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>Version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>Old policy object.</para>
            /// </summary>
            [NameInMap("oldRule")]
            [Validation(Required=false)]
            public CompareRuleResponseBodyResultObjectOldRule OldRule { get; set; }
            public class CompareRuleResponseBodyResultObjectOldRule : TeaModel {
                /// <summary>
                /// <para>Audit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>257</para>
                /// </summary>
                [NameInMap("auditId")]
                [Validation(Required=false)]
                public long? AuditId { get; set; }

                /// <summary>
                /// <para>Authorization type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("authType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>Primary key ID of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6760</para>
                /// </summary>
                [NameInMap("consoleRuleId")]
                [Validation(Required=false)]
                public long? ConsoleRuleId { get; set; }

                /// <summary>
                /// <para>Creation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("createType")]
                [Validation(Required=false)]
                public string CreateType { get; set; }

                /// <summary>
                /// <para>Event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de_asssce8122</para>
                /// </summary>
                [NameInMap("eventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>Event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>注册_事件</para>
                /// </summary>
                [NameInMap("eventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760670462000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760670462000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>Execution logic of the policy expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1&amp;2</para>
                /// </summary>
                [NameInMap("logicExpression")]
                [Validation(Required=false)]
                public string LogicExpression { get; set; }

                /// <summary>
                /// <para>Main event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de_asssce8122</para>
                /// </summary>
                [NameInMap("mainEventCode")]
                [Validation(Required=false)]
                public string MainEventCode { get; set; }

                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>鸿蒙元服务_交费业务</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>Returned rule action structure. Returned when the policy type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;TAG&quot;: &quot;[{\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;inputs\&quot;:[\&quot;test\&quot;],\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;}]&quot;
                /// }</para>
                /// </summary>
                [NameInMap("ruleActionMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> RuleActionMap { get; set; }

                /// <summary>
                /// <para>Policy execution output actions. Returned when the policy type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;actionType&quot;: &quot;TAG&quot;,
                ///         &quot;code&quot;: &quot;addDeTags&quot;,
                ///         &quot;description&quot;: &quot;打标签&quot;,
                ///         &quot;displayType&quot;: &quot;ACTION&quot;,
                ///         &quot;fieldType&quot;: &quot;STRING&quot;,
                ///         &quot;inputs&quot;: [
                ///             &quot;test&quot;
                ///         ],
                ///         &quot;name&quot;: &quot;<b>addDeTags</b>&quot;,
                ///         &quot;sourceType&quot;: &quot;SAF&quot;,
                ///         &quot;title&quot;: &quot;打标签&quot;,
                ///         &quot;type&quot;: &quot;ACTION&quot;
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("ruleActions")]
                [Validation(Required=false)]
                public string RuleActions { get; set; }

                /// <summary>
                /// <para>Policy authorization type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("ruleAuthType")]
                [Validation(Required=false)]
                public string RuleAuthType { get; set; }

                /// <summary>
                /// <para>DSL policy execution logic. Returned when the policy type is DSL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;elseStatement&quot;: {</para>
                /// <pre><c>},
                /// &quot;ifStatement&quot;: {
                ///     &quot;condition&quot;: {
                ///         &quot;currentId&quot;: 0,
                ///         &quot;deepCount&quot;: 1,
                ///         &quot;list&quot;: [
                ///             {
                ///                 &quot;sequence&quot;: 1,
                ///                 &quot;left&quot;: {
                ///                     &quot;displayType&quot;: &quot;NATIVE&quot;,
                ///                     &quot;code&quot;: &quot;ip&quot;,
                ///                     &quot;functionCode&quot;: &quot;&quot;,
                ///                     &quot;functionName&quot;: &quot;&quot;,
                ///                     &quot;name&quot;: &quot;ip&quot;,
                ///                     &quot;description&quot;: &quot;IP地址&quot;,
                ///                     &quot;hasRightVariable&quot;: true,
                ///                     &quot;title&quot;: &quot;IP地址&quot;,
                ///                     &quot;type&quot;: &quot;NATIVE&quot;,
                ///                     &quot;fieldType&quot;: &quot;STRING&quot;
                ///                 },
                ///                 &quot;currentId&quot;: 0,
                ///                 &quot;deepCount&quot;: 1,
                ///                 &quot;right&quot;: {
                ///                     &quot;name&quot;: &quot;192.168.1.1&quot;,
                ///                     &quot;rightVariableType&quot;: &quot;constant&quot;
                ///                 },
                ///                 &quot;operatorCode&quot;: &quot;equals&quot;,
                ///                 &quot;operatorName&quot;: &quot;等于&quot;,
                ///                 &quot;parentId&quot;: 0
                ///             }
                ///         ],
                ///         &quot;relationship&quot;: &quot;and&quot;,
                ///         &quot;parentId&quot;: 0
                ///     },
                ///     &quot;then&quot;: [
                ///         {
                ///             &quot;actionType&quot;: &quot;TAG&quot;,
                ///             &quot;displayType&quot;: &quot;ACTION&quot;,
                ///             &quot;code&quot;: &quot;addDeTags&quot;,
                ///             &quot;sourceType&quot;: &quot;SAF&quot;,
                ///             &quot;inputs&quot;: [
                ///                 &quot;10&quot;
                ///             ],
                ///             &quot;name&quot;: &quot;__addDeTags__&quot;,
                ///             &quot;description&quot;: &quot;打标签&quot;,
                ///             &quot;outputType&quot;: &quot;const&quot;,
                ///             &quot;title&quot;: &quot;打标签&quot;,
                ///             &quot;type&quot;: &quot;ACTION&quot;,
                ///             &quot;fieldType&quot;: &quot;STRING&quot;
                ///         }
                ///     ],
                ///     &quot;expressions&quot;: [
                ///         {
                ///             &quot;itemId&quot;: 1,
                ///             &quot;left&quot;: {
                ///                 &quot;displayType&quot;: &quot;NATIVE&quot;,
                ///                 &quot;code&quot;: &quot;ip&quot;,
                ///                 &quot;functionCode&quot;: &quot;&quot;,
                ///                 &quot;functionName&quot;: &quot;&quot;,
                ///                 &quot;name&quot;: &quot;ip&quot;,
                ///                 &quot;description&quot;: &quot;IP地址&quot;,
                ///                 &quot;hasRightVariable&quot;: true,
                ///                 &quot;title&quot;: &quot;IP地址&quot;,
                ///                 &quot;type&quot;: &quot;NATIVE&quot;,
                ///                 &quot;fieldType&quot;: &quot;STRING&quot;
                ///             },
                ///             &quot;expressionName&quot;: &quot;IP地址 等于 192.168.1.1&quot;,
                ///             &quot;rightValue&quot;: &quot;192.168.1.1&quot;,
                ///             &quot;right&quot;: {
                ///                 &quot;name&quot;: &quot;192.168.1.1&quot;,
                ///                 &quot;fieldValue&quot;: &quot;192.168.1.1&quot;
                ///             },
                ///             &quot;operatorCode&quot;: &quot;equals&quot;,
                ///             &quot;operatorName&quot;: &quot;等于&quot;
                ///         }
                ///     ]
                /// },
                /// &quot;elseIfStatement&quot;: [
                /// 
                /// ]
                /// </c></pre>
                /// <para>}</para>
                /// </summary>
                [NameInMap("ruleBody")]
                [Validation(Required=false)]
                public string RuleBody { get; set; }

                /// <summary>
                /// <para>Policy expression. Returned when the policy type is DEFAULT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;expressionName\&quot;:\&quot;设备token不为空\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;deviceToken\&quot;},\&quot;operatorCode\&quot;:\&quot;isNotEmptyWrapper\&quot;,\&quot;operatorName\&quot;:\&quot;不为空\&quot;}]</para>
                /// </summary>
                [NameInMap("ruleExpressions")]
                [Validation(Required=false)]
                public string RuleExpressions { get; set; }

                /// <summary>
                /// <para>Policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101793</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>Policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>返回设备信息</para>
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
                /// <para>Policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DSL</para>
                /// </summary>
                [NameInMap("ruleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>Primary key ID of the policy version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11518</para>
                /// </summary>
                [NameInMap("ruleVersionId")]
                [Validation(Required=false)]
                public long? RuleVersionId { get; set; }

                /// <summary>
                /// <para>User UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>151222xxxxxxxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>Version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

        }

    }

}
