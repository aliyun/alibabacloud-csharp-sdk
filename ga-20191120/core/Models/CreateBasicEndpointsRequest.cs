// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointsRequest : TeaModel {
        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint group that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateBasicEndpointsRequestEndpoints> Endpoints { get; set; }
        public class CreateBasicEndpointsRequestEndpoints : TeaModel {
            /// <summary>
            /// The address of the endpoint.
            /// </summary>
            [NameInMap("EndpointAddress")]
            [Validation(Required=false)]
            public string EndpointAddress { get; set; }

            /// <summary>
            /// The secondary address of the endpoint.
            /// 
            /// This parameter is required when the accelerated IP address is associated with the secondary private IP address of an ECS instance or ENI.
            /// 
            /// *   When the endpoint type is **ECS**, you can set **EndpointSubAddress** to the secondary private IP address of the primary ENI. If the parameter is left empty, the primary private IP address of the primary ENI is used.
            /// *   When the endpoint type is **ENI**, you can set **EndpointSubAddress** to the secondary private IP address of the secondary ENI. If the parameter is left empty, the primary private IP address of the secondary ENI is used.
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// The type of endpoint. Valid values:
            /// 
            /// *   **ENI**: elastic network interface (ENI)
            /// *   **SLB**: Classic Load Balancer (CLB)
            /// *   **ECS**: Elastic Compute Service (ECS)
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
