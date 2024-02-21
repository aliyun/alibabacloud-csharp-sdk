// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetCdnDomainSSLCertificateRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        /// <summary>
        /// The name of the SSL certificate. You can specify only one certificate name.
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// The region ID of the certificate. Valid values: **cn-hangzhou** and **ap-southeast-1**. Default value: **cn-hangzhou**.
        /// </summary>
        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// The type of the certificate.
        /// 
        /// *   **upload**: a user-uploaded SSL certificate.
        /// *   **cas**: a certificate that is acquired through Certificate Management Service.
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// The accelerated domain name for which you want to configure the SSL certificate. The type of request supported by the domain name must be HTTPS. You can specify only one domain name in each request.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies whether the certificate is issued in canary releases. If you set this parameter to **staging**, the certificate is issued in canary releases. If you do not specify this parameter or set this parameter to other values, the certificate is officially issued.
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The private key. Specify the private key only if you want to enable the SSL certificate.
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// Specifies whether to enable the SSL certificate.
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("SSLProtocol")]
        [Validation(Required=false)]
        public string SSLProtocol { get; set; }

        /// <summary>
        /// The content of the SSL certificate. Specify the content of the SSL certificate only if you want to enable the SSL certificate.
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
