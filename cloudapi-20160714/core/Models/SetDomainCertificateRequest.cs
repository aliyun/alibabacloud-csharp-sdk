// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainCertificateRequest : TeaModel {
        /// <summary>
        /// The content of the CA certificate.
        /// </summary>
        [NameInMap("CaCertificateBody")]
        [Validation(Required=false)]
        public string CaCertificateBody { get; set; }

        /// <summary>
        /// The certificate content.
        /// </summary>
        [NameInMap("CertificateBody")]
        [Validation(Required=false)]
        public string CertificateBody { get; set; }

        /// <summary>
        /// The name of the SSL certificate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// The private key of the SSL certificate.
        /// </summary>
        [NameInMap("CertificatePrivateKey")]
        [Validation(Required=false)]
        public string CertificatePrivateKey { get; set; }

        /// <summary>
        /// The custom domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the API group to which the domain name is bound. This ID is generated by the system and globally unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The certificate verification depth.
        /// </summary>
        [NameInMap("SslVerifyDepth")]
        [Validation(Required=false)]
        public string SslVerifyDepth { get; set; }

    }

}
