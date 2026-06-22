// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The check items.</para>
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<ListCheckResultResponseBodyChecks> Checks { get; set; }
        public class ListCheckResultResponseBodyChecks : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: an ECS instance</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: a SLB instance</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: a NAT gateway</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: an ApsaraDB RDS instance</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: an ApsaraDB for MongoDB instance</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: an ApsaraDB for Redis instance</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: a container image</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: a container</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The service provider of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Alibaba Cloud</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Huawei Cloud</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Microsoft Azure</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: AWS</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: Tencent Cloud</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AssetVendor")]
            [Validation(Required=false)]
            public int? AssetVendor { get; set; }

            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The check policies.</para>
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListCheckResultResponseBodyChecksCheckPolicies> CheckPolicies { get; set; }
            public class ListCheckResultResponseBodyChecksCheckPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the requirement item for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequirementId")]
                [Validation(Required=false)]
                public long? RequirementId { get; set; }

                /// <summary>
                /// <para>The display name of the requirement item for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba cloud OSS best security practices</para>
                /// </summary>
                [NameInMap("RequirementShowName")]
                [Validation(Required=false)]
                public string RequirementShowName { get; set; }

                /// <summary>
                /// <para>The ID of the section for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public long? SectionId { get; set; }

                /// <summary>
                /// <para>The display name of the section for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Log Audit</para>
                /// </summary>
                [NameInMap("SectionShowName")]
                [Validation(Required=false)]
                public string SectionShowName { get; set; }

                /// <summary>
                /// <para>The standard ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <para>The standard display name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Best security practices</para>
                /// </summary>
                [NameInMap("StandardShowName")]
                [Validation(Required=false)]
                public string StandardShowName { get; set; }

            }

            /// <summary>
            /// <para>The type of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: paid</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: free</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckSaleType")]
            [Validation(Required=false)]
            public int? CheckSaleType { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS-PublicReadOpenManifestFileWithoutEncryption</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The source type of the situation awareness check item:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CUSTOM</b>: User-defined</para>
            /// </description></item>
            /// <item><description><para><b>SYSTEM</b>: Predefined by the situation awareness platform</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The asset subtype of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>ECS</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INSTANCE</b></para>
            /// </description></item>
            /// <item><description><para><b>DISK</b></para>
            /// </description></item>
            /// <item><description><para><b>SECURITY_GROUP</b></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>ACR</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>REPOSITORY_ENTERPRISE</b></para>
            /// </description></item>
            /// <item><description><para><b>REPOSITORY_PERSON</b></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>RAM</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ALIAS</b></para>
            /// </description></item>
            /// <item><description><para><b>USER</b></para>
            /// </description></item>
            /// <item><description><para><b>POLICY</b></para>
            /// </description></item>
            /// <item><description><para><b>GROUP</b></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>WAF</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DOMAIN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to other values, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DISK</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ECS</b>: ECS</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: SLB</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>: ApsaraDB RDS</para>
            /// </description></item>
            /// <item><description><para><b>MONGODB</b>: MongoDB</para>
            /// </description></item>
            /// <item><description><para><b>KVSTORE</b>: Redis</para>
            /// </description></item>
            /// <item><description><para><b>ACR</b>: Container Registry</para>
            /// </description></item>
            /// <item><description><para><b>CSK</b>: ACK</para>
            /// </description></item>
            /// <item><description><para><b>VPC</b>: VPC</para>
            /// </description></item>
            /// <item><description><para><b>ACTIONTRAIL</b>: ActionTrail</para>
            /// </description></item>
            /// <item><description><para><b>CDN</b>: CDN</para>
            /// </description></item>
            /// <item><description><para><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service)</para>
            /// </description></item>
            /// <item><description><para><b>RDC</b>: Apsara Devops</para>
            /// </description></item>
            /// <item><description><para><b>RAM</b>: RAM</para>
            /// </description></item>
            /// <item><description><para><b>DDOS</b>: Anti-DDoS</para>
            /// </description></item>
            /// <item><description><para><b>WAF</b>: WAF</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>POLARDB</b>: PolarDB</para>
            /// </description></item>
            /// <item><description><para><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL</para>
            /// </description></item>
            /// <item><description><para><b>MSE</b>: MSE</para>
            /// </description></item>
            /// <item><description><para><b>NAS</b>: NAS</para>
            /// </description></item>
            /// <item><description><para><b>SDDP</b>: SDDP</para>
            /// </description></item>
            /// <item><description><para><b>EIP</b>: EIP</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The timestamp when the last check was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657793398000</para>
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public long? LastCheckTime { get; set; }

            /// <summary>
            /// <para>Indicates whether fixing is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SUPPORT_REPAIR</b></para>
            /// </description></item>
            /// <item><description><para><b>NOT_SUPPORT_REPAIR</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_SUPPORT_REPAIR</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HIGH</b></para>
            /// </description></item>
            /// <item><description><para><b>MEDIUM</b></para>
            /// </description></item>
            /// <item><description><para><b>LOW</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PASS</b>: passed</para>
            /// </description></item>
            /// <item><description><para><b>NOT_PASS</b>: failed</para>
            /// </description></item>
            /// <item><description><para><b>CHECKING</b>: being checked</para>
            /// </description></item>
            /// <item><description><para><b>NOT_CHECK</b>: not checked</para>
            /// </description></item>
            /// <item><description><para><b>WHITELIST</b>: added to the whitelist</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: failed</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The message returned if the status of the check item is abnormal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIMEOUT</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The ID of the check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Indicates whether the TRIAL permission is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TrialPermission")]
            [Validation(Required=false)]
            public bool? TrialPermission { get; set; }

            /// <summary>
            /// <para>Check whether the data delivery period for ActionTrail is enabled for more than 30 days to establish a baseline of behaviour.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: REQUIRED</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: NOT REQUIRED</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrialPermissionType")]
            [Validation(Required=false)]
            public int? TrialPermissionType { get; set; }

            /// <summary>
            /// <para>The cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <para>The name of the cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("VendorShowName")]
            [Validation(Required=false)]
            public string VendorShowName { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9B6DD67-B289-5406-B35C-B0F4A217S23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
