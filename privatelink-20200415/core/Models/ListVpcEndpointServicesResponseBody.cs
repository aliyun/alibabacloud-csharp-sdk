// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServicesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
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

        /// <summary>
        /// The endpoint services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// Indicates whether endpoint connection requests are automatically accepted. Valid values:
            /// 
            /// *   **true**: Endpoint connection requests are automatically accepted.
            /// *   **false**: Endpoint connection requests are not automatically accepted.
            /// </summary>
            [NameInMap("AutoAcceptEnabled")]
            [Validation(Required=false)]
            public bool? AutoAcceptEnabled { get; set; }

            /// <summary>
            /// The default maximum bandwidth of the endpoint connection. Unit: Mbit/s.
            /// </summary>
            [NameInMap("ConnectBandwidth")]
            [Validation(Required=false)]
            public int? ConnectBandwidth { get; set; }

            /// <summary>
            /// The time when the endpoint service was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The maximum bandwidth of the endpoint connection. Unit: Mbit/s.
            /// </summary>
            [NameInMap("MaxBandwidth")]
            [Validation(Required=false)]
            public int? MaxBandwidth { get; set; }

            /// <summary>
            /// The minimum bandwidth of the endpoint connection. Unit: Mbit/s.
            /// </summary>
            [NameInMap("MinBandwidth")]
            [Validation(Required=false)]
            public int? MinBandwidth { get; set; }

            /// <summary>
            /// The payer. Valid values:
            /// 
            /// *   **Endpoint**: service consumer
            /// *   **EndpointService**: service provider
            /// </summary>
            [NameInMap("Payer")]
            [Validation(Required=false)]
            public string Payer { get; set; }

            /// <summary>
            /// The region ID of the endpoint service.
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
            /// The service state of the endpoint service. Valid values:
            /// 
            /// *   **Normal**: The endpoint service runs as expected.
            /// *   **FinancialLocked**: The endpoint service is locked due to overdue payments.
            /// </summary>
            [NameInMap("ServiceBusinessStatus")]
            [Validation(Required=false)]
            public string ServiceBusinessStatus { get; set; }

            /// <summary>
            /// The description of the endpoint service.
            /// </summary>
            [NameInMap("ServiceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }

            /// <summary>
            /// The domain name of the endpoint service.
            /// </summary>
            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// The ID of the endpoint service.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The name of the endpoint service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The type of the service resource. Valid values:
            /// 
            /// *   **slb**: Classic Load Balancer (CLB) instance
            /// *   **alb**: Application Load Balancer (ALB) instance
            /// *   **nlb**: Network Load Balancer (NLB) instance
            /// </summary>
            [NameInMap("ServiceResourceType")]
            [Validation(Required=false)]
            public string ServiceResourceType { get; set; }

            /// <summary>
            /// The state of the endpoint service. Valid values:
            /// 
            /// *   **Creating**: The endpoint service is being created.
            /// *   **Pending**: The endpoint service is being modified.
            /// *   **Active**: The endpoint service is available.
            /// *   **Deleting**: The endpoint service is being deleted.
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// Indicates whether the endpoint service supports IPv6. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ServiceSupportIPv6")]
            [Validation(Required=false)]
            public bool? ServiceSupportIPv6 { get; set; }

            /// <summary>
            /// The type of the endpoint service.
            /// 
            /// *   Only **Interface** may be returned. You can specify CLB, ALB, and NLB instances as the service resources of the endpoint service.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The tags added to the resource.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcEndpointServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListVpcEndpointServicesResponseBodyServicesTags : TeaModel {
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
            /// Indicates whether zone affinity is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ZoneAffinityEnabled")]
            [Validation(Required=false)]
            public bool? ZoneAffinityEnabled { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
