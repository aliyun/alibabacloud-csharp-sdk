// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePrivateKeyDecryptRequest : TeaModel {
        /// <summary>
        /// The encryption algorithm. Valid values:
        /// 
        /// *   RSAES_OAEP_SHA\_1
        /// 
        /// *   RSAES_OAEP_SHA\_256
        /// 
        /// *   SM2PKE
        /// 
        /// > The SM2PKE encryption algorithm is supported only in regions in mainland China. In these regions, managed hardware security modules (HSMs) are used. For more information, see [Managed HSM overview](~~125803~~).
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The ID of the certificate. The ID must be globally unique in Certificates Manager.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The data that you want to decrypt.
        /// 
        /// The value is encoded in Base64.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

    }

}
