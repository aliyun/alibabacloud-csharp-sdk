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
            /// The GA instance ID.
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
            /// The endpoint group ID.
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
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The backend service protocols of the endpoint group. Valid values:
            /// 
            /// *   **TCP:** TCP.
            /// *   **UDP:** UDP.
            /// *   **TCP,UDP:** TCP and UDP.
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// 托管实例所属的服务方ID。
            /// > 仅在**ServiceManaged**参数为**True**时有效。
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// 是否为托管实例。取值：  
            /// 
            /// - true：是托管资实例。  
            /// 
            /// - false：不是托管实例。
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// 用户在此托管实例下可执行的动作策略列表。
            /// > 仅在**ServiceManaged**参数为**True**时有效。
            /// > - 当实例处于托管状态时，用户对实例的操作会受到限制，某些操作行为会被禁止。
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// 子资源类型，取值：
                /// - **Listener**：监听资源。
                /// - **IpSet**：加速地域资源。
                /// - **EndpointGroup**：终端节点组资源。
                /// - **ForwardingRule**：转发策略资源。
                /// - **Endpoint**：终端节点资源。
                /// - **EndpointGroupDestination**：自定义路由监听下的终端节点组协议映射资源。
                /// - **EndpointPolicy**：自定义路由监听下的终端节点通行策略资源。
                /// > 仅在**Action**参数为**CreateChild**时有效
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// 托管策略动作是否被托管，取值：
                /// - **true**：托管策略动作被托管，用户无权在托管实例下执行Action指定的操作。
                /// - **false**：托管策略动作未被托管，用户可在托管实例下执行Action指定的操作。
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
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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
