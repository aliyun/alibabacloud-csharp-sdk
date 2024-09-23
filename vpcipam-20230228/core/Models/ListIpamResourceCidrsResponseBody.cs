// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceCidrsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamResourceCidrs")]
        [Validation(Required=false)]
        public List<ListIpamResourceCidrsResponseBodyIpamResourceCidrs> IpamResourceCidrs { get; set; }
        public class ListIpamResourceCidrsResponseBodyIpamResourceCidrs : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("ComplianceStatus")]
            [Validation(Required=false)]
            public string ComplianceStatus { get; set; }

            [NameInMap("IpUsage")]
            [Validation(Required=false)]
            public string IpUsage { get; set; }

            [NameInMap("IpamAllocationId")]
            [Validation(Required=false)]
            public string IpamAllocationId { get; set; }

            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            [NameInMap("ManagementStatus")]
            [Validation(Required=false)]
            public string ManagementStatus { get; set; }

            [NameInMap("OverlapStatus")]
            [Validation(Required=false)]
            public string OverlapStatus { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
