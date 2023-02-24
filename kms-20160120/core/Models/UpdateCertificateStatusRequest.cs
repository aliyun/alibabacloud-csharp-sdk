// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateCertificateStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate. The ID must be globally unique in Certificates Manager.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The status of the certificate. Valid values:
        /// 
        /// *   INACTIVE: The certificate is disabled.
        /// 
        /// *   ACTIVE: The certificate is enabled.
        /// 
        /// *   REVOKED: The certificate is revoked.
        /// 
        /// > If the certificate is in the REVOKED state, you can use the certificate only to verify a signature, but not to generate a signature.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
