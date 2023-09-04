// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateSCIMServerCredentialResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the SCIM credential.
        /// </summary>
        [NameInMap("SCIMServerCredential")]
        [Validation(Required=false)]
        public CreateSCIMServerCredentialResponseBodySCIMServerCredential SCIMServerCredential { get; set; }
        public class CreateSCIMServerCredentialResponseBodySCIMServerCredential : TeaModel {
            /// <summary>
            /// The time when the SCIM credential was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the SCIM credential.
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// The SCIM credential.
            /// 
            /// >  The SCIM credential is returned only when it is created. After the SCIM credential is created, you cannot query it. Keep the SCIM credential confidential.
            /// </summary>
            [NameInMap("CredentialSecret")]
            [Validation(Required=false)]
            public string CredentialSecret { get; set; }

            /// <summary>
            /// The type of the SCIM credential.
            /// </summary>
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// The ID of the directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The time when the SCIM credential expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The status of the SCIM credential. The value is fixed as Enabled, which indicates that the SCIM credential is enabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
