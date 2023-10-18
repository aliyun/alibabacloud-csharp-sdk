// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcGatewayEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The list of gateway endpoints.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcGatewayEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcGatewayEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// The ID of the route table associated with the gateway endpoint.
            /// </summary>
            [NameInMap("AssociatedRouteTables")]
            [Validation(Required=false)]
            public List<string> AssociatedRouteTables { get; set; }

            /// <summary>
            /// The time when the endpoint was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the gateway endpoint.
            /// </summary>
            [NameInMap("EndpointDescription")]
            [Validation(Required=false)]
            public string EndpointDescription { get; set; }

            /// <summary>
            /// The ID of the gateway endpoint.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The name of the gateway endpoint.
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

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
            [NameInMap("EndpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// The access policy for the cloud service.
            /// 
            /// For more information about the syntax and structure of the access policy, see [Policy syntax and structure](~~93739~~).
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// The ID of the resource group to which the gateway endpoint belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The name of the endpoint service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The tag list.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcGatewayEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcGatewayEndpointsResponseBodyEndpointsTags : TeaModel {
                /// <summary>
                /// The key of tag N added to the resource.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N added to the resource.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the gateway endpoint belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
