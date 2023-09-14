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
            /// The port range of the traffic destination.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The first port of the port range.
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
        public List<DescribeCustomRoutingEndPointTrafficPolicyResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndPointTrafficPolicyResponseBodyServiceManagedInfos : TeaModel {
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
