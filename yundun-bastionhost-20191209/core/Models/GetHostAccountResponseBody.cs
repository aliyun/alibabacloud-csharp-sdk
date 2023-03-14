// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostAccountResponseBody : TeaModel {
        /// <summary>
        /// The details of the host account that were queried.
        /// </summary>
        [NameInMap("HostAccount")]
        [Validation(Required=false)]
        public GetHostAccountResponseBodyHostAccount HostAccount { get; set; }
        public class GetHostAccountResponseBodyHostAccount : TeaModel {
            /// <summary>
            /// Indicates whether a password is set for the host account. Valid values:
            /// 
            /// *   **true**: indicates that a password is set for the host account.
            /// *   **false**: indicates that no password is set for the host account.
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// The ID of the host account.
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// The name of the host account.
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// The ID of the host to which the host account belongs.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The ID of the shared key.
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// The name of the shared key.
            /// </summary>
            [NameInMap("HostShareKeyName")]
            [Validation(Required=false)]
            public string HostShareKeyName { get; set; }

            /// <summary>
            /// The fingerprint of the private key.
            /// </summary>
            [NameInMap("PrivateKeyFingerprint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerprint { get; set; }

            /// <summary>
            /// The protocol used by the host account. Valid values:
            /// 
            /// *   **SSH**
            /// *   **RDP**
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
