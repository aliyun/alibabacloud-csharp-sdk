// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailRequest : TeaModel {
        /// <summary>
        /// If true, the Cert, Key, EncryptCert, EncryptPrivateKey, SignCert, SignPrivateKey will return null, default is false.
        /// </summary>
        [NameInMap("CertFilter")]
        [Validation(Required=false)]
        public bool? CertFilter { get; set; }

        /// <summary>
        /// The ID of the certificate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

    }

}
