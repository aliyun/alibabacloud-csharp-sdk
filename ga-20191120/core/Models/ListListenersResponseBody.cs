// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListListenersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersCertificates> Certificates { get; set; }
            public class ListListenersResponseBodyListenersCertificates : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersBackendPorts> BackendPorts { get; set; }
            public class ListListenersResponseBodyListenersBackendPorts : TeaModel {
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public string FromPort { get; set; }

                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public string ToPort { get; set; }

            }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ClientAffinity")]
            [Validation(Required=false)]
            public string ClientAffinity { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersPortRanges> PortRanges { get; set; }
            public class ListListenersResponseBodyListenersPortRanges : TeaModel {
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProxyProtocol")]
            [Validation(Required=false)]
            public bool? ProxyProtocol { get; set; }

            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                [NameInMap("XForwardedForGaIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaIdEnabled { get; set; }
                [NameInMap("XRealIpEnabled")]
                [Validation(Required=false)]
                public bool? XRealIpEnabled { get; set; }
                [NameInMap("XForwardedForGaApEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaApEnabled { get; set; }
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }
                [NameInMap("XForwardedForPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForPortEnabled { get; set; }
            };

            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
