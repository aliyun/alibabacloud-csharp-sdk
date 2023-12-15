// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeOrganizationUserCertsResponseBody : TeaModel {
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeOrganizationUserCertsResponseBodyResult Result { get; set; }
        public class DescribeOrganizationUserCertsResponseBodyResult : TeaModel {
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<DescribeOrganizationUserCertsResponseBodyResultCertificates> Certificates { get; set; }
            public class DescribeOrganizationUserCertsResponseBodyResultCertificates : TeaModel {
                [NameInMap("CertData")]
                [Validation(Required=false)]
                public string CertData { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                [NameInMap("ValidTo")]
                [Validation(Required=false)]
                public string ValidTo { get; set; }

            }

            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public DescribeOrganizationUserCertsResponseBodyResultKeyPair KeyPair { get; set; }
            public class DescribeOrganizationUserCertsResponseBodyResultKeyPair : TeaModel {
                [NameInMap("PrivateKey")]
                [Validation(Required=false)]
                public string PrivateKey { get; set; }

                [NameInMap("PublicKey")]
                [Validation(Required=false)]
                public string PublicKey { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
