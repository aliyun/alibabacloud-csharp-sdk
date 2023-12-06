// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshAssetsRequest : TeaModel {
        /// <summary>
        /// The type of the asset that you want to synchronize. Valid values:
        /// 
        /// *   **cloud_product**: Alibaba Cloud service
        /// *   **ecs**: Elastic Compute Service (ECS) instance
        /// *   **container_image**: container image
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// The subtype of the cloud service.
        /// 
        /// >  The following list describes the subtypes of cloud services.
        /// </summary>
        [NameInMap("CloudAssetSubType")]
        [Validation(Required=false)]
        public int? CloudAssetSubType { get; set; }

        /// <summary>
        /// The type of the cloud service. Valid values:
        /// 
        /// *   **0**: ECS
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
        /// </summary>
        [NameInMap("CloudAssetType")]
        [Validation(Required=false)]
        public int? CloudAssetType { get; set; }

        /// <summary>
        /// The type of the server. Valid values:
        /// 
        /// *   **0**: an asset provided by Alibaba Cloud
        /// *   **1**: a third-party cloud asset
        /// *   **2**: an asset in a data center
        /// *   **3**, **4**, **5**, and **7**: an asset provided by another cloud
        /// *   **8**: a lightweight asset
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
