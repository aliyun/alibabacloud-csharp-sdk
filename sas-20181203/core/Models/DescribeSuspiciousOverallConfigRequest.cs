// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousOverallConfigRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   **auto_breaking**: Anti-Virus
        /// *   **ransomware_breaking**: Anti-ransomware (Bait Capture)
        /// *   **webshell_cloud_breaking**: Webshell Protection
        /// *   **alinet**: Behavior prevention
        /// *   **k8s_log_analysis**: K8s Threat Detection
        /// *   **alisecguard**: Defense mode for Client Protection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
