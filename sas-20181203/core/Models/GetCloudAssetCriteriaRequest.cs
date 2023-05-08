// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// The name of the filter condition. Valid values:
        /// 
        /// *   **instanceId**: the ID of the instance
        /// *   **instanceName**: the name of an instance
        /// *   **internetIp**: the public IP address
        /// *   **riskStatus**: the risk status
        /// *   **vendorRegionId**: the region ID by service provider
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetCriteriaRequestCloudAssetTypes : TeaModel {
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
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// The type of the cloud asset.
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

        }

        /// <summary>
        /// The type of the filter condition. Valid values:
        /// 
        /// *   **input**: The filter condition needs to be specified.
        /// *   **select**: The filter condition is an option that can be selected from the drop-down list.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
