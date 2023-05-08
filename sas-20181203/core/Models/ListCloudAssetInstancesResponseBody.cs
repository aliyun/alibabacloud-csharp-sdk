// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the cloud asset.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListCloudAssetInstancesResponseBodyInstances> Instances { get; set; }
        public class ListCloudAssetInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// Indicates whether risks are detected on the cloud asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// The instance ID of the cloud asset.
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public string AssetSubType { get; set; }

            /// <summary>
            /// The security information about the cloud asset.
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// The subtype of the cloud asset. The subtype of the cloud service. Valid values:
            /// 
            /// *   **0**: ECS
            ///     * **0**: instance
            ///     * **1**: disk (storage)
            ///     * **2**: security group
            /// *   **1**: SLB
            ///     * **0**: SLB
            ///     * **1**: Application Load Balancer (ALB)
            /// *   **3**: ApsaraDB RDS
            ///     * **0**: instance
            /// *   **4**: MongoDB
            ///     * **0**: instance
            /// *   **5**: Redis
            ///     * **0**: instance
            /// *   **6**: Container Registry
            ///     * **1**: Enterprise Edition
            ///     * **2**: Personal Edition
            /// *   **8**: ACK
            ///     * **0**: cluster
            /// *   **9**: VPC
            ///     * **0**: NAT gateway
            ///     * **1**:EIP
            ///     * **2**:VPN
            ///     * **3**:FLOW_LOG
            /// *   **11**: ActionTrail
            ///     * **0**: trail
            /// *   **12**: CDN
            ///     * **0**: instance
            /// *   **13**: Certificate Management Service (formerly SSL Certificates Service)
            ///      * **0**: certificate
            /// *   **14**: Apsara Devops
            ///     * **0**: organization
            /// *   **16**: Anti-DDoS
            ///     * **0**: instance
            /// *   **17**: WAF
            ///     * **0**: domain name
            /// *   **18**: OSS
            ///     * **0**:Bucket
            /// *   **19**: PolarDB
            ///     * **0**: cluster
            /// *   **20**: ApsaraDB RDS for PostgreSQL
            ///     * **0**: instance
            /// *   **21**: MSE
            ///     * **0**: cluster
            /// *   **22**: NAS
            ///     * **0**: file system
            /// *   **23**: DSC
            ///     * **0**: instance
            /// *   **24**: EIP
            ///     * **0**: Anycast EIP
            /// *   **25**: IDaaS EIAM
            ///     * **0**: instance
            /// *   **26**: PolarDB-X
            ///     * **0**: instance
            /// *   **27**: Elasticsearch
            ///     * **0**: instance
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// The subtype name of the cloud asset.
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// The public IP address of the instance.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The instance name of the cloud asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// Indicates whether alerts are generated for the cloud asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The type of the cloud asset by source. Valid values:
            /// 
            /// *   **0**: an asset provided by Alibaba Cloud
            /// *   **1**: a third-party cloud asset
            /// *   **2**: an asset in a data center
            /// *   **3**, **4**, **5**, and **7**: other cloud asset
            /// *   **8**: a lightweight asset
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type name of the cloud asset.
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            [NameInMap("SecurityInfo")]
            [Validation(Required=false)]
            public string SecurityInfo { get; set; }

            /// <summary>
            /// The type of the asset. Valid values:
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
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCloudAssetInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class ListCloudAssetInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// An array that consists of the details of the cloud assets.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The total number of cloud assets.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
