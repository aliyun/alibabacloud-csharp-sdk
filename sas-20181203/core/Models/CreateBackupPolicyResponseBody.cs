// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the anti-ransomware policy.
        /// </summary>
        [NameInMap("BackupPolicy")]
        [Validation(Required=false)]
        public CreateBackupPolicyResponseBodyBackupPolicy BackupPolicy { get; set; }
        public class CreateBackupPolicyResponseBodyBackupPolicy : TeaModel {
            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **enabled**
            /// *   **disabled**
            /// 
            /// >  After you create an anti-ransomware policy, the policy is enabled by default.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
