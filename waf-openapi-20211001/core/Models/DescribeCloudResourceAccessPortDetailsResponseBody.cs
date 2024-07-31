// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceAccessPortDetailsResponseBody : TeaModel {
        [NameInMap("AccessPortDetails")]
        [Validation(Required=false)]
        public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetails> AccessPortDetails { get; set; }
        public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetails : TeaModel {
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsCertificates> Certificates { get; set; }
            public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsCertificates : TeaModel {
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("CertificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

            }

            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            [NameInMap("LogHeaders")]
            [Validation(Required=false)]
            public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsLogHeaders> LogHeaders { get; set; }
            public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsLogHeaders : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
