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
            /// The ID of the endpoint group to which the endpoints belong.
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
            /// This parameter is returned when the accelerated IP address is associated with the secondary private IP address of an ECS instance or ENI.
            /// 
            /// *   When the endpoint type is **ECS**, **EndpointSubAddress** returns the secondary private IP address of the primary ENI. If the parameter is left empty, the primary private IP address of the primary ENI is returned.
            /// *   When the endpoint type is **ENI**, **EndpointSubAddress** returns the secondary private IP address of the secondary ENI. If the parameter is left empty, the primary private IP address of the secondary ENI is returned.
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// The type of endpoint. Valid values:
            /// 
            /// *   **ENI**: ENI
            /// *   **SLB**: CLB
            /// *   **ECS**: ECS
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

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
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value is the token that is used for the next query.
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
