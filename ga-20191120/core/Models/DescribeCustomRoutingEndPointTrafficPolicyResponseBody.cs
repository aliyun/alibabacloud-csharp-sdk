// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndPointTrafficPolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the traffic policy.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The ID of the endpoint to which the traffic policy belongs.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The ID of the listener to which the endpoint belongs.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the endpoint group to which the endpoint belongs.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The ID of the GA instance to which the endpoint belongs.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The name of the vSwitch to which the traffic policy belongs.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The IP address of the traffic policy.
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndPointTrafficPolicyResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeCustomRoutingEndPointTrafficPolicyResponseBodyPortRanges : TeaModel {
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
        /// The ID of the endpoint to which the traffic destination belongs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the service that manages the instance.
        /// 
        /// >  This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the instance is managed. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The actions that users can perform on the managed instance.
        /// > *   This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// > *   Users can perform only specific actions on a managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndPointTrafficPolicyResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndPointTrafficPolicyResponseBodyServiceManagedInfos : TeaModel {
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
            /// *   **Listener**: listener.
            /// *   **IpSet**: acceleration region.
            /// *   **EndpointGroup**: endpoint group.
            /// *   **ForwardingRule**: forwarding rule.
            /// *   **Endpoint**: endpoint.
            /// *   **EndpointGroupDestination**: protocol mapping of an endpoint group that is associated with a custom routing listener.
            /// *   **EndpointPolicy**: traffic policy of an endpoint that is associated with a custom routing listener.
            /// 
            /// >  This parameter takes effect only if the value of **Action** is **CreateChild**.
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// Indicates whether the specified actions are managed.
            /// 
            /// *   **true**: The specified actions are managed, and users cannot perform the specified actions on the managed instance.
            /// *   **false**: The specified actions are not managed, and users can perform the specified actions on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// The status of the traffic destination.
        /// 
        /// - init: being initialized.
        /// - active: running as expected.
        /// - updating: being updated.
        /// - deleting: being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
