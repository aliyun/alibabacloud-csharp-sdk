// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainCertificateRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the SSL certificate. Default value: off. Valid values:
        /// 
        /// *   **on**: enables the SSL certificate.
        /// *   **off**: disables the SSL certificate.
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// The content of the certificate. This parameter is required only if you enable the SSL certificate.
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// The type of the certificate.
        /// 
        /// *   **upload**: a user-uploaded SSL certificate.
        /// *   **cas**: a certificate that is acquired through SSL Certificates Service.
        /// *   **free**: a free certificate.
        /// 
        /// > 
        /// *   If the value of the CertType parameter is **cas**, the **SSLPri** parameter is not required.
        /// *   If the value of the CertType parameter is **free**, the **SSLPri** and **SSLPub** parameters are not required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// >  You can call this operation up to 30 times per second per account.
        /// </summary>
        [NameInMap("ForceSet")]
        [Validation(Required=false)]
        public string ForceSet { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies whether to check the certificate name for duplicates. If you set the value to 1, the system does not perform the check and overwrites the information about the existing certificate that uses the same name.
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// The private key. This parameter is required only if you enable the SSL certificate.
        /// </summary>
        [NameInMap("SSLProtocol")]
        [Validation(Required=false)]
        public string SSLProtocol { get; set; }

        /// <summary>
        /// The region. Default value: ch-hangzhou.
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
