// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainByCertificateRequest : TeaModel {
        /// <summary>
        /// Specifies whether the domain name list to return match the SSL certificate.
        /// 
        /// *   true: The domain name list match the SSL certificate.
        /// *   false: The domain name list do not match the SSL certificate.
        /// </summary>
        [NameInMap("Exact")]
        [Validation(Required=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// The public key of the SSL certificate. You must encode the public key in Base64 and then call the encodeURIComponent function to encode the public key again.
        /// 
        /// The public key must be in the PEM format.
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// Specifies whether the domain name list to return contains only domain names with HTTPS enabled or disabled.
        /// 
        /// *   true: The domain name list contains only domain names with HTTPS enabled.
        /// *   false: The domain name list contains only domain names with HTTPS disabled.
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public bool? SSLStatus { get; set; }

    }

}
