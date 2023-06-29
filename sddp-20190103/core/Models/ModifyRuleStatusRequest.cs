// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the sensitive data detection rule.
        /// 
        /// > You can query the ID of the sensitive data detection rule by calling the **DescribeRules** operation.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The ID of the sensitive data detection rule. Separate multiple IDs with commas (,).
        /// 
        /// > You can query the ID of the sensitive data detection rule by calling the **DescribeRules** operation.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to enable or disable the sensitive data detection rule. Valid values:
        /// 
        /// *   **0**: disables the sensitive data detection rule.
        /// *   **1**: enables the sensitive data detection rule.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
