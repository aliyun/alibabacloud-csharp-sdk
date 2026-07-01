// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceDiscoveryAssociationsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamResourceDiscoveryAssociations")]
        [Validation(Required=false)]
        public List<ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations> IpamResourceDiscoveryAssociations { get; set; }
        public class ListIpamResourceDiscoveryAssociationsResponseBodyIpamResourceDiscoveryAssociations : TeaModel {
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            [NameInMap("IpamResourceDiscoveryOwnerId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryOwnerId { get; set; }

            [NameInMap("IpamResourceDiscoveryStatus")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryStatus { get; set; }

            [NameInMap("IpamResourceDiscoveryType")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
