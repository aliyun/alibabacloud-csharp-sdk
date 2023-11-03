// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetContainerDefenseRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContainerDefenseRuleDetailResponseBodyData Data { get; set; }
        public class GetContainerDefenseRuleDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The alert name. Valid values:
            /// 
            /// *   **Non-image Program Startup**
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The alert type. Valid values:
            /// 
            /// *   **Proactive Defense for Containers**
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The action specified in the rule. Valid values:
            /// 
            /// *   **1**: alert
            /// *   **2**: block
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            /// <summary>
            /// The type of the rule. Valid values:
            /// 
            /// *   **1**: system rule
            /// *   **2**: custom rule
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// The effective scope of the rule.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<GetContainerDefenseRuleDetailResponseBodyDataScope> Scope { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataScope : TeaModel {
                /// <summary>
                /// Indicates whether all namespaces are included. Valid values:
                /// 
                /// *   **0**: no
                /// *   **1**: yes
                /// </summary>
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                /// <summary>
                /// The ID of the container cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The namespaces.
                /// </summary>
                [NameInMap("Namespaces")]
                [Validation(Required=false)]
                public List<string> Namespaces { get; set; }

            }

            /// <summary>
            /// The whitelist.
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public GetContainerDefenseRuleDetailResponseBodyDataWhitelist Whitelist { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataWhitelist : TeaModel {
                /// <summary>
                /// The hash values of the files that are added to the whitelist.
                /// 
                /// >  This parameter is not supported.
                /// </summary>
                [NameInMap("Hash")]
                [Validation(Required=false)]
                public List<string> Hash { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public List<string> Image { get; set; }

                /// <summary>
                /// The paths to the files that are added to the whitelist.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public List<string> Path { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
