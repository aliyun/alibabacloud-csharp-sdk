// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterVulsResponseBody : TeaModel {
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeClusterVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeClusterVulsResponseBodyVulRecords : TeaModel {
            [NameInMap("cve_list")]
            [Validation(Required=false)]
            public List<string> CveList { get; set; }

            [NameInMap("necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            [NameInMap("node_count")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            [NameInMap("nodepool_name")]
            [Validation(Required=false)]
            public string NodepoolName { get; set; }

            [NameInMap("vul_alias_name")]
            [Validation(Required=false)]
            public string VulAliasName { get; set; }

            [NameInMap("vul_name")]
            [Validation(Required=false)]
            public string VulName { get; set; }

            [NameInMap("vul_type")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

    }

}
