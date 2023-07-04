// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcGatewayEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The name of the endpoint service.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcGatewayEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcGatewayEndpointsResponseBodyEndpoints : TeaModel {
            [NameInMap("AssociatedRouteTables")]
            [Validation(Required=false)]
            public List<string> AssociatedRouteTables { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The time when the endpoint was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("EndpointDescription")]
            [Validation(Required=false)]
            public string EndpointDescription { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the gateway endpoint belongs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The access policy for the cloud service.
            /// 
            /// For more information about the syntax and structure of the access policy, see [Policy syntax and structure](~~93739~~).
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            [NameInMap("EndpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the gateway endpoint. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Created**
            /// *   **Modifying**
            /// *   **Associating**
            /// *   **Dissociating**
            /// *   **Deleting**
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcGatewayEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcGatewayEndpointsResponseBodyEndpointsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the route table associated with the gateway endpoint.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The name of the gateway endpoint.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the gateway endpoint.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the gateway endpoint.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
