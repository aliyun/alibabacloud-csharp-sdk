// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainByCertificateRequest : TeaModel {
        /// <summary>
        /// The public key of the certificate.
        /// 
        /// You must use Base64 encoding schemes and then the encodeURIComponent method to encode the public key. PEM files are supported.
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
