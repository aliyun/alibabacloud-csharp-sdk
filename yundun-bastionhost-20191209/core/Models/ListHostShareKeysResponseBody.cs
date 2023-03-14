// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostShareKeysResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the shared keys.
        /// </summary>
        [NameInMap("HostShareKeys")]
        [Validation(Required=false)]
        public List<ListHostShareKeysResponseBodyHostShareKeys> HostShareKeys { get; set; }
        public class ListHostShareKeysResponseBodyHostShareKeys : TeaModel {
            /// <summary>
            /// The number of the associated host accounts.
            /// </summary>
            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public long? HostAccountCount { get; set; }

            /// <summary>
            /// The ID of the host account.
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
            /// The time when the shared key was last modified.
            /// </summary>
            [NameInMap("LastModifyKeyAt")]
            [Validation(Required=false)]
            public long? LastModifyKeyAt { get; set; }

            /// <summary>
            /// The fingerprint of the private key.
            /// </summary>
            [NameInMap("PrivateKeyFingerPrint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerPrint { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the shared keys.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
