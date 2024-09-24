// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("InterceptionRuleDetail")]
        [Validation(Required=false)]
        public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail InterceptionRuleDetail { get; set; }
        public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail : TeaModel {
            /// <summary>
            /// <para>The destination network object.</para>
            /// </summary>
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget DstTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>An array that consists of the name of the image specified for the network object.</para>
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// <para>The namespace to which the network object belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>An array that consists of the port range of the destination network object.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                /// <summary>
                /// <para>The type of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>An array that consists of the labels specified for the network object.</para>
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// <para>The ID of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200014</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// <para>The name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo4-be1</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// <para>The type of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The interception mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: monitor</description></item>
            /// <item><description><b>1</b>: block</description></item>
            /// <item><description><b>2</b>: alert</description></item>
            /// <item><description><b>3</b>: allow</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            /// <summary>
            /// <para>The priority of the rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>467</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dmz-frontend-accept</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The rule is enabled.</description></item>
            /// <item><description><b>0</b>: The rule is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>suggest</b>: a suggestion rule</description></item>
            /// <item><description><b>customize</b>: a custom rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>customize</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The source network object.</para>
            /// </summary>
            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget SrcTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The images of the network object.</para>
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// <para>The namespace to which the network object belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The type of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customize</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The labels specified for the network object.</para>
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// <para>The ID of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300635</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// <para>The name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmz</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// <para>The type of the network object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBC6E47-7508-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
