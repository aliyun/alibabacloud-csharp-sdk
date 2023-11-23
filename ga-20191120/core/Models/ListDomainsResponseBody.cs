// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// A list of accelerated domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<ListDomainsResponseBodyDomains> Domains { get; set; }
        public class ListDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// A list of GA instances.
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainsAccelerators> Accelerators { get; set; }
            public class ListDomainsResponseBodyDomainsAccelerators : TeaModel {
                /// <summary>
                /// The ID of the GA instance.
                /// </summary>
                [NameInMap("AcceleratorId")]
                [Validation(Required=false)]
                public string AcceleratorId { get; set; }

                /// <summary>
                /// The name of the GA instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                public List<ListDomainsResponseBodyDomainsAcceleratorsServiceManagedInfos> ServiceManagedInfos { get; set; }
                public class ListDomainsResponseBodyDomainsAcceleratorsServiceManagedInfos : TeaModel {
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
            /// The accelerated domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The ICP filing status of the accelerated domain name. Valid values:
            /// 
            /// *   **illegal:** The domain name is illegal.
            /// *   **inactive:** The domain name has not completed ICP filing.
            /// *   **active:** The domain name has a valid ICP number.
            /// *   **unknown:** The ICP filing status is unknown.
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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
