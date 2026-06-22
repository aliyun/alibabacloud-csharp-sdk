// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The vulnerability information returned by the query.</para>
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeGroupedVulResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeGroupedVulResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RHSA-2017:0184-Important: mysql security update</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities with a fix priority of <b>high</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was first detected, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639371046000</para>
            /// </summary>
            [NameInMap("GmtFirst")]
            [Validation(Required=false)]
            public long? GmtFirst { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was last detected, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639371446000</para>
            /// </summary>
            [NameInMap("GmtLast")]
            [Validation(Required=false)]
            public long? GmtLast { get; set; }

            /// <summary>
            /// <para>The number of handled vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HandledCount")]
            [Validation(Required=false)]
            public int? HandledCount { get; set; }

            /// <summary>
            /// <para>The language type associated with the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>java</b></description></item>
            /// <item><description><b>php</b><remarks>
            /// <para>This parameter applies only to sca vulnerabilities.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("LanguageType")]
            [Validation(Required=false)]
            public string LanguageType { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities with a fix priority of <b>medium</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20170184</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities with a fix priority of <b>low</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>Indicates whether RASP real-time protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// <item><description><b>1</b>: Supported.<remarks>
            /// <para>If this property is not present, RASP real-time protection is not supported.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// <para>The list of CVEs associated with the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2023-24881,CVE-2023-24898</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>The vulnerability label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Restart required</b></description></item>
            /// <item><description><b>Remote utilization</b></description></item>
            /// <item><description><b>EXP exists</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Privilege escalation</b></description></item>
            /// <item><description><b>Code execution</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Code Execution</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The total number of fixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalFixCount")]
            [Validation(Required=false)]
            public long? TotalFixCount { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
            /// <item><description><b>app</b>: application vulnerability</description></item>
            /// <item><description><b>emg</b>: emergency vulnerability</description></item>
            /// <item><description><b>sca</b>: software constituency parsing.</description></item>
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
        /// <para>The number of vulnerability entries per page in a paged query. Default value: 10, which indicates that 10 vulnerability entries are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFA6D78-07EA-5C0A-9358-E4434573507B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
