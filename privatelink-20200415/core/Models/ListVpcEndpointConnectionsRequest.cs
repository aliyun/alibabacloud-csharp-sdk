// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsRequest : TeaModel {
        /// <summary>
        /// The ID of the endpoint connection.
        /// 
        /// > This parameter is required only when a gateway is used for load balancing.
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// The state of the endpoint connection. Valid values:
        /// 
        /// *   **Pending**: The endpoint connection is being modified.
        /// *   **Connecting**: The endpoint connection is being established.
        /// *   **Connected**: The endpoint connection is established.
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
        /// The ID of the endpoint elastic network interface (ENI).
        /// </summary>
        [NameInMap("EniId")]
        [Validation(Required=false)]
        public string EniId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **50**. Default value: **50**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If this is your first request and no next requests are to be performed, you do not need to specify this parameter.
        /// *   If a next request is to be performed, set the value to the value of **NextToken** that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the endpoint connection.
        /// 
        /// You can call the [DescribeRegions](~~120468~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the replaced service resource in smooth migration scenarios.
        /// </summary>
        [NameInMap("ReplacedResourceId")]
        [Validation(Required=false)]
        public string ReplacedResourceId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the endpoint belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The service resource ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The endpoint service ID.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
