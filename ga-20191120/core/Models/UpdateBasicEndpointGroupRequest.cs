// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateBasicEndpointGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the endpoint group that is associated with the basic GA instance.
        /// 
        /// The description cannot exceed 256 characters in length and cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The address of the endpoint.
        /// </summary>
        [NameInMap("EndpointAddress")]
        [Validation(Required=false)]
        public string EndpointAddress { get; set; }

        /// <summary>
        /// The ID of the endpoint group that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// The type of endpoint. Valid values:
        /// 
        /// *   **ENI**: elastic network interface (ENI)
        /// *   **SLB**: Server Load Balancer (SLB) instance
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The name of the endpoint group that is associated with the basic GA instance.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the basic GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
