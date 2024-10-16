// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainByCertificateRequest : TeaModel {
        /// <summary>
        /// Specifies whether the domain name list to return matches the SSL certificate.
        /// - **true**: The domain name list matches the SSL certificate.
        /// - **false**: The domain name list does not match the SSL certificate.
        /// </summary>
        [NameInMap("Exact")]
        [Validation(Required=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// The public key of the certificate.
        /// 
        /// You must use Base64 encoding schemes and then the encodeURIComponent method to encode the public key. PEM files are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// Specifies whether the domain name list to return contains only domain names with HTTPS enabled or disabled.
        /// 
        /// *   true: The list contains only domain names with HTTPS enabled.
        /// *   false: The list contains only domain names with HTTPS disabled.
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public bool? SSLStatus { get; set; }

    }

}
