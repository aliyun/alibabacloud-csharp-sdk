// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckResultResponseBody : TeaModel {
        /// <summary>
        /// The check results.
        /// </summary>
        [NameInMap("CheckResultList")]
        [Validation(Required=false)]
        public List<DescribeCheckResultResponseBodyCheckResultList> CheckResultList { get; set; }
        public class DescribeCheckResultResponseBodyCheckResultList : TeaModel {
            /// <summary>
            /// The compliance status. Valid values:
            /// 
            /// *   **1**: compliant
            /// *   **0**: non-compliant
            /// </summary>
            [NameInMap("ComplianceStatus")]
            [Validation(Required=false)]
            public int? ComplianceStatus { get; set; }

            /// <summary>
            /// The name of the corresponding section. Valid values:
            /// 
            /// *   **information_classification**: information classification
            /// *   **information_mark**: information labeling
            /// *   **network_security_policy**: access to networks and network services
            /// *   **login_control**: secure logon procedures
            /// *   **week_password**: password management system
            /// *   **key_manage**: key management
            /// *   **malicious_software**: protection against malware
            /// *   **information_backup**: information backup
            /// *   **audit_policy**: information system audit control mechanisms
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
