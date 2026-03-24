// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Information on check results.</para>
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<ListClusterCheckResultResponseBodyChecks> Checks { get; set; }
        public class ListClusterCheckResultResponseBodyChecks : TeaModel {
            /// <summary>
            /// <para>Subtype of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>Asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>Information about the standards, requirements, and sections associated with the check result.</para>
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListClusterCheckResultResponseBodyChecksCheckPolicies> CheckPolicies { get; set; }
            public class ListClusterCheckResultResponseBodyChecksCheckPolicies : TeaModel {
                /// <summary>
                /// <para>Requirement ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequirementId")]
                [Validation(Required=false)]
                public long? RequirementId { get; set; }

                /// <summary>
                /// <para>Display name of the requirement for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba cloud OSS best security practices</para>
                /// </summary>
                [NameInMap("RequirementShowName")]
                [Validation(Required=false)]
                public string RequirementShowName { get; set; }

                /// <summary>
                /// <para>Section ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public long? SectionId { get; set; }

                /// <summary>
                /// <para>Display name of the section for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Log Audit</para>
                /// </summary>
                [NameInMap("SectionShowName")]
                [Validation(Required=false)]
                public string SectionShowName { get; set; }

                /// <summary>
                /// <para>Standard ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <para>Display name of the standard for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Best security practices</para>
                /// </summary>
                [NameInMap("StandardShowName")]
                [Validation(Required=false)]
                public string StandardShowName { get; set; }

            }

            /// <summary>
            /// <para>Name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS-PublicReadOpenManifestFileWithoutEncryption</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>Source type of the security check item:</para>
            /// <list type="bullet">
            /// <item><description><b>CUSTOM</b>：User-defined</description></item>
            /// <item><description><b>SYSTEM</b>：Predefined by the Security Platform</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>Subtype of the cloud product asset. Values:</para>
            /// <list type="bullet">
            /// <item><description>When <b>InstanceType</b> is <b>ECS</b>, this parameter can take the following values:<list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// <item><description><b>DISK</b></description></item>
            /// <item><description><b>SECURITY_GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is <b>ACR</b>, this parameter can take the following values:<list type="bullet">
            /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
            /// <item><description><b>REPOSITORY_PERSON</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is <b>RAM</b>, this parameter can take the following values:<list type="bullet">
            /// <item><description><b>ALIAS</b></description></item>
            /// <item><description><b>USER</b></description></item>
            /// <item><description><b>POLICY</b></description></item>
            /// <item><description><b>GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is <b>WAF</b>, this parameter can take the following values:<list type="bullet">
            /// <item><description><b>DOMAIN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>For other <b>InstanceType</b> values, this parameter can take the following value:<list type="bullet">
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
            /// <para>Asset type of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Workload</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Timestamp of the latest check, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657793398000</para>
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public long? LastCheckTime { get; set; }

            /// <summary>
            /// <para>Risk level of the check item. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><b>HIGH</b>：High</description></item>
            /// <item><description><b>MEDIUM</b>：Medium</description></item>
            /// <item><description><b>LOW</b>：Low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>Status of the check item. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>PASS</b>: Passed</description></item>
            /// <item><description><b>NOT_PASS</b>: Not passed</description></item>
            /// <item><description><b>CHECKING</b>: Checking</description></item>
            /// <item><description><b>NOT_CHECK</b>: Not checked</description></item>
            /// <item><description><b>WHITELIST</b>: Whitelisted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Whether the check depends on TRIAL permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TrialPermission")]
            [Validation(Required=false)]
            public bool? TrialPermission { get; set; }

            /// <summary>
            /// <para>Whether the check item requires enabling data delivery of operation audit for more than 30 days to build a behavior baseline.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>：Required</description></item>
            /// <item><description><b>0</b>：Not Required</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrialPermissionType")]
            [Validation(Required=false)]
            public int? TrialPermissionType { get; set; }

            /// <summary>
            /// <para>Vendor of the asset. Values:</para>
            /// <para>0: Alibaba Cloud
            /// 3: Other cloud
            /// 4: Other cloud
            /// 5: Other cloud
            /// 7: Other cloud</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterCheckResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of data entries displayed on the current page during pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Page number in the pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of items per page in the pagination query. The default value is <b>20</b>, indicating that 20 items are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
