// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("InterceptionRuleDetail")]
        [Validation(Required=false)]
        public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail InterceptionRuleDetail { get; set; }
        public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail : TeaModel {
            /// <summary>
            /// The destination network object.
            /// </summary>
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget DstTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// An array that consists of the name of the image specified for the network object.
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// The namespace to which the network object belongs.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// An array that consists of the port range of the destination network object.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                /// <summary>
                /// The type of the rule.
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// An array that consists of the labels specified for the network object.
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// The ID of the network object.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// The name of the object.
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// The type of the network object.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The interception mode. Valid values:
            /// 
            /// *   **0**: monitor
            /// *   **1**: block
            /// *   **2**: alert
            /// *   **3**: allow
            /// </summary>
            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            /// <summary>
            /// The priority of the rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the defense rule. Valid values:
            /// 
            /// *   **1**: The rule is enabled.
            /// *   **0**: The rule is disabled.
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// The type of the rule. Valid values:
            /// 
            /// *   **suggest**: a suggestion rule
            /// *   **customize**: a custom rule
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// The source network object.
            /// </summary>
            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget SrcTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget : TeaModel {
                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The images of the network object.
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                /// <summary>
                /// The namespace to which the network object belongs.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The type of the rule.
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// The labels specified for the network object.
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                /// <summary>
                /// The ID of the network object.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                /// <summary>
                /// The name of the object.
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// The type of the network object.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
