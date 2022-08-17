// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceEndpointsResponseBody : TeaModel {
        [NameInMap("EndPointSlice")]
        [Validation(Required=false)]
        public GetRegisteredServiceEndpointsResponseBodyEndPointSlice EndPointSlice { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyEndPointSlice : TeaModel {
            [NameInMap("EndpointsDetails")]
            [Validation(Required=false)]
            public List<GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails> EndpointsDetails { get; set; }
            public class GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails : TeaModel {
                public string Address { get; set; }
                public string Hostname { get; set; }
                public string PodName { get; set; }
                public List<int?> Ports { get; set; }
                public string Region { get; set; }
                public bool? SidecarInjected { get; set; }
            }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceEndpoints")]
        [Validation(Required=false)]
        public List<GetRegisteredServiceEndpointsResponseBodyServiceEndpoints> ServiceEndpoints { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyServiceEndpoints : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
