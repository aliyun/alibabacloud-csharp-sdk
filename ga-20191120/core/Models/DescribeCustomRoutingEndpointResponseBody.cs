// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance with which the endpoint is associated.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The name of the endpoint (vSwitch).
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
        /// The ID of the endpoint.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The ID of the listener with which the endpoint is associated.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        public List<DescribeCustomRoutingEndpointResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndpointResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// Managed policy action name, Valid values:
            /// 
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
        /// The status of the endpoint.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The access policy of traffic for the specified endpoint. Valid values:
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
        /// Set the value to **PrivateSubNet**, which indicates private CIDR blocks.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
