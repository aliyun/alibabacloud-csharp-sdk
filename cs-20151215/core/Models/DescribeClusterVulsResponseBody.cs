// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterVulsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of vulnerabilities.</para>
        /// </summary>
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeClusterVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeClusterVulsResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// <para>The list of CVEs.</para>
            /// </summary>
            [NameInMap("cve_list")]
            [Validation(Required=false)]
            public List<string> CveList { get; set; }

            /// <summary>
            /// <para>The vulnerability severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asap</para>
            /// </summary>
            [NameInMap("necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>The number of nodes that have this vulnerability.</para>
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
            /// <para>np0156da1082b54fa987e32618dd******</para>
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// <para>The node pool name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("nodepool_name")]
            [Validation(Required=false)]
            public string NodepoolName { get; set; }

            /// <summary>
            /// <para>The vulnerability alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2022-xxxx:rsync security vulnerability</para>
            /// </summary>
            [NameInMap("vul_alias_name")]
            [Validation(Required=false)]
            public string VulAliasName { get; set; }

            /// <summary>
            /// <para>The vulnerability name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:xxxxxxx</para>
            /// </summary>
            [NameInMap("vul_name")]
            [Validation(Required=false)]
            public string VulName { get; set; }

            /// <summary>
            /// <para>The vulnerability type.</para>
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
