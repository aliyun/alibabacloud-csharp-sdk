// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamPoolsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamPools")]
        [Validation(Required=false)]
        public List<ListIpamPoolsResponseBodyIpamPools> IpamPools { get; set; }
        public class ListIpamPoolsResponseBodyIpamPools : TeaModel {
            [NameInMap("AllocationDefaultCidrMask")]
            [Validation(Required=false)]
            public int? AllocationDefaultCidrMask { get; set; }

            [NameInMap("AllocationMaxCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMaxCidrMask { get; set; }

            [NameInMap("AllocationMinCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMinCidrMask { get; set; }

            [NameInMap("AutoImport")]
            [Validation(Required=false)]
            public bool? AutoImport { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("HasSubPool")]
            [Validation(Required=false)]
            public bool? HasSubPool { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            [NameInMap("IpamPoolDescription")]
            [Validation(Required=false)]
            public string IpamPoolDescription { get; set; }

            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            [NameInMap("IpamPoolName")]
            [Validation(Required=false)]
            public string IpamPoolName { get; set; }

            [NameInMap("IpamRegionId")]
            [Validation(Required=false)]
            public string IpamRegionId { get; set; }

            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            [NameInMap("IpamScopeType")]
            [Validation(Required=false)]
            public string IpamScopeType { get; set; }

            [NameInMap("IsShared")]
            [Validation(Required=false)]
            public bool? IsShared { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            [NameInMap("PoolDepth")]
            [Validation(Required=false)]
            public int? PoolDepth { get; set; }

            [NameInMap("PoolRegionId")]
            [Validation(Required=false)]
            public string PoolRegionId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SourceIpamPoolId")]
            [Validation(Required=false)]
            public string SourceIpamPoolId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamPoolsResponseBodyIpamPoolsTags> Tags { get; set; }
            public class ListIpamPoolsResponseBodyIpamPoolsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
