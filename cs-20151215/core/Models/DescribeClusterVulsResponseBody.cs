// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterVulsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of vulnerabilities.</para>
        /// </summary>
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeClusterVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeClusterVulsResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// <para>The CVE list.</para>
            /// </summary>
            [NameInMap("cve_list")]
            [Validation(Required=false)]
            public List<string> CveList { get; set; }

            /// <summary>
            /// <para>The severity level of the vulnerability.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nntf: low</description></item>
            /// <item><description>later: medium     </description></item>
            /// <item><description>asap: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>asap</para>
            /// </summary>
            [NameInMap("necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>The number of nodes that have the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("node_count")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np0156da1082b54fa987e32618dd45f5d3</para>
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// <para>The name of the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("nodepool_name")]
            [Validation(Required=false)]
            public string NodepoolName { get; set; }

            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2022-xxxx:rsync Security vulnerabilities</para>
            /// </summary>
            [NameInMap("vul_alias_name")]
            [Validation(Required=false)]
            public string VulAliasName { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:xxxxxxx</para>
            /// </summary>
            [NameInMap("vul_name")]
            [Validation(Required=false)]
            public string VulName { get; set; }

            /// <summary>
            /// <para>The type of vulnerability.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>app: application vulnerabilities</description></item>
            /// <item><description>sca: application vulnerabilities (software component analysis)</description></item>
            /// <item><description>cve: Linux vulnerabilities</description></item>
            /// <item><description>cms: Web-CMS vulnerabilities</description></item>
            /// <item><description>sys: Windows vulnerabilities</description></item>
            /// <item><description>emg:  emergency vulnerabilities</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("vul_type")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

    }

}
