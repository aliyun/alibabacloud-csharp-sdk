// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The action that you want to specify for the rule. Valid values:
        /// 
        /// *   **1**: triggers alerts.
        /// *   **2**: blocks escapes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// The name of the rule. The name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_). The names of rules that are created for the same user must be unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The ID of the rule template. You can call the ListSystemClientRules operation to query the ID of the rule template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleTemplateId")]
        [Validation(Required=false)]
        public int? RuleTemplateId { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   **0**: custom rule
        /// *   **1**: system rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The check items that are enabled for the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SelectedPolicy")]
        [Validation(Required=false)]
        public List<string> SelectedPolicy { get; set; }

        /// <summary>
        /// The images that are added to the whitelist.
        /// </summary>
        [NameInMap("WhiteImages")]
        [Validation(Required=false)]
        public List<string> WhiteImages { get; set; }

    }

}
