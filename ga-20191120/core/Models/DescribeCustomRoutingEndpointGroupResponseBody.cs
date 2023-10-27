// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// The GA instance ID.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// Indicates the status of the binding between the Log Service project and the endpoint group. Valid values:
        /// 
        /// *   **on:** The endpoint group is bound to the Log Service project.
        /// *   **off:** The endpoint group is not bound to the Log Service project.
        /// *   **binding:** The endpoint group is being bound to the Log Service project.
        /// *   **unbinding:** The endpoint group is being unbound from the Log Service project.
        /// </summary>
        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        /// <summary>
        /// The description of the endpoint group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the access log feature is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableAccessLog")]
        [Validation(Required=false)]
        public bool? EnableAccessLog { get; set; }

        /// <summary>
        /// The endpoint group ID.
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
        /// The region ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// The endpoint group IP addresses that need to be confirmed after the GA instance is upgraded.
        /// </summary>
        [NameInMap("EndpointGroupUnconfirmedIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupUnconfirmedIpList { get; set; }

        /// <summary>
        /// The custom routing listener ID.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The actions that users can perform on the managed instance.
        /// 
        /// >  This parameter takes effect only if **ServiceManaged** is set to **True**.
        /// 
        /// *   Users can perform only specific actions on a managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
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
            /// Indicates whether the specified actions are managed. Valid values:
            /// 
            /// *   **true**: The specified actions are managed, and users cannot perform the specified actions on the managed instance.
            /// *   **false**: The specified actions are not managed, and users can perform the specified actions on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// The name of the Logstore.
        /// </summary>
        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        /// <summary>
        /// The name of the Log Service project.
        /// </summary>
        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        /// <summary>
        /// The region of the logs that are created in Log Service.
        /// </summary>
        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        /// <summary>
        /// The status of the endpoint group. Valid values:
        /// 
        /// *   **init:** The endpoint group is being initialized.
        /// *   **active:** The endpoint group is running normally.
        /// *   **updating:** The endpoint group is being updated.
        /// *   **deleting:** The ACL is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
