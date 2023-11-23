// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointTrafficPoliciesResponseBody : TeaModel {
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
        /// A list of traffic policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The ID of the GA instance with which the endpoint is associated.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The IP address of the traffic destination.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the endpoint group to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The ID of the endpoint to which the traffic destination belongs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the custom routing listener with which the endpoint is associated.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The traffic policy ID.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The port range of the traffic policy.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges> PortRanges { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges : TeaModel {
                /// <summary>
                /// The first port of the port range used by the traffic destination to process requests.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port of the port range used by the traffic destination to process requests.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

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
            /// *   **true**: The GA instance is managed.
            /// *   **false**: The GA instance is not managed.
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The actions that you can perform on the managed instance.
            /// 
            /// >  This parameter takes effect only if **ServiceManaged** is set to **True**.
            /// 
            /// *   You can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos : TeaModel {
                /// <summary>
                /// The name of the action on the managed instance. Valid values:
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

        }

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
