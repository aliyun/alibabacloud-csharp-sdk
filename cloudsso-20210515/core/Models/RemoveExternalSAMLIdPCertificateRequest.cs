// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class RemoveExternalSAMLIdPCertificateRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// 
        /// You can call the [ListExternalSAMLIdPCertificates](~~341629~~) operation to query the IDs of certificates.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

    }

}
