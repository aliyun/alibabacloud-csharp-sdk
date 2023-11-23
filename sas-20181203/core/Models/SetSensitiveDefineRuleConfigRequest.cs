// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetSensitiveDefineRuleConfigRequest : TeaModel {
        /// <summary>
        /// The configurations of the custom check rule. The value is in the JSON format. Valid values of keys:
        /// 
        /// *   **classKey**: the category keyword of the check rule.
        /// *   **ruleList**: the keyword of the check rule.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
