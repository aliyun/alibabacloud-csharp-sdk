// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// The types of cloud assets.
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetCriteriaRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// The subtype of the cloud service. Valid values:
            /// 
            /// *   **0**: ECS
            ///     *   **0**: instance
            ///     *  **1**: disk (storage)
            ///     *  **2**: security group
            /// *   **1**: SLB
            ///     *  **0**: SLB
            ///     *  **1**: Application Load Balancer (ALB)
            /// *   **3**: ApsaraDB RDS
            ///     *  **0**: instance
            /// *   **4**: MongoDB
            ///     *  **0**: instance
            /// *   **5**: Redis
            ///     *  **0**: instance
            /// *   **6**: Container Registry
            ///     *  **1**: Container Registry Enterprise Edition
            ///     *  **2**: Container Registry Personal Edition
            /// *   **8**: ACK
            ///     *  **0**: cluster
            /// *   **9**: VPC
            ///     *  **0**: NAT gateway
            ///     *  **1**: EIP
            ///     *  **2**: Virtual Private Network (VPN)
            ///     *  **3**: flow log
            /// *   **11**: ActionTrail
            ///     *  **0**: trail
            /// *   **12**: CDN
            ///     *  **0**: instance
            /// *   **13**: Certificate Management Service (formerly SSL Certificates Service)
            ///     *  **0**: certificate
            /// *   **14**: Apsara Devops
            ///     *  **0**: organization
            /// *   **16**: Anti-DDoS
            ///     *  **0**: instance
            /// *   **17**: WAF
            ///     *  **0**: domain name
            /// *   **18**: OSS
            ///     *  **0**: bucket
            /// *   **19**: PolarDB
            ///     *  **0**: cluster
            /// *   **20**: ApsaraDB RDS for PostgreSQL
            ///     *  **0**: instance
            /// *   **21**: MSE
            ///     *  **0**: cluster
            /// *   **22**: NAS
            ///     *  **0**: file system
            /// *   **23**: DSC
            ///     *  **0**: instance
            /// *   **24**: EIP
            ///     *  **0**: Anycast EIP
            /// *   **25**: IDaaS EIAM
            ///     *  **0**: instance
            /// *   **26**: PolarDB-X
            ///     *  **0**: instance
            /// *   **27**: Elasticsearch
            ///     *  **0**: instance
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// The type of the asset by source. Valid values:
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

        }

        /// <summary>
        /// The keyword for fuzzy search when you query the asset.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
