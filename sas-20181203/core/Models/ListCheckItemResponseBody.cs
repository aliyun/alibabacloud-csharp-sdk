// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemResponseBody : TeaModel {
        /// <summary>
        /// The check items.
        /// </summary>
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<ListCheckItemResponseBodyCheckItems> CheckItems { get; set; }
        public class ListCheckItemResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// The check items.
            /// </summary>
            [NameInMap("CustomConfigs")]
            [Validation(Required=false)]
            public List<ListCheckItemResponseBodyCheckItemsCustomConfigs> CustomConfigs { get; set; }
            public class ListCheckItemResponseBodyCheckItemsCustomConfigs : TeaModel {
                /// <summary>
                /// The default value of the check item. The value is a string.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// The name of the check item.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The display name of the check item.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// The type of the check item. The value is a JSON string.
                /// </summary>
                [NameInMap("TypeDefine")]
                [Validation(Required=false)]
                public string TypeDefine { get; set; }

                /// <summary>
                /// The specified value of the check item. The value is a string.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the check item.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public ListCheckItemResponseBodyCheckItemsDescription Description { get; set; }
            public class ListCheckItemResponseBodyCheckItemsDescription : TeaModel {
                /// <summary>
                /// The type of the description of the check item. Valid value:
                /// 
                /// *   **text**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The content of the description for the check item when the Type parameter is text.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("EstimatedCount")]
            [Validation(Required=false)]
            public int? EstimatedCount { get; set; }

            /// <summary>
            /// The asset subtype of the cloud service. Valid value:
            /// 
            /// *   If **InstanceType** is set to **ECS**, this parameter supports the following valid values:
            /// 
            ///     *   **INSTANCE**
            ///     *   **DISK**
            ///     *   **SECURITY_GROUP**
            /// 
            /// *   If **InstanceType** is set to **ACR**, this parameter supports the following valid values:
            /// 
            ///     *   **REPOSITORY_ENTERPRISE**
            ///     *   **REPOSITORY_PERSON**
            /// 
            /// *   If **InstanceType** is set to **RAM**, this parameter supports the following valid values:
            /// 
            ///     *   **ALIAS**
            ///     *   **USER**
            ///     *   **POLICY**
            ///     *   **GROUP**
            /// 
            /// *   If **InstanceType** is set to **WAF**, this parameter supports the following valid values:
            /// 
            ///     *   **DOMAIN**
            /// 
            /// *   If **InstanceType** is set to other values, this parameter supports the following valid values:
            /// 
            ///     *   **INSTANCE**
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// The asset type of the cloud service. Valid value:
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
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The risk level of the check item. Valid value:
            /// 
            /// *   **HIGH**
            /// *   **MEDIUM**
            /// *   **LOW**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The IDs of the sections associated with the check items.
            /// </summary>
            [NameInMap("SectionIds")]
            [Validation(Required=false)]
            public List<long?> SectionIds { get; set; }

            /// <summary>
            /// The type of the cloud asset. Valid value:
            /// 
            /// *   **0**: an asset provided by Alibaba Cloud
            /// *   **1**: a third-party cloud asset
            /// *   **2**: an asset in a data center
            /// *   **3**, **4**, **5**, and **7**: other cloud asset
            /// *   **8**: a simple application server
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
