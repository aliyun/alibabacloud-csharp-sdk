// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSmbAclResponseBody : TeaModel {
        /// <summary>
        /// The information about the ACL feature.
        /// </summary>
        [NameInMap("Acl")]
        [Validation(Required=false)]
        public DescribeSmbAclResponseBodyAcl Acl { get; set; }
        public class DescribeSmbAclResponseBodyAcl : TeaModel {
            /// <summary>
            /// Indicates whether the file system allows anonymous access. Valid values:
            /// 
            /// *   true: The file system allows anonymous access.
            /// *   false: The file system does not allow anonymous access.
            /// </summary>
            [NameInMap("EnableAnonymousAccess")]
            [Validation(Required=false)]
            public bool? EnableAnonymousAccess { get; set; }

            /// <summary>
            /// Indicates whether the ACL feature is enabled. Valid values:
            /// 
            /// *   true: The ACL feature is enabled.
            /// *   false: The ACL feature is disabled.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// Indicates whether encryption in transit is enabled. Valid values:
            /// 
            /// *   true: Encryption in transit is enabled.
            /// *   false: Encryption in transit is disabled.
            /// </summary>
            [NameInMap("EncryptData")]
            [Validation(Required=false)]
            public bool? EncryptData { get; set; }

            /// <summary>
            /// The home directory of each user.
            /// </summary>
            [NameInMap("HomeDirPath")]
            [Validation(Required=false)]
            public string HomeDirPath { get; set; }

            /// <summary>
            /// Indicates whether the file system denies access from non-encrypted clients. Valid values:
            /// 
            /// *   true: The file system denies access from non-encrypted clients.
            /// *   false: The file system allows access from non-encrypted clients.
            /// </summary>
            [NameInMap("RejectUnencryptedAccess")]
            [Validation(Required=false)]
            public bool? RejectUnencryptedAccess { get; set; }

            /// <summary>
            /// The ID of a super admin.
            /// </summary>
            [NameInMap("SuperAdminSid")]
            [Validation(Required=false)]
            public string SuperAdminSid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
