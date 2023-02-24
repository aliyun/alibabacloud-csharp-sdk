// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UntagResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// 
        /// >  You can configure only one of the KeyId, SecretName, and CertificateId parameters.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The ID of the customer master key (CMK). The ID must be globally unique.
        /// 
        /// >  You can configure only one of the KeyId, SecretName, and CertificateId parameters.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// >  You can configure only one of the KeyId, SecretName, and CertificateId parameters.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// One or more tag keys. Separate multiple tag keys with commas (,).
        /// 
        /// You need to specify only the tag keys, not the tag values.
        /// 
        /// Each tag key must be 1 to 128 bytes in length.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
