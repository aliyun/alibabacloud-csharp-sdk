// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DeleteClientCertificateRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the client certificate or server certificate that you want to delete. The status of the certificate must be **REVOKE**.
        /// 
        /// >  You can call the [ListClientCertificate](~~330884~~) operation to query the unique identifiers and status of all client certificates and server certificates.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
