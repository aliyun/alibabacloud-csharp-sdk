// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The information about the endpoints.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListCustomRoutingEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// The ID of the GA instance with which the endpoint is associated.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The name of the vSwitch that is specified as an endpoint.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The ID of the endpoint group to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The endpoint ID.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the listener to which the endpoint belongs.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The ID of the service that manages the GA instance.
            /// 
            /// >  This parameter is valid only if **ServiceManaged** is set to **True**.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Indicates whether the GA instance is managed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The actions that users can perform on the managed instance.
            /// 
            /// >  This parameter is valid only if **ServiceManaged** is set to **True**.
            /// 
            /// *   Users can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointsResponseBodyEndpointsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointsResponseBodyEndpointsServiceManagedInfos : TeaModel {
                /// <summary>
                /// The name of the action performed on the managed instance. Valid values:
                /// 
                /// *   **Create**
                /// *   **Update**
                /// *   **Delete**
                /// *   **Associate**
                /// *   **UserUnmanaged**
                /// *   **CreateChild**
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The type of the child resource. Valid values:
                /// 
                /// *   **Listener**: listener
                /// *   **IpSet**: acceleration region
                /// *   **EndpointGroup**: endpoint group
                /// *   **ForwardingRule**: forwarding rule
                /// *   **Endpoint**: endpoint
                /// *   **EndpointGroupDestination**: protocol mapping of an endpoint group associated with a custom routing listener
                /// *   **EndpointPolicy**: traffic policy of an endpoint associated with a custom routing listener
                /// 
                /// >  This parameter is valid only if **Action** is set to **CreateChild**.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Indicates whether the specified actions are managed. Valid values:
                /// 
                /// *   **true**: The specified actions are managed, and users cannot perform the specified actions on the managed resource.
                /// *   **false**: The specified actions are not managed, and users can perform the specified actions on the managed resource.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The access policy of traffic that is destined for the endpoint. Valid values:
            /// 
            /// *   **AllowAll**: allows all traffic to the endpoint.
            /// *   **DenyAll**: denies all traffic to the endpoint.
            /// *   **AllowCustom**: allows traffic only to specified destinations.
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            /// <summary>
            /// The backend service type of the endpoint.
            /// 
            /// Only **PrivateSubNet** may be returned, which indicates a private CIDR block.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
