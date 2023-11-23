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
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
            /// 
            /// *   **BGP** (default)
            /// *   **BGP_PRO** If the acceleration region is China (Hong Kong) and a basic bandwidth plan whose bandwidth type is Premium is associated with the GA instance, the default value of IspType is BGP_PRO.
            /// 
            /// If you are allowed to use single-ISP bandwidth, one of the following values is supported:
            /// 
            /// *   **ChinaTelecom**
            /// *   **ChinaUnicom**
            /// *   **ChinaMobile**
            /// *   **ChinaTelecom_L2**
            /// *   **ChinaUnicom_L2**
            /// *   **ChinaMobile_L2**
            /// 
            /// >  The supported line types vary based on the acceleration region.
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

            /// <summary>
            /// The service that manages the instance.
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
            /// The status of the acceleration region. Valid values:
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
