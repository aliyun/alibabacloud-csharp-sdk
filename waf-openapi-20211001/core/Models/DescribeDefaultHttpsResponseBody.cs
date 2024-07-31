// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefaultHttpsResponseBody : TeaModel {
        [NameInMap("DefaultHttps")]
        [Validation(Required=false)]
        public DescribeDefaultHttpsResponseBodyDefaultHttps DefaultHttps { get; set; }
        public class DescribeDefaultHttpsResponseBodyDefaultHttps : TeaModel {
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public string CipherSuite { get; set; }

            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public string CustomCiphers { get; set; }

            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
