// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeNodePoolVulsResponseBody : TeaModel {
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeNodePoolVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeNodePoolVulsResponseBodyVulRecords : TeaModel {
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("vul_list")]
            [Validation(Required=false)]
            public List<DescribeNodePoolVulsResponseBodyVulRecordsVulList> VulList { get; set; }
            public class DescribeNodePoolVulsResponseBodyVulRecordsVulList : TeaModel {
                [NameInMap("alias_name")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                [NameInMap("cve_list")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

            }

        }

        [NameInMap("vuls_fix_service_purchased")]
        [Validation(Required=false)]
        public bool? VulsFixServicePurchased { get; set; }

    }

}
