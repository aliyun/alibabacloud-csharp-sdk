// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamDiscoveredIpAddressesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamDiscoveredIpAddresses")]
        [Validation(Required=false)]
        public List<ListIpamDiscoveredIpAddressesResponseBodyIpamDiscoveredIpAddresses> IpamDiscoveredIpAddresses { get; set; }
        public class ListIpamDiscoveredIpAddressesResponseBodyIpamDiscoveredIpAddresses : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            [NameInMap("ResourceServiceType")]
            [Validation(Required=false)]
            public string ResourceServiceType { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
