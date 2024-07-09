// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeNodePoolVulsResponseBody : TeaModel {
        /// <summary>
        /// The node pool vulnerabilities.
        /// </summary>
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeNodePoolVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeNodePoolVulsResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The node name. This name is the identifier of the node in the cluster.
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// A list of vulnerabilities.
            /// </summary>
            [NameInMap("vul_list")]
            [Validation(Required=false)]
            public List<DescribeNodePoolVulsResponseBodyVulRecordsVulList> VulList { get; set; }
            public class DescribeNodePoolVulsResponseBodyVulRecordsVulList : TeaModel {
                /// <summary>
                /// The alias of the vulnerability.
                /// </summary>
                [NameInMap("alias_name")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// A list of CVE names corresponding to the vulnerabilities.
                /// </summary>
                [NameInMap("cve_list")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }

                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The severity level of the vulnerability.
                /// 
                /// Valid values:
                /// 
                /// *   nntf: You can ignore the vulnerability.
                /// *   later: You can fix the vulnerability later.
                /// *   asap: You need to fix the vulnerability at the earliest opportunity.
                /// </summary>
                [NameInMap("necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// Indicates whether a restart is required.
                /// </summary>
                [NameInMap("need_reboot")]
                [Validation(Required=false)]
                public bool? NeedReboot { get; set; }

            }

        }

        [NameInMap("vuls_fix_service_purchased")]
        [Validation(Required=false)]
        public bool? VulsFixServicePurchased { get; set; }

    }

}
