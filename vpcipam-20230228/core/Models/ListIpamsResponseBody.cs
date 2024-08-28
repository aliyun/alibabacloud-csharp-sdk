// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamsResponseBody : TeaModel {
        [NameInMap("Ipams")]
        [Validation(Required=false)]
        public List<ListIpamsResponseBodyIpams> Ipams { get; set; }
        public class ListIpamsResponseBodyIpams : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultResourceDiscoveryAssociationId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryAssociationId { get; set; }

            [NameInMap("DefaultResourceDiscoveryId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryId { get; set; }

            [NameInMap("IpamDescription")]
            [Validation(Required=false)]
            public string IpamDescription { get; set; }

            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            [NameInMap("IpamName")]
            [Validation(Required=false)]
            public string IpamName { get; set; }

            [NameInMap("IpamStatus")]
            [Validation(Required=false)]
            public string IpamStatus { get; set; }

            [NameInMap("OperatingRegionList")]
            [Validation(Required=false)]
            public List<string> OperatingRegionList { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            [NameInMap("PrivateDefaultScopeId")]
            [Validation(Required=false)]
            public string PrivateDefaultScopeId { get; set; }

            [NameInMap("PublicDefaultScopeId")]
            [Validation(Required=false)]
            public string PublicDefaultScopeId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceDiscoveryAssociationCount")]
            [Validation(Required=false)]
            public int? ResourceDiscoveryAssociationCount { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ScopeCount")]
            [Validation(Required=false)]
            public int? ScopeCount { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamsResponseBodyIpamsTags> Tags { get; set; }
            public class ListIpamsResponseBodyIpamsTags : TeaModel {
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
