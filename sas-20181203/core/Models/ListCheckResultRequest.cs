// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultRequest : TeaModel {
        /// <summary>
        /// The key that you want to use to search for check items in fuzzy match mode.
        /// </summary>
        [NameInMap("CheckKey")]
        [Validation(Required=false)]
        public string CheckKey { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The instance IDs of the cloud services that you want to query. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The asset type of the cloud service. Valid values:
        /// 
        /// *   **ECS**: Elastic Compute Service (ECS)
        /// *   **SLB**: Server Load Balancer (SLB)
        /// *   **RDS**: ApsaraDB RDS
        /// *   **MONGODB**: ApsaraDB for MongoDB (MongoDB)
        /// *   **KVSTORE**: ApsaraDB for Redis (Redis)
        /// *   **ACR**: Container Registry
        /// *   **CSK**: Container Service for Kubernetes (ACK)
        /// *   **VPC**: Virtual Private Cloud (VPC)
        /// *   **ACTIONTRAIL**: ActionTrail
        /// *   **CDN**: Alibaba Cloud CDN (CDN)
        /// *   **CAS**: Certificate Management Service (formerly SSL Certificates Service)
        /// *   **RDC**: Apsara Devops
        /// *   **RAM**: Resource Access Management (RAM)
        /// *   **DDOS**: Anti-DDoS
        /// *   **WAF**: Web Application Firewall (WAF)
        /// *   **OSS**: Object Storage Service (OSS)
        /// *   **POLARDB**: PolarDB
        /// *   **POSTGRESQL**: ApsaraDB RDS for PostgreSQL
        /// *   **MSE**: Microservices Engine (MSE)
        /// *   **NAS**: Apsara File Storage NAS (NAS)
        /// *   **SDDP**: Sensitive Data Discovery and Protection (SDDP)
        /// *   **EIP**: Elastic IP Address (EIP)
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of requirement items.
        /// </summary>
        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        /// <summary>
        /// The risk levels of check items. Separate multiple risk levels with commas (,). Valid values:
        /// 
        /// *   **HIGH**
        /// *   **MEDIUM**
        /// *   **LOW**
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        /// <summary>
        /// The types of the conditions based on which check items are sorted. Valid values:
        /// 
        /// *   **RISK_LEVEL**: risk level
        /// *   **STATUS**: status
        /// </summary>
        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        /// <summary>
        /// The IDs of standards.
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// The status of check items. Separate multiple status with commas (,). Valid values:
        /// 
        /// *   **PASS**
        /// *   **NOT_PASS**
        /// *   **CHECKING**
        /// *   **NOT_CHECK**
        /// *   **WHITELIST**
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// The cloud service provider. Valid values:
        /// 
        /// *   **ALIYUN**: Alibaba Cloud
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
