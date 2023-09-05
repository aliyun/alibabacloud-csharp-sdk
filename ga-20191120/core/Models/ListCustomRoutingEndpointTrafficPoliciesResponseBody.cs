// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointTrafficPoliciesResponseBody : TeaModel {
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
        /// The list of traffic policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The ID of the GA instance with which the endpoint is associated.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The IP address of the traffic destination.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The ID of the endpoint group to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The ID of the endpoint to which the traffic destination belongs.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the custom routing listener with which the endpoint is associated.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The traffic policy ID.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The port range of the traffic policy.
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges> PortRanges { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges : TeaModel {
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
            /// 
            /// > 仅在**ServiceManaged**参数为**True**时有效。
            /// > - 当实例处于托管状态时，用户对实例的操作会受到限制，某些操作行为会被禁止。
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos : TeaModel {
                /// <summary>
                /// 托管策略动作名称，取值：
                /// - **Create**：创建实例。
                /// - **Update**：更新当前实例。
                /// - **Delete**：删除当前实例。
                /// - **Associate**：引用/被引用当前实例。
                /// - **UserUnmanaged**：用户解托管实例。
                /// - **CreateChild**：在当前实例下创建子资源。
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// 子资源类型，取值：
                /// 
                /// - **Listener**：监听资源。
                /// 
                /// - **IpSet**：加速地域资源。
                /// 
                /// - **EndpointGroup**：终端节点组资源。
                /// 
                /// - **ForwardingRule**：转发策略资源。
                /// 
                /// - **Endpoint**：终端节点资源。
                /// 
                /// - **EndpointGroupDestination**：自定义路由监听下的终端节点组协议映射资源。
                /// 
                /// - **EndpointPolicy**：自定义路由监听下的终端节点通行策略资源。
                /// 
                /// > 仅在**Action**参数为**CreateChild**时有效。
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// 托管策略动作是否被托管，取值：
                /// 
                /// - **true**：托管策略动作被托管，用户无权在托管实例下执行Action指定的操作。
                /// 
                /// - **false**：托管策略动作未被托管，用户可在托管实例下执行Action指定的操作。
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

        }

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
