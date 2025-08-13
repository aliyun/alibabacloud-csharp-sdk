// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UpdateRuleRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Primary key ID of the policy</para>
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
        /// <para>de_agdxgz0246</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

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
        /// <para>备注</para>
        /// </summary>
        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Output action</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;inputs\&quot;:[\&quot;rn0301\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;}]</para>
        /// </summary>
        [NameInMap("ruleActions")]
        [Validation(Required=false)]
        public string RuleActions { get; set; }

        /// <summary>
        /// <para>DSL policy expression</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;elseIfStatement&quot;: [
        ///             {
        ///                 &quot;condition&quot;: {
        ///                     &quot;currentId&quot;: 0,
        ///                     &quot;deepCount&quot;: 1,
        ///                     &quot;list&quot;: [
        ///                         {
        ///                             &quot;currentId&quot;: 0,
        ///                             &quot;deepCount&quot;: 1,
        ///                             &quot;left&quot;: {
        ///                                 &quot;code&quot;: &quot;getLbsRegion(longitude, latitude)?.prov&quot;,
        ///                                 &quot;description&quot;: &quot;根据经纬度得到省份信息，比如经度：111.878062，纬度：22.585409，则经过运算，输出”广东省“&quot;,
        ///                                 &quot;displayType&quot;: &quot;SELF_BIND&quot;,
        ///                                 &quot;fieldType&quot;: &quot;STRING&quot;,
        ///                                 &quot;functionCode&quot;: &quot;&quot;,
        ///                                 &quot;functionName&quot;: &quot;&quot;,
        ///                                 &quot;hasRightVariable&quot;: true,
        ///                                 &quot;name&quot;: &quot;sl_S02sHLFT7818&quot;,
        ///                                 &quot;outputThreshold&quot;: {</para>
        /// <pre><c>                            },
        ///                             &quot;sourceType&quot;: &quot;SAF&quot;,
        ///                             &quot;title&quot;: &quot;经纬度自定义系统变量&quot;,
        ///                             &quot;type&quot;: &quot;SELF_BIND&quot;
        ///                         },
        ///                         &quot;operatorCode&quot;: &quot;equals&quot;,
        ///                         &quot;operatorName&quot;: &quot;等于&quot;,
        ///                         &quot;parentId&quot;: 0,
        ///                         &quot;right&quot;: {
        ///                             &quot;name&quot;: &quot;v&quot;,
        ///                             &quot;rightVariableType&quot;: &quot;constant&quot;
        ///                         },
        ///                         &quot;sequence&quot;: 2
        ///                     },
        ///                     {
        ///                         &quot;currentId&quot;: 0,
        ///                         &quot;deepCount&quot;: 1,
        ///                         &quot;list&quot;: [
        ///                             {
        ///                                 &quot;currentId&quot;: 0,
        ///                                 &quot;deepCount&quot;: 1,
        ///                                 &quot;left&quot;: {
        ///                                     &quot;code&quot;: &quot;deReadVelocity(userId,&quot;hK1DMAp1d97&quot;,1,&quot;H&quot;,0,true,&quot;COUNT&quot;)&quot;,
        ///                                     &quot;description&quot;: &quot;测试系统变量累计&quot;,
        ///                                     &quot;displayType&quot;: &quot;SELF_BIND&quot;,
        ///                                     &quot;fieldType&quot;: &quot;DOUBLE&quot;,
        ///                                     &quot;functionCode&quot;: &quot;&quot;,
        ///                                     &quot;functionName&quot;: &quot;&quot;,
        ///                                     &quot;hasRightVariable&quot;: true,
        ///                                     &quot;name&quot;: &quot;hK1DMAp1d97&quot;,
        ///                                     &quot;outputThreshold&quot;: {
        /// 
        ///                                     },
        ///                                     &quot;sourceType&quot;: &quot;SAF_SELF&quot;,
        ///                                     &quot;title&quot;: &quot;测试系统变量累计&quot;,
        ///                                     &quot;type&quot;: &quot;SELF_BIND&quot;
        ///                                 },
        ///                                 &quot;operatorCode&quot;: &quot;equals&quot;,
        ///                                 &quot;operatorName&quot;: &quot;等于&quot;,
        ///                                 &quot;parentId&quot;: 0,
        ///                                 &quot;right&quot;: {
        ///                                     &quot;name&quot;: &quot;a&quot;,
        ///                                     &quot;rightVariableType&quot;: &quot;constant&quot;
        ///                                 },
        ///                                 &quot;sequence&quot;: 3
        ///                             }
        ///                         ],
        ///                         &quot;parentId&quot;: 0,
        ///                         &quot;relationship&quot;: &quot;and&quot;
        ///                     }
        ///                 ],
        ///                 &quot;parentId&quot;: 0,
        ///                 &quot;relationship&quot;: &quot;and&quot;
        ///             },
        ///             &quot;then&quot;: [
        ///                 {
        ///                     &quot;inputs&quot;: [
        ///                         &quot;123&quot;
        ///                     ],
        ///                     &quot;name&quot;: &quot;__addDeScore__&quot;,
        ///                     &quot;actionType&quot;: &quot;SCORE&quot;,
        ///                     &quot;outputType&quot;: &quot;const&quot;,
        ///                     &quot;inputTitle&quot;: &quot;123&quot;
        ///                 }
        ///             ]
        ///         }
        ///     ],
        ///     &quot;elseStatement&quot;: {
        /// 
        ///     },
        ///     &quot;ifStatement&quot;: {
        ///         &quot;condition&quot;: {
        ///             &quot;currentId&quot;: 0,
        ///             &quot;deepCount&quot;: 1,
        ///             &quot;list&quot;: [
        ///                 {
        ///                     &quot;currentId&quot;: 0,
        ///                     &quot;deepCount&quot;: 1,
        ///                     &quot;left&quot;: {
        ///                         &quot;code&quot;: &quot;deFunctionProcess(ip,&quot;isIp&quot;)&quot;,
        ///                         &quot;description&quot;: &quot;判断是否符合IPv4标准&quot;,
        ///                         &quot;displayType&quot;: &quot;SYSTEM_BIND&quot;,
        ///                         &quot;fieldType&quot;: &quot;BOOLEAN&quot;,
        ///                         &quot;functionCode&quot;: &quot;&quot;,
        ///                         &quot;functionName&quot;: &quot;&quot;,
        ///                         &quot;hasRightVariable&quot;: true,
        ///                         &quot;name&quot;: &quot;__isIpAddressV4__&quot;,
        ///                         &quot;outputThreshold&quot;: {
        /// 
        ///                         },
        ///                         &quot;sourceType&quot;: &quot;SAF&quot;,
        ///                         &quot;title&quot;: &quot;IP是否符合IPV4格式&quot;,
        ///                         &quot;type&quot;: &quot;SYSTEM_BIND&quot;
        ///                     },
        ///                     &quot;operatorCode&quot;: &quot;equals&quot;,
        ///                     &quot;operatorName&quot;: &quot;等于&quot;,
        ///                     &quot;parentId&quot;: 0,
        ///                     &quot;right&quot;: {
        ///                         &quot;name&quot;: &quot;c
        /// </c></pre>
        /// <para>d
        /// s&quot;,
        ///                             &quot;rightVariableType&quot;: &quot;constant&quot;
        ///                         },
        ///                         &quot;sequence&quot;: 1
        ///                     }
        ///                 ],
        ///                 &quot;parentId&quot;: 0,
        ///                 &quot;relationship&quot;: &quot;and&quot;
        ///             },
        ///             &quot;then&quot;: [
        ///                 {
        ///                     &quot;inputs&quot;: [
        ///                         &quot;22&quot;
        ///                     ],
        ///                     &quot;name&quot;: &quot;<b>addDeTags</b>&quot;,
        ///                     &quot;actionType&quot;: &quot;TAG&quot;,
        ///                     &quot;outputType&quot;: &quot;const&quot;
        ///                 }
        ///             ]
        ///         }
        ///     }</para>
        /// </summary>
        [NameInMap("ruleBody")]
        [Validation(Required=false)]
        public string RuleBody { get; set; }

        /// <summary>
        /// <para>Policy expression</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;expressionName\&quot;:\&quot;手机号MD5命中人脸测试名单\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;mobileMd5\&quot;},\&quot;operatorCode\&quot;:\&quot;deInNameList\&quot;,\&quot;operatorName\&quot;:\&quot;在名单中\&quot;,\&quot;right\&quot;:{\&quot;fieldValue\&quot;:\&quot;nl_5tolf69W138c\&quot;}}]</para>
        /// </summary>
        [NameInMap("ruleExpressions")]
        [Validation(Required=false)]
        public string RuleExpressions { get; set; }

        /// <summary>
        /// <para>Policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>102224</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>Policy name</para>
        /// 
        /// <b>Example:</b>
        /// <para>分析中心事件测试_策略01</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Policy status</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("ruleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>Policy type</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>Primary key ID of the policy version</para>
        /// 
        /// <b>Example:</b>
        /// <para>11519</para>
        /// </summary>
        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
