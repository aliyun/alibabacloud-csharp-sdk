// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVulnerabilitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The list of vulnerabilities.</para>
        /// </summary>
        [NameInMap("Vulnerabilities")]
        [Validation(Required=false)]
        public List<ListVulnerabilitiesResponseBodyVulnerabilities> Vulnerabilities { get; set; }
        public class ListVulnerabilitiesResponseBodyVulnerabilities : TeaModel {
            /// <summary>
            /// <para>The list of CVE IDs corresponding to the vulnerability. An empty list is returned if no CVE is associated.</para>
            /// </summary>
            [NameInMap("CveList")]
            [Validation(Required=false)]
            public List<string> CveList { get; set; }

            /// <summary>
            /// <para>The English description of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This update fixes several remote code execution and privilege escalation vulnerabilities.</para>
            /// </summary>
            [NameInMap("DescriptionEn")]
            [Validation(Required=false)]
            public string DescriptionEn { get; set; }

            /// <summary>
            /// <para>The Chinese description of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>该更新修复了若干远程代码执行与权限提升漏洞</para>
            /// </summary>
            [NameInMap("DescriptionZh")]
            [Validation(Required=false)]
            public string DescriptionZh { get; set; }

            /// <summary>
            /// <para>The list of Knowledge Base (KB) numbers corresponding to the vulnerability.</para>
            /// </summary>
            [NameInMap("Kbs")]
            [Validation(Required=false)]
            public List<string> Kbs { get; set; }

            /// <summary>
            /// <para>The name of the product affected by the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows 11 Home</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The release time of the vulnerability, in seconds as a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786291200</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The English title of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08 Cumulative Update for Windows 11</para>
            /// </summary>
            [NameInMap("TitleEn")]
            [Validation(Required=false)]
            public string TitleEn { get; set; }

            /// <summary>
            /// <para>The Chinese title of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08 适用于 Windows 11 的累积更新</para>
            /// </summary>
            [NameInMap("TitleZh")]
            [Validation(Required=false)]
            public string TitleZh { get; set; }

            /// <summary>
            /// <para>The patch ID corresponding to the vulnerability. For Windows vulnerabilities, this is the Microsoft patch Update ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9f8c1d2e-4b7a-4c31-9e05-6d2f8a71****</para>
            /// </summary>
            [NameInMap("UpdateId")]
            [Validation(Required=false)]
            public string UpdateId { get; set; }

            /// <summary>
            /// <para>The number of user endpoint devices affected by the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("VulDeviceCount")]
            [Validation(Required=false)]
            public long? VulDeviceCount { get; set; }

            /// <summary>
            /// <para>The vulnerability risk level, mapped from the vendor risk level: Critical is mapped to High, Important is mapped to Mid, and others are mapped to Low. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>High</b>: high risk.</description></item>
            /// <item><description><b>Mid</b>: medium risk.</description></item>
            /// <item><description><b>Low</b>: low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

            /// <summary>
            /// <para>The vulnerability type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows system vulnerability.</description></item>
            /// <item><description><b>ai_agent</b>: AI Agent vulnerability.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("VulType")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

    }

}
