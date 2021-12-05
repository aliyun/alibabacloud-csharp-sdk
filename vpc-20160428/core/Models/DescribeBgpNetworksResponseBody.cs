// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpNetworksResponseBody : TeaModel {
        [NameInMap("BgpNetworks")]
        [Validation(Required=false)]
        public DescribeBgpNetworksResponseBodyBgpNetworks BgpNetworks { get; set; }
        public class DescribeBgpNetworksResponseBodyBgpNetworks : TeaModel {
            [NameInMap("BgpNetwork")]
            [Validation(Required=false)]
            public List<DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork> BgpNetwork { get; set; }
            public class DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork : TeaModel {
                public string DstCidrBlock { get; set; }
                public string RouterId { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
