// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainCertificateRequest : TeaModel {
        /// <summary>
        /// Content of the CA certificate
        /// </summary>
        [NameInMap("CaCertificateBody")]
        [Validation(Required=false)]
        public string CaCertificateBody { get; set; }

        /// <summary>
        /// For more information, see the following request examples
        /// </summary>
        [NameInMap("CertificateBody")]
        [Validation(Required=false)]
        public string CertificateBody { get; set; }

        /// <summary>
        /// The content of the certificate.
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// For more information, see the following request examples
        /// </summary>
        [NameInMap("CertificatePrivateKey")]
        [Validation(Required=false)]
        public string CertificatePrivateKey { get; set; }

        /// <summary>
        /// The name of the SSL certificate.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The custom domain name.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SslVerifyDepth")]
        [Validation(Required=false)]
        public string SslVerifyDepth { get; set; }

    }

}
