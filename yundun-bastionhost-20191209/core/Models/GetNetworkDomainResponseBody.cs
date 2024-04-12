// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetNetworkDomainResponseBody : TeaModel {
        [NameInMap("NetworkDomain")]
        [Validation(Required=false)]
        public GetNetworkDomainResponseBodyNetworkDomain NetworkDomain { get; set; }
        public class GetNetworkDomainResponseBodyNetworkDomain : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            [NameInMap("NetworkDomainName")]
            [Validation(Required=false)]
            public string NetworkDomainName { get; set; }

            [NameInMap("NetworkDomainType")]
            [Validation(Required=false)]
            public string NetworkDomainType { get; set; }

            [NameInMap("Proxies")]
            [Validation(Required=false)]
            public List<GetNetworkDomainResponseBodyNetworkDomainProxies> Proxies { get; set; }
            public class GetNetworkDomainResponseBodyNetworkDomainProxies : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("HasPassword")]
                [Validation(Required=false)]
                public bool? HasPassword { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

                [NameInMap("ProxyStateErrorCode")]
                [Validation(Required=false)]
                public string ProxyStateErrorCode { get; set; }

                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
