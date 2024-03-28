// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAccelerateIpEndpointRelationsRequest : TeaModel {
        /// <summary>
        /// A list of accelerated IP addresses and the endpoints with which the accelerated IP addresses are associated.
        /// </summary>
        [NameInMap("AccelerateIpEndpointRelations")]
        [Validation(Required=false)]
        public List<CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations> AccelerateIpEndpointRelations { get; set; }
        public class CreateBasicAccelerateIpEndpointRelationsRequestAccelerateIpEndpointRelations : TeaModel {
            /// <summary>
            /// The IDs of the accelerated IP addresses.
            /// 
            /// You can call the [ListBasicAccelerateIps](~~2253393~~) operation to query the IDs of the accelerated IP addresses.
            /// 
            /// You can specify up to 20 IP address IDs.
            /// </summary>
            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            /// <summary>
            /// The IDs of the endpoints.
            /// 
            /// You can call the [ListBasicEndpoints](~~2253406~~) to query the IDs of the endpoints.
            /// 
            /// You can specify up to 20 endpoint IDs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

        /// <summary>
        /// The ID of the basic GA instance.
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
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
