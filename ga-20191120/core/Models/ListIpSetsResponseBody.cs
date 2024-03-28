// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIpSetsResponseBody : TeaModel {
        /// <summary>
        /// The acceleration regions.
        /// </summary>
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<ListIpSetsResponseBodyIpSets> IpSets { get; set; }
        public class ListIpSetsResponseBodyIpSets : TeaModel {
            /// <summary>
            /// The ID of the acceleration region.
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// The bandwidth that is allocated to the acceleration region. Unit: **Mbit/s**.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The accelerated IP addresses.
            /// </summary>
            [NameInMap("IpAddressList")]
            [Validation(Required=false)]
            public List<string> IpAddressList { get; set; }

            /// <summary>
            /// The ID of the acceleration region.
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            /// <summary>
            /// The IP version. Valid values:
            /// 
            /// *   **IPv4**
            /// *   **IPv6**
            /// *   **DUAL_STACK**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
            /// 
            /// *   **BGP**: BGP (Multi-ISP) lines. This is the default value.
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines.
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

            /// <summary>
            /// The ID of the service that manages the instance.
            /// 
            /// >  This parameter takes effect only if **ServiceManaged** is set to **true**.
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
            /// 
            /// > *   This parameter takes effect only if **ServiceManaged** is set to **true**.
            /// >*   Users can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListIpSetsResponseBodyIpSetsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListIpSetsResponseBodyIpSetsServiceManagedInfos : TeaModel {
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
                /// Indicates whether the specified actions are managed.
                /// 
                /// *   **true**: The specified actions are managed, and users cannot perform the actions on the managed instance.****
                /// *   **false**: The specified actions are not managed, and users can perform the actions on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// The status of the acceleration region. Valid values:
            /// 
            /// *   **init:** The acceleration region is being initialized.
            /// *   **active:** The acceleration region is in the running state.
            /// *   **updating:** The acceleration region is being configured.
            /// *   **deleting:** The acceleration region is being deleted.
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
