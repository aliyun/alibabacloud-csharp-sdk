// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousOverallConfigResponseBody : TeaModel {
        /// <summary>
        /// The configuration.
        /// </summary>
        [NameInMap("OverallConfig")]
        [Validation(Required=false)]
        public DescribeSuspiciousOverallConfigResponseBodyOverallConfig OverallConfig { get; set; }
        public class DescribeSuspiciousOverallConfigResponseBodyOverallConfig : TeaModel {
            /// <summary>
            /// The status of the feature. Valid values:
            /// 
            /// *   **off**: disabled
            /// *   **on**: enabled
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The type of the feature. Valid values:
            /// 
            /// *   **auto_breaking**: Anti-Virus
            /// *   **ransomware_breaking**: Anti-ransomware (Bait Capture)
            /// *   **webshell_cloud_breaking**: Webshell Protection
            /// *   **alinet**: Behavior prevention
            /// *   **k8s_log_analysis**: K8s Threat Detection
            /// *   **alisecguard**: Defense mode for Client Protection
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
