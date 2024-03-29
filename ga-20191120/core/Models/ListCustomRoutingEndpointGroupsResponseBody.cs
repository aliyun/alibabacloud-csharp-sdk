// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// The configuration information about the endpoint groups.
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
            /// The list of endpoint group IP addresses.
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
            /// The service ID to which the managed instance belongs.
            /// 
            /// >  Valid only when the ServiceManaged parameter is True.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Is it a managed instance. Valid values:
            /// 
            /// - true
            /// - false
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// A list of action policies that users can execute on this managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// Managed policy action name, Valid values:
                /// - Create
                /// - Update
                /// - Delete
                /// - Associate
                /// - UserUnmanaged
                /// - CreateChild
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// Sub resource type, Valid values:
                /// 
                /// - Listener
                /// - IpSet
                /// - EndpointGroup
                /// - ForwardingRule
                /// - Endpoint
                /// - EndpointGroupDestination
                /// - EndpointPolicy
                /// 
                /// >Only valid when the Action parameter is CreateChild.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Is the managed policy action managed, Valid values:
                /// 
                /// - true: The managed policy action is managed, and users do not have permission to perform the operation specified in the Action on the managed instance.
                /// 
                /// - false: The managed policy action is not managed, and users have permission to perform the operation specified in the Action on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The status of the endpoint group.
            /// 
            /// *   **init**: being initialized
            /// *   **active**: running as expected
            /// *   **updating**: being updated
            /// *   **deleting**: being deleted
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
