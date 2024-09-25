// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class RulesValue : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Rate")]
        [Validation(Required=false)]
        public int? Rate { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceNum")]
        [Validation(Required=false)]
        public int? InstanceNum { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public RulesValueRules Rules { get; set; }
        public class RulesValueRules : TeaModel {
            [NameInMap("springcloud")]
            [Validation(Required=false)]
            public List<RulesValueRulesSpringcloud> Springcloud { get; set; }
            public class RulesValueRulesSpringcloud : TeaModel {
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<RulesValueRulesSpringcloudRestItems> RestItems { get; set; }
                public class RulesValueRulesSpringcloudRestItems : TeaModel {
                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                [NameInMap("triggerPolicy")]
                [Validation(Required=false)]
                public string TriggerPolicy { get; set; }

                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            [NameInMap("dubbo")]
            [Validation(Required=false)]
            public List<RulesValueRulesDubbo> Dubbo { get; set; }
            public class RulesValueRulesDubbo : TeaModel {
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("triggerPolicy")]
                [Validation(Required=false)]
                public string TriggerPolicy { get; set; }

                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("methodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                [NameInMap("paramTypes")]
                [Validation(Required=false)]
                public List<string> ParamTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                [NameInMap("argumentItems")]
                [Validation(Required=false)]
                public List<RulesValueRulesDubboArgumentItems> ArgumentItems { get; set; }
                public class RulesValueRulesDubboArgumentItems : TeaModel {
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

            }

        }

    }

}
