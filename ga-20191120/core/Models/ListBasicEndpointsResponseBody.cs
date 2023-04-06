// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The endpoints that are associated with the basic GA instance.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListBasicEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListBasicEndpointsResponseBodyEndpoints : TeaModel {
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
            /// The ID of the endpoint group to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The ID of the endpoint that is associated with the basic GA instance.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

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
            /// The secondary address type of the endpoint.
            /// 
            /// *   **primary**: a primary private IP address.
            /// *   **secondary**: a secondary private IP address.
            /// 
            /// This parameter is returned if the type of the endpoint is set to **ECS**, **ENI**, or **NLB**. If the endpoint type is set to **NLB**, **primary** is returned.
            /// </summary>
            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// The type of endpoint. Valid values:
            /// 
            /// *   **ENI**: ENI.
            /// *   **SLB**: CLB instance.
            /// *   **ECS**: ECS instance.
            /// *   **NLB**: NLB instance.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The zone ID of the endpoint.
            /// 
            /// This parameter is returned only when the endpoint type is set to **NLB**.
            /// </summary>
            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

            /// <summary>
            /// The name of the endpoint.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the endpoint. Valid values:
            /// 
            /// *   **init**: The endpoint is being initialized.
            /// *   **active**: The endpoint is available.
            /// *   **updating**: The endpoint is being configured.
            /// *   **binding**: The endpoint is being associated.
            /// *   **unbinding**: The endpoint is being disassociated.
            /// *   **deleting**: The endpoint is being deleted.
            /// *   **bound**: The endpoint is associated.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
