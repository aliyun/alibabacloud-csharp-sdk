// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAccelerateIpEndpointRelationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the accelerated IP address.
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

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
        /// The name of the endpoint.
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// The secondary address of the endpoint.
        /// 
        /// This parameter is returned if the endpoint type is **ECS**, **ENI**, or **NLB**.
        /// 
        /// *   If the endpoint type is **ECS**, **EndpointSubAddress** returns the primary or secondary private IP address of the primary ENI.
        /// *   If the endpoint type is **ENI**, **EndpointSubAddress** returns the primary or secondary private IP address of the secondary ENI.
        /// *   If the endpoint type is **NLB**, **EndpointSubAddress** returns the primary private IP address of the NLB backend server.
        /// </summary>
        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// The type of the secondary address of the endpoint.
        /// 
        /// *   **primary**: a primary private IP address.
        /// *   **secondary**: a secondary private IP address.
        /// 
        /// This parameter is returned if the endpoint type is **ECS**, **ENI**, or **NLB**. If the endpoint type is set to **NLB**, **primary** is returned.
        /// </summary>
        [NameInMap("EndpointSubAddressType")]
        [Validation(Required=false)]
        public string EndpointSubAddressType { get; set; }

        /// <summary>
        /// The type of endpoint. Valid values:
        /// 
        /// *   **ENI**: elastic network interface (ENI).
        /// *   **SLB**: Classic Load Balancer (CLB) instance.
        /// *   **ECS**: Elastic Compute Service (ECS) instance.
        /// *   **NLB**: Network Load Balancer (NLB) instance.
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The ID of the zone where the endpoint is created.
        /// 
        /// This parameter is returned only when the endpoint type is **NLB**.
        /// </summary>
        [NameInMap("EndpointZoneId")]
        [Validation(Required=false)]
        public string EndpointZoneId { get; set; }

        /// <summary>
        /// The accelerated IP address of the basic GA instance.
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The association status between the accelerated IP address and endpoint.
        /// 
        /// A value of **active** indicates that the accelerated IP address is associated with the endpoint.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
