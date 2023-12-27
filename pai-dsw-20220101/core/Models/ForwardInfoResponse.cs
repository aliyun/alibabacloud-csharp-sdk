// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ForwardInfoResponse : TeaModel {
        [NameInMap("ConnectInfo")]
        [Validation(Required=false)]
        public ForwardInfoResponseConnectInfo ConnectInfo { get; set; }
        public class ForwardInfoResponseConnectInfo : TeaModel {
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public ForwardInfoResponseConnectInfoInternet Internet { get; set; }
            public class ForwardInfoResponseConnectInfoInternet : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public ForwardInfoResponseConnectInfoIntranet Intranet { get; set; }
            public class ForwardInfoResponseConnectInfoIntranet : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

        }

        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        [NameInMap("EipAllocationId")]
        [Validation(Required=false)]
        public string EipAllocationId { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("SSHPublicKey")]
        [Validation(Required=false)]
        public string SSHPublicKey { get; set; }

    }

}
