// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAegisContainerPluginRuleResponseBodyData Data { get; set; }
        public class GetAegisContainerPluginRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The timestamp when the rule was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The timestamp when the rule was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The action mode of the rule. Valid values:
            /// 
            /// *   **0**: allows escape behavior.
            /// *   **1**: triggers alerts.
            /// *   **2**: blocks escape behavior.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

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
            /// The template ID of the rule.
            /// </summary>
            [NameInMap("RuleTemplateId")]
            [Validation(Required=false)]
            public string RuleTemplateId { get; set; }

            /// <summary>
            /// The template name of the rule.
            /// </summary>
            [NameInMap("RuleTemplateName")]
            [Validation(Required=false)]
            public string RuleTemplateName { get; set; }

            /// <summary>
            /// The rule items.
            /// </summary>
            [NameInMap("SelectedPolicy")]
            [Validation(Required=false)]
            public List<string> SelectedPolicy { get; set; }

            /// <summary>
            /// The ID of the switch.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// The images that are added to the whitelist.
            /// </summary>
            [NameInMap("WhiteImages")]
            [Validation(Required=false)]
            public List<string> WhiteImages { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
