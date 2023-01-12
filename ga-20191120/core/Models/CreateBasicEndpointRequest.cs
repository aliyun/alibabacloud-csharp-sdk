// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointRequest : TeaModel {
        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The address of the endpoint.
        /// </summary>
        [NameInMap("EndpointAddress")]
        [Validation(Required=false)]
        public string EndpointAddress { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The secondary address of the endpoint.
        /// 
        /// This parameter is required if the endpoint type is **ECS**, **ENI**, or **NLB**.
        /// 
        /// *   If the endpoint type is **ECS**, you can set **EndpointSubAddress** to the secondary private IP address of the primary ENI. If the parameter is left empty, the primary private IP address of the primary ENI is used.
        /// *   If the endpoint type is **ENI**, you can set **EndpointSubAddress** to the secondary private IP address of the secondary ENI. If the parameter is left empty, the primary private IP address of the secondary ENI is used.
        /// *   This parameter is required if the endpoint type is **NLB**. **EndpointSubAddress** is the primary private IP address of the NLB backend server.
        /// </summary>
        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// The type of the secondary address of the endpoint. Valid values:
        /// 
        /// *   **primary**: a primary private IP address.
        /// *   **secondary**: a secondary private IP address.
        /// 
        /// This parameter is required if the endpoint type is **ECS**, **ENI**, or **NLB**. If the endpoint type is **NLB**, only **primary** is supported.
        /// </summary>
        [NameInMap("EndpointSubAddressType")]
        [Validation(Required=false)]
        public string EndpointSubAddressType { get; set; }

        /// <summary>
        /// The type of endpoint. Valid values:
        /// 
        /// *   **ENI**: elastic network interface (ENI)
        /// *   **SLB**: Classic Load Balancer (CLB)
        /// *   **ECS**: Elastic Compute Service (ECS)
        /// *   **NLB**: Network Load Balancer (NLB)
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The zone ID of the endpoint.
        /// 
        /// This parameter is required only if the endpoint type is **NLB**.
        /// </summary>
        [NameInMap("EndpointZoneId")]
        [Validation(Required=false)]
        public string EndpointZoneId { get; set; }

        /// <summary>
        /// The name of the endpoint.
        /// 
        /// The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
