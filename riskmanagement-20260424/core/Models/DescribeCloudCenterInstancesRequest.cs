// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesRequestSdkRequest SdkRequest { get; set; }
        public class DescribeCloudCenterInstancesRequestSdkRequest : TeaModel {
            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Flags")]
            [Validation(Required=false)]
            public string Flags { get; set; }

            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            [NameInMap("MachineTypes")]
            [Validation(Required=false)]
            public string MachineTypes { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("NoGroupTrace")]
            [Validation(Required=false)]
            public bool? NoGroupTrace { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("ResourceDirectoryAccountId")]
            [Validation(Required=false)]
            public string ResourceDirectoryAccountId { get; set; }

            [NameInMap("UseNextToken")]
            [Validation(Required=false)]
            public bool? UseNextToken { get; set; }

        }

    }

}
