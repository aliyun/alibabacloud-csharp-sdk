// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointServiceAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether endpoint connection requests are automatically accepted. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

        /// <summary>
        /// The default maximum bandwidth of the endpoint connection. Unit: Mbit/s. Valid values: **100** to 10240.
        /// </summary>
        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        /// <summary>
        /// The time when the endpoint service was created.
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
        /// The payer of the endpoint service. Valid values:
        /// 
        /// *   **Endpoint**: the service consumer.
        /// *   **EndpointService**: the service provider.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The service state of the endpoint service. Valid values:
        /// 
        /// *   **Normal**: The endpoint service runs as expected.
        /// *   **FinacialLocked**: The endpoint service is locked due to overdue payments.
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
        /// The endpoint service ID.
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
        /// *   **slb**: a CLB instance.
        /// *   **alb**: an ALB instance.
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
        /// *   **Inactive**: The endpoint service is unavailable.
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// Indicates whether IPv6 is enabled for the endpoint service. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("ServiceSupportIPv6")]
        [Validation(Required=false)]
        public bool? ServiceSupportIPv6 { get; set; }

        /// <summary>
        /// The type of the endpoint.
        /// 
        /// Only **Interface** is returned. The value indicates the interface endpoint. Then, you can specify ALB and CLB instances as service resources for the endpoint service.
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Indicates whether the domain name of the nearest endpoint that is associated with the endpoint service is resolved first. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// The zones to which the service resources belong.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
