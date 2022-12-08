// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointsResponseBody : TeaModel {
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateBasicEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class CreateBasicEndpointsResponseBodyEndpoints : TeaModel {
            [NameInMap("EndpointAddress")]
            [Validation(Required=false)]
            public string EndpointAddress { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
