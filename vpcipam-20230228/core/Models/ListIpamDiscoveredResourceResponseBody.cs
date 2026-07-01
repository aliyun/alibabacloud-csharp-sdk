// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamDiscoveredResourceResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamDiscoveredResources")]
        [Validation(Required=false)]
        public List<ListIpamDiscoveredResourceResponseBodyIpamDiscoveredResources> IpamDiscoveredResources { get; set; }
        public class ListIpamDiscoveredResourceResponseBodyIpamDiscoveredResources : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("DiscoveryTime")]
            [Validation(Required=false)]
            public string DiscoveryTime { get; set; }

            [NameInMap("IpCountDetail")]
            [Validation(Required=false)]
            public ListIpamDiscoveredResourceResponseBodyIpamDiscoveredResourcesIpCountDetail IpCountDetail { get; set; }
            public class ListIpamDiscoveredResourceResponseBodyIpamDiscoveredResourcesIpCountDetail : TeaModel {
                [NameInMap("FreeIpCount")]
                [Validation(Required=false)]
                public string FreeIpCount { get; set; }

                [NameInMap("TotalIpCount")]
                [Validation(Required=false)]
                public string TotalIpCount { get; set; }

                [NameInMap("UsedIpCount")]
                [Validation(Required=false)]
                public string UsedIpCount { get; set; }

            }

            [NameInMap("IpUsage")]
            [Validation(Required=false)]
            public string IpUsage { get; set; }

            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

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

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
