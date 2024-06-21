// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The information about the endpoints.
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListVpcEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListVpcEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// The bandwidth of the endpoint connection. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// The state of the endpoint connection. Valid values:
            /// 
            /// *   **Pending**: The endpoint connection is being modified.
            /// *   **Connecting**: The endpoint connection is being established.
            /// *   **Connected**: The endpoint connection is established.
            /// *   **Disconnecting**: The endpoint is being disconnected from the endpoint service.
            /// *   **Disconnected**: The endpoint is disconnected from the endpoint service.
            /// *   **Deleting**: The endpoint connection is being deleted.
            /// *   **ServiceDeleted**: The corresponding service is deleted.
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The time when the endpoint was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The service state of the endpoint. Valid values:
            /// 
            /// *   **Normal**: The endpoint runs as expected.
            /// *   **FinancialLocked**: The endpoint is locked due to overdue payments.
            /// </summary>
            [NameInMap("EndpointBusinessStatus")]
            [Validation(Required=false)]
            public string EndpointBusinessStatus { get; set; }

            /// <summary>
            /// The description of the endpoint.
            /// </summary>
            [NameInMap("EndpointDescription")]
            [Validation(Required=false)]
            public string EndpointDescription { get; set; }

            /// <summary>
            /// The domain name of the endpoint.
            /// </summary>
            [NameInMap("EndpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The name of the endpoint.
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// The state of the endpoint. Valid values:
            /// 
            /// *   **Creating**: The endpoint is being created.
            /// *   **Active**: The endpoint is available.
            /// *   **Pending**: The endpoint is being modified.
            /// *   **Deleting**: The endpoint is being deleted.
            /// </summary>
            [NameInMap("EndpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            /// <summary>
            /// The type of the endpoint.
            /// 
            /// Only **Interface** may be returned, which indicates an interface endpoint. You can specify Application Load Balancer (ALB) instances, Classic Load Balancer (CLB) instances, and Network Load Balancer (NLB) instances as service resources.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// The region ID of the endpoint.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
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
            /// The ID of the endpoint service that is associated with the endpoint.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The name of the endpoint service that is associated with the endpoint.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The tags added to the resource.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointsResponseBodyEndpointsTags> Tags { get; set; }
            public class ListVpcEndpointsResponseBodyEndpointsTags : TeaModel {
                /// <summary>
                /// The key of the tag added to the resource.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag added to the resource.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the endpoint belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// Indicates whether the domain name of the nearest endpoint that is associated with the endpoint service is resolved first. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ZoneAffinityEnabled")]
            [Validation(Required=false)]
            public bool? ZoneAffinityEnabled { get; set; }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If this is your first request and no next requests are to be performed, you do not need to specify this parameter.
        /// *   If a next request is to be performed, set the parameter to the value of **NextToken** that is returned from the last call.
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

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
