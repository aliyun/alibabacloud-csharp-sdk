// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("BackupPolicyDetail")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDetail BackupPolicyDetail { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDetail : TeaModel {
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// DescribeBackupPolicy
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// Queries the details of an anti-ransomware policy for servers.
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// The ID of the region in which backup data is stored.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
