// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageGroupedVulListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of image vulnerabilities.</para>
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeImageGroupedVulListResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeImageGroupedVulListResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the vulnerability supports agentless fix. true: supported. false: not supported. If this field is not returned, no corresponding fix capability information is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgentlessCanFix")]
            [Validation(Required=false)]
            public string AgentlessCanFix { get; set; }

            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RHSA-2017:3075-Important: wget security update</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The number of high-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability can be fixed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b>: The vulnerability can be fixed.</description></item>
            /// <item><description><b>no</b>: The vulnerability cannot be fixed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("CanFix")]
            [Validation(Required=false)]
            public string CanFix { get; set; }

            /// <summary>
            /// <para>The CVSS score of the vulnerability, which measures the vulnerability severity. The value ranges from 0 to 10. A higher score indicates a higher severity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.5</para>
            /// </summary>
            [NameInMap("CveScore")]
            [Validation(Required=false)]
            public string CveScore { get; set; }

            /// <summary>
            /// <para>The timestamp of the first scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611201274000</para>
            /// </summary>
            [NameInMap("GmtLast")]
            [Validation(Required=false)]
            public long? GmtLast { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611201274000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The number of medium-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>debian:9:CVE-2019-3858</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of low-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>The associated vulnerability IDs, such as CVE IDs. Multiple IDs are separated by commas (,). Some vulnerabilities return the corresponding vulnerability advisory IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2023-38408</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>The vulnerability tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AI</b>: vulnerabilities related to AI components</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("RuleTag")]
            [Validation(Required=false)]
            public string RuleTag { get; set; }

            /// <summary>
            /// <para>The processing status of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unhandled.</description></item>
            /// <item><description><b>1</b>: Handled.</description></item>
            /// <item><description><b>2</b>: Verifying.</description></item>
            /// <item><description><b>3</b>: Added to the whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The labels of the vulnerability. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Restart required</description></item>
            /// <item><description>Remote utilization</description></item>
            /// <item><description>EXP exists</description></item>
            /// <item><description>Exploitable</description></item>
            /// <item><description>Privilege escalation</description></item>
            /// <item><description>Code execution</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Restart required</description></item>
            /// <item><description>Remote utilization</description></item>
            /// <item><description>EXP exists</description></item>
            /// <item><description>Exploitable</description></item>
            /// <item><description>Privilege escalation</description></item>
            /// <item><description>Code Execution</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXP exists</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The type of vulnerability to query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: image system vulnerability</description></item>
            /// <item><description><b>sca</b>: image application vulnerability</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of image vulnerabilities displayed on each page in a paging query. Default value: <b>20</b>, which indicates 20 image vulnerability records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E244439-UJND-8BF7-26F36E21B9AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of image system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
