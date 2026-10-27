// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The check result information.</para>
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<ListClusterCheckResultResponseBodyChecks> Checks { get; set; }
        public class ListClusterCheckResultResponseBodyChecks : TeaModel {
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
            /// <para>The asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

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
            /// <para>The standards, regulations, and sections associated with the check result.</para>
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListClusterCheckResultResponseBodyChecksCheckPolicies> CheckPolicies { get; set; }
            public class ListClusterCheckResultResponseBodyChecksCheckPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the regulation for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequirementId")]
                [Validation(Required=false)]
                public long? RequirementId { get; set; }

                /// <summary>
                /// <para>The display name of the regulation for the check item.</para>
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
                /// <para>The ID of the standard for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <para>The display name of the standard for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Best security practices</para>
                /// </summary>
                [NameInMap("StandardShowName")]
                [Validation(Required=false)]
                public string StandardShowName { get; set; }

            }

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
            /// <para>The source type of the Threat Detection Service check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CUSTOM</b>: Custom.</description></item>
            /// <item><description><b>SYSTEM</b>: Predefined by the Threat Detection Service platform.</description></item>
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
            /// <item><description>If <b>InstanceType</b> is set to <b>ECS</b>, valid values are:<list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// <item><description><b>DISK</b></description></item>
            /// <item><description><b>SECURITY_GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If <b>InstanceType</b> is set to <b>ACR</b>, valid values are:<list type="bullet">
            /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
            /// <item><description><b>REPOSITORY_PERSON</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If <b>InstanceType</b> is set to <b>RAM</b>, valid values are:<list type="bullet">
            /// <item><description><b>ALIAS</b></description></item>
            /// <item><description><b>USER</b></description></item>
            /// <item><description><b>POLICY</b></description></item>
            /// <item><description><b>GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If <b>InstanceType</b> is set to <b>WAF</b>, valid values are:<list type="bullet">
            /// <item><description><b>DOMAIN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If <b>InstanceType</b> is set to other values, valid values are:<list type="bullet">
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
            /// <para>The asset type of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Workload</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest check. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657793398000</para>
            /// </summary>
            [NameInMap("LastCheckTime")]
            [Validation(Required=false)]
            public long? LastCheckTime { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HIGH</b>: High.</description></item>
            /// <item><description><b>MEDIUM</b>: Medium.</description></item>
            /// <item><description><b>LOW</b>: Low.</description></item>
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
            /// <item><description><b>PASS</b>: Passed.</description></item>
            /// <item><description><b>NOT_PASS</b>: Failed.</description></item>
            /// <item><description><b>CHECKING</b>: Checking.</description></item>
            /// <item><description><b>NOT_CHECK</b>: Not checked.</description></item>
            /// <item><description><b>WHITELIST</b>: Whitelisted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether the check depends on the TRIAL permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TrialPermission")]
            [Validation(Required=false)]
            public bool? TrialPermission { get; set; }

            /// <summary>
            /// <para>Specifies whether the check item requires enabling data delivery for ActionTrail for more than 30 days to build a behavior baseline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Yes.</description></item>
            /// <item><description><b>0</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrialPermissionType")]
            [Validation(Required=false)]
            public int? TrialPermissionType { get; set; }

            /// <summary>
            /// <para>The vendor of the asset. Valid values:</para>
            /// <para>0: Alibaba Cloud.
            /// 3: Other cloud.
            /// 4: Other cloud.
            /// 5: Other cloud.
            /// 7: Other cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterCheckResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of data entries displayed on the current page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of alerting events to display on each page during paging in a paged query. Default value: <b>20</b>, which indicates that 20 alerting events are displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
