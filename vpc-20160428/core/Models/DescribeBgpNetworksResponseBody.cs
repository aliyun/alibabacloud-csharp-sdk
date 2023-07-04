// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpNetworksResponseBody : TeaModel {
        /// <summary>
        /// BGP networks.
        /// </summary>
        [NameInMap("BgpNetworks")]
        [Validation(Required=false)]
        public DescribeBgpNetworksResponseBodyBgpNetworks BgpNetworks { get; set; }
        public class DescribeBgpNetworksResponseBodyBgpNetworks : TeaModel {
            [NameInMap("BgpNetwork")]
            [Validation(Required=false)]
            public List<DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork> BgpNetwork { get; set; }
            public class DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork : TeaModel {
                /// <summary>
                /// The CIDR block of the advertised BGP network.
                /// </summary>
                [NameInMap("DstCidrBlock")]
                [Validation(Required=false)]
                public string DstCidrBlock { get; set; }

                /// <summary>
                /// The ID of the VBR.
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// The status of the advertised BGP network.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of advertised BGP networks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
