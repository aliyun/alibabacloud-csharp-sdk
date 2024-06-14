// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateClientKeyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("ClientKeyId")]
        [Validation(Required=false)]
        public string ClientKeyId { get; set; }

        /// <summary>
        /// The ID of the client key.
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// The beginning of the validity period of the client key.
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// The private key of the client key.
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// The algorithm that is used to encrypt the private key of the client key. Currently, only RSA_2048 is supported.
        /// </summary>
        [NameInMap("PrivateKeyData")]
        [Validation(Required=false)]
        public string PrivateKeyData { get; set; }

        /// <summary>
        /// The beginning of the validity period of the client key.
        /// 
        /// Specify the time in the ISO 8601 standard. The time must be in UTC. The time must be in the yyyy-MM-ddTHH:mm:ssZ format.
        /// 
        /// > 
        /// 
        /// *   If you do not configure NotBefore, the default value is the time when the client key was created.
        /// *   If you configure NotBefore, you must configure NotAfter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
