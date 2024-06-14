// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteCertificateRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate. It is the globally unique identifier (GUID) of the certificate in Alibaba Cloud Certificate Manager.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

    }

}
