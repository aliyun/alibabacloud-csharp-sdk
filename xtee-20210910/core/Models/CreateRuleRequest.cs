// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateRuleRequest : TeaModel {
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
        /// <para>Rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5178</para>
        /// </summary>
        [NameInMap("consoleRuleId")]
        [Validation(Required=false)]
        public long? ConsoleRuleId { get; set; }

        /// <summary>
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_acytyt7036</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Event name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录事件</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>Policy expression execution logic</para>
        /// 
        /// <b>Example:</b>
        /// <para>1&amp;2</para>
        /// </summary>
        [NameInMap("logicExpression")]
        [Validation(Required=false)]
        public string LogicExpression { get; set; }

        /// <summary>
        /// <para>Memo</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述信息</para>
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
        /// <para>Policy execution output action</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;inputs&quot;:[&quot;123&quot;],&quot;name&quot;:&quot;<b>addDeTags</b>&quot;,&quot;actionType&quot;:&quot;TAG&quot;,&quot;outputType&quot;:&quot;const&quot;},{&quot;inputs&quot;:[&quot;123&quot;],&quot;name&quot;:&quot;<b>addDeScore</b>&quot;,&quot;actionType&quot;:&quot;SCORE&quot;,&quot;outputType&quot;:&quot;const&quot;,&quot;inputTitle&quot;:&quot;123&quot;},{&quot;actionType&quot;:&quot;MIDDLE_VARIABLE&quot;,&quot;fieldValue&quot;:&quot;123&quot;,&quot;inputs&quot;:[&quot;mid1&quot;]},{&quot;actionType&quot;:&quot;VARIABLE&quot;,&quot;inputs&quot;:[&quot;gg&quot;],&quot;name&quot;:&quot;mid1&quot;}]</para>
        /// </summary>
        [NameInMap("ruleActions")]
        [Validation(Required=false)]
        public string RuleActions { get; set; }

        /// <summary>
        /// <para>DSL policy execution logic</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;elseIfStatement&quot;:[],&quot;elseStatement&quot;:{},&quot;ifStatement&quot;:{&quot;condition&quot;:{&quot;currentId&quot;:0,&quot;deepCount&quot;:1,&quot;list&quot;:[{&quot;currentId&quot;:0,&quot;deepCount&quot;:1,&quot;left&quot;:{&quot;code&quot;:&quot;deFunctionProcess(ip,\&quot;isIp\&quot;)&quot;,&quot;description&quot;:&quot;判断是否符合IPv4标准&quot;,&quot;displayType&quot;:&quot;SYSTEM_BIND&quot;,&quot;fieldType&quot;:&quot;BOOLEAN&quot;,&quot;functionCode&quot;:&quot;&quot;,&quot;functionName&quot;:&quot;&quot;,&quot;hasRightVariable&quot;:false,&quot;name&quot;:&quot;<b>isIpAddressV4</b>&quot;,&quot;outputThreshold&quot;:{},&quot;sourceType&quot;:&quot;SAF&quot;,&quot;title&quot;:&quot;IP是否符合IPV4格式&quot;,&quot;type&quot;:&quot;SYSTEM_BIND&quot;},&quot;operatorCode&quot;:&quot;boolIsFalse&quot;,&quot;operatorName&quot;:&quot;为false&quot;,&quot;parentId&quot;:0,&quot;sequence&quot;:1}],&quot;parentId&quot;:0,&quot;relationship&quot;:&quot;and&quot;},&quot;then&quot;:[{&quot;inputs&quot;:[&quot;123&quot;],&quot;name&quot;:&quot;<b>addDeTags</b>&quot;,&quot;actionType&quot;:&quot;TAG&quot;,&quot;outputType&quot;:&quot;const&quot;}]}}</para>
        /// </summary>
        [NameInMap("ruleBody")]
        [Validation(Required=false)]
        public string RuleBody { get; set; }

        /// <summary>
        /// <para>Policy expression</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;expressionName&quot;:&quot;cc&quot;,&quot;itemId&quot;:1,&quot;left&quot;:{&quot;name&quot;:&quot;<b>ipLocationCityCode</b>&quot;},&quot;operatorCode&quot;:&quot;equals&quot;,&quot;operatorName&quot;:&quot;等于&quot;,&quot;right&quot;:{&quot;fieldValue&quot;:&quot;a&quot;}}]</para>
        /// </summary>
        [NameInMap("ruleExpressions")]
        [Validation(Required=false)]
        public string RuleExpressions { get; set; }

        /// <summary>
        /// <para>Policy name</para>
        /// 
        /// <b>Example:</b>
        /// <para>注册手机号是11位数字</para>
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Policy status</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("ruleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>Policy type</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
