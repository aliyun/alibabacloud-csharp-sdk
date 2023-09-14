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
        /// 托管实例所属的服务方ID。
        /// > 仅在**ServiceManaged**参数为**True**时有效。
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 是否为托管实例。取值：
        /// 
        /// - **true**：是托管实例。
        /// 
        /// - **false**：不是托管实例。
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
        public List<DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
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
