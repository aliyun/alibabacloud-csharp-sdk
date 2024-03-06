// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListClientKeysResponseBody : TeaModel {
        /// <summary>
        /// A list of client keys.
        /// </summary>
        [NameInMap("ClientKeys")]
        [Validation(Required=false)]
        public List<ListClientKeysResponseBodyClientKeys> ClientKeys { get; set; }
        public class ListClientKeysResponseBodyClientKeys : TeaModel {
            /// <summary>
            /// The name of the AAP.
            /// </summary>
            [NameInMap("AapName")]
            [Validation(Required=false)]
            public string AapName { get; set; }

            /// <summary>
            /// The ID of the client key.
            /// </summary>
            [NameInMap("ClientKeyId")]
            [Validation(Required=false)]
            public string ClientKeyId { get; set; }

            /// <summary>
            /// The time when the client key was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The private key algorithm of the client key.
            /// </summary>
            [NameInMap("KeyAlgorithm")]
            [Validation(Required=false)]
            public string KeyAlgorithm { get; set; }

            /// <summary>
            /// The provider of the client key.
            /// 
            /// Currently, only KMS is supported. The value is fixed as KMS_PROVIDED.
            /// </summary>
            [NameInMap("KeyOrigin")]
            [Validation(Required=false)]
            public string KeyOrigin { get; set; }

            /// <summary>
            /// The end of the validity period of the client key.
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            /// <summary>
            /// The beginning of the validity period of the client key.
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            /// <summary>
            /// The public key of the client key.
            /// </summary>
            [NameInMap("PublicKeyData")]
            [Validation(Required=false)]
            public string PublicKeyData { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
