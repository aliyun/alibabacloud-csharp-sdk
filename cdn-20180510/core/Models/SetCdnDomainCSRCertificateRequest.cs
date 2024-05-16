// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetCdnDomainCSRCertificateRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name for which you want to configure an SSL certificate. The domain name must have HTTPS secure acceleration enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The content of the certificate. The certificate must match the certificate signing request (CSR) created by calling the [CreateCdnCertificateSigningRequest](https://help.aliyun.com/document_detail/144478.html) operation. Make sure that the content of the certificate is encoded in Base64 and then encoded by encodeURIComponent.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

    }

}
