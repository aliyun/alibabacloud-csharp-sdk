// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSuspiciousOverallConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the feature. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

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
        /// Specifies whether to configure assets for the feature. Default value: **false**. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  This parameter takes effect only when you set **Config** to **on**.
        /// </summary>
        [NameInMap("NoTargetAsOn")]
        [Validation(Required=false)]
        public bool? NoTargetAsOn { get; set; }

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
        /// *   **webshell\_cloud_breaking**: Webshell Protection
        /// *   **alinet**: Behavior prevention
        /// *   **k8s\_log_analysis**: K8s Threat Detection
        /// *   **alisecguard**: Defense mode for Client Protection
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
