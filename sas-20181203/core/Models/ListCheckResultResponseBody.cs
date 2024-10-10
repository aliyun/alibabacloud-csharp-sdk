// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the check items.</para>
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
            /// <item><description><b>0</b>: paid</description></item>
            /// <item><description><b>1</b>: free</description></item>
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
            /// <para>The asset subtype of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>ECS</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// <item><description><b>DISK</b></description></item>
            /// <item><description><b>SECURITY_GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>ACR</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
            /// <item><description><b>REPOSITORY_PERSON</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the <b>InstanceType</b> parameter is set to <b>RAM</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIAS</b></description></item>
            /// <item><description><b>USER</b></description></item>
            /// <item><description><b>POLICY</b></description></item>
            /// <item><description><b>GROUP</b></description></item>
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
            /// <item><description><b>ECS</b>: ECS</description></item>
            /// <item><description><b>SLB</b>: SLB</description></item>
            /// <item><description><b>RDS</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>MONGODB</b>: MongoDB</description></item>
            /// <item><description><b>KVSTORE</b>: Redis</description></item>
            /// <item><description><b>ACR</b>: Container Registry</description></item>
            /// <item><description><b>CSK</b>: ACK</description></item>
            /// <item><description><b>VPC</b>: VPC</description></item>
            /// <item><description><b>ACTIONTRAIL</b>: ActionTrail</description></item>
            /// <item><description><b>CDN</b>: CDN</description></item>
            /// <item><description><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
            /// <item><description><b>RDC</b>: Apsara Devops</description></item>
            /// <item><description><b>RAM</b>: RAM</description></item>
            /// <item><description><b>DDOS</b>: Anti-DDoS</description></item>
            /// <item><description><b>WAF</b>: WAF</description></item>
            /// <item><description><b>OSS</b>: OSS</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB</description></item>
            /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL</description></item>
            /// <item><description><b>MSE</b>: MSE</description></item>
            /// <item><description><b>NAS</b>: NAS</description></item>
            /// <item><description><b>SDDP</b>: SDDP</description></item>
            /// <item><description><b>EIP</b>: EIP</description></item>
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

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HIGH</b></description></item>
            /// <item><description><b>MEDIUM</b></description></item>
            /// <item><description><b>LOW</b></description></item>
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
            /// <item><description><b>PASS</b>: passed</description></item>
            /// <item><description><b>NOT_PASS</b>: failed</description></item>
            /// <item><description><b>CHECKING</b>: being checked</description></item>
            /// <item><description><b>NOT_CHECK</b>: not checked</description></item>
            /// <item><description><b>WHITELIST</b>: added to the whitelist</description></item>
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
