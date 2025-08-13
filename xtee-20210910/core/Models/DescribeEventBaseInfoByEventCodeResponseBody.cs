// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventBaseInfoByEventCodeResponseBody : TeaModel {
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
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventBaseInfoByEventCodeResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventBaseInfoByEventCodeResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Business version number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("bizVersion")]
            [Validation(Required=false)]
            public int? BizVersion { get; set; }

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
            /// <para>Event status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("eventStauts")]
            [Validation(Required=false)]
            public string EventStauts { get; set; }

            /// <summary>
            /// <para>Field list.</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<DescribeEventBaseInfoByEventCodeResponseBodyResultObjectInputFields> InputFields { get; set; }
            public class DescribeEventBaseInfoByEventCodeResponseBodyResultObjectInputFields : TeaModel {
                /// <summary>
                /// <para>Field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Field code</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                /// <summary>
                /// <para>Field ranking</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fieldRank")]
                [Validation(Required=false)]
                public string FieldRank { get; set; }

                /// <summary>
                /// <para>Field source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("fieldSource")]
                [Validation(Required=false)]
                public string FieldSource { get; set; }

                /// <summary>
                /// <para>Field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>Field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

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
            /// <para>Policy Information</para>
            /// </summary>
            [NameInMap("ruleDetails")]
            [Validation(Required=false)]
            public List<DescribeEventBaseInfoByEventCodeResponseBodyResultObjectRuleDetails> RuleDetails { get; set; }
            public class DescribeEventBaseInfoByEventCodeResponseBodyResultObjectRuleDetails : TeaModel {
                /// <summary>
                /// <para>Policy Execution Logic</para>
                /// 
                /// <b>Example:</b>
                /// <para>3&amp;((1&amp;2&amp;4)</para>
                /// </summary>
                [NameInMap("logicExpression")]
                [Validation(Required=false)]
                public string LogicExpression { get; set; }

                /// <summary>
                /// <para>Memo</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>Rule Actions</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;inputs\&quot;:[\&quot;auto_accselist\&quot;],\&quot;name\&quot;:\&quot;<b>addDeTags</b>\&quot;,\&quot;actionType\&quot;:\&quot;TAG\&quot;,\&quot;outputType\&quot;:\&quot;const\&quot;}]</para>
                /// </summary>
                [NameInMap("ruleActions")]
                [Validation(Required=false)]
                public string RuleActions { get; set; }

                /// <summary>
                /// <para>Policy Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("ruleAuthType")]
                [Validation(Required=false)]
                public string RuleAuthType { get; set; }

                /// <summary>
                /// <para>Event Expressions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;expressionName\&quot;:\&quot;同一设备同一IP上的注册用户数\&quot;,\&quot;itemId\&quot;:1,\&quot;left\&quot;:{\&quot;name\&quot;:\&quot;dK7EXHr490f\&quot;},\&quot;operatorCode\&quot;:\&quot;gte\&quot;,\&quot;operatorName\&quot;:\&quot;大于等于\&quot;,\&quot;right\&quot;:{\&quot;fieldValue\&quot;:\&quot;2\&quot;}}]</para>
                /// </summary>
                [NameInMap("ruleExpressions")]
                [Validation(Required=false)]
                public string RuleExpressions { get; set; }

                /// <summary>
                /// <para>Policy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>101544</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>Policy Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>手机号MD5命中人脸测试名单</para>
                /// </summary>
                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Policy Status</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFT</para>
                /// </summary>
                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

            }

            /// <summary>
            /// <para>Operation template code</para>
            /// 
            /// <b>Example:</b>
            /// <para>register</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>Template name</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册事件模板</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Template type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEMPLATE</para>
            /// </summary>
            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

    }

}
