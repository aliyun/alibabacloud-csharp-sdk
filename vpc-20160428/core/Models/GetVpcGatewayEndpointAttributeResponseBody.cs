// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcGatewayEndpointAttributeResponseBody : TeaModel {
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The status of the gateway endpoint. Valid values:
        /// 
        /// *   **Creating**: being created
        /// *   **Created**: created
        /// *   **Modifying**: being modified
        /// *   **Associating**: being associated
        /// *   **Dissociating**: being disassociated
        /// *   **Deleting**: being deleted
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// The access policy for the cloud service.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The time when the endpoint was created. The time follows the ISO 8601 standard in UTC in the YYYY-MM-DDThh:mm:ssZ format.
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the gateway endpoint belongs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public List<string> RouteTables { get; set; }

        /// <summary>
        /// The ID of the route table associated with the gateway endpoint.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetVpcGatewayEndpointAttributeResponseBodyTags> Tags { get; set; }
        public class GetVpcGatewayEndpointAttributeResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
