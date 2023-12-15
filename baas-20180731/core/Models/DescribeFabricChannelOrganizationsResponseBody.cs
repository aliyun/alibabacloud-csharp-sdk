// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeFabricChannelOrganizationsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeFabricChannelOrganizationsResponseBodyResult Result { get; set; }
        public class DescribeFabricChannelOrganizationsResponseBodyResult : TeaModel {
            [NameInMap("AnchorPeers")]
            [Validation(Required=false)]
            public List<DescribeFabricChannelOrganizationsResponseBodyResultAnchorPeers> AnchorPeers { get; set; }
            public class DescribeFabricChannelOrganizationsResponseBodyResultAnchorPeers : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("Crls")]
            [Validation(Required=false)]
            public string Crls { get; set; }

            [NameInMap("MspId")]
            [Validation(Required=false)]
            public string MspId { get; set; }

            [NameInMap("MspType")]
            [Validation(Required=false)]
            public string MspType { get; set; }

            [NameInMap("Orderer")]
            [Validation(Required=false)]
            public bool? Orderer { get; set; }

            [NameInMap("OrdererNodes")]
            [Validation(Required=false)]
            public List<DescribeFabricChannelOrganizationsResponseBodyResultOrdererNodes> OrdererNodes { get; set; }
            public class DescribeFabricChannelOrganizationsResponseBodyResultOrdererNodes : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Certificate")]
                [Validation(Required=false)]
                public string Certificate { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Tlsroot")]
                [Validation(Required=false)]
                public string Tlsroot { get; set; }

            }

            [NameInMap("RootCertificates")]
            [Validation(Required=false)]
            public string RootCertificates { get; set; }

            [NameInMap("TlsRootCertificates")]
            [Validation(Required=false)]
            public string TlsRootCertificates { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
