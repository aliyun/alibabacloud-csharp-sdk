// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// The configuration information about the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListCustomRoutingEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The description of the endpoint group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The endpoint group IP addresses.
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// The ID of the region where the endpoint group is created.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The endpoint group IP addresses to be confirmed after the GA instance is upgraded.
            /// </summary>
            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            /// <summary>
            /// The ID of the custom routing listener.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The name of the endpoint group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the service that manages the instance.
            /// 
            /// >  This parameter takes effect only if **ServiceManaged** is set to **True**.
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
            /// > 
            /// 
            /// *   This parameter takes effect only if **ServiceManaged** is set to **True**.
            /// 
            /// *   Users can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// The name of the action on the managed instance. Valid values:
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
                /// >  This parameter takes effect only if **Action** is set to **CreateChild**.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Indicates whether the specified actions are managed.
                /// 
                /// *   **true**: Users cannot perform the specified actions on the managed instance.
                /// *   **false**: Users can perform the specified actions on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The status of the endpoint group. Valid values:
            /// 
            /// *   **init**
            /// *   **active**
            /// *   **updating**
            /// *   **deleting**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
