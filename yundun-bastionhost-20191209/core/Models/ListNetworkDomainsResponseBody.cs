// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListNetworkDomainsResponseBody : TeaModel {
        [NameInMap("NetworkDomains")]
        [Validation(Required=false)]
        public List<ListNetworkDomainsResponseBodyNetworkDomains> NetworkDomains { get; set; }
        public class ListNetworkDomainsResponseBodyNetworkDomains : TeaModel {
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

            [NameInMap("ProxiesState")]
            [Validation(Required=false)]
            public List<ListNetworkDomainsResponseBodyNetworkDomainsProxiesState> ProxiesState { get; set; }
            public class ListNetworkDomainsResponseBodyNetworkDomainsProxiesState : TeaModel {
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("ProxyState")]
                [Validation(Required=false)]
                public string ProxyState { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
