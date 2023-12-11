// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// The summary of cloud services.
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public GetCloudAssetSummaryResponseBodyGroupedFields GroupedFields { get; set; }
        public class GetCloudAssetSummaryResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// The statistics of cloud services.
            /// </summary>
            [NameInMap("CloudAssetSummaryMetas")]
            [Validation(Required=false)]
            public List<GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas> CloudAssetSummaryMetas { get; set; }
            public class GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas : TeaModel {
                /// <summary>
                /// The subtype of the cloud service.
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// The type of the cloud service. Valid values:
                /// 
                /// *   **0**: Elastic Compute Service (ECS)
                /// *   **1**: Server Load Balancer (SLB)
                /// *   **3**: ApsaraDB RDS
                /// *   **4**: ApsaraDB for MongoDB (MongoDB)
                /// *   **5**: ApsaraDB for Redis (Redis)
                /// *   **6**: Container Registry
                /// *   **8**: Container Service for Kubernetes (ACK)
                /// *   **9**: Virtual Private Cloud (VPC)
                /// *   **11**: ActionTrail
                /// *   **12**: Alibaba Cloud CDN (CDN)
                /// *   **13**: Certificate Management Service (formerly SSL Certificates Service)
                /// *   **14**: Apsara Devops
                /// *   **15**: Resource Access Management (RAM)
                /// *   **16**: Anti-DDoS
                /// *   **17**: Web Application Firewall (WAF)
                /// *   **18**: Object Storage Service (OSS)
                /// *   **19**: PolarDB
                /// *   **20**: ApsaraDB RDS for PostgreSQL
                /// *   **21**: Microservices Engine (MSE)
                /// *   **22**: Apsara File Storage NAS (NAS)
                /// *   **23**: Data Security Center (DSC)
                /// *   **24**: Elastic IP Address (EIP)
                /// *   **25**: Identity as a Service (IDaaS) - Enterprise Identity Access Management (EIAM)
                /// *   **26**: PolarDB for Xscale (PolarDB-X)
                /// *   **27**: Elasticsearch
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// The total number of cloud service instances of this type.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The total number of cloud service instances that are at risk of this type.
                /// </summary>
                [NameInMap("InstanceRiskCount")]
                [Validation(Required=false)]
                public int? InstanceRiskCount { get; set; }

                /// <summary>
                /// The server type. Valid values:
                /// 
                /// *   **0**: an asset provided by Alibaba Cloud
                /// *   **1**: an asset outside Alibaba Cloud
                /// *   **2**: an asset in a data center
                /// *   **3**, **4**, **5**, and **7**: an asset provided by a third-party service provider
                /// *   **8**: a lightweight asset
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// The total number of cloud service instances.
            /// </summary>
            [NameInMap("InstanceCountTotal")]
            [Validation(Required=false)]
            public int? InstanceCountTotal { get; set; }

            /// <summary>
            /// The total number of cloud service instances that are at risk.
            /// </summary>
            [NameInMap("InstanceRiskCountTotal")]
            [Validation(Required=false)]
            public int? InstanceRiskCountTotal { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
