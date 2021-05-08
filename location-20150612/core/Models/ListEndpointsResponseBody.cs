// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Location20150612.Models
{
    public class ListEndpointsResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EndpointList")]
        [Validation(Required=false)]
        public ListEndpointsResponseBodyEndpointList EndpointList { get; set; }
        public class ListEndpointsResponseBodyEndpointList : TeaModel {
            [NameInMap("ItemEndpoint")]
            [Validation(Required=false)]
            public List<ListEndpointsResponseBodyEndpointListItemEndpoint> ItemEndpoint { get; set; }
            public class ListEndpointsResponseBodyEndpointListItemEndpoint : TeaModel {
                public string Type { get; set; }
                public string Namespace { get; set; }
                public string Product { get; set; }
                public string Id { get; set; }
                public string Endpoint { get; set; }
                public ListEndpointsResponseBodyEndpointListItemEndpointProtocols Protocols { get; set; }
                public class ListEndpointsResponseBodyEndpointListItemEndpointProtocols : TeaModel {
                    [NameInMap("Protocols")]
                    [Validation(Required=false)]
                    public List<string> Protocols { get; set; }

                }
            }
        };

    }

}
