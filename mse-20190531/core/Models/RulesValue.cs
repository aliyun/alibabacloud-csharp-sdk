// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class RulesValue : TeaModel {
        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public int? Rate { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The environment of this routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The name of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceNum")]
        [Validation(Required=false)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// <para>The rule information.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public RulesValueRules Rules { get; set; }
        public class RulesValueRules : TeaModel {
            /// <summary>
            /// <para>The Spring Cloud rules.</para>
            /// </summary>
            [NameInMap("springcloud")]
            [Validation(Required=false)]
            public List<RulesValueRulesSpringcloud> Springcloud { get; set; }
            public class RulesValueRulesSpringcloud : TeaModel {
                /// <summary>
                /// <para>The logical operator used between the following items. Valid values: AND and OR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The list of matching conditions for REST requests.</para>
                /// </summary>
                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<RulesValueRulesSpringcloudRestItems> RestItems { get; set; }
                public class RulesValueRulesSpringcloudRestItems : TeaModel {
                    /// <summary>
                    /// <para>The value to be compared for operators such as rawvalue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    /// <summary>
                    /// <para>The operator. A value of rawvalue indicates direct comparison. A value of mode indicates a modulo operation. A value of list indicates a whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The field required for the list operator.</para>
                    /// </summary>
                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    /// <summary>
                    /// <para>The comparison operator. Valid values: &gt;=, &lt;=, &gt;, &lt;, and ==.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The divisor field required for the mod operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    /// <summary>
                    /// <para>The percentage value field required for the percentage operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    /// <summary>
                    /// <para>The proportion rule. For example, 20% indicates that 20% of the traffic is routed to the node corresponding to the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTENT</para>
                /// </summary>
                [NameInMap("triggerPolicy")]
                [Validation(Required=false)]
                public string TriggerPolicy { get; set; }

                /// <summary>
                /// <para>Specifies whether the rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>@</b></em></para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The list of tags.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The list of paths.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/hello</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The Dubbo rules.</para>
            /// </summary>
            [NameInMap("dubbo")]
            [Validation(Required=false)]
            public List<RulesValueRulesDubbo> Dubbo { get; set; }
            public class RulesValueRulesDubbo : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>@</b></em></para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The list of tags.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTENT</para>
                /// </summary>
                [NameInMap("triggerPolicy")]
                [Validation(Required=false)]
                public string TriggerPolicy { get; set; }

                /// <summary>
                /// <para>The service name (interface).</para>
                /// 
                /// <b>Example:</b>
                /// <para>HelloService</para>
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The Dubbo service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The Dubbo service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The method name of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("methodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The list of parameter types.</para>
                /// </summary>
                [NameInMap("paramTypes")]
                [Validation(Required=false)]
                public List<string> ParamTypes { get; set; }

                /// <summary>
                /// <para>The logical operator used between the following items. Valid values: AND and OR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The list of parameter content.</para>
                /// </summary>
                [NameInMap("argumentItems")]
                [Validation(Required=false)]
                public List<RulesValueRulesDubboArgumentItems> ArgumentItems { get; set; }
                public class RulesValueRulesDubboArgumentItems : TeaModel {
                    /// <summary>
                    /// <para>The operator. A value of rawvalue indicates direct comparison. A value of mode indicates a modulo operation. A value of list indicates a whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The list of names.</para>
                    /// </summary>
                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    /// <summary>
                    /// <para>The value to be compared for operators such as rawvalue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    /// <summary>
                    /// <para>The comparison operator. Valid values: &gt;=, &lt;=, &gt;, &lt;, and ==.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The divisor field required for the mod operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    /// <summary>
                    /// <para>The percentage value field required for the percentage operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    /// <summary>
                    /// <para>The proportion rule. For example, 20% indicates that 20% of the traffic is routed to the node corresponding to the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// <para>The position of the parameter, starting from 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The expression. See other field descriptions for details.</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>The value to compare. The value obtained from the expression is compared with this value. If the operator is a list whitelist, separate values with commas (,), such as 1,2,3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1,2,3</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

            }

        }

    }

}
