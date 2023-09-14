// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeIpSetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the acceleration region.
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth that is allocated to the acceleration region. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The list of accelerated IP addresses in the acceleration region.
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
        /// The version of the IP protocol. Valid values:
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
        /// *   **BGP**: BGP (Multi-ISP) lines.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines.
        /// 
        /// If you are allowed to use single-ISP bandwidth, one of the following values is returned:
        /// 
        /// *   **ChinaTelecom**: China Telecom (single ISP).
        /// *   **ChinaUnicom**: China Unicom (single ISP).
        /// *   **ChinaMobile**: China Mobile (single ISP).
        /// *   **ChinaTelecom_L2**: China Telecom (single ISP)\_L2.
        /// *   **ChinaUnicom_L2**: China Unicom (single ISP)\_L2.
        /// *   **ChinaMobile_L2**: China Mobile (single ISP)\_L2.
        /// 
        /// >  The supported single-ISP type varies with the acceleration region.
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

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
        public List<DescribeIpSetResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeIpSetResponseBodyServiceManagedInfos : TeaModel {
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
        /// The status of the acceleration region. Valid values:
        /// 
        /// *   **init**: The acceleration region is being initialized.
        /// *   **active**: The acceleration region is in the running state.
        /// *   **updating**: The acceleration region is being configured.
        /// *   **deleting**: The GA instance is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
