// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamScopesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamScopes")]
        [Validation(Required=false)]
        public List<ListIpamScopesResponseBodyIpamScopes> IpamScopes { get; set; }
        public class ListIpamScopesResponseBodyIpamScopes : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            [NameInMap("IpamScopeDescription")]
            [Validation(Required=false)]
            public string IpamScopeDescription { get; set; }

            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            [NameInMap("IpamScopeName")]
            [Validation(Required=false)]
            public string IpamScopeName { get; set; }

            [NameInMap("IpamScopeType")]
            [Validation(Required=false)]
            public string IpamScopeType { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            [NameInMap("PoolCount")]
            [Validation(Required=false)]
            public int? PoolCount { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamScopesResponseBodyIpamScopesTags> Tags { get; set; }
            public class ListIpamScopesResponseBodyIpamScopesTags : TeaModel {
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
