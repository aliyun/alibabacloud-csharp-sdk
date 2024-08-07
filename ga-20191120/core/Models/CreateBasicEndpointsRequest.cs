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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The endpoints.
        /// 
        /// This parameter is required.
        /// </summary>
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
            /// This parameter is required only if you set the endpoint type to **ECS**, **ENI**, or **NLB**.
            /// 
            /// *   If you set the endpoint type to **ECS**, you can set **EndpointSubAddress** to the secondary private IP address of the primary ENI. If you leave this parameter empty, the primary private IP address of the primary ENI is used.
            /// *   If you set the endpoint type to **ENI**, you can set **EndpointSubAddress** to the secondary private IP address of the secondary ENI. If you leave this parameter empty, the primary private IP address of the secondary ENI is used.
            /// *   If you set the endpoint type to **NLB**, you can set **EndpointSubAddress** to the primary private IP address of the NLB backend server.
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            /// <summary>
            /// The secondary address type of the endpoint. Valid values:
            /// 
            /// *   **primary**: a primary private IP address.
            /// *   **secondary**: a secondary private IP address.
            /// 
            /// This parameter is required only if you set the endpoint type to **ECS**, **ENI**, or **NLB**. If you set the endpoint type to **NLB**, only **primary** is supported.
            /// </summary>
            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// The type of the endpoint. Valid values:
            /// 
            /// *   **ENI**: elastic network interface (ENI).
            /// *   **SLB**: Classic Load Balancer (CLB) instance.
            /// *   **ECS**: Elastic Compute Service (ECS) instance.
            /// *   **NLB**: Network Load Balancer (NLB) instance.
            /// 
            /// >  This parameter is required.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The ID of the zone where the endpoint resides.
            /// 
            /// This parameter is required only if you set the endpoint type to **NLB**.
            /// </summary>
            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

            /// <summary>
            /// The name of the endpoint.
            /// 
            /// The name must be 1 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
