// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsResponseBody : TeaModel {
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<ListVpcEndpointConnectionsResponseBodyConnections> Connections { get; set; }
        public class ListVpcEndpointConnectionsResponseBodyConnections : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("EndpointOwnerId")]
            [Validation(Required=false)]
            public long? EndpointOwnerId { get; set; }

            [NameInMap("EndpointVpcId")]
            [Validation(Required=false)]
            public string EndpointVpcId { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public bool? ResourceOwner { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListVpcEndpointConnectionsResponseBodyConnectionsZones> Zones { get; set; }
            public class ListVpcEndpointConnectionsResponseBodyConnectionsZones : TeaModel {
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                [NameInMap("ReplacedEniId")]
                [Validation(Required=false)]
                public string ReplacedEniId { get; set; }

                [NameInMap("ReplacedResourceId")]
                [Validation(Required=false)]
                public string ReplacedResourceId { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ZoneDomain")]
                [Validation(Required=false)]
                public string ZoneDomain { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneStatus")]
                [Validation(Required=false)]
                public string ZoneStatus { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
