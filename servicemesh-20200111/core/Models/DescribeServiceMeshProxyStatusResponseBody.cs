// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshProxyStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshProxyStatusResponseBodyProxyStatus> ProxyStatus { get; set; }
        public class DescribeServiceMeshProxyStatusResponseBodyProxyStatus : TeaModel {
            [NameInMap("ClusterSynced")]
            [Validation(Required=false)]
            public string ClusterSynced { get; set; }

            [NameInMap("EndpointPercent")]
            [Validation(Required=false)]
            public string EndpointPercent { get; set; }

            [NameInMap("EndpointSynced")]
            [Validation(Required=false)]
            public string EndpointSynced { get; set; }

            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }

            [NameInMap("ListenerSynced")]
            [Validation(Required=false)]
            public string ListenerSynced { get; set; }

            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            [NameInMap("ProxyVersion")]
            [Validation(Required=false)]
            public string ProxyVersion { get; set; }

            [NameInMap("RouteSynced")]
            [Validation(Required=false)]
            public string RouteSynced { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
