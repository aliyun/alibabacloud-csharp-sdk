// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeleteUserCertificateRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// 
        /// >  You can call the [ListUserCertificateOrder](https://help.aliyun.com/document_detail/455804.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

    }

}
