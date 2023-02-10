// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPoliciesResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupPoliciesResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeBackupPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeBackupPoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("ClientErrorCount")]
            [Validation(Required=false)]
            public int? ClientErrorCount { get; set; }

            [NameInMap("ClientErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ClientErrorUuidList { get; set; }

            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            [NameInMap("HealthClientCount")]
            [Validation(Required=false)]
            public int? HealthClientCount { get; set; }

            [NameInMap("HealthClientUuidList")]
            [Validation(Required=false)]
            public List<string> HealthClientUuidList { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("PolicyRegionId")]
            [Validation(Required=false)]
            public string PolicyRegionId { get; set; }

            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            [NameInMap("RemarkedUuidList")]
            [Validation(Required=false)]
            public List<string> RemarkedUuidList { get; set; }

            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            [NameInMap("ServiceErrorCount")]
            [Validation(Required=false)]
            public int? ServiceErrorCount { get; set; }

            [NameInMap("ServiceErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ServiceErrorUuidList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
