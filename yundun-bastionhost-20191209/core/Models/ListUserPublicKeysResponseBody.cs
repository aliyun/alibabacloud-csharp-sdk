// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUserPublicKeysResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the public keys of the user.
        /// </summary>
        [NameInMap("PublicKeys")]
        [Validation(Required=false)]
        public List<ListUserPublicKeysResponseBodyPublicKeys> PublicKeys { get; set; }
        public class ListUserPublicKeysResponseBodyPublicKeys : TeaModel {
            /// <summary>
            /// The description of the public key.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The fingerprint of the public key.
            /// </summary>
            [NameInMap("FingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

            /// <summary>
            /// The ID of the public key.
            /// </summary>
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }

            /// <summary>
            /// The name of the public key.
            /// </summary>
            [NameInMap("PublicKeyName")]
            [Validation(Required=false)]
            public string PublicKeyName { get; set; }

            /// <summary>
            /// The ID of the user to which the public key belongs.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of public keys.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
