// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Location20150612.Models
{
    public class DescribeEndpointsResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeEndpointsResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeEndpointsResponseBodyEndpoints : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public List<DescribeEndpointsResponseBodyEndpointsEndpoint> Endpoint { get; set; }
            public class DescribeEndpointsResponseBodyEndpointsEndpoint : TeaModel {
                public string Type { get; set; }
                public string Namespace { get; set; }
                public string SerivceCode { get; set; }
                public string Id { get; set; }
                public string Endpoint { get; set; }
                public DescribeEndpointsResponseBodyEndpointsEndpointProtocols Protocols { get; set; }
                public class DescribeEndpointsResponseBodyEndpointsEndpointProtocols : TeaModel {
                    [NameInMap("Protocols")]
                    [Validation(Required=false)]
                    public List<string> Protocols { get; set; }

                }
            }
        };

    }

}
