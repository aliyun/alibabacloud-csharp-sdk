// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterVulsResponseBody : TeaModel {
        /// <summary>
        /// An array of vulnerabilities.
        /// </summary>
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeClusterVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeClusterVulsResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// The CVE list.
            /// </summary>
            [NameInMap("cve_list")]
            [Validation(Required=false)]
            public List<string> CveList { get; set; }

            /// <summary>
            /// The severity level of the vulnerability.
            /// 
            /// Valid values:
            /// 
            /// *   nntf: low
            /// *   later: medium     
            /// *   asap: high
            /// </summary>
            [NameInMap("necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// The number of nodes that have the vulnerability.
            /// </summary>
            [NameInMap("node_count")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            /// <summary>
            /// The node pool ID.
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// The name of the node pool.
            /// </summary>
            [NameInMap("nodepool_name")]
            [Validation(Required=false)]
            public string NodepoolName { get; set; }

            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("vul_alias_name")]
            [Validation(Required=false)]
            public string VulAliasName { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("vul_name")]
            [Validation(Required=false)]
            public string VulName { get; set; }

            /// <summary>
            /// The type of vulnerability.
            /// 
            /// Valid values:
            /// 
            /// *   app: application vulnerabilities
            /// *   sca: application vulnerabilities (software component analysis)
            /// *   cve: Linux vulnerabilities
            /// *   cms: Web-CMS vulnerabilities
            /// *   sys: Windows vulnerabilities
            /// *   emg:  emergency vulnerabilities
            /// </summary>
            [NameInMap("vul_type")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

    }

}
