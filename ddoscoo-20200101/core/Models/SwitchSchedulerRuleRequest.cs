// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class SwitchSchedulerRuleRequest : TeaModel {
        /// <summary>
        /// The name of the scheduling rule to manage.
        /// 
        /// > You can call the [DescribeSchedulerRules](https://help.aliyun.com/document_detail/157481.html) operation to query the names of all scheduling rules.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of the scheduling rule. Valid values:
        /// 
        /// *   **2**: tiered protection rule
        /// *   **3**: network acceleration rule
        /// *   **5**: Alibaba Cloud CDN (CDN) interaction rule
        /// *   **6**: cloud service interaction rule
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The configuration that is used to switch service traffic. This parameter is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that includes the following parameters:
        /// 
        /// *   **Value**: required. The IP address of the associated resource. Data type: string.
        /// 
        /// *   **State**: required. The operation type. Data type: integer. Valid values:
        /// 
        ///     *   **0**: switches service traffic from the associated resource to your Anti-DDoS Pro or Anti-DDoS Premium instance for scrubbing.
        ///     *   **1**: switches service traffic back to the associated cloud resource.
        /// 
        /// *   **Interval**: optional. The waiting time that is required before the service traffic is switched back. Unit: minutes. Data type: integer. Usage notes:
        /// 
        ///     *   If the **State** parameter is set to **0**, you must set this parameter to \\*\\*-1\\*\\*. Otherwise, the call fails.
        ///     *   If the **State** parameter is set to **1**, you do not need to set this parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SwitchData")]
        [Validation(Required=false)]
        public string SwitchData { get; set; }

    }

}
