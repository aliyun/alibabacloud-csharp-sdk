// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingPortMappingsByDestinationResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<ListCustomRoutingPortMappingsByDestinationResponseBodyPortMappings> PortMappings { get; set; }
        public class ListCustomRoutingPortMappingsByDestinationResponseBodyPortMappings : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("AcceleratorPort")]
            [Validation(Required=false)]
            public int? AcceleratorPort { get; set; }

            [NameInMap("DestinationSocketAddress")]
            [Validation(Required=false)]
            public ListCustomRoutingPortMappingsByDestinationResponseBodyPortMappingsDestinationSocketAddress DestinationSocketAddress { get; set; }
            public class ListCustomRoutingPortMappingsByDestinationResponseBodyPortMappingsDestinationSocketAddress : TeaModel {
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("DestinationTrafficState")]
            [Validation(Required=false)]
            public string DestinationTrafficState { get; set; }

            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
