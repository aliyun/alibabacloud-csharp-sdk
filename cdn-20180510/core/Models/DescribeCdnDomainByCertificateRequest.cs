// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainByCertificateRequest : TeaModel {
        [NameInMap("Exact")]
        [Validation(Required=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// The public key of the SSL certificate. You must encode the public key in Base64 before you invoke the encodeURIComponent function to encode a URI component.
        /// 
        /// A public key in the Privacy Enhanced Mail (PEM) format is supported.
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// Specifies whether to return only domain names with HTTPS enabled or disabled.
        /// 
        /// *   true: returns only domain names with HTTPS enabled.
        /// *   false: returns only domain names with HTTPS disabled.
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public bool? SSLStatus { get; set; }

    }

}
