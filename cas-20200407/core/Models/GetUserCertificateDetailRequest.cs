// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailRequest : TeaModel {
        /// <summary>
        /// Specifies whether to filter return results. Valid values: true and false. Default value: false. **true** specifies that the Cert, Key, EncryptCert, EncryptPrivateKey, SignCert, and SignPrivateKey parameters are not returned. **false** specifies that the parameters are returned.
        /// </summary>
        [NameInMap("CertFilter")]
        [Validation(Required=false)]
        public bool? CertFilter { get; set; }

        /// <summary>
        /// The ID of the certificate.
        /// 
        /// >  You can call the [ListUserCertificateOrder](https://help.aliyun.com/document_detail/455804.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

    }

}
