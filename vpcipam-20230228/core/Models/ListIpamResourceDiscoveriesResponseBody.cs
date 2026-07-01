// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceDiscoveriesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamResourceDiscoveries")]
        [Validation(Required=false)]
        public List<ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveries> IpamResourceDiscoveries { get; set; }
        public class ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveries : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IpamResourceDiscoveryDescription")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryDescription { get; set; }

            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            [NameInMap("IpamResourceDiscoveryName")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryName { get; set; }

            [NameInMap("IpamResourceDiscoveryStatus")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryStatus { get; set; }

            [NameInMap("OperatingRegionList")]
            [Validation(Required=false)]
            public List<string> OperatingRegionList { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveriesTags> Tags { get; set; }
            public class ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveriesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
