// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class TagResourceRequest : TeaModel {
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
        /// One or more tags that you want to add. The value is in the array format.
        /// 
        /// Tag attributes:
        /// 
        /// *   TagKey: the tag key.
        /// *   TagValue: the tag value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
