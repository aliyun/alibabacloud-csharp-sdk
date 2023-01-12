// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicEndpointResponseBody : TeaModel {
        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the endpoint that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("EndPointId")]
        [Validation(Required=false)]
        public string EndPointId { get; set; }

        /// <summary>
        /// The address of the endpoint.
        /// </summary>
        [NameInMap("EndpointAddress")]
        [Validation(Required=false)]
        public string EndpointAddress { get; set; }

        /// <summary>
        /// The ID of the endpoint group to which the endpoint belongs.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The secondary address of the endpoint.
        /// 
        /// This parameter is returned if the endpoint type is set to **ECS**, **ENI**, or **NLB**.
        /// 
        /// *   If the endpoint type is set to **ECS**, **EndpointSubAddress** returns the secondary private IP address of the primary ENI or the primary private IP address of the primary ENI.
        /// *   If the endpoint type is set to **ENI**, **EndpointSubAddress** returns the secondary private IP address of the secondary ENI or the primary private IP address of the secondary ENI is used.
        /// *   If the endpoint type is set to **NLB**, **EndpointSubAddress** returns the primary private IP address of the backend server of the NLB instance.
        /// </summary>
        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// The type of the secondary address of the endpoint.
        /// 
        /// *   **primary:** primary private IP address
        /// *   **secondary:** secondary private IP address
        /// 
        /// This parameter is returned if the type of the endpoint is set to **ECS**, **ENI**, or **NLB**. If the endpoint type is set to **NLB**, **primary**is returned.
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
        /// The ID of the zone where the endpoint is deployed.
        /// 
        /// This parameter is returned only when the endpoint type is set to **NLB**.
        /// </summary>
        [NameInMap("EndpointZoneId")]
        [Validation(Required=false)]
        public string EndpointZoneId { get; set; }

        /// <summary>
        /// The name of the endpoint that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the endpoint. Valid values:
        /// 
        /// *   **init:** The endpoint is being initialized.
        /// *   **active:** The endpoint is available.
        /// *   **updating:** The endpoint is being configured.
        /// *   **binding:** The endpoint is being associated.
        /// *   **unbinding:** The endpoint is being disassociated.
        /// *   **deleting:** The endpoint is being deleted.
        /// *   **bound:** The endpoint is associated.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
