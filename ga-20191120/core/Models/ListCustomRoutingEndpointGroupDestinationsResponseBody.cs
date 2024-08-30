// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// The details about the endpoint group mappings.
        /// </summary>
        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations> Destinations { get; set; }
        public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations : TeaModel {
            /// <summary>
            /// The GA instance ID.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The ID of the endpoint group mapping.
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// The endpoint group ID.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The first port of the backend service port range.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The backend service protocols of the endpoint group. Valid values:
            /// 
            /// *   **TCP**
            /// *   **UDP**
            /// *   **TCP,UDP**
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The ID of the service that manages the GA instance.
            /// 
            /// >  This parameter takes effect only if **ServiceManaged** is set to **True**.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Indicates whether the GA instance is managed. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The actions that you can perform on the managed instance.
            /// 
            /// >  - This parameter takes effect only if **ServiceManaged** is set to **True**.
            /// >  - You can perform only specific actions on the managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos : TeaModel {
                /// <summary>
                /// The name of the action that you can perform on the managed instance. Valid values:
                /// 
                /// *   **Create**: Create an instance.
                /// *   **Update**: Update the current instance.
                /// *   **Delete**: Delete the current instance.
                /// *   **Associate**: Reference the current instance.
                /// *   **UserUnmanaged**: Unmanage the instance.
                /// *   **CreateChild**: Create a child resource in the current instance.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The type of the child resource. Valid values:
                /// 
                /// *   **Listener**: listener.
                /// *   **IpSet**: acceleration region.
                /// *   **EndpointGroup**: endpoint group.
                /// *   **ForwardingRule**: forwarding rule.
                /// *   **Endpoint**: endpoint.
                /// *   **EndpointGroupDestination**: protocol mapping of an endpoint group associated with a custom routing listener.
                /// *   **EndpointPolicy**: traffic policy of an endpoint associated with a custom routing listener.
                /// 
                /// >  This parameter takes effect only if **Action** is set to **CreateChild**.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Indicates whether the specified actions are managed. Valid values:
                /// 
                /// *   **true**: The specified actions are managed, and you cannot perform the specified actions on the managed instance.
                /// *   **false**: The specified actions are not managed, and you can perform the specified actions on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The last port of the backend service port range.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
