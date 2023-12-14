// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// The feature that you want to select for the asset. Valid values:
        /// 
        /// *   **VIRUS_SCAN_CYCLE_CONFIG**: virus detection and removal
        /// *   **VIRUS_SCAN_ONCE_TASK**: one-time scan for viruses
        /// *   **AGENTLESS_MALICIOUS_WHITE_LIST_\[ID]**: a whitelist rule for alerts that are detected by using the agentless detection feature
        /// *   **AGENTLESS_VUL_WHITE_LIST_\[ID]**: a whitelist rule for vulnerabilities that are detected by using the agentless detection feature
        /// *   **FILE_PROTECT_RULE_SWITCH_TYPE_\[ID]**: core file protection
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The dimension based on which you want to select the asset. Valid values:
        /// 
        /// *   **instance**: selects the asset by server.
        /// *   **group**: selects the asset by group.
        /// *   **vpc**: selects the asset by virtual private cloud (VPC).
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
