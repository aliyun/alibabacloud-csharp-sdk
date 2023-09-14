// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// The details about the endpoint group mapping configurations.
        /// </summary>
        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations> Destinations { get; set; }
        public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The ID of the endpoint group mapping configuration.
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// The ID of the endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The start port of the backend service port range of the endpoint group.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The ID of the listener.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint group.
            /// 
            /// *   **TCP**: TCP
            /// *   **UDP**: UDP
            /// *   **TCP,UDP**: TCP and UDP
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

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
            /// - **true**
            /// 
            /// - **false**
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// A list of action policies that users can execute on this managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos : TeaModel {
                /// <summary>
                /// Managed policy action name, Valid values:
                /// 
                /// Create
                /// Update
                /// Delete
                /// Associate
                /// UserUnmanaged
                /// CreateChild
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// Sub resource type, Valid values:
                /// 
                /// Listener
                /// IpSet
                /// EndpointGroup
                /// ForwardingRule
                /// Endpoint
                /// EndpointGroupDestination
                /// EndpointPolicy
                /// 
                /// > Only valid when the Action parameter is CreateChild.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Is the managed policy action managed, Valid values:
                /// 
                /// - **true**: The managed policy action is managed, and users do not have permission to perform the operation specified in the Action on the managed instance.
                /// 
                /// - **false**: The managed policy action is not managed, and users have permission to perform the operation specified in the Action on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The end port of the backend service port range of the endpoint group.
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
