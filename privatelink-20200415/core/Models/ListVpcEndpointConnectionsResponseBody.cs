// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The endpoint connections.
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<ListVpcEndpointConnectionsResponseBodyConnections> Connections { get; set; }
        public class ListVpcEndpointConnectionsResponseBodyConnections : TeaModel {
            /// <summary>
            /// The bandwidth of the endpoint connection. Valid values: **1024 to 10240**. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The state of the endpoint connection. Valid values:
            /// 
            /// *   **Pending**: The connection is being modified.
            /// *   **Connecting**: The connection is being established.
            /// *   **Connected**: The connection is established.
            /// *   **Disconnecting**: The endpoint is being disconnected from the endpoint service.
            /// *   **Disconnected**: The endpoint is disconnected from the endpoint service.
            /// *   **Deleting**: The connection is being deleted.
            /// *   **ServiceDeleted**: The corresponding endpoint service has been deleted.
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The endpoint ID.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointOwnerId")]
            [Validation(Required=false)]
            public long? EndpointOwnerId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the endpoint belongs.
            /// </summary>
            [NameInMap("EndpointVpcId")]
            [Validation(Required=false)]
            public string EndpointVpcId { get; set; }

            /// <summary>
            /// The time when the endpoint connection was modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The ID of the resource group to which the endpoint belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the endpoint and the endpoint service belong to the same Alibaba Cloud account. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public bool? ResourceOwner { get; set; }

            /// <summary>
            /// The endpoint service ID.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The zones.
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListVpcEndpointConnectionsResponseBodyConnectionsZones> Zones { get; set; }
            public class ListVpcEndpointConnectionsResponseBodyConnectionsZones : TeaModel {
                /// <summary>
                /// The endpoint ENI ID.
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// The ID of the replaced endpoint ENI in smooth migration scenarios.
                /// </summary>
                [NameInMap("ReplacedEniId")]
                [Validation(Required=false)]
                public string ReplacedEniId { get; set; }

                /// <summary>
                /// The ID of the replaced service resource in smooth migration scenarios.
                /// </summary>
                [NameInMap("ReplacedResourceId")]
                [Validation(Required=false)]
                public string ReplacedResourceId { get; set; }

                /// <summary>
                /// The service resource ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The ID of the vSwitch to which the endpoint belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The domain name of the zone.
                /// </summary>
                [NameInMap("ZoneDomain")]
                [Validation(Required=false)]
                public string ZoneDomain { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The state of the zone. Valid values:
                /// 
                /// *   **Creating**: The zone is being created.
                /// *   **Wait**: The zone is to be connected.
                /// *   **Connected**: The zone is connected.
                /// *   **Deleting**: The zone is being deleted.
                /// *   **Disconnecting**: The zone is being disconnected.
                /// *   **Disconnected**: The zone is disconnected.
                /// *   **Connecting**: The zone is being connected.
                /// *   **Migrating**: The zone is being migrated.
                /// *   **Migrated**: The zone is migrated.
                /// </summary>
                [NameInMap("ZoneStatus")]
                [Validation(Required=false)]
                public string ZoneStatus { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next requests are performed.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
