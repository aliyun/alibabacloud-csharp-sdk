// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the endpoint group that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The endpoints in the endpoint group.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateBasicEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class CreateBasicEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// The address of the endpoint.
            /// </summary>
            [NameInMap("EndpointAddress")]
            [Validation(Required=false)]
            public string EndpointAddress { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The secondary address of the endpoint.
            /// 
            /// This parameter is returned when the accelerated IP address is associated with the secondary private IP address of an ECS instance or ENI.
            /// 
            /// *   When the endpoint type is **ECS**, you can set **EndpointSubAddress** to the secondary private IP address of the primary ENI. If the parameter is left empty, the primary private IP address of the primary ENI is used.
            /// *   When the endpoint type is **ENI**, you can set **EndpointSubAddress** to the secondary private IP address of the secondary ENI. If the parameter is left empty, the primary private IP address of the secondary ENI is used.
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            /// <summary>
            /// The type of endpoint. Valid values:
            /// 
            /// *   **ENI**: ENI
            /// *   **SLB**: CLB
            /// *   **ECS**: ECS
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
