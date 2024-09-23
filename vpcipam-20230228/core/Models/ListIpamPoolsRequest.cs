// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamPoolsRequest : TeaModel {
        [NameInMap("IpamPoolIds")]
        [Validation(Required=false)]
        public List<string> IpamPoolIds { get; set; }

        [NameInMap("IpamPoolName")]
        [Validation(Required=false)]
        public string IpamPoolName { get; set; }

        [NameInMap("IpamScopeId")]
        [Validation(Required=false)]
        public string IpamScopeId { get; set; }

        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PoolRegionId")]
        [Validation(Required=false)]
        public string PoolRegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SourceIpamPoolId")]
        [Validation(Required=false)]
        public string SourceIpamPoolId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListIpamPoolsRequestTags> Tags { get; set; }
        public class ListIpamPoolsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
