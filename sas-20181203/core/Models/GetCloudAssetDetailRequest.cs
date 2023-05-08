// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetDetailRequest : TeaModel {
        /// <summary>
        /// The subtype of the cloud asset.
        /// </summary>
        [NameInMap("AssetSubType")]
        [Validation(Required=false)]
        public int? AssetSubType { get; set; }

        /// <summary>
        /// The type of the cloud asset. Valid values:
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
        /// *   **25**: IDaaS EIAM
        /// *   **26**: PolarDB-X
        /// *   **27**: Elasticsearch
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public int? AssetType { get; set; }

        /// <summary>
        /// The details of the assets.
        /// </summary>
        [NameInMap("CloudAssetInstances")]
        [Validation(Required=false)]
        public List<GetCloudAssetDetailRequestCloudAssetInstances> CloudAssetInstances { get; set; }
        public class GetCloudAssetDetailRequestCloudAssetInstances : TeaModel {
            /// <summary>
            /// The instance ID of the cloud asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region where the cloud asset resides.
            /// 
            /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The service provider of the cloud asset. Valid values:
        /// 
        /// *   **0**: The asset is provided by Alibaba Cloud.
        /// *   **1**: The asset is not provided by Alibaba Cloud.
        /// *   **2**: The asset resides in a data center.
        /// *   **3**, **4**, **5**, and **7**: other cloud asset.
        /// *   **8**: The asset is a simple application server.
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
