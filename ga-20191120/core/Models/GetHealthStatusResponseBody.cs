// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The information about the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<GetHealthStatusResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class GetHealthStatusResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// The ID of the endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The type of the endpoint group. Valid values:
            /// 
            /// *   **default**: a default endpoint group
            /// *   **virtual**: a virtual endpoint group
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// The information about the endpoints.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<GetHealthStatusResponseBodyEndpointGroupsEndpoints> Endpoints { get; set; }
            public class GetHealthStatusResponseBodyEndpointGroupsEndpoints : TeaModel {
                /// <summary>
                /// The IP address of the endpoint.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The ID of the endpoint.
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// The health check details of the endpoint.
                /// 
                /// >  This parameter is unavailable.
                /// </summary>
                [NameInMap("HealthDetail")]
                [Validation(Required=false)]
                public string HealthDetail { get; set; }

                /// <summary>
                /// The health status of the endpoint. Valid values:
                /// 
                /// *   **init**: The endpoint is being initialized.
                /// *   **normal**: The endpoint is normal.
                /// *   **Abnormal**: The endpoint is abnormal.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// The port that is used to connect to the endpoint.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// The type of the endpoint. Valid values:
                /// 
                /// *   **Domain**: a custom domain name
                /// *   **Ip**: a custom IP address
                /// *   **PublicIp**: a public IP address provided by Alibaba Cloud
                /// *   **ECS**: an Elastic Compute Service (ECS) instance
                /// *   **SLB**: a Server Load Balancer (SLB) instance
                /// *   **ALB**: an Application Load Balancer (ALB) instance
                /// *   **OSS**: an Object Storage Service (OSS) bucket
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The IDs of the forwarding rules.
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// The health status of the endpoint group. Valid values:
            /// 
            /// *   **init**: The endpoint group is being initialized.
            /// *   **normal**: The endpoint group is normal.
            /// *   **Abnormal**: The endpoint group is abnormal.
            /// *   **partiallyAbnormal**: Some endpoint groups that are associated with the listener are abnormal.
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

        }

        /// <summary>
        /// The health status of the listener. Valid values:
        /// 
        /// *   **normal**: The listener is normal.
        /// *   **Abnormal**: The listener is abnormal.
        /// *   **partiallyAbnormal**: Some exceptions occur to the listener.
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
