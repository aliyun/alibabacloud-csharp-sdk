// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleDetailByRuleIdResponseBody : TeaModel {
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
        public DescribeRuleDetailByRuleIdResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRuleDetailByRuleIdResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Service authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("bizVersion")]
            [Validation(Required=false)]
            public string BizVersion { get; set; }

            /// <summary>
            /// <para>Primary key ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6633</para>
            /// </summary>
            [NameInMap("consoleRuleId")]
            [Validation(Required=false)]
            public long? ConsoleRuleId { get; set; }

            /// <summary>
            /// <para>Creation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MORMAL</para>
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
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Log expression.</para>
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
            /// <para>Memo.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <para>Rule action structure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///                 &quot;SCORE&quot;: [
            ///                     {
            ///                         &quot;actionType&quot;: &quot;SCORE&quot;,
            ///                         &quot;displayType&quot;: &quot;ACTION&quot;,
            ///                         &quot;code&quot;: &quot;deAddScore&quot;,
            ///                         &quot;sourceType&quot;: &quot;SAF&quot;,
            ///                         &quot;inputs&quot;: [
            ///                             &quot;123&quot;
            ///                         ],
            ///                         &quot;name&quot;: &quot;<b>addDeScore</b>&quot;,
            ///                         &quot;description&quot;: &quot;打分&quot;,
            ///                         &quot;inputTitle&quot;: &quot;123&quot;,
            ///                         &quot;outputType&quot;: &quot;const&quot;,
            ///                         &quot;type&quot;: &quot;ACTION&quot;,
            ///                         &quot;title&quot;: &quot;打分&quot;,
            ///                         &quot;fieldType&quot;: &quot;DOUBLE&quot;
            ///                     }
            ///                 ],
            ///                 &quot;VARIABLE&quot;: [
            ///                     {
            ///                         &quot;actionType&quot;: &quot;VARIABLE&quot;,
            ///                         &quot;displayType&quot;: &quot;MIDDLE&quot;,
            ///                         &quot;code&quot;: &quot;mid1&quot;,
            ///                         &quot;inputs&quot;: [
            ///                             &quot;gg&quot;
            ///                         ],
            ///                         &quot;name&quot;: &quot;mid1&quot;,
            ///                         &quot;description&quot;: &quot;中间变量,mid1&quot;,
            ///                         &quot;type&quot;: &quot;MIDDLE&quot;,
            ///                         &quot;title&quot;: &quot;mid1&quot;,
            ///                         &quot;fieldType&quot;: &quot;STRING&quot;
            ///                     }
            ///                 ],
            ///                 &quot;TAG&quot;: [
            ///                     {
            ///                         &quot;actionType&quot;: &quot;TAG&quot;,
            ///                         &quot;displayType&quot;: &quot;ACTION&quot;,
            ///                         &quot;code&quot;: &quot;addDeTags&quot;,
            ///                         &quot;sourceType&quot;: &quot;SAF&quot;,
            ///                         &quot;inputs&quot;: [
            ///                             &quot;123&quot;
            ///                         ],
            ///                         &quot;name&quot;: &quot;<b>addDeTags</b>&quot;,
            ///                         &quot;description&quot;: &quot;打标签&quot;,
            ///                         &quot;outputType&quot;: &quot;const&quot;,
            ///                         &quot;type&quot;: &quot;ACTION&quot;,
            ///                         &quot;title&quot;: &quot;打标签&quot;,
            ///                         &quot;fieldType&quot;: &quot;STRING&quot;
            ///                     }
            ///                 ],
            ///                 &quot;MIDDLE_VARIABLE&quot;: [
            ///                     {
            ///                         &quot;actionType&quot;: &quot;MIDDLE_VARIABLE&quot;,
            ///                         &quot;inputs&quot;: [
            ///                             &quot;mid1&quot;
            ///                         ],
            ///                         &quot;fieldValue&quot;: &quot;123&quot;,
            ///                         &quot;fieldType&quot;: &quot;STRING&quot;
            ///                     }
            ///                 ]
            ///             }</para>
            /// </summary>
            [NameInMap("ruleActionMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> RuleActionMap { get; set; }

            /// <summary>
            /// <para>Rule actions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;inputs\&quot;:[\&quot;123\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;},{\&quot;actionType\&quot;:\&quot;SCORE\&quot;,\&quot;code\&quot;:\&quot;deAddScore\&quot;,\&quot;description\&quot;:\&quot;打分\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;fieldType\&quot;:\&quot;DOUBLE\&quot;,\&quot;inputTitle\&quot;:\&quot;123\&quot;,\&quot;inputs\&quot;:[\&quot;123\&quot;],\&quot;name\&quot;:\&quot;<b>addDeScore</b>\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;打分\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;},{\&quot;actionType\&quot;:\&quot;MIDDLE_VARIABLE\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;fieldValue\&quot;:\&quot;123\&quot;,\&quot;inputs\&quot;:[\&quot;mid1\&quot;]},{\&quot;actionType\&quot;:\&quot;VARIABLE\&quot;,\&quot;code\&quot;:\&quot;mid1\&quot;,\&quot;description\&quot;:\&quot;中间变量,mid1\&quot;,\&quot;displayType\&quot;:\&quot;MIDDLE\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;inputs\&quot;:[\&quot;gg\&quot;],\&quot;name\&quot;:\&quot;mid1\&quot;,\&quot;title\&quot;:\&quot;mid1\&quot;,\&quot;type\&quot;:\&quot;MIDDLE\&quot;}]</para>
            /// </summary>
            [NameInMap("ruleActions")]
            [Validation(Required=false)]
            public string RuleActions { get; set; }

            /// <summary>
            /// <para>Rule authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NOMAL</para>
            /// </summary>
            [NameInMap("ruleAuthType")]
            [Validation(Required=false)]
            public string RuleAuthType { get; set; }

            /// <summary>
            /// <para>DSL policy expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;elseIfStatement\&quot;:[{\&quot;condition\&quot;:{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;list\&quot;:[{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;getLbsRegion(longitude, latitude)?.prov\&quot;,\&quot;description\&quot;:\&quot;根据经纬度得到省份信息，比如经度：111.878062，纬度：22.585409，则经过运算，输出”广东省“\&quot;,\&quot;displayType\&quot;:\&quot;SELF_BIND\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;sl_S02sHLFT7818\&quot;,\&quot;outputThreshold\&quot;:{},\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;经纬度自定义系统变量\&quot;,\&quot;type\&quot;:\&quot;SELF_BIND\&quot;},\&quot;operatorCode\&quot;:\&quot;equals\&quot;,\&quot;operatorName\&quot;:\&quot;等于\&quot;,\&quot;parentId\&quot;:0,\&quot;right\&quot;:{\&quot;name\&quot;:\&quot;cc\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;},\&quot;sequence\&quot;:5}],\&quot;parentId\&quot;:0,\&quot;relationship\&quot;:\&quot;and\&quot;},\&quot;then\&quot;:[{\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;inputs\&quot;:[\&quot;332\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;}]}],\&quot;elseStatement\&quot;:{\&quot;then\&quot;:[{\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;inputs\&quot;:[\&quot;321\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;}]},\&quot;ifStatement\&quot;:{\&quot;condition\&quot;:{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;list\&quot;:[{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;queryPhoneSimulatorInfo(deviceToken)?.brand\&quot;,\&quot;description\&quot;:\&quot;设备信息-终端品牌\&quot;,\&quot;displayType\&quot;:\&quot;DEVICE\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;<b>device_brand</b>\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;设备信息-终端品牌-brand\&quot;,\&quot;type\&quot;:\&quot;DEVICE\&quot;},\&quot;operatorCode\&quot;:\&quot;deInNameList\&quot;,\&quot;operatorName\&quot;:\&quot;在名单中\&quot;,\&quot;parentId\&quot;:0,\&quot;right\&quot;:{\&quot;code\&quot;:\&quot;nl_UN8otElLb490\&quot;,\&quot;description\&quot;:\&quot;描述11\&quot;,\&quot;displayType\&quot;:\&quot;NAME_LIST\&quot;,\&quot;name\&quot;:\&quot;nl_UN8otElLb490\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;wtz_名单新建测试02\&quot;,\&quot;type\&quot;:\&quot;NAME_LIST\&quot;},\&quot;sequence\&quot;:1},{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;deFunctionProcess(ip,\\\&quot;isIp\\\&quot;)\&quot;,\&quot;description\&quot;:\&quot;判断是否符合IPv4标准\&quot;,\&quot;displayType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;fieldType\&quot;:\&quot;BOOLEAN\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:false,\&quot;name\&quot;:\&quot;<b>isIpAddressV4</b>\&quot;,\&quot;outputThreshold\&quot;:{},\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;IP是否符合IPV4格式\&quot;,\&quot;type\&quot;:\&quot;SYSTEM_BIND\&quot;},\&quot;operatorCode\&quot;:\&quot;boolIsTrue\&quot;,\&quot;operatorName\&quot;:\&quot;为true\&quot;,\&quot;parentId\&quot;:0,\&quot;right\&quot;:{\&quot;name\&quot;:\&quot;\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;},\&quot;sequence\&quot;:2},{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;list\&quot;:[{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;parseIpV2(ip)?.cityId\&quot;,\&quot;description\&quot;:\&quot;通过IP地址库解析IP所在的城市Code，例如，输入“42.120.74.211”，经过该变量运算，输出“330100”。\&quot;,\&quot;displayType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;<b>ipLocationCityCode</b>\&quot;,\&quot;outputThreshold\&quot;:{},\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;IP所在地_城市Code\&quot;,\&quot;type\&quot;:\&quot;SYSTEM_BIND\&quot;},\&quot;operatorCode\&quot;:\&quot;equals\&quot;,\&quot;operatorName\&quot;:\&quot;等于\&quot;,\&quot;parentId\&quot;:0,\&quot;right\&quot;:{\&quot;code\&quot;:\&quot;deFunctionProcess(ip,\\\&quot;getCountry\\\&quot;)\&quot;,\&quot;description\&quot;:\&quot;通过IP地址库解析IP所在的城市名称，例如，输入“42.120.74.211”，经过该变量运算，输出“CN”。\&quot;,\&quot;displayType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;name\&quot;:\&quot;<b>ipLocationCountryId</b>\&quot;,\&quot;outputThreshold\&quot;:{},\&quot;rightVariableType\&quot;:\&quot;variable\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;IP所在地_国家Code\&quot;,\&quot;type\&quot;:\&quot;SYSTEM_BIND\&quot;},\&quot;sequence\&quot;:3},{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;list\&quot;:[{\&quot;currentId\&quot;:0,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;parseIpV2(ip)?.cityId\&quot;,\&quot;description\&quot;:\&quot;通过IP地址库解析IP所在的城市Code，例如，输入“42.120.74.211”，经过该变量运算，输出“330100”。\&quot;,\&quot;displayType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionCode\&quot;:\&quot;\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;<b>ipLocationCityCode</b>\&quot;,\&quot;outputThreshold\&quot;:{\&quot;$ref\&quot;:\&quot;$.ifStatement.condition.list[2].list[0].left.outputThreshold\&quot;},\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;IP所在地_城市Code\&quot;,\&quot;type\&quot;:\&quot;SYSTEM_BIND\&quot;},\&quot;operatorCode\&quot;:\&quot;deInNameList\&quot;,\&quot;operatorName\&quot;:\&quot;在名单中\&quot;,\&quot;parentId\&quot;:0,\&quot;right\&quot;:{\&quot;code\&quot;:\&quot;nl_NsVwBD2s11e0\&quot;,\&quot;displayType\&quot;:\&quot;NAME_LIST\&quot;,\&quot;name\&quot;:\&quot;nl_NsVwBD2s11e0\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;device_block_list\&quot;,\&quot;type\&quot;:\&quot;NAME_LIST\&quot;},\&quot;sequence\&quot;:4}],\&quot;parentId\&quot;:0,\&quot;relationship\&quot;:\&quot;and\&quot;}],\&quot;parentId\&quot;:0,\&quot;relationship\&quot;:\&quot;and\&quot;}],\&quot;parentId\&quot;:0,\&quot;relationship\&quot;:\&quot;and\&quot;},\&quot;then\&quot;:[{\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;code\&quot;:\&quot;addDeTags\&quot;,\&quot;description\&quot;:\&quot;打标签\&quot;,\&quot;displayType\&quot;:\&quot;ACTION\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;inputs\&quot;:[\&quot;123\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;,\&quot;sourceType\&quot;:\&quot;SAF\&quot;,\&quot;title\&quot;:\&quot;打标签\&quot;,\&quot;type\&quot;:\&quot;ACTION\&quot;}]}}</para>
            /// </summary>
            [NameInMap("ruleBody")]
            [Validation(Required=false)]
            public string RuleBody { get; set; }

            /// <summary>
            /// <para>Rule expressions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;expressionName\&quot;:\&quot;营销风险识别评分\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;sl_rjtsDXK124a5\&quot;},\&quot;operatorCode\&quot;:\&quot;between\&quot;,\&quot;operatorName\&quot;:\&quot;数字在[a,b]之间\&quot;,\&quot;right\&quot;:{\&quot;fieldValue\&quot;:\&quot;[65,100]\&quot;}}]</para>
            /// </summary>
            [NameInMap("ruleExpressions")]
            [Validation(Required=false)]
            public string RuleExpressions { get; set; }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101544</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

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
            /// <para>Rule type.</para>
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
            /// <para>3823</para>
            /// </summary>
            [NameInMap("ruleVersionId")]
            [Validation(Required=false)]
            public long? RuleVersionId { get; set; }

        }

    }

}
