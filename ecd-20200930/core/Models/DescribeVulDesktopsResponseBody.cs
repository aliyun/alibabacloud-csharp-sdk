// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. An empty value indicates that no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kRxd1mKkNnHlUy14zdjl/I</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of cloud computers affected by the vulnerability.</para>
        /// </summary>
        [NameInMap("VulDesktops")]
        [Validation(Required=false)]
        public List<DescribeVulDesktopsResponseBodyVulDesktops> VulDesktops { get; set; }
        public class DescribeVulDesktopsResponseBodyVulDesktops : TeaModel {
            /// <summary>
            /// <para>The configuration task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-0bbay4w7bwbxd****</para>
            /// </summary>
            [NameInMap("ConfigGroupId")]
            [Validation(Required=false)]
            public string ConfigGroupId { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("CveCount")]
            [Validation(Required=false)]
            public int? CveCount { get; set; }

            /// <summary>
            /// <para>The list of vulnerability details.</para>
            /// </summary>
            [NameInMap("Cves")]
            [Validation(Required=false)]
            public List<DescribeVulDesktopsResponseBodyVulDesktopsCves> Cves { get; set; }
            public class DescribeVulDesktopsResponseBodyVulDesktopsCves : TeaModel {
                /// <summary>
                /// <para>The CVE ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CVE-2026-62690</para>
                /// </summary>
                [NameInMap("CveId")]
                [Validation(Required=false)]
                public string CveId { get; set; }

                /// <summary>
                /// <para>The vulnerability level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>low</para>
                /// </summary>
                [NameInMap("CveLevel")]
                [Validation(Required=false)]
                public string CveLevel { get; set; }

                /// <summary>
                /// <para>The vulnerability name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows Push Notification Elevation of Privilege Vulnerability</para>
                /// </summary>
                [NameInMap("CveTitle")]
                [Validation(Required=false)]
                public string CveTitle { get; set; }

                /// <summary>
                /// <para>The CVE URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://avd.aliyun.com/detail/CVE-2026-62690">https://avd.aliyun.com/detail/CVE-2026-62690</a></para>
                /// </summary>
                [NameInMap("CveUrl")]
                [Validation(Required=false)]
                public string CveUrl { get; set; }

                /// <summary>
                /// <para>The vulnerability score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.0</para>
                /// </summary>
                [NameInMap("ImpactScore")]
                [Validation(Required=false)]
                public string ImpactScore { get; set; }

                /// <summary>
                /// <para>The reference URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://msrc.microsoft.com/update-guide/vulnerability/CVE-2026-62690">https://msrc.microsoft.com/update-guide/vulnerability/CVE-2026-62690</a></para>
                /// </summary>
                [NameInMap("ReferenceUrl")]
                [Validation(Required=false)]
                public string ReferenceUrl { get; set; }

                /// <summary>
                /// <para>The release time. The time follows the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-11 07:00:00</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud computer affected by the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-0jtd4z5binubxe32e</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>Indicates whether the activation code is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The time when the vulnerability was first discovered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-05 00:00:00</para>
            /// </summary>
            [NameInMap("FirstFoundTime")]
            [Validation(Required=false)]
            public string FirstFoundTime { get; set; }

            /// <summary>
            /// <para>The list of fix records for the cloud computer.</para>
            /// </summary>
            [NameInMap("FixRecords")]
            [Validation(Required=false)]
            public List<DescribeVulDesktopsResponseBodyVulDesktopsFixRecords> FixRecords { get; set; }
            public class DescribeVulDesktopsResponseBodyVulDesktopsFixRecords : TeaModel {
                /// <summary>
                /// <para>The batch ID of the scheduled task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d7f3d7bc-b98b-4da8-95ae-fea21b604b34</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Update failed</para>
                /// </summary>
                [NameInMap("FixFailureReason")]
                [Validation(Required=false)]
                public string FixFailureReason { get; set; }

                /// <summary>
                /// <para>The fix result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("FixResult")]
                [Validation(Required=false)]
                public string FixResult { get; set; }

                /// <summary>
                /// <para>The timestamp when the fix task ended, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-05 13:57:31</para>
                /// </summary>
                [NameInMap("FixTime")]
                [Validation(Required=false)]
                public string FixTime { get; set; }

                /// <summary>
                /// <para>The fix type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AutoTask</para>
                /// </summary>
                [NameInMap("FixType")]
                [Validation(Required=false)]
                public string FixType { get; set; }

            }

            /// <summary>
            /// <para>The list of patch IDs.</para>
            /// </summary>
            [NameInMap("PatchIds")]
            [Validation(Required=false)]
            public List<string> PatchIds { get; set; }

            /// <summary>
            /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The enterprise resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm2tswogr****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The fix status of the patch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fixed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The patch level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

        }

    }

}
