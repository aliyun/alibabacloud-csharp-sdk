// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultResponseBody : TeaModel {
        /// <summary>
        /// The information about the check items.
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<ListCheckResultResponseBodyChecks> Checks { get; set; }
        public class ListCheckResultResponseBodyChecks : TeaModel {
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("AssetVendor")]
            [Validation(Required=false)]
            public int? AssetVendor { get; set; }

            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The check policies.
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListCheckResultResponseBodyChecksCheckPolicies> CheckPolicies { get; set; }
            public class ListCheckResultResponseBodyChecksCheckPolicies : TeaModel {
                /// <summary>
                /// The ID of the requirement item for the check item.
                /// </summary>
                [NameInMap("RequirementId")]
                [Validation(Required=false)]
                public long? RequirementId { get; set; }

                /// <summary>
                /// The display name of the requirement item for the check item.
                /// </summary>
                [NameInMap("RequirementShowName")]
                [Validation(Required=false)]
                public string RequirementShowName { get; set; }

                /// <summary>
                /// The ID of the section for the check item.
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public long? SectionId { get; set; }

                /// <summary>
                /// The display name of the section for the check item.
                /// </summary>
                [NameInMap("SectionShowName")]
                [Validation(Required=false)]
                public string SectionShowName { get; set; }

                /// <summary>
                /// The standard ID of the check item.
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// The standard display name of the check item.
                /// </summary>
                [NameInMap("StandardShowName")]
                [Validation(Required=false)]
                public string StandardShowName { get; set; }

            }

            /// <summary>
            /// The type of the check item. Valid values:
            /// 
            /// *   **0**: paid
            /// *   **1**: free
            /// </summary>
            [NameInMap("CheckSaleType")]
            [Validation(Required=false)]
            public int? CheckSaleType { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// The asset subtype of the cloud service. Valid values:
            /// 
            /// *   If the **InstanceType** parameter is set to **ECS**, this parameter supports the following valid values:
            /// 
            ///     *   **INSTANCE**
            ///     *   **DISK**
            ///     *   **SECURITY_GROUP**
            /// 
            /// *   If the **InstanceType** parameter is set to **ACR**, this parameter supports the following valid values:
            /// 
            ///     *   **REPOSITORY_ENTERPRISE**
            ///     *   **REPOSITORY_PERSON**
            /// 
            /// *   If the **InstanceType** parameter is set to **RAM**, this parameter supports the following valid values:
            /// 
            ///     *   **ALIAS**
            ///     *   **USER**
            ///     *   **POLICY**
            ///     *   **GROUP**
            /// 
            /// *   If the **InstanceType** parameter is set to **WAF**, this parameter supports the following valid values:
            /// 
            ///     *   **DOMAIN**
            /// 
            /// *   If the **InstanceType** parameter is set to other values, this parameter supports the following valid values:
            /// 
            ///     *   **INSTANCE**
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// The asset type of the cloud service. Valid values:
            /// 
            /// *   **ECS**: ECS
            /// *   **SLB**: SLB
            /// *   **RDS**: ApsaraDB RDS
            /// *   **MONGODB**: MongoDB
            /// *   **KVSTORE**: Redis
            /// *   **ACR**: Container Registry
            /// *   **CSK**: ACK
            /// *   **VPC**: VPC
            /// *   **ACTIONTRAIL**: ActionTrail
            /// *   **CDN**: CDN
            /// *   **CAS**: Certificate Management Service (formerly SSL Certificates Service)
            /// *   **RDC**: Apsara Devops
            /// *   **RAM**: RAM
            /// *   **DDOS**: Anti-DDoS
            /// *   **WAF**: WAF
            /// *   **OSS**: OSS
            /// *   **POLARDB**: PolarDB
            /// *   **POSTGRESQL**: ApsaraDB RDS for PostgreSQL
            /// *   **MSE**: MSE
            /// *   **NAS**: NAS
            /// *   **SDDP**: SDDP
            /// *   **EIP**: EIP
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The timestamp when the last check was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public long? LastCheckTime { get; set; }

            /// <summary>
            /// The risk level of the check item. Valid values:
            /// 
            /// *   **HIGH**
            /// *   **MEDIUM**
            /// *   **LOW**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The status of the check item. Valid values:
            /// 
            /// *   **PASS**: passed
            /// *   **NOT_PASS**: failed
            /// *   **CHECKING**: being checked
            /// *   **NOT_CHECK**: not checked
            /// *   **WHITELIST**: added to the whitelist
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The message returned if the status of the check item is abnormal.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The ID of the check task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// Indicates whether the TRIAL permission is required.
            /// </summary>
            [NameInMap("TrialPermission")]
            [Validation(Required=false)]
            public bool? TrialPermission { get; set; }

            /// <summary>
            /// The cloud service provider.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// The name of the cloud service provider.
            /// </summary>
            [NameInMap("VendorShowName")]
            [Validation(Required=false)]
            public string VendorShowName { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
