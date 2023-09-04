// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetDomainServerCertificateRequest : TeaModel {
        /// <summary>
        /// The name of the SSL certificate. You can specify only one name.
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// The type of the certificate. Valid values:
        /// 
        /// *   **upload**: a user-uploaded SSL certificate.
        /// *   **cas**: a certificate that is purchased from Alibaba Cloud SSL Certificates Service.
        /// 
        /// > If this parameter is set to **cas**, the **PrivateKey** parameter is optional.
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// The accelerated domain name for which you want to configure the SSL certificate. The type of request supported by the domain name must be HTTPS.
        /// 
        /// You can specify one domain name in each call.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies whether to check the certificate name for duplicates. If you set the value to 1, the system does not perform the check and overwrites the information about the existing certificate that uses the same name.
        /// </summary>
        [NameInMap("ForceSet")]
        [Validation(Required=false)]
        public string ForceSet { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The private key. Specify the private key only if you want to enable the SSL certificate.
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The content of the SSL certificate. Specify the content of the SSL certificate only if you want to enable the SSL certificate. You can use one of the following methods to obtain the content of the SSL certificate:
        /// 
        /// *   Method 1: Call the [DescribeDomainCertificateInfo](~~91182~~) API operation to query the information about the SSL certificate corresponding to the accelerated domain name and obtain the public key of the ServerCertificate certificate from the returned data.
        /// *   Method 2: Call the [DescribeCdnCertificateList](~~91181~~) API operation to query the SSL certificate list corresponding to the accelerated domain name, and obtain the value of CertName from the returned data. Then, Call the [DescribeCdnCertificateDetail](~~131905~~) API operation with CertName as a parameter to obtain the details about the certificate, and obtain the public key of the Cert certificate from the returned data.
        /// </summary>
        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

        /// <summary>
        /// Specifies whether to enable the SSL certificate. Default value: off. Valid values:
        /// 
        /// *   **on** : enables the SSL certificate.
        /// *   **off**: disables the SSL certificate.
        /// </summary>
        [NameInMap("ServerCertificateStatus")]
        [Validation(Required=false)]
        public string ServerCertificateStatus { get; set; }

    }

}
